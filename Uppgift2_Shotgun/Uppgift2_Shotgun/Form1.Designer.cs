namespace Uppgift2_Shotgun
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
            this.ButtonShoot = new System.Windows.Forms.Button();
            this.ButtonCharge = new System.Windows.Forms.Button();
            this.ButtonBlock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelTotalScore = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelBulletYou = new System.Windows.Forms.Label();
            this.LabelScoreAI = new System.Windows.Forms.Label();
            this.LabelScoreYou = new System.Windows.Forms.Label();
            this.LabelBulletAi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PictureBoxAI = new System.Windows.Forms.PictureBox();
            this.PictureBoxYou = new System.Windows.Forms.PictureBox();
            this.PctureBoxBackground = new System.Windows.Forms.PictureBox();
            this.PictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.PictureBoxTopImage = new System.Windows.Forms.PictureBox();
            this.LabelCharge = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxYou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTopImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonShoot
            // 
            this.ButtonShoot.BackColor = System.Drawing.Color.White;
            this.ButtonShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShoot.Location = new System.Drawing.Point(76, 301);
            this.ButtonShoot.Name = "ButtonShoot";
            this.ButtonShoot.Size = new System.Drawing.Size(125, 37);
            this.ButtonShoot.TabIndex = 0;
            this.ButtonShoot.Text = "Skjuta";
            this.ButtonShoot.UseVisualStyleBackColor = false;
            this.ButtonShoot.Click += new System.EventHandler(this.ButtonShoot_Click);
            // 
            // ButtonCharge
            // 
            this.ButtonCharge.BackColor = System.Drawing.Color.White;
            this.ButtonCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCharge.Location = new System.Drawing.Point(218, 301);
            this.ButtonCharge.Name = "ButtonCharge";
            this.ButtonCharge.Size = new System.Drawing.Size(125, 37);
            this.ButtonCharge.TabIndex = 1;
            this.ButtonCharge.Text = "Ladda";
            this.ButtonCharge.UseVisualStyleBackColor = false;
            this.ButtonCharge.Click += new System.EventHandler(this.ButtonCharge_Click);
            // 
            // ButtonBlock
            // 
            this.ButtonBlock.BackColor = System.Drawing.Color.White;
            this.ButtonBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBlock.Location = new System.Drawing.Point(360, 301);
            this.ButtonBlock.Name = "ButtonBlock";
            this.ButtonBlock.Size = new System.Drawing.Size(125, 37);
            this.ButtonBlock.TabIndex = 2;
            this.ButtonBlock.Text = "Blocka";
            this.ButtonBlock.UseVisualStyleBackColor = false;
            this.ButtonBlock.Click += new System.EventHandler(this.ButtonBlock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(121, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Du";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(390, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dator";
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.BackColor = System.Drawing.Color.Transparent;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.Color.Aqua;
            this.LabelMessage.Location = new System.Drawing.Point(70, 354);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(185, 25);
            this.LabelMessage.TabIndex = 7;
            this.LabelMessage.Text = "Välj en knapp ovan!";
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Location = new System.Drawing.Point(360, 395);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(125, 28);
            this.ButtonClear.TabIndex = 8;
            this.ButtonClear.Text = "Rensa poäng";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(360, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "En gång till";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(360, 424);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(125, 28);
            this.ButtonClose.TabIndex = 10;
            this.ButtonClose.Text = "Avsluta";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelTotalScore
            // 
            this.LabelTotalScore.AutoSize = true;
            this.LabelTotalScore.BackColor = System.Drawing.Color.Transparent;
            this.LabelTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalScore.ForeColor = System.Drawing.Color.White;
            this.LabelTotalScore.Location = new System.Drawing.Point(73, 402);
            this.LabelTotalScore.Name = "LabelTotalScore";
            this.LabelTotalScore.Size = new System.Drawing.Size(34, 24);
            this.LabelTotalScore.TabIndex = 11;
            this.LabelTotalScore.Text = "Du";
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.White;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(247, 406);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 20;
            this.ButtonStart.Text = "START";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dator ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(103, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Skott :";
            // 
            // LabelBulletYou
            // 
            this.LabelBulletYou.AutoSize = true;
            this.LabelBulletYou.BackColor = System.Drawing.Color.Transparent;
            this.LabelBulletYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBulletYou.ForeColor = System.Drawing.Color.White;
            this.LabelBulletYou.Location = new System.Drawing.Point(167, 257);
            this.LabelBulletYou.Name = "LabelBulletYou";
            this.LabelBulletYou.Size = new System.Drawing.Size(20, 24);
            this.LabelBulletYou.TabIndex = 25;
            this.LabelBulletYou.Text = "0";
            // 
            // LabelScoreAI
            // 
            this.LabelScoreAI.AutoSize = true;
            this.LabelScoreAI.BackColor = System.Drawing.Color.Transparent;
            this.LabelScoreAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreAI.ForeColor = System.Drawing.Color.White;
            this.LabelScoreAI.Location = new System.Drawing.Point(146, 427);
            this.LabelScoreAI.Name = "LabelScoreAI";
            this.LabelScoreAI.Size = new System.Drawing.Size(20, 24);
            this.LabelScoreAI.TabIndex = 27;
            this.LabelScoreAI.Text = "0";
            // 
            // LabelScoreYou
            // 
            this.LabelScoreYou.AutoSize = true;
            this.LabelScoreYou.BackColor = System.Drawing.Color.Transparent;
            this.LabelScoreYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreYou.ForeColor = System.Drawing.Color.White;
            this.LabelScoreYou.Location = new System.Drawing.Point(146, 402);
            this.LabelScoreYou.Name = "LabelScoreYou";
            this.LabelScoreYou.Size = new System.Drawing.Size(20, 24);
            this.LabelScoreYou.TabIndex = 26;
            this.LabelScoreYou.Text = "0";
            // 
            // LabelBulletAi
            // 
            this.LabelBulletAi.AutoSize = true;
            this.LabelBulletAi.BackColor = System.Drawing.Color.Transparent;
            this.LabelBulletAi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBulletAi.ForeColor = System.Drawing.Color.White;
            this.LabelBulletAi.Location = new System.Drawing.Point(441, 257);
            this.LabelBulletAi.Name = "LabelBulletAi";
            this.LabelBulletAi.Size = new System.Drawing.Size(20, 24);
            this.LabelBulletAi.TabIndex = 29;
            this.LabelBulletAi.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(377, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Skott :";
            // 
            // PictureBoxAI
            // 
            this.PictureBoxAI.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxAI.Location = new System.Drawing.Point(313, 58);
            this.PictureBoxAI.Name = "PictureBoxAI";
            this.PictureBoxAI.Size = new System.Drawing.Size(200, 200);
            this.PictureBoxAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAI.TabIndex = 17;
            this.PictureBoxAI.TabStop = false;
            // 
            // PictureBoxYou
            // 
            this.PictureBoxYou.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxYou.Location = new System.Drawing.Point(42, 58);
            this.PictureBoxYou.Name = "PictureBoxYou";
            this.PictureBoxYou.Size = new System.Drawing.Size(200, 200);
            this.PictureBoxYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxYou.TabIndex = 13;
            this.PictureBoxYou.TabStop = false;
            // 
            // PctureBoxBackground
            // 
            this.PctureBoxBackground.Location = new System.Drawing.Point(13, 13);
            this.PctureBoxBackground.Name = "PctureBoxBackground";
            this.PctureBoxBackground.Size = new System.Drawing.Size(528, 448);
            this.PctureBoxBackground.TabIndex = 21;
            this.PctureBoxBackground.TabStop = false;
   
            // 
            // PictureBoxTitle
            // 
            this.PictureBoxTitle.BackColor = System.Drawing.Color.Black;
            this.PictureBoxTitle.Image = global::Uppgift2_Shotgun.Properties.Resources.Title;
            this.PictureBoxTitle.Location = new System.Drawing.Point(112, 34);
            this.PictureBoxTitle.Name = "PictureBoxTitle";
            this.PictureBoxTitle.Size = new System.Drawing.Size(327, 110);
            this.PictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxTitle.TabIndex = 18;
            this.PictureBoxTitle.TabStop = false;
            // 
            // PictureBoxTopImage
            // 
            this.PictureBoxTopImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxTopImage.Image = global::Uppgift2_Shotgun.Properties.Resources.Top;
            this.PictureBoxTopImage.Location = new System.Drawing.Point(26, 91);
            this.PictureBoxTopImage.Name = "PictureBoxTopImage";
            this.PictureBoxTopImage.Size = new System.Drawing.Size(473, 362);
            this.PictureBoxTopImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxTopImage.TabIndex = 19;
            this.PictureBoxTopImage.TabStop = false;
            // 
            // LabelCharge
            // 
            this.LabelCharge.AutoSize = true;
            this.LabelCharge.BackColor = System.Drawing.Color.Transparent;
            this.LabelCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCharge.ForeColor = System.Drawing.Color.Magenta;
            this.LabelCharge.Location = new System.Drawing.Point(71, 278);
            this.LabelCharge.Name = "LabelCharge";
            this.LabelCharge.Size = new System.Drawing.Size(132, 20);
            this.LabelCharge.TabIndex = 30;
            this.LabelCharge.Text = "Du måste ladda!";
            // 
            // LabelResult
            // 
            this.LabelResult.BackColor = System.Drawing.Color.Transparent;
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.ForeColor = System.Drawing.Color.Aqua;
            this.LabelResult.Location = new System.Drawing.Point(154, 42);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(256, 38);
            this.LabelResult.TabIndex = 31;
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(180, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "poäng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(180, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "poäng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(553, 482);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelBulletAi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelBulletYou);
            this.Controls.Add(this.PictureBoxAI);
            this.Controls.Add(this.PictureBoxYou);
            this.Controls.Add(this.LabelCharge);
            this.Controls.Add(this.LabelScoreAI);
            this.Controls.Add(this.LabelScoreYou);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonBlock);
            this.Controls.Add(this.ButtonCharge);
            this.Controls.Add(this.ButtonShoot);
            this.Controls.Add(this.LabelTotalScore);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.PctureBoxBackground);
            this.Controls.Add(this.PictureBoxTitle);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.PictureBoxTopImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxYou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTopImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonShoot;
        private System.Windows.Forms.Button ButtonCharge;
        private System.Windows.Forms.Button ButtonBlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelTotalScore;
        private System.Windows.Forms.PictureBox PictureBoxYou;
        private System.Windows.Forms.PictureBox PictureBoxAI;
        private System.Windows.Forms.PictureBox PictureBoxTitle;
        private System.Windows.Forms.PictureBox PictureBoxTopImage;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.PictureBox PctureBoxBackground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelBulletYou;
        private System.Windows.Forms.Label LabelScoreAI;
        private System.Windows.Forms.Label LabelScoreYou;
        private System.Windows.Forms.Label LabelBulletAi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelCharge;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

