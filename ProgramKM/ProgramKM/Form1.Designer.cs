namespace ProgramKM
{
    partial class KMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KMForm));
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblTitle2 = new System.Windows.Forms.Label();
            this.TxtLevel = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BGLives = new System.Windows.Forms.PictureBox();
            this.BGLevel = new System.Windows.Forms.PictureBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.DspName = new System.Windows.Forms.Label();
            this.DspScore = new System.Windows.Forms.Label();
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.tmrKrool = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.KMLevel2 = new System.Windows.Forms.Button();
            this.KMLevel3 = new System.Windows.Forms.Button();
            this.KMLevel4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KMPanel1 = new System.Windows.Forms.Panel();
            this.KMLevel1 = new System.Windows.Forms.Button();
            this.KMLevel5 = new System.Windows.Forms.Button();
            this.LivesTxt = new System.Windows.Forms.TextBox();
            this.Column2 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LblLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Column2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Column1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LblTitle.Location = new System.Drawing.Point(295, -4);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(216, 76);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Kuluru\'s";
            // 
            // LblTitle2
            // 
            this.LblTitle2.AutoSize = true;
            this.LblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle2.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LblTitle2.Location = new System.Drawing.Point(310, 58);
            this.LblTitle2.Name = "LblTitle2";
            this.LblTitle2.Size = new System.Drawing.Size(179, 76);
            this.LblTitle2.TabIndex = 1;
            this.LblTitle2.Text = "Moves";
            // 
            // TxtLevel
            // 
            this.TxtLevel.AutoSize = true;
            this.TxtLevel.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLevel.Location = new System.Drawing.Point(79, 38);
            this.TxtLevel.Name = "TxtLevel";
            this.TxtLevel.Size = new System.Drawing.Size(52, 50);
            this.TxtLevel.TabIndex = 2;
            this.TxtLevel.Text = "0";
            this.TxtLevel.Click += new System.EventHandler(this.TxtLevel_Click);
            // 
            // LblLives
            // 
            this.LblLives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLives.Location = new System.Drawing.Point(641, 26);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(75, 75);
            this.LblLives.TabIndex = 4;
            this.LblLives.TabStop = false;
            this.LblLives.Click += new System.EventHandler(this.LblLives_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(68, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BGLives
            // 
            this.BGLives.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BGLives.Location = new System.Drawing.Point(628, 12);
            this.BGLives.Name = "BGLives";
            this.BGLives.Size = new System.Drawing.Size(102, 102);
            this.BGLives.TabIndex = 7;
            this.BGLives.TabStop = false;
            // 
            // BGLevel
            // 
            this.BGLevel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BGLevel.Location = new System.Drawing.Point(54, 12);
            this.BGLevel.Name = "BGLevel";
            this.BGLevel.Size = new System.Drawing.Size(102, 102);
            this.BGLevel.TabIndex = 8;
            this.BGLevel.TabStop = false;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(177, 94);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 10;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // DspName
            // 
            this.DspName.AutoSize = true;
            this.DspName.BackColor = System.Drawing.Color.Transparent;
            this.DspName.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DspName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DspName.Location = new System.Drawing.Point(167, 42);
            this.DspName.Name = "DspName";
            this.DspName.Size = new System.Drawing.Size(118, 55);
            this.DspName.TabIndex = 11;
            this.DspName.Text = "Name";
            // 
            // DspScore
            // 
            this.DspScore.AutoSize = true;
            this.DspScore.BackColor = System.Drawing.Color.Transparent;
            this.DspScore.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DspScore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DspScore.Location = new System.Drawing.Point(496, 42);
            this.DspScore.Name = "DspScore";
            this.DspScore.Size = new System.Drawing.Size(129, 55);
            this.DspScore.TabIndex = 12;
            this.DspScore.Text = "Score";
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Enabled = true;
            this.tmrEnemy.Interval = 40;
            this.tmrEnemy.Tick += new System.EventHandler(this.tmrEnemy_Tick);
            // 
            // tmrKrool
            // 
            this.tmrKrool.Enabled = true;
            this.tmrKrool.Interval = 1;
            this.tmrKrool.Tick += new System.EventHandler(this.tmrKrool_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(547, 86);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(28, 31);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "0";
            // 
            // KMLevel2
            // 
            this.KMLevel2.BackgroundImage = global::ProgramKM.Properties.Resources.KMLevel21;
            this.KMLevel2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMLevel2.Location = new System.Drawing.Point(121, 213);
            this.KMLevel2.Name = "KMLevel2";
            this.KMLevel2.Size = new System.Drawing.Size(541, 50);
            this.KMLevel2.TabIndex = 17;
            this.KMLevel2.UseVisualStyleBackColor = true;
            this.KMLevel2.Click += new System.EventHandler(this.KMLevel2_Click);
            // 
            // KMLevel3
            // 
            this.KMLevel3.BackgroundImage = global::ProgramKM.Properties.Resources.KMLevel3;
            this.KMLevel3.Enabled = false;
            this.KMLevel3.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMLevel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KMLevel3.Location = new System.Drawing.Point(121, 287);
            this.KMLevel3.Name = "KMLevel3";
            this.KMLevel3.Size = new System.Drawing.Size(541, 50);
            this.KMLevel3.TabIndex = 18;
            this.KMLevel3.UseVisualStyleBackColor = true;
            this.KMLevel3.Click += new System.EventHandler(this.KMLevel3_Click);
            // 
            // KMLevel4
            // 
            this.KMLevel4.BackgroundImage = global::ProgramKM.Properties.Resources.KMLevel4;
            this.KMLevel4.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMLevel4.Location = new System.Drawing.Point(121, 362);
            this.KMLevel4.Name = "KMLevel4";
            this.KMLevel4.Size = new System.Drawing.Size(541, 50);
            this.KMLevel4.TabIndex = 19;
            this.KMLevel4.UseVisualStyleBackColor = true;
            this.KMLevel4.Click += new System.EventHandler(this.KMLevel4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(54, 508);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(676, 66);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(68, 522);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(648, 40);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Game by Zach Saunders";
            // 
            // KMPanel1
            // 
            this.KMPanel1.BackgroundImage = global::ProgramKM.Properties.Resources.Ship_1;
            this.KMPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KMPanel1.Location = new System.Drawing.Point(54, 137);
            this.KMPanel1.Name = "KMPanel1";
            this.KMPanel1.Size = new System.Drawing.Size(676, 350);
            this.KMPanel1.TabIndex = 0;
            this.KMPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.KMPanel_Paint);
            // 
            // KMLevel1
            // 
            this.KMLevel1.BackgroundImage = global::ProgramKM.Properties.Resources.KMLevel;
            this.KMLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.KMLevel1.Location = new System.Drawing.Point(121, 138);
            this.KMLevel1.Name = "KMLevel1";
            this.KMLevel1.Size = new System.Drawing.Size(541, 49);
            this.KMLevel1.TabIndex = 25;
            this.KMLevel1.UseVisualStyleBackColor = true;
            this.KMLevel1.Click += new System.EventHandler(this.KMLevel1_Click_1);
            // 
            // KMLevel5
            // 
            this.KMLevel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KMLevel5.BackgroundImage")));
            this.KMLevel5.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMLevel5.Location = new System.Drawing.Point(120, 436);
            this.KMLevel5.Name = "KMLevel5";
            this.KMLevel5.Size = new System.Drawing.Size(541, 50);
            this.KMLevel5.TabIndex = 24;
            this.KMLevel5.UseVisualStyleBackColor = true;
            this.KMLevel5.Click += new System.EventHandler(this.KMLevel5_Click);
            // 
            // LivesTxt
            // 
            this.LivesTxt.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesTxt.Location = new System.Drawing.Point(641, 57);
            this.LivesTxt.Name = "LivesTxt";
            this.LivesTxt.Size = new System.Drawing.Size(75, 44);
            this.LivesTxt.TabIndex = 23;
            this.LivesTxt.TextChanged += new System.EventHandler(this.Txtlives_TextChanged);
            // 
            // Column2
            // 
            this.Column2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Column2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Column2.Location = new System.Drawing.Point(55, 137);
            this.Column2.Name = "Column2";
            this.Column2.Size = new System.Drawing.Size(46, 350);
            this.Column2.TabIndex = 26;
            this.Column2.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Column1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Column1.Location = new System.Drawing.Point(683, 137);
            this.Column1.Name = "Column1";
            this.Column1.Size = new System.Drawing.Size(46, 350);
            this.Column1.TabIndex = 27;
            this.Column1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lives";
            // 
            // KMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgramKM.Properties.Resources.db35qhj_ea72c51d_b0b7_4555_ac33_3592a554fb77;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KMLevel5);
            this.Controls.Add(this.KMLevel3);
            this.Controls.Add(this.KMLevel4);
            this.Controls.Add(this.KMLevel1);
            this.Controls.Add(this.KMLevel2);
            this.Controls.Add(this.LivesTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.DspScore);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.DspName);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.BGLives);
            this.Controls.Add(this.LblTitle2);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtLevel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BGLevel);
            this.Controls.Add(this.KMPanel1);
            this.Controls.Add(this.Column2);
            this.Controls.Add(this.Column1);
            this.KeyPreview = true;
            this.Name = "KMForm";
            this.Text = "KULURU\'S MOVES";
            this.Load += new System.EventHandler(this.KMForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KMForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KMForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.LblLives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGLives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Column2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Column1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblTitle2;
        private System.Windows.Forms.Label TxtLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox LblLives;
        private System.Windows.Forms.PictureBox BGLives;
        private System.Windows.Forms.PictureBox BGLevel;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label DspName;
        private System.Windows.Forms.Label DspScore;
        private System.Windows.Forms.Timer tmrEnemy;
        private System.Windows.Forms.Timer tmrKrool;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button KMLevel2;
        private System.Windows.Forms.Button KMLevel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel KMPanel1;
        private System.Windows.Forms.TextBox LivesTxt;
        private System.Windows.Forms.Button KMLevel5;
        private System.Windows.Forms.Button KMLevel3;
        private System.Windows.Forms.Button KMLevel1;
        private System.Windows.Forms.PictureBox Column2;
        private System.Windows.Forms.PictureBox Column1;
        private System.Windows.Forms.Label label1;
    }
}

