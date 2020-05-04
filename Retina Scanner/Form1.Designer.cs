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
            this.button1 = new System.Windows.Forms.Button();
            this.retinaPictureBox = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.eyeBinaryBox = new System.Windows.Forms.PictureBox();
            this.eyeMainPictureBox = new System.Windows.Forms.PictureBox();
            this.eyeGrayPictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.confidenceLbl = new System.Windows.Forms.Label();
            this.whitelistCheck = new System.Windows.Forms.CheckBox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.matchLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.retinaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeBinaryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeMainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeGrayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload Eye Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // retinaPictureBox
            // 
            this.retinaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retinaPictureBox.Location = new System.Drawing.Point(201, 371);
            this.retinaPictureBox.Name = "retinaPictureBox";
            this.retinaPictureBox.Size = new System.Drawing.Size(150, 150);
            this.retinaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.retinaPictureBox.TabIndex = 1;
            this.retinaPictureBox.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(174, 14);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(18, 507);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(201, 339);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(540, 21);
            this.bunifuSeparator2.TabIndex = 3;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // eyeBinaryBox
            // 
            this.eyeBinaryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyeBinaryBox.Location = new System.Drawing.Point(587, 371);
            this.eyeBinaryBox.Name = "eyeBinaryBox";
            this.eyeBinaryBox.Size = new System.Drawing.Size(150, 150);
            this.eyeBinaryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyeBinaryBox.TabIndex = 4;
            this.eyeBinaryBox.TabStop = false;
            // 
            // eyeMainPictureBox
            // 
            this.eyeMainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyeMainPictureBox.Location = new System.Drawing.Point(201, 18);
            this.eyeMainPictureBox.Name = "eyeMainPictureBox";
            this.eyeMainPictureBox.Size = new System.Drawing.Size(540, 310);
            this.eyeMainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyeMainPictureBox.TabIndex = 5;
            this.eyeMainPictureBox.TabStop = false;
            // 
            // eyeGrayPictureBox
            // 
            this.eyeGrayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyeGrayPictureBox.Location = new System.Drawing.Point(394, 371);
            this.eyeGrayPictureBox.Name = "eyeGrayPictureBox";
            this.eyeGrayPictureBox.Size = new System.Drawing.Size(150, 150);
            this.eyeGrayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyeGrayPictureBox.TabIndex = 6;
            this.eyeGrayPictureBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "Match Against Another Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // confidenceLbl
            // 
            this.confidenceLbl.AutoSize = true;
            this.confidenceLbl.Location = new System.Drawing.Point(12, 240);
            this.confidenceLbl.Name = "confidenceLbl";
            this.confidenceLbl.Size = new System.Drawing.Size(98, 20);
            this.confidenceLbl.TabIndex = 8;
            this.confidenceLbl.Text = "Confidence: ?";
            // 
            // whitelistCheck
            // 
            this.whitelistCheck.AutoSize = true;
            this.whitelistCheck.Location = new System.Drawing.Point(16, 86);
            this.whitelistCheck.Name = "whitelistCheck";
            this.whitelistCheck.Size = new System.Drawing.Size(145, 24);
            this.whitelistCheck.TabIndex = 9;
            this.whitelistCheck.Text = "Save eye data file\r\n";
            this.whitelistCheck.UseVisualStyleBackColor = true;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(16, 118);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(150, 38);
            this.bunifuSeparator3.TabIndex = 10;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // matchLbl
            // 
            this.matchLbl.AutoSize = true;
            this.matchLbl.Location = new System.Drawing.Point(12, 260);
            this.matchLbl.Name = "matchLbl";
            this.matchLbl.Size = new System.Drawing.Size(64, 20);
            this.matchLbl.TabIndex = 11;
            this.matchLbl.Text = "Match: ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 534);
            this.Controls.Add(this.matchLbl);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.whitelistCheck);
            this.Controls.Add(this.confidenceLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.eyeGrayPictureBox);
            this.Controls.Add(this.eyeMainPictureBox);
            this.Controls.Add(this.eyeBinaryBox);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.retinaPictureBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Retina Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.retinaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeBinaryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeMainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeGrayPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox retinaPictureBox;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox eyeBinaryBox;
        private System.Windows.Forms.PictureBox eyeMainPictureBox;
        private System.Windows.Forms.PictureBox eyeGrayPictureBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label confidenceLbl;
        private System.Windows.Forms.CheckBox whitelistCheck;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label matchLbl;
    }
}

