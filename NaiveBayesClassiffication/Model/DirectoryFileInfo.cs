using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Model
{
    public class DirectoryFileInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public string GuessCategory { get; set; }
    }
}
