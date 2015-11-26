using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading.Tasks;
using Windows.Phone.Speech.Synthesis;
using System.Runtime.ExceptionServices;

namespace FreddysPhoneSoundApp
{


    public partial class TextToSpeech : PhoneApplicationPage
    {
        bool FirstRun = false;

        string[] ThingsToSay = "Hello Freddy how are you?,Freddy, who is this?,Freddy, are you hungry?,Happy Happy Joy Joy, Can you saw Mommy?, Where is mommy?,Where is daddy?,Mommy and Daddy love you Freddy Lee".Split(',');


        public TextToSpeech()
        {
            InitializeComponent();
        }



        public static async Task Speak(string text)
        {
            ExceptionDispatchInfo capturedException = null;

            using (var speech = new SpeechSynthesizer())
            {
                try
                {
                    await speech.SpeakTextAsync(text);
                }
                catch (Exception ex)
                {

                    capturedException = ExceptionDispatchInfo.Capture(ex);
                }

                if (capturedException != null)
                {
                    MessageBox.Show(capturedException.SourceException.Message);

                    //capturedException.Throw();
                }


            }

        }





        private async void button_Click(object sender, RoutedEventArgs e)
        {
            int SayNumber = 0;

            if (!FirstRun)
            { FirstRun = true; }
            else
            {
                SayNumber = new Random().Next(0, ThingsToSay.Count() - 1);
            }


            await Speak(ThingsToSay[SayNumber].ToString());
        }

        private async void Eat_Click(object sender, RoutedEventArgs e)
        {
            await Speak("Freddy wants to EAT!!!");
        }

        private async void Bathroom_Click(object sender, RoutedEventArgs e)
        {
            await Speak("Freddy needs to go to the bathroom");
        }

        private async void Sleep_Click(object sender, RoutedEventArgs e)
        {
            await Speak("Freddy is ready for sleep");
        }
    }
}