using NaiveBayesClassiffication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Helper
{
    public class GramHelper
    {
        public List<Gram> GetTwoGrams(List<DirectoryFileInfo> files, List<DirectoryFolderInfo> folders, string catName, bool isTest)
        {
            List<Gram> result = new List<Gram>();
            
            try
            {
                foreach (var file in files)
                {
                    for (int i = 0; i < file.Content.Length - 1; i++)
                    {
                        file.Content = file.Content.Replace(" ", "_").Replace(Environment.NewLine, " ");
                        if(result.Where(x=>x.Content== file.Content.Substring(i, 2)).FirstOrDefault() == null)
                        {
                            Gram g = new Gram();
                            g.Content = file.Content.Substring(i, 2);
                            g.Category = file.Category;
                            g.FileName = file.Name;
                            g.FileContent = file.Content;
                            g.Type = 2;
                            g.IsTest = isTest;
                            g.Frequency = file.Content.Length - file.Content.Replace(g.Content, "").Length;
                            //result.Add(g);
                            if (isTest)
                            {
                                if (g.Frequency > 50) result.Add(g);
                                //result.Add(g);
                            }
                            else
                            {
                                Gram hasGramInResult = result.Where(x => x.Content == g.Content).FirstOrDefault();
                                if (g.Frequency > 50 && hasGramInResult == null)
                                {
                                    result.Add(g);
                                }
                                else if (hasGramInResult != null)
                                {
                                    hasGramInResult.Frequency += g.Frequency;
                                    result.Add(hasGramInResult);
                                }
                            }
                        }
                    }
                }
                return result;
            }
            catch(Exception e)
            {
                Console.WriteLine("HATA ! : " + e.Message);
                return result;
            }
        }
        public List<Gram> GetTwoThreeGrams(List<DirectoryFileInfo> files, List<DirectoryFolderInfo> folders, string catName, bool isTest)
        {
            List<Gram> result = new List<Gram>();

            try
            {
                foreach (var file in files)
                {
                    for (int i = 0; i < file.Content.Length - 3; i++)
                    {
                        file.Content = file.Content.Replace(" ", "_").Replace(Environment.NewLine, " ");
                        if (result.Where(x => x.Content == file.Content.Substring(i, 3)).FirstOrDefault() == null)
                        {
                            Gram g = new Gram();
                            g.Content = file.Content.Substring(i, 3);
                            g.Category = file.Category;
                            g.FileName = file.Name;
                            g.FileContent = file.Content;
                            g.Type = 3;
                            g.IsTest = isTest;
                            g.Frequency = file.Content.Length - file.Content.Replace(g.Content, "").Length;
                            //result.Add(g);
                            if (isTest)
                            {
                                result.Add(g);
                            }
                            else
                            {
                                Gram hasGramInResult = result.Where(x => x.Content == g.Content).FirstOrDefault();
                                if (g.Frequency > 50 && hasGramInResult == null)
                                {
                                    result.Add(g);
                                }
                                else if (hasGramInResult != null)
                                {
                                    hasGramInResult.Frequency += g.Frequency;
                                    result.Add(hasGramInResult);
                                }
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("HATA ! : " + e.Message);
                return result;
            }
        }
        public List<Gram> GetThreeGrams(List<DirectoryFileInfo> files, List<DirectoryFolderInfo> folders, string catName, bool isTest)
        {
            List<Gram> result = new List<Gram>();
            try
            {
                foreach (var file in files)
                {
                    for (int i = 0; i < file.Content.Length - 3; i++)
                    {
                        file.Content = file.Content.Replace(" ", "_");
                        Gram g = new Gram();
                        g.Content = file.Content.Substring(i, 3);
                        g.Category = file.Category;
                        g.FileName = file.Name;
                        g.FileContent = file.Content;
                        g.Type = 3;
                        g.IsTest = isTest;
                        g.Frequency = file.Content.Length - file.Content.Replace(g.Content, "").Length;
                        //result.Add(g);
                        if (isTest)
                        {
                            result.Add(g);
                        }
                        else
                        {
                            Gram hasGramInResult = result.Where(x => x.Content == g.Content).FirstOrDefault();
                            if (g.Frequency > 50 && hasGramInResult == null)
                            {
                                result.Add(g);
                            }
                            else if (hasGramInResult != null)
                            {
                                hasGramInResult.Frequency += g.Frequency;
                                result.Add(hasGramInResult);
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("HATA ! : " + e.Message);
                return result;
            }
        }
    }
}
