using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using Windows.Storage;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FreddysPhoneSoundApp.Resources;
using Microsoft.Phone.BackgroundAudio;

namespace TestFreddyPHone2015
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void playsounds(string filename)
        {
            try
            {
                myMediaElement.Source = new Uri("/Audio/" + filename, UriKind.RelativeOrAbsolute);
                myMediaElement.Play();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {

            playsounds("Evil_Laugh_Halloween_Wav_Free_Loop_and_Sound_Download_from_Evil_20Laugh.wav_18087_Free_Loops.com.mp3");
           

        }

        private void Howling_Click(object sender, RoutedEventArgs e)
        {
            playsounds("howling37.mp3");
          
        }

        private void ImageTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            playsounds("piggy_ringtone.mp3");
          
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            playsounds("Pure Imagination_Fiona Apple.mp3");
            
        }

        private void OneFishTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            playsounds("onefish.mp3");

        }

        private void FamilyTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            playsounds("thisismyfamily.mp3");
            
        }

        private void WhatColorClick(object sender, RoutedEventArgs e)
        {
            List<Color> AllColors = new List<Color>();
            
            
            AllColors.Add(Colors.Cyan);
            AllColors.Add(Colors.Blue);
            AllColors.Add(Colors.Brown);
            AllColors.Add(Colors.Cyan);
            AllColors.Add(Colors.DarkGray);
            AllColors.Add(Colors.Magenta);
            AllColors.Add(Colors.Red);

            WhatColor.Background = new SolidColorBrush(AllColors[new Random().Next(0,6)]);
        }

        private void Simpons_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            playsounds("appletozebra.mp3");

           
        }

        private void Supermantab(object sender, System.Windows.Input.GestureEventArgs e)
        {
            playsounds("whatcanyourecycle.mp3");

            
        }

        private void lifetap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            playsounds("howoldareyou1.mp3");
        }

        private void SpaceTap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            playsounds("Dream English Lets Count 1 to 1001.mp3.mp3");
          
        }

        private void BasicImageTap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            playsounds("Dream English Traditional ABC01.mp3");
           
        }

        private void trippyTap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            playsounds("howoldareyou2.mp3");
            
        }

        private void space2tab(object sender, System.Windows.Input.GestureEventArgs e)
        {
            playsounds("Owl_Sound24.mp3");
           
        }

        private void Scity(object sender, System.Windows.Input.GestureEventArgs e)
        {

            playsounds("bingo.mp3");
           
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AnimalSounds.xaml", UriKind.Relative));
        }
    }
}