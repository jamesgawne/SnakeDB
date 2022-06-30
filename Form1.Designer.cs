namespace SnakeDB
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScrNum = new System.Windows.Forms.Label();
            this.lblEndGame = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.txtHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Gray;
            this.picCanvas.Location = new System.Drawing.Point(13, 13);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(541, 560);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphics);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(629, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 24);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblScrNum
            // 
            this.lblScrNum.AutoSize = true;
            this.lblScrNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrNum.Location = new System.Drawing.Point(692, 13);
            this.lblScrNum.Name = "lblScrNum";
            this.lblScrNum.Size = new System.Drawing.Size(32, 24);
            this.lblScrNum.TabIndex = 2;
            this.lblScrNum.Text = "00";
            // 
            // lblEndGame
            // 
            this.lblEndGame.AutoSize = true;
            this.lblEndGame.BackColor = System.Drawing.Color.Black;
            this.lblEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndGame.ForeColor = System.Drawing.Color.Yellow;
            this.lblEndGame.Location = new System.Drawing.Point(215, 226);
            this.lblEndGame.Name = "lblEndGame";
            this.lblEndGame.Size = new System.Drawing.Size(95, 24);
            this.lblEndGame.TabIndex = 3;
            this.lblEndGame.Text = "End Text";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(633, 88);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // snapButton
            // 
            this.snapButton.Location = new System.Drawing.Point(633, 137);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(75, 23);
            this.snapButton.TabIndex = 5;
            this.snapButton.Text = "Snap";
            this.snapButton.UseVisualStyleBackColor = true;
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(629, 200);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(121, 24);
            this.txtHighScore.TabIndex = 6;
            this.txtHighScore.Text = "High Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 631);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.lblEndGame);
            this.Controls.Add(this.lblScrNum);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "SnakeDB";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScrNum;
        private System.Windows.Forms.Label lblEndGame;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Label txtHighScore;
    }
}

