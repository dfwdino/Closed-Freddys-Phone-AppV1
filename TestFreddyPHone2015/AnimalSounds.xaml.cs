using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TestFreddyPHone2015
{
    public partial class AnimalSounds : PhoneApplicationPage
    {
        private void playsounds(string filename)
        {
            try
            {
                myMediaElement.Source = new Uri("/Audio/Animal/" + filename, UriKind.RelativeOrAbsolute);
                myMediaElement.Play();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public AnimalSounds()
        {
            InitializeComponent();
        }

        private void BarbedOwl_Click(object sender, RoutedEventArgs e)
        {
            playsounds("Barbed Owl.mp3");
        }

        private void NightWolf_Click(object sender, RoutedEventArgs e)
        {
            playsounds("Night_Wolf23.mp3");
        }

        private void OwlSound_Click(object sender, RoutedEventArgs e)
        {
            playsounds("Owl_Sound24.mp3");
        }

        private void Wolf36_Click(object sender, RoutedEventArgs e)
        {
            playsounds("Wolf36.mp3");
        }

        private void PeekABooColor_Click(object sender, RoutedEventArgs e)
        {
            List<Color> AllColors = new List<Color>();


            AllColors.Add(Colors.Cyan);
            AllColors.Add(Colors.Blue);
            AllColors.Add(Colors.Brown);
            AllColors.Add(Colors.Cyan);
            AllColors.Add(Colors.DarkGray);
            AllColors.Add(Colors.Magenta);
            AllColors.Add(Colors.Red);

            playsounds("peek-a-boo.mp3");

            PeekABooColor.Background = new SolidColorBrush(AllColors[new Random().Next(0, 6)]);
            //PeekABooColor.Content = PeekABooColor.Background.Opacity.ToString();
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Speak_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TextToSpeech.xaml", UriKind.Relative));
        }
    }
}