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
namespace Retina_Scanner
{
    public partial class Form1 : Form
    {
        Globals globals = new Globals();
        Functions functions = new Functions();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                //set image
                Bitmap img = new Bitmap(f.FileName);

                //invert, grayscale, binary on image
                Bitmap blobImg = functions.BinaryFilter(functions.GrayScale(functions.Invert(img)));
                Bitmap grayScaleImg = functions.GrayScale(img);

                //get centers
                Rectangle rect = functions.GetCenter(blobImg);

                //draw square
                using (Graphics g = Graphics.FromImage(img))
                {
                    g.DrawRectangle(new Pen(Color.Red, 5), rect);
                }

                eyeMainPictureBox.Image = img;

                //crop rectange
                img = functions.CropImage(img, rect);
                blobImg = functions.CropImage(blobImg, rect);
                grayScaleImg = functions.CropImage(grayScaleImg, rect);

                //set
                globals.currImg = img;

                //picture boxes
                retinaPictureBox.Image = img;
                eyeBinaryBox.Image = blobImg;
                eyeGrayPictureBox.Image = grayScaleImg;

                //data
                globals.currImgData = functions.ImageToData(grayScaleImg);

                if (whitelistCheck.Checked)
                {
                    string name = Microsoft.VisualBasic.Interaction.InputBox("File name?", "Enter save name of this retina data", "");

                    string[] data = Array.ConvertAll(globals.currImgData, x => x.ToString());
                    File.WriteAllText ($"Data/{name}.txt", String.Join(",", data));

                    MessageBox.Show("Successfully saved to Data/" + name + ".txt !");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //open file dialog
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Text Files|*.txt";
            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] data = File.ReadAllText(f.FileName).Split(',');
                globals.matchImgData.Clear();
                foreach(string d in data)
                {
                    globals.matchImgData.Add(Int32.Parse(d));
                }
            }

            //find match
            double confidence = functions.Confidence(globals.currImgData, globals.matchImgData.ToArray());
            string matchProbability = "";

            if(confidence == 100)
            {
                matchProbability = "Perfect Match";
            }
            else if(confidence > 80)
            {
                matchProbability = "Very Likely";
            } else if(confidence > 65)
            {
                matchProbability = "Likely";
            } else
            {
                matchProbability = "No Match";

            }
            confidenceLbl.Text = "Confidence: " + confidence.ToString() + "%";
            matchLbl.Text = "Match: " + matchProbability;
        }
    }
}
