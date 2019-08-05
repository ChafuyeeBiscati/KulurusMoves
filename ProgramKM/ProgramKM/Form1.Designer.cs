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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblTitle2 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TxtLevel = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.PictureBox();
            this.KMPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtLives = new System.Windows.Forms.Label();
            this.BGLives = new System.Windows.Forms.PictureBox();
            this.BGLevel = new System.Windows.Forms.PictureBox();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.DspName = new System.Windows.Forms.Label();
            this.DspScore = new System.Windows.Forms.Label();
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.tmrKrool = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LblLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGLevel)).BeginInit();
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
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(54, 509);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(675, 65);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Begin Adventure";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // TxtLevel
            // 
            this.TxtLevel.AutoSize = true;
            this.TxtLevel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLevel.Location = new System.Drawing.Point(80, 35);
            this.TxtLevel.Name = "TxtLevel";
            this.TxtLevel.Size = new System.Drawing.Size(48, 55);
            this.TxtLevel.TabIndex = 2;
            this.TxtLevel.Text = "4";
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
            // 
            // KMPanel
            // 
            this.KMPanel.BackgroundImage = global::ProgramKM.Properties.Resources.Ship_1;
            this.KMPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KMPanel.Location = new System.Drawing.Point(54, 137);
            this.KMPanel.Name = "KMPanel";
            this.KMPanel.Size = new System.Drawing.Size(675, 350);
            this.KMPanel.TabIndex = 0;
            this.KMPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.KMPanel_Paint);
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
            // TxtLives
            // 
            this.TxtLives.AutoSize = true;
            this.TxtLives.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLives.Location = new System.Drawing.Point(656, 35);
            this.TxtLives.Name = "TxtLives";
            this.TxtLives.Size = new System.Drawing.Size(48, 55);
            this.TxtLives.TabIndex = 6;
            this.TxtLives.Text = "0";
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
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(506, 95);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(100, 20);
            this.TxtScore.TabIndex = 9;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(177, 94);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 10;
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
            // KMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgramKM.Properties.Resources.db35qhj_ea72c51d_b0b7_4555_ac33_3592a554fb77;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.DspScore);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.DspName);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.TxtLives);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.TxtLevel);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblTitle2);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.KMPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BGLives);
            this.Controls.Add(this.BGLevel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel KMPanel;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblTitle2;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label TxtLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox LblLives;
        private System.Windows.Forms.Label TxtLives;
        private System.Windows.Forms.PictureBox BGLives;
        private System.Windows.Forms.PictureBox BGLevel;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label DspName;
        private System.Windows.Forms.Label DspScore;
        private System.Windows.Forms.Timer tmrEnemy;
        private System.Windows.Forms.Timer tmrKrool;
    }
}

