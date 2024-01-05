using NAudio;
using NAudio.CoreAudioApi;
using NAudio.Utils;
using NAudio.Wave;

using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace play_sound_events_haitran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            volume_system = GetSystemVolume();
            
        }
        int volume_system;
        Boolean isstop = false;

        private void btn_play_Click(object sender, EventArgs e)
        {
            isstop = false;
            string filepart = "flac.flac";
            Task.Run(() => PlayAudio(filepart));
        }


        private void btn_play2_Click(object sender, EventArgs e)
        {
            isstop = false;
            string audiopart = "mp3.mp3";
            Task.Run(() => PlayAudio(audiopart));
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            isstop = true;
        }

        public void PlayAudio(string filePath)
        {
            using (var waveOut = new WaveOutEvent())
            {
                var audioFileReader = new AudioFileReader(filePath);
                waveOut.Init(audioFileReader);
                waveOut.Play();

                // Đợi cho đến khi nhạc kết thúc
                while (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);

                    if (isstop == true)
                    {
                        System.Threading.Thread.Sleep(600);
                        waveOut.Stop();
                        //SetSystemVolume(2);
                    }
                }


            }
        }

        // Hàm để lấy giá trị âm lượng hệ thống sử dụng NAudio
        public static int GetSystemVolume()
        {
            using (var deviceEnumerator = new MMDeviceEnumerator())
            {
                using (var defaultDevice = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia))
                {
                    // Lấy giá trị âm lượng từ phạm vi 0-1 và chuyển đổi sang phạm vi 0-100
                    float volumeLevel = defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar;
                    int currentVolume = (int)(volumeLevel * 100);

                    return currentVolume;
                }
            }
        }

        // Hàm để đặt mức âm lượng hệ thống sử dụng NAudio
        public static void SetSystemVolume(int volume)
        {
            using (var deviceEnumerator = new MMDeviceEnumerator())
            {
                using (var defaultDevice = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia))
                {
                    // Chuyển đổi giá trị âm lượng từ phạm vi 0-100 sang phạm vi 0-1
                    float volumeLevel = volume / 100.0f;

                    // Đặt âm lượng của hệ thống
                    defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = volumeLevel;
                }
            }
        }

    }
}