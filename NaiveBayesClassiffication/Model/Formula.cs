using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Model
{
    public class Formula
    {
        public double Precision { get; set; }
        public double ReCall { get; set; }
        public double FeMeasure { get; set; }
        public double TP { get; set; }
        public double FN { get; set; }
        public double FP { get; set; }
        public string Category { get; set; }
        public Formula GetCalculate(List<DirectoryFileInfo> dataPredictions, string category)
        {
            double TP = dataPredictions.Where(x => x.Category == category && x.GuessCategory == category).ToList().Count;
            double FN = dataPredictions.Where(x => x.Category == category && x.GuessCategory != category).ToList().Count;
            double FP = dataPredictions.Where(x => x.Category != category && x.GuessCategory == category).ToList().Count;
            double precision = TP / (TP + FP);
            double recall = TP / (TP + FN);
            double feMeasure = 2 * precision * recall / (precision + recall);
            this.ReCall = recall;
            this.Precision = precision;
            this.FeMeasure = feMeasure;
            this.FN = FN;
            this.FP = FP;
            this.TP = TP;
            this.Category = category;
            return this;
        }
    }
}
