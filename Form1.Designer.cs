namespace Rock_Paper_Scissors
{
    partial class RockPaperScissorsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockPaperScissorsApp));
            this.pictureRockImg = new System.Windows.Forms.PictureBox();
            this.picturePaperImg = new System.Windows.Forms.PictureBox();
            this.pictureScissorsImg = new System.Windows.Forms.PictureBox();
            this.rockBt = new System.Windows.Forms.Button();
            this.paperBt = new System.Windows.Forms.Button();
            this.scissorsBt = new System.Windows.Forms.Button();
            this.playerOptionLbl = new System.Windows.Forms.Label();
            this.computerOptionLbl = new System.Windows.Forms.Label();
            this.gameOneWinnerLbl = new System.Windows.Forms.Label();
            this.gameTwoWinnerLbl = new System.Windows.Forms.Label();
            this.gameThreeWinnerLbl = new System.Windows.Forms.Label();
            this.overallWinnerLBL = new System.Windows.Forms.Label();
            this.playAgainBt = new System.Windows.Forms.Button();
            this.exitBt = new System.Windows.Forms.Button();
            this.gameFourWinnerLbl = new System.Windows.Forms.Label();
            this.gameOverLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRockImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaperImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissorsImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureRockImg
            // 
            this.pictureRockImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureRockImg.ErrorImage")));
            this.pictureRockImg.ImageLocation = "Visual Studio/Visual Studio IDE/Rock Paper Scissors/Images/Rock";
            this.pictureRockImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureRockImg.InitialImage")));
            this.pictureRockImg.Location = new System.Drawing.Point(119, 29);
            this.pictureRockImg.Name = "pictureRockImg";
            this.pictureRockImg.Size = new System.Drawing.Size(150, 150);
            this.pictureRockImg.TabIndex = 0;
            this.pictureRockImg.TabStop = false;
            // 
            // picturePaperImg
            // 
            this.picturePaperImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picturePaperImg.ErrorImage")));
            this.picturePaperImg.ImageLocation = "Visual Studio/Visual Studio IDE/Rock Paper Scissors/Images/Paper";
            this.picturePaperImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturePaperImg.InitialImage")));
            this.picturePaperImg.Location = new System.Drawing.Point(307, 29);
            this.picturePaperImg.Name = "picturePaperImg";
            this.picturePaperImg.Size = new System.Drawing.Size(150, 150);
            this.picturePaperImg.TabIndex = 1;
            this.picturePaperImg.TabStop = false;
            // 
            // pictureScissorsImg
            // 
            this.pictureScissorsImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureScissorsImg.ErrorImage")));
            this.pictureScissorsImg.ImageLocation = "Visual Studio/Visual Studio IDE/Rock Paper Scissors/Images/Scissors";
            this.pictureScissorsImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureScissorsImg.InitialImage")));
            this.pictureScissorsImg.Location = new System.Drawing.Point(492, 29);
            this.pictureScissorsImg.Name = "pictureScissorsImg";
            this.pictureScissorsImg.Size = new System.Drawing.Size(150, 150);
            this.pictureScissorsImg.TabIndex = 2;
            this.pictureScissorsImg.TabStop = false;
            // 
            // rockBt
            // 
            this.rockBt.Location = new System.Drawing.Point(150, 199);
            this.rockBt.Name = "rockBt";
            this.rockBt.Size = new System.Drawing.Size(75, 23);
            this.rockBt.TabIndex = 3;
            this.rockBt.Text = "Rock";
            this.rockBt.UseVisualStyleBackColor = true;
            this.rockBt.Click += new System.EventHandler(this.rockBt_Click);
            // 
            // paperBt
            // 
            this.paperBt.Location = new System.Drawing.Point(341, 199);
            this.paperBt.Name = "paperBt";
            this.paperBt.Size = new System.Drawing.Size(75, 23);
            this.paperBt.TabIndex = 4;
            this.paperBt.Text = "Paper";
            this.paperBt.UseVisualStyleBackColor = true;
            this.paperBt.Click += new System.EventHandler(this.paperBt_Click);
            // 
            // scissorsBt
            // 
            this.scissorsBt.Location = new System.Drawing.Point(530, 199);
            this.scissorsBt.Name = "scissorsBt";
            this.scissorsBt.Size = new System.Drawing.Size(75, 23);
            this.scissorsBt.TabIndex = 5;
            this.scissorsBt.Text = "Scissors";
            this.scissorsBt.UseVisualStyleBackColor = true;
            this.scissorsBt.Click += new System.EventHandler(this.scissorsBt_Click);
            // 
            // playerOptionLbl
            // 
            this.playerOptionLbl.AutoSize = true;
            this.playerOptionLbl.Location = new System.Drawing.Point(116, 240);
            this.playerOptionLbl.Name = "playerOptionLbl";
            this.playerOptionLbl.Size = new System.Drawing.Size(77, 13);
            this.playerOptionLbl.TabIndex = 6;
            this.playerOptionLbl.Text = "Player choice :";
            // 
            // computerOptionLbl
            // 
            this.computerOptionLbl.AutoSize = true;
            this.computerOptionLbl.Location = new System.Drawing.Point(116, 253);
            this.computerOptionLbl.Name = "computerOptionLbl";
            this.computerOptionLbl.Size = new System.Drawing.Size(90, 13);
            this.computerOptionLbl.TabIndex = 7;
            this.computerOptionLbl.Text = "Computer choice:";
            // 
            // gameOneWinnerLbl
            // 
            this.gameOneWinnerLbl.AutoSize = true;
            this.gameOneWinnerLbl.Location = new System.Drawing.Point(116, 292);
            this.gameOneWinnerLbl.Name = "gameOneWinnerLbl";
            this.gameOneWinnerLbl.Size = new System.Drawing.Size(81, 13);
            this.gameOneWinnerLbl.TabIndex = 8;
            this.gameOneWinnerLbl.Text = "Game 1 winner:";
            // 
            // gameTwoWinnerLbl
            // 
            this.gameTwoWinnerLbl.AutoSize = true;
            this.gameTwoWinnerLbl.Location = new System.Drawing.Point(116, 305);
            this.gameTwoWinnerLbl.Name = "gameTwoWinnerLbl";
            this.gameTwoWinnerLbl.Size = new System.Drawing.Size(81, 13);
            this.gameTwoWinnerLbl.TabIndex = 9;
            this.gameTwoWinnerLbl.Text = "Game 2 winner:";
            this.gameTwoWinnerLbl.Visible = false;
            // 
            // gameThreeWinnerLbl
            // 
            this.gameThreeWinnerLbl.AutoSize = true;
            this.gameThreeWinnerLbl.Location = new System.Drawing.Point(116, 318);
            this.gameThreeWinnerLbl.Name = "gameThreeWinnerLbl";
            this.gameThreeWinnerLbl.Size = new System.Drawing.Size(81, 13);
            this.gameThreeWinnerLbl.TabIndex = 10;
            this.gameThreeWinnerLbl.Text = "Game 3 winner:";
            this.gameThreeWinnerLbl.Visible = false;
            // 
            // overallWinnerLBL
            // 
            this.overallWinnerLBL.AutoSize = true;
            this.overallWinnerLBL.Location = new System.Drawing.Point(116, 358);
            this.overallWinnerLBL.Name = "overallWinnerLBL";
            this.overallWinnerLBL.Size = new System.Drawing.Size(77, 13);
            this.overallWinnerLBL.TabIndex = 11;
            this.overallWinnerLBL.Text = "Overall winner:";
            // 
            // playAgainBt
            // 
            this.playAgainBt.Location = new System.Drawing.Point(493, 358);
            this.playAgainBt.Name = "playAgainBt";
            this.playAgainBt.Size = new System.Drawing.Size(75, 23);
            this.playAgainBt.TabIndex = 12;
            this.playAgainBt.Text = "Play Again";
            this.playAgainBt.UseVisualStyleBackColor = true;
            this.playAgainBt.Click += new System.EventHandler(this.playAgainBt_Click);
            // 
            // exitBt
            // 
            this.exitBt.Location = new System.Drawing.Point(604, 358);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(75, 23);
            this.exitBt.TabIndex = 13;
            this.exitBt.Text = "Exit Button";
            this.exitBt.UseVisualStyleBackColor = true;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // gameFourWinnerLbl
            // 
            this.gameFourWinnerLbl.AutoSize = true;
            this.gameFourWinnerLbl.Location = new System.Drawing.Point(116, 331);
            this.gameFourWinnerLbl.Name = "gameFourWinnerLbl";
            this.gameFourWinnerLbl.Size = new System.Drawing.Size(104, 13);
            this.gameFourWinnerLbl.TabIndex = 14;
            this.gameFourWinnerLbl.Text = "Game 4 Tie breaker:";
            this.gameFourWinnerLbl.Visible = false;
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.AutoSize = true;
            this.gameOverLbl.Location = new System.Drawing.Point(493, 291);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(93, 13);
            this.gameOverLbl.TabIndex = 15;
            this.gameOverLbl.Text = "GAME OVER GG!";
            this.gameOverLbl.Visible = false;
            // 
            // RockPaperScissorsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameOverLbl);
            this.Controls.Add(this.gameFourWinnerLbl);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.playAgainBt);
            this.Controls.Add(this.overallWinnerLBL);
            this.Controls.Add(this.gameThreeWinnerLbl);
            this.Controls.Add(this.gameTwoWinnerLbl);
            this.Controls.Add(this.gameOneWinnerLbl);
            this.Controls.Add(this.computerOptionLbl);
            this.Controls.Add(this.playerOptionLbl);
            this.Controls.Add(this.scissorsBt);
            this.Controls.Add(this.paperBt);
            this.Controls.Add(this.rockBt);
            this.Controls.Add(this.pictureScissorsImg);
            this.Controls.Add(this.picturePaperImg);
            this.Controls.Add(this.pictureRockImg);
            this.Name = "RockPaperScissorsApp";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureRockImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaperImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissorsImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRockImg;
        private System.Windows.Forms.PictureBox picturePaperImg;
        private System.Windows.Forms.PictureBox pictureScissorsImg;
        private System.Windows.Forms.Button rockBt;
        private System.Windows.Forms.Button paperBt;
        private System.Windows.Forms.Button scissorsBt;
        private System.Windows.Forms.Label playerOptionLbl;
        private System.Windows.Forms.Label computerOptionLbl;
        private System.Windows.Forms.Label gameOneWinnerLbl;
        private System.Windows.Forms.Label gameTwoWinnerLbl;
        private System.Windows.Forms.Label gameThreeWinnerLbl;
        private System.Windows.Forms.Label overallWinnerLBL;
        private System.Windows.Forms.Button playAgainBt;
        private System.Windows.Forms.Button exitBt;
        private System.Windows.Forms.Label gameFourWinnerLbl;
        private System.Windows.Forms.Label gameOverLbl;
    }
}

