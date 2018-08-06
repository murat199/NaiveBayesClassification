using NaiveBayesClassiffication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Helper
{
    public static class NaiveBayesHelper
    {
        public static string GetCategory(DirectoryFileInfo file, List<Gram> gramsAll, List<Gram> gramsLearn, List<Gram> gramsPrediction, List<string> categories)
        {
            try
            {
                double maxRatio = double.MinValue;
                double ratio = 1.0;
                string maxCategory = "NOT FOUND";
                List<Gram> gramsTxt = gramsPrediction.Where(x => x.FileName == file.Name).ToList();
                foreach (var category in categories)
                {
                    ratio = 1.0;
                    foreach (var gram in gramsTxt)
                    {
                        double x = 0.0, y = 0.0;
                        List<Gram> gramsByContent = gramsAll.Where(a => a.Category == category && a.Content == gram.Content).ToList();
                        if (gramsByContent != null)
                        {
                            foreach (var gramByContent in gramsByContent)
                            {
                                x += gramByContent.Frequency;
                            }
                            y = x + gramsLearn.Count();
                            x += 2;
                            //ratio *= Math.Log10((x / y));
                            ratio += Math.Log(x, 10) - Math.Log(y, 10);
                            if(maxRatio == 0.0) maxRatio = ratio;

                            if (ratio > double.MaxValue || ratio < double.MinValue)
                            {
                                Console.WriteLine("------------------------------------EŞİT EŞİT EŞİT 22222222222222222222222");
                            }
                            //Console.WriteLine(String.Format("Kategori : {0}. Gram : {1}. Olasılık : {2}", gram.Category, gram.Content, ratio.ToString()));
                        }
                        else
                        {
                            ratio *= 1;
                        }
                    }
                    if (ratio >= maxRatio)
                    {
                        maxRatio = ratio;
                        maxCategory = category;
                    }
                }
                if(maxCategory=="NOT FOUND")
                {
                    Console.WriteLine("***************not found*********************");
                }
                return maxCategory;
            }
            catch(Exception e)
            {
                Console.WriteLine("HATA ! " + e.Message);
                return "HATA !";
            }
        }
    }
}
