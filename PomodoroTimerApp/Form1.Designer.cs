namespace PomodoroTimerApp
{
    partial class PomoInitD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomoInitD));
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
            labelTimer.ForeColor = SystemColors.ControlLightLight;
            labelTimer.Location = new Point(98, 27);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(44, 20);
            labelTimer.TabIndex = 0;
            labelTimer.Text = "00:00";
            // 
            // textBoxStatus
            // 
            textBoxStatus.BackColor = Color.Tomato;
            textBoxStatus.ForeColor = Color.White;
            textBoxStatus.Location = new Point(42, 66);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(150, 27);
            textBoxStatus.TabIndex = 2;
            // 
            // textBoxIterations
            // 
            textBoxIterations.BackColor = Color.Tomato;
            textBoxIterations.ForeColor = Color.White;
            textBoxIterations.Location = new Point(42, 109);
            textBoxIterations.Name = "textBoxIterations";
            textBoxIterations.Size = new Size(150, 27);
            textBoxIterations.TabIndex = 3;
            // 
            // btnSkip
            // 
            btnSkip.ForeColor = SystemColors.ActiveCaptionText;
            btnSkip.Location = new Point(231, 86);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(94, 29);
            btnSkip.TabIndex = 4;
            btnSkip.Text = "Skip";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // btnStartPause
            // 
            btnStartPause.ForeColor = SystemColors.ActiveCaptionText;
            btnStartPause.Location = new Point(231, 35);
            btnStartPause.Name = "btnStartPause";
            btnStartPause.Size = new Size(94, 29);
            btnStartPause.TabIndex = 5;
            btnStartPause.Text = "Start/Pause";
            btnStartPause.UseVisualStyleBackColor = true;
            btnStartPause.Click += btnStartPause_Click;
            // 
            // btnEndSession
            // 
            btnEndSession.ForeColor = SystemColors.ActiveCaptionText;
            btnEndSession.Location = new Point(231, 121);
            btnEndSession.Name = "btnEndSession";
            btnEndSession.Size = new Size(94, 29);
            btnEndSession.TabIndex = 6;
            btnEndSession.Text = "End";
            btnEndSession.UseVisualStyleBackColor = true;
            btnEndSession.Click += btnEndSession_Click;
            // 
            // PomoInitD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(382, 175);
            Controls.Add(btnEndSession);
            Controls.Add(btnStartPause);
            Controls.Add(btnSkip);
            Controls.Add(textBoxIterations);
            Controls.Add(textBoxStatus);
            Controls.Add(labelTimer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PomoInitD";
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
