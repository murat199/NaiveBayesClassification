using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Model
{
    public class TabShowControl
    {
        public TabShowControl()
        {
            tabIsShow = new List<bool>();
            tabIsShow.Add(true);
            tabIsShow.Add(false);
            tabIsShow.Add(false);
            tabIsShow.Add(false);
            tabIsShow.Add(false);
        }
        public List<bool> tabIsShow { get; set; }
    }
}
