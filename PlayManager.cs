using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SC2Unit.ViewModels;
using Windows.Phone.Speech.Synthesis;

namespace SC2Unit
{
    public class PlayManager
    {

        public SpeechSynthesizer synth = new SpeechSynthesizer();

        public async void PlayOrder(string content)
        {
            await synth.SpeakTextAsync(content);

        }


        


    }
}
