using System;
using System.Windows.Forms;

namespace PomodoroTimerApp
{
    public partial class Form1 : Form
    {
        private int workMinutes = 25;
        private int restMinutes = 5;

        private int currentMinutes;
        private int currentSeconds;

        private int iterationCount = 0;

        private bool isWorking = true;
        private bool isPaused = false;

        public Form1()
        {
            InitializeComponent();
            timerPomodoro.Interval = 1000; // 1-second interval
            timerPomodoro.Tick += TimerPomodoro_Tick;
            UpdateTimerDisplay();
        }

        private void TimerPomodoro_Tick(object sender, EventArgs e)
        {
            if (currentMinutes == 0 && currentSeconds == 0)
            {
                isWorking = !isWorking;
                iterationCount++;
                currentMinutes = isWorking ? workMinutes : restMinutes;
                currentSeconds = 0;
            }
            else
            {
                if (!isPaused)
                {
                    if (currentSeconds == 0)
                    {
                        currentMinutes--;
                        currentSeconds = 59;
                    }
                    else
                    {
                        currentSeconds--;
                    }
                }
            }

            UpdateTimerDisplay();
        }

        private void StartNewSession()
        {
            currentMinutes = workMinutes;
            currentSeconds = 0;
            iterationCount = 0;
            isWorking = true;
            isPaused = false;
            timerPomodoro.Start();
        }

        private void SkipToNextPomodoro()
        {
            iterationCount++;
            isWorking = !isWorking;
            currentMinutes = isWorking ? workMinutes : restMinutes;
            currentSeconds = 0;
        }

        private void UpdateTimerDisplay()
        {
            labelTimer.Text = $"{currentMinutes:D2}:{currentSeconds:D2}";

            if (isWorking)
            {
                textBoxStatus.Text = "Time to Focus!";
            }
            else
            {
                textBoxStatus.Text = "Time for a Break!";
            }

            textBoxIterations.Text = $"Iteration: {iterationCount}";
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;

            if (!timerPomodoro.Enabled)
            {
                StartNewSession();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            SkipToNextPomodoro();
            UpdateTimerDisplay();
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            timerPomodoro.Stop();
            currentMinutes = 0;
            currentSeconds = 0;
            iterationCount = 0;
            isWorking = true;
            isPaused = false;
            UpdateTimerDisplay();
        }
    }
}
