namespace Whack_A_Mole_HW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_Score = new System.Windows.Forms.Label();
            this.Button_AverageTime = new System.Windows.Forms.Label();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Button_Quit = new System.Windows.Forms.Button();
            this.Mole = new System.Windows.Forms.PictureBox();
            this.WinLbl = new System.Windows.Forms.Label();
            this.User_Directions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Score
            // 
            this.Button_Score.Location = new System.Drawing.Point(245, 9);
            this.Button_Score.Name = "Button_Score";
            this.Button_Score.Size = new System.Drawing.Size(80, 35);
            this.Button_Score.TabIndex = 0;
            this.Button_Score.Text = "Score: 0";
            // 
            // Button_AverageTime
            // 
            this.Button_AverageTime.Location = new System.Drawing.Point(464, 9);
            this.Button_AverageTime.Name = "Button_AverageTime";
            this.Button_AverageTime.Size = new System.Drawing.Size(238, 62);
            this.Button_AverageTime.TabIndex = 1;
            this.Button_AverageTime.Text = "Score 10 to win. Go below -2? You lose.";
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(192, 371);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(75, 34);
            this.Button_Start.TabIndex = 2;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Button_Stop
            // 
            this.Button_Stop.Location = new System.Drawing.Point(192, 411);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(75, 35);
            this.Button_Stop.TabIndex = 3;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 600;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Button_Quit
            // 
            this.Button_Quit.Location = new System.Drawing.Point(192, 452);
            this.Button_Quit.Name = "Button_Quit";
            this.Button_Quit.Size = new System.Drawing.Size(75, 31);
            this.Button_Quit.TabIndex = 4;
            this.Button_Quit.Text = "QUIT";
            this.Button_Quit.UseVisualStyleBackColor = true;
            this.Button_Quit.Click += new System.EventHandler(this.Button_Quit_Click);
            // 
            // Mole
            // 
            this.Mole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mole.Image = ((System.Drawing.Image)(resources.GetObject("Mole.Image")));
            this.Mole.Location = new System.Drawing.Point(378, 102);
            this.Mole.Name = "Mole";
            this.Mole.Size = new System.Drawing.Size(111, 47);
            this.Mole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mole.TabIndex = 5;
            this.Mole.TabStop = false;
            this.Mole.Visible = false;
            this.Mole.Click += new System.EventHandler(this.Mole_Click);
            // 
            // WinLbl
            // 
            this.WinLbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WinLbl.Location = new System.Drawing.Point(417, 420);
            this.WinLbl.Name = "WinLbl";
            this.WinLbl.Size = new System.Drawing.Size(151, 63);
            this.WinLbl.TabIndex = 7;
            this.WinLbl.Text = " ";
            this.WinLbl.Visible = false;
            // 
            // User_Directions
            // 
            this.User_Directions.Location = new System.Drawing.Point(618, 420);
            this.User_Directions.Name = "User_Directions";
            this.User_Directions.Size = new System.Drawing.Size(157, 63);
            this.User_Directions.TabIndex = 8;
            this.User_Directions.Text = " ";
            this.User_Directions.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.User_Directions);
            this.Controls.Add(this.WinLbl);
            this.Controls.Add(this.Mole);
            this.Controls.Add(this.Button_Quit);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Button_AverageTime);
            this.Controls.Add(this.Button_Score);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Whack-A-Mole By Matthew";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Mole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Button_Score;
        private System.Windows.Forms.Label Button_AverageTime;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button Button_Quit;
        private System.Windows.Forms.PictureBox Mole;
        private System.Windows.Forms.Label WinLbl;
        private System.Windows.Forms.Label User_Directions;
    }
}

