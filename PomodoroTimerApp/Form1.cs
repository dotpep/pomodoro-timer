using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace PomodoroTimerApp
{
    public partial class PomoInitD : Form
    {
        private const int WorkMinutes = 25;
        private const int RestMinutes = 5;

        private int currentMinutes;
        private int currentSeconds;

        private int iterationCount = 0;

        private bool isWorking = true;
        private bool isPaused = false;

        private readonly SoundPlayer notifySoundPlayer;

        public PomoInitD()
        {
            InitializeComponent();
            timerPomodoro.Interval = 1000; // 1-second
            timerPomodoro.Tick += TimerPomodoro_Tick;

            // sound path: PomodoroTimerApp\bin\Debug\net6.0-windows\sound.wav
            string soundFileName = "D:\\Programming\\Pet_project\\WinForms\\PomodoroTimerApp\\PomodoroTimerApp\\source\\sound.wav";
            notifySoundPlayer = InitializeSoundPlayer(soundFileName);

            UpdateTimerDisplay();
        }

        private void ShowErrorMessage(string message, string filePath)
        {
            MessageBox.Show($"{message}\n\nExpected path: {filePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private SoundPlayer InitializeSoundPlayer(string soundFileName)
        {
            try
            {
                if (File.Exists(soundFileName))
                {
                    return new SoundPlayer(soundFileName);
                }

                ShowErrorMessage("Sound file not found.", soundFileName);
                return null;
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error initializing sound player: {ex.Message}", soundFileName);
                return null;
            }
        }


        private void TimerPomodoro_Tick(object sender, EventArgs e)
        {
            if (currentMinutes == 0 && currentSeconds == 0)
            {
                isWorking = !isWorking;
                iterationCount++;
                currentMinutes = isWorking ? WorkMinutes : RestMinutes;
                currentSeconds = 0;

                PlayNotificationSound();
            }
            else
            {
                if (!isPaused)
                {
                    UpdateTimeRemaining();
                }
            }

            UpdateTimerDisplay();
        }

        private void UpdateTimeRemaining()
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

        private void PlayNotificationSound()
        {
            if (notifySoundPlayer != null)
            {
                try
                {
                    notifySoundPlayer.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StartNewSession()
        {
            currentMinutes = WorkMinutes;
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
            currentMinutes = isWorking ? WorkMinutes : RestMinutes;
            currentSeconds = 0;
        }

        private void UpdateTimerDisplay()
        {
            labelTimer.Text = $"{currentMinutes:D2}:{currentSeconds:D2}";

            textBoxStatus.Text = isWorking ? "Time to Focus!" : "Time for a Break!";
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
            PlayNotificationSound();
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
