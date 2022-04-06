namespace Snake
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(520, 49);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 37);
            this.lblScore.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(23, 143);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(102, 37);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "High Score: ";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(604, 100);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(0, 37);
            this.lblHighScore.TabIndex = 5;
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.Location = new System.Drawing.Point(66, 180);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(102, 37);
            this.lblStartGame.TabIndex = 6;
            this.lblStartGame.Text = "label2";
            this.lblStartGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStartGame.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Controls";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snake.Properties.Resources.arrows1;
            this.pictureBox1.InitialImage = global::Snake.Properties.Resources.png_transparent_grey_arrow_keys_art_keyboard_arrow_keys_computer_keyboard_happy_birthday_vector_images_3d_arrows;
            this.pictureBox1.Location = new System.Drawing.Point(464, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(384, 384);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Up";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Down";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Left";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(610, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Right";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 410);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStartGame);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

