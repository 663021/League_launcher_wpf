using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;

namespace LeagueOfLegends_login
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MyWindow_Loaded;
        }

        Microsoft.DirectX.AudioVideoPlayback.Video league_video;

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            mediaElement.Source = new Uri(@"C:\Users\михаил\Documents\Visual Studio 2015\Projects\LeagueOfLegends_login\Season_Start.mp4");
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.UnloadedBehavior = MediaState.Manual;
            mediaElement.Volume = 1000;
            mediaElement.Play();
        }

        private void checkBox_video_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox_video.IsChecked == true)
            {
                image_none_video.Visibility = Visibility.Visible;
            }
            else
            {
                image_none_video.Visibility = Visibility.Hidden;
            }
        }

        private void checkBox_audio_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox_audio.IsChecked == true)
            {
                mediaElement.Volume = 0;
            }else
            {
                mediaElement.Volume = 1000;
            }
        }

        private void button_in_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Work!");
        }

        private void button_reg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Work!");
        }
    }
}
