using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Model
{
    public class Mixer
    {
        public Mixer()
        {
            Data25 = new List<int>();
            Data75 = new List<int>();
        }
        public List<int> Data75 { get; set; }
        public List<int> Data25 { get; set; }
    }
}
