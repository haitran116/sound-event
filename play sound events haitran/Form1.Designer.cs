namespace play_sound_events_haitran
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_play = new Button();
            btn_play2 = new Button();
            button1 = new Button();
            button2 = new Button();
            btn_stop = new Button();
            SuspendLayout();
            // 
            // btn_play
            // 
            btn_play.Location = new Point(207, 150);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(167, 87);
            btn_play.TabIndex = 0;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = true;
            btn_play.Click += btn_play_Click;
            // 
            // btn_play2
            // 
            btn_play2.Location = new Point(407, 150);
            btn_play2.Name = "btn_play2";
            btn_play2.Size = new Size(167, 87);
            btn_play2.TabIndex = 1;
            btn_play2.Text = "Play 2";
            btn_play2.UseVisualStyleBackColor = true;
            btn_play2.Click += btn_play2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumVioletRed;
            button1.Font = new Font("UTM HelvetIns", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(207, 150);
            button1.Name = "button1";
            button1.Size = new Size(167, 87);
            button1.TabIndex = 0;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_play_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumVioletRed;
            button2.Font = new Font("UTM HelvetIns", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(407, 150);
            button2.Name = "button2";
            button2.Size = new Size(167, 87);
            button2.TabIndex = 1;
            button2.Text = "Play 2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btn_play2_Click;
            // 
            // btn_stop
            // 
            btn_stop.BackColor = Color.MediumVioletRed;
            btn_stop.Font = new Font("UTM HelvetIns", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_stop.ForeColor = Color.Gold;
            btn_stop.Location = new Point(207, 254);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(167, 87);
            btn_stop.TabIndex = 2;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = false;
            btn_stop.Click += btn_stop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_stop);
            Controls.Add(button2);
            Controls.Add(btn_play2);
            Controls.Add(button1);
            Controls.Add(btn_play);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_play;
        private Button btn_play2;
        private Button button1;
        private Button button2;
        private Button btn_stop;
    }
}