namespace PomodoroTimerApp
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
            components = new System.ComponentModel.Container();
            timerPomodoro = new System.Windows.Forms.Timer(components);
            labelTimer = new Label();
            textBoxStatus = new TextBox();
            textBoxIterations = new TextBox();
            btnSkip = new Button();
            btnStartPause = new Button();
            btnEndSession = new Button();
            SuspendLayout();
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(12, 20);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(44, 20);
            labelTimer.TabIndex = 0;
            labelTimer.Text = "00:00";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(12, 80);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(150, 27);
            textBoxStatus.TabIndex = 2;
            // 
            // textBoxIterations
            // 
            textBoxIterations.Location = new Point(12, 110);
            textBoxIterations.Name = "textBoxIterations";
            textBoxIterations.Size = new Size(150, 27);
            textBoxIterations.TabIndex = 3;
            // 
            // btnSkip
            // 
            btnSkip.Location = new Point(191, 105);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(94, 29);
            btnSkip.TabIndex = 4;
            btnSkip.Text = "Skip";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // btnStartPause
            // 
            btnStartPause.Location = new Point(236, 35);
            btnStartPause.Name = "btnStartPause";
            btnStartPause.Size = new Size(94, 29);
            btnStartPause.TabIndex = 5;
            btnStartPause.Text = "Start/Pause";
            btnStartPause.UseVisualStyleBackColor = true;
            btnStartPause.Click += btnStartPause_Click;
            // 
            // btnEndSession
            // 
            btnEndSession.Location = new Point(294, 105);
            btnEndSession.Name = "btnEndSession";
            btnEndSession.Size = new Size(94, 29);
            btnEndSession.TabIndex = 6;
            btnEndSession.Text = "End";
            btnEndSession.UseVisualStyleBackColor = true;
            btnEndSession.Click += btnEndSession_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 200);
            Controls.Add(btnEndSession);
            Controls.Add(btnStartPause);
            Controls.Add(btnSkip);
            Controls.Add(textBoxIterations);
            Controls.Add(textBoxStatus);
            Controls.Add(labelTimer);
            Name = "Form1";
            Text = "Pomodoro Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerPomodoro;
        private Label labelTimer;
        private TextBox textBoxStatus;
        private TextBox textBoxIterations;
        private Button btnSkip;
        private Button btnStartPause;
        private Button btnEndSession;
    }
}
