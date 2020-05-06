using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using System.Threading;
namespace Retina_Scanner
{
    public partial class Form1 : Form
    {
        Globals globals = new Globals();
        Functions functions = new Functions();
        FilterInfoCollection devices;
        VideoCaptureDevice videoSource;
        bool working = false;
        bool takeSnap = false;
        int frameNum=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cameras
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in devices)
            {
                videoDevices.Items.Add(device.Name);
                videoDevices.SelectedItem = device.Name;
            }

            string[] sd = functions.subdirectories();
            foreach (string s in sd)
            {
                profileCombo.Items.Add(s.Replace("Data\\", ""));
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if(globals.selectedProfile != null)
            {
                //reset
                globals.dataFileNames.Clear();
                globals.dataFiles.Clear();
                takeSnap = false;
                globals.currConfidence = 0;
                globals.currConfidenceAbove75 = 0;

                //data files load
                DirectoryInfo d = new DirectoryInfo("Data/" + globals.selectedProfile);
                FileInfo[] Files = d.GetFiles("*.txt");

                foreach (FileInfo file in Files)
                {
                    globals.dataFileNames.Add(file.Name);
                }

                //load files
                for (int x = 0; x < globals.dataFileNames.Count; x++)
                {
                    string[] data = File.ReadAllText("Data/" + globals.selectedProfile + "/" + globals.dataFileNames[x]).Split(',');
                    globals.dataFiles.Add(Array.ConvertAll(data, s => float.Parse(s)));
                }

                //start video
                videoSource = new VideoCaptureDevice(devices[videoDevices.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
                confTimer.Start();
            } else
            {
                MessageBox.Show("Please select a profile before starting!");
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            confTimer.Stop();
            eyeMainPictureBox.Image = null;
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //show the eye from frame
            Bitmap eye = (Bitmap)eventArgs.Frame.Clone();

            showEye(eye);

            if (takeSnap)
            {
                videoSource.SignalToStop();
                confTimer.Stop();

                saveEye(eye);
            }
            else if (globals.eyefound == true && frameNum >= 5 && globals.eyedrawn == true)
            {
                //turn cropped eye into low quality version of itself
                Bitmap cropedEye = (Bitmap)globals.currImgCropped.Clone();

                frameNum = 0;

                // if eye found then try compare using the hashes
                for (int i = 0; i < globals.dataFiles.Count; i++)
                {
                    //get data from current image and saved file
                    List<float> currImgData = functions.GetHash(cropedEye);
                    if (currImgData[1] != 0)
                    {
                        globals.currConfidence = functions.Confidence(currImgData.ToArray(), globals.dataFiles[i]);
                    }

                }
            } else
            {
                frameNum++;
            }
        }

        void showEye(Bitmap img)
        {
            //set images
            img = (Bitmap)img.Clone();
            Bitmap blobImg = functions.BinaryFilter(functions.GrayScale(functions.Invert(img)));
            Bitmap grayScaleImg = functions.GrayScale(img);

            //main image
            globals.currImg = img;

            //get center
            Rectangle rect = functions.GetCenter(blobImg, globals);

            if(globals.eyefound && rect.Height > 50 && rect.Height < 300)
            {
                globals.currImgCropped = functions.ResizeImage(functions.CropImage(img, rect), 64, 64);
                pictureBox1.Image = functions.ResizeImage(functions.CropImage(img, rect), 64, 64);

                //draw square
                using (Graphics g = Graphics.FromImage(img))
                {
                    g.DrawRectangle(new Pen(Color.Red, 5), rect);
                }

                globals.eyedrawn = true;

            } else
            {
                globals.eyedrawn = false;
            }

            //picture boxes
            eyeMainPictureBox.Image = img;

        }

        void saveEye(Bitmap eye)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("File name?", "Enter save name of this retina data", "");

            if (name != "")
            {
                string[] data = Array.ConvertAll(functions.GetHash(globals.currImgCropped).ToArray(), x => x.ToString());
                File.WriteAllText($"Data/{globals.selectedProfile}/{name}.txt", String.Join(",", data));

                MessageBox.Show($"Successfully saved to Data/{globals.selectedProfile}/{name}.txt !");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //open file dialog
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = f.ShowDialog();

            //check ok
            if(result == DialogResult.OK)
            {
                showEye(new Bitmap(f.FileName));
                saveEye(new Bitmap(f.FileName));
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            double conf = globals.currConfidence;
            confidenceLbl.Text = "Closest Match: " + conf.ToString()  + "%";
            Console.WriteLine(conf.ToString() + "%");
            if (globals.currConfidenceAbove75 >= 10)
            {
                confTimer.Stop();
                videoSource.SignalToStop();
                eyeMainPictureBox.Image = null;
                confidenceLbl.Text = "Found match!";
                MessageBox.Show("Found match!");
            }
            else if(conf >= 80)
            {
                globals.currConfidenceAbove75++;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            takeSnap = true;
        }

        private void ProfileCombo_TextChanged(object sender, EventArgs e)
        {
            globals.selectedProfile = profileCombo.SelectedItem.ToString().Replace("\\Data", "");
        }

        private void CreateProfileBtn_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Profile name?", "Enter the profile name", "");

            Directory.CreateDirectory($"Data/{name}");
            MessageBox.Show("Successfully created profile. You may now upload eye images");
        }
    }
}
