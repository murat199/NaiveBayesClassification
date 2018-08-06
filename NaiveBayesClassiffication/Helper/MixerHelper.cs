using NaiveBayesClassiffication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Helper
{
    public static class MixerHelper
    {
        public static Mixer GetMixerData()
        {
            Mixer result = new Mixer();
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 230);
            for (int i = 0; i < 230; i++)
            {
                result.Data25.Add(i);
            }
            for (int i = 0; i < 172; i++)
            {
                while (result.Data75.Contains(randomNumber))
                {
                    randomNumber = rnd.Next(0, 230);
                }
                result.Data75.Add(randomNumber);
                result.Data25.Remove(randomNumber);
            }
            return result;
        }
    }
}
