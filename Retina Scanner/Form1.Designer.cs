namespace Retina_Scanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.eyeMainPictureBox = new System.Windows.Forms.PictureBox();
            this.confidenceLbl = new System.Windows.Forms.Label();
            this.videoDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.confTimer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createProfileBtn = new System.Windows.Forms.Button();
            this.profileCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eyeMainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload image to profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(190, 14);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(18, 493);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // eyeMainPictureBox
            // 
            this.eyeMainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyeMainPictureBox.Location = new System.Drawing.Point(215, 49);
            this.eyeMainPictureBox.Name = "eyeMainPictureBox";
            this.eyeMainPictureBox.Size = new System.Drawing.Size(540, 310);
            this.eyeMainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyeMainPictureBox.TabIndex = 5;
            this.eyeMainPictureBox.TabStop = false;
            // 
            // confidenceLbl
            // 
            this.confidenceLbl.AutoSize = true;
            this.confidenceLbl.Location = new System.Drawing.Point(215, 379);
            this.confidenceLbl.Name = "confidenceLbl";
            this.confidenceLbl.Size = new System.Drawing.Size(98, 20);
            this.confidenceLbl.TabIndex = 8;
            this.confidenceLbl.Text = "Confidence: ?";
            // 
            // videoDevices
            // 
            this.videoDevices.FormattingEnabled = true;
            this.videoDevices.Location = new System.Drawing.Point(284, 15);
            this.videoDevices.Name = "videoDevices";
            this.videoDevices.Size = new System.Drawing.Size(238, 28);
            this.videoDevices.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Camera:";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(528, 14);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(107, 29);
            this.startBtn.TabIndex = 14;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(648, 14);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(107, 29);
            this.stopBtn.TabIndex = 15;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // confTimer
            // 
            this.confTimer.Interval = 10;
            this.confTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Take photo now";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "OR";
            // 
            // createProfileBtn
            // 
            this.createProfileBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProfileBtn.Location = new System.Drawing.Point(16, 340);
            this.createProfileBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createProfileBtn.Name = "createProfileBtn";
            this.createProfileBtn.Size = new System.Drawing.Size(167, 59);
            this.createProfileBtn.TabIndex = 18;
            this.createProfileBtn.Text = "Create new profile";
            this.createProfileBtn.UseVisualStyleBackColor = true;
            this.createProfileBtn.Click += new System.EventHandler(this.CreateProfileBtn_Click);
            // 
            // profileCombo
            // 
            this.profileCombo.FormattingEnabled = true;
            this.profileCombo.Location = new System.Drawing.Point(16, 37);
            this.profileCombo.Name = "profileCombo";
            this.profileCombo.Size = new System.Drawing.Size(167, 28);
            this.profileCombo.TabIndex = 19;
            this.profileCombo.TextChanged += new System.EventHandler(this.ProfileCombo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Select profile:";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 5;
            this.bunifuSeparator2.Location = new System.Drawing.Point(16, 218);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(167, 23);
            this.bunifuSeparator2.TabIndex = 21;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(627, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profileCombo);
            this.Controls.Add(this.createProfileBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoDevices);
            this.Controls.Add(this.confidenceLbl);
            this.Controls.Add(this.eyeMainPictureBox);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Retina Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eyeMainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox eyeMainPictureBox;
        private System.Windows.Forms.Label confidenceLbl;
        private System.Windows.Forms.ComboBox videoDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Timer confTimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createProfileBtn;
        private System.Windows.Forms.ComboBox profileCombo;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

