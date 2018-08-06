using NaiveBayesClassiffication.Model;
using net.zemberek.erisim;
using net.zemberek.tr.yapi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesClassiffication.Helper
{
    public static class DirectoryHelper
    {
        public static string[] GetSubFolders(string root)
        {
            string[] subFolders = Directory.GetDirectories(root);
            return subFolders;
        }
        public static string[] GetSubFiles(string root)
        {
            string[] subFolders = Directory.GetFiles(root);
            return subFolders;
        }
        public static List<DirectoryFolderInfo> GetSubCategories(string root)
        {
            List<DirectoryFolderInfo> result = new List<DirectoryFolderInfo>();
            try
            {
                string[] subFolders = GetSubFolders(root);
                foreach (string item in subFolders)
                {
                    DirectoryFolderInfo fi = new DirectoryFolderInfo();
                    fi.Path = item;
                    fi.Name = item.Substring(item.LastIndexOf('\\') + 1);
                    result.Add(fi);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("HATA ! : " + e.Message);
                return result;
            }
            
        }
        public static List<DirectoryFileInfo> GetSubDatasets(List<DirectoryFolderInfo> subFolders)
        {
            List<DirectoryFileInfo> result = new List<DirectoryFileInfo>();
            var zemberek = new Zemberek(new TurkiyeTurkcesi());
            try
            {
                foreach (var subFolder in subFolders)
                {
                    string path = @"" + subFolder.Path;
                    string[] subFilesInCategory = GetSubFiles(path);
                    foreach (string item in subFilesInCategory)
                    {
                        DirectoryFileInfo fi = new DirectoryFileInfo();
                        fi.Path = item;
                        fi.Name = item.Substring(item.LastIndexOf('\\') + 1);
                        fi.Category = subFolder.Name;
                        fi.Content = "";
                        string[] txtFile = StringHelper.GetOnlyLetterAndSpace(File.ReadAllText(@"" + item, Encoding.GetEncoding("iso-8859-9"))).Split(' ');
                        foreach (string word in txtFile)
                        {
                            if (word != "")
                            {
                                string strRoot = word;
                                if (zemberek.kelimeAyristir(word).Count > 0)
                                    strRoot = zemberek.kelimeAyristir(word)[0][0];
                                fi.Content += strRoot + " ";
                            }
                        }
                        result.Add(fi);
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
        public static List<DirectoryFileInfo> GetSubDatasets(DirectoryFolderInfo subFolder)
        {
            List<DirectoryFileInfo> result = new List<DirectoryFileInfo>();
            var zemberek = new Zemberek(new TurkiyeTurkcesi());
            try
            {
                string path = @"" + subFolder.Path;
                string[] subFilesInCategory = GetSubFiles(path);
                foreach (string item in subFilesInCategory)
                {
                    DirectoryFileInfo fi = new DirectoryFileInfo();
                    fi.Path = item;
                    fi.Name = item.Substring(item.LastIndexOf('\\') + 1);
                    if (fi.Name.Contains("Kopya"))  fi.Name = fi.Name.Replace("\u008d", "");
                    fi.Category = subFolder.Name;
                    fi.Content = "";
                    string[] txtFile = StringHelper.GetOnlyLetterAndSpace(File.ReadAllText(@"" + item, Encoding.GetEncoding("iso-8859-9")).ToLower()).Split(' ');
                    foreach (string word in txtFile)
                    {
                        if (word != "")
                        {
                            string strRoot = word;
                            if (zemberek.kelimeAyristir(word).Count > 0)
                                strRoot = zemberek.kelimeAyristir(word)[0][0];
                            fi.Content += strRoot + " ";
                        }
                    }
                    result.Add(fi);
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
