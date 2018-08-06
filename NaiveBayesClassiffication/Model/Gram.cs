using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Model
{
    public class Gram
    {
        public Gram()
        {
            IsTest = false;
        }
        public string Content { get; set; }
        public int Type { get; set; }
        public string Category { get; set; }
        public int Frequency { get; set; }
        public string FileName { get; set; }
        public string FileContent { get; set; }
        public bool IsTest { get; set; }
    }
}
