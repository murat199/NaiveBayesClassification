using NaiveBayesClassiffication.Helper;
using NaiveBayesClassiffication.Model;
using net.zemberek.erisim;
using net.zemberek.tr.yapi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaiveBayesClassiffication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formula formula;
        List<Formula> formulas;
        List<string> categories;
        List<Gram> gramsDataAll;
        List<Gram> gramsDataLearn;
        List<Gram> gramsDataPrediction;
        List<DirectoryFileInfo> dataLearn;
        List<DirectoryFileInfo> dataPrediction;
        List<DirectoryFileInfo> directoryFilesInfo;
        List<DirectoryFolderInfo> directoryFoldersInfo;

        List<DirectoryFileInfo> directoryFilesInfoEkonomi;
        List<DirectoryFileInfo> directoryFilesInfoSaglik;
        List<DirectoryFileInfo> directoryFilesInfoMagazin;
        List<DirectoryFileInfo> directoryFilesInfoSpor;
        List<DirectoryFileInfo> directoryFilesInfoSiyasi;
        bool hasPermissionDirectory = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            directoryFoldersInfo = new List<DirectoryFolderInfo>();
            directoryFilesInfo = new List<DirectoryFileInfo>();

            formula = new Formula();
            formulas = new List<Formula>();

            gramsDataAll = new List<Gram>();
            gramsDataLearn = new List<Gram>();
            gramsDataPrediction = new List<Gram>();

            dataLearn = new List<DirectoryFileInfo>();
            dataPrediction = new List<DirectoryFileInfo>();

            directoryFilesInfoEkonomi = new List<DirectoryFileInfo>();
            directoryFilesInfoSaglik = new List<DirectoryFileInfo>();
            directoryFilesInfoMagazin = new List<DirectoryFileInfo>();
            directoryFilesInfoSpor = new List<DirectoryFileInfo>();
            directoryFilesInfoSiyasi = new List<DirectoryFileInfo>();
            hasPermissionDirectory = true;

            categories = new List<string>();
            categories.Add("siyasi");
            categories.Add("ekonomi");
            categories.Add("saglik");
            categories.Add("spor");
            categories.Add("magazin");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            directoryFoldersInfo = new List<DirectoryFolderInfo>();
            directoryFilesInfo = new List<DirectoryFileInfo>();
            Thread tRead = new Thread(new ThreadStart(ReadDirectoryFolders));
            tRead.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var cat in categories)
            {
                Mixer mixer = MixerHelper.GetMixerData();
                List<DirectoryFileInfo> files = directoryFilesInfo.Where(x => x.Category == cat).ToList();
                foreach (int i in mixer.Data75)
                {
                    dataLearn.Add(files[i]);
                }
                foreach (int i in mixer.Data25)
                {
                    dataPrediction.Add(files[i]);
                }
            }
            foreach (var cat in categories)
            {
                Thread tTwoGramRead = new Thread(() => ReadDirectoryTwoGrams(cat));
                tTwoGramRead.Start();
                Thread tThreeGramRead = new Thread(() => ReadDirectoryThreeGrams(cat));
                tThreeGramRead.Start();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*foreach (var cat in categories)
            {
                Thread tRead = new Thread(() => ReadNaiveBayes(cat));
                tRead.Start();
            }*/
        }
        private void button4_Click(object sender, EventArgs e)
        {
            /*Thread tRead = new Thread(new ThreadStart(ReadFormula));
            tRead.Start();*/
        }

        private void ReadDirectoryFolders()
        {
            DateTime dateStart = DateTime.Now;
            directoryFoldersInfo = DirectoryHelper.GetSubCategories(@"D:\Univercity\3.sinif\Donem2\dersler\yazlab2\proje3\1150haber\raw_texts");
            foreach(var folder in directoryFoldersInfo)
            {
                listBoxFolders.Invoke((MethodInvoker)(() => listBoxFolders.Items.Insert(0, folder.Name)));
                progressBarFolders.Invoke((MethodInvoker)(() => progressBarFolders.Value += 20));
                Thread tFileRead = new Thread(() => ReadDirectoryFiles(folder));
                tFileRead.Start();
                //ReadDirectoryFiles(folder);
            }
            lblCountFolders.Invoke((MethodInvoker)(() => lblCountFolders.Text = "Toplam : " + listBoxFolders.Items.Count));
            DateTime dateEnd = DateTime.Now;
            Console.WriteLine("Folder Süre :" + (dateEnd - dateStart).ToString());
        }
        private void ReadDirectoryFiles(DirectoryFolderInfo folder)
        {
            DateTime dateStart = DateTime.Now;
            foreach(var item in DirectoryHelper.GetSubDatasets(folder))
            {
                listBoxFiles.Invoke((MethodInvoker)(() => listBoxFiles.Items.Insert(0, item.Name + " - " + item.Category)));
                progressBarFiles.Invoke((MethodInvoker)(() => progressBarFiles.Value += 1));
                if (folder.Name == "ekonomi") directoryFilesInfoEkonomi.Add(item);
                if (folder.Name == "saglik") directoryFilesInfoSaglik.Add(item);
                if (folder.Name == "magazin") directoryFilesInfoMagazin.Add(item);
                if (folder.Name == "spor") directoryFilesInfoSpor.Add(item);
                if (folder.Name == "siyasi") directoryFilesInfoSiyasi.Add(item);
            }
            if(directoryFilesInfoEkonomi.Count == 230 &&
                directoryFilesInfoSaglik.Count == 230 &&
                directoryFilesInfoMagazin.Count == 230 &&
                directoryFilesInfoSpor.Count == 230 &&
                directoryFilesInfoSiyasi.Count == 230 &&
                hasPermissionDirectory)
            {
                foreach (var item in directoryFilesInfoEkonomi) directoryFilesInfo.Add(item);
                foreach (var item in directoryFilesInfoSaglik) directoryFilesInfo.Add(item);
                foreach (var item in directoryFilesInfoMagazin) directoryFilesInfo.Add(item);
                foreach (var item in directoryFilesInfoSpor) directoryFilesInfo.Add(item);
                foreach (var item in directoryFilesInfoSiyasi) directoryFilesInfo.Add(item);
                hasPermissionDirectory = false;
            }
            lblCountFiles.Invoke((MethodInvoker)(() => lblCountFiles.Text = "Toplam : " + directoryFilesInfo.Count));
            DateTime dateEnd = DateTime.Now;
            Console.WriteLine("File Süre :" + folder.Name + " :" + (dateEnd - dateStart).ToString());
        }
        private void ReadDirectoryTwoGrams(string category)
        {
            DateTime dateStart = DateTime.Now;
            GramHelper gHelper = new GramHelper();
            List<Gram> resultGramsLearn = gHelper.GetTwoGrams(dataLearn.Where(x => x.Category == category).ToList(), directoryFoldersInfo, category, false);
            List<Gram> resultGramsPrediction = gHelper.GetTwoGrams(dataPrediction.Where(x => x.Category == category).ToList(), directoryFoldersInfo, category, true);
            foreach (var gram in resultGramsLearn)
            {
                listBoxLearnGram2.Invoke((MethodInvoker)(() => listBoxLearnGram2.Items.Insert(0, gram.Content)));
                gramsDataLearn.Add(gram);
                gramsDataAll.Add(gram);
            }
            foreach (var gram in resultGramsPrediction)
            {
                listBoxPredictionGram2.Invoke((MethodInvoker)(() => listBoxPredictionGram2.Items.Insert(0, gram.Content)));
                gramsDataPrediction.Add(gram);
                gramsDataAll.Add(gram);
            }
            lblStepLearnGram2.Invoke((MethodInvoker)(() => lblStepLearnGram2.Text += "+ "));
            lblStepPredictionGram2.Invoke((MethodInvoker)(() => lblStepPredictionGram2.Text += "+ "));
            DateTime dateEnd = DateTime.Now;
        }
        private void ReadDirectoryThreeGrams(string category)
        {
            DateTime dateStart = DateTime.Now;
            GramHelper gHelper = new GramHelper();
            List<Gram> resultGramsLearn = gHelper.GetTwoThreeGrams(dataLearn.Where(x => x.Category == category).ToList(), directoryFoldersInfo, category, false);
            List<Gram> resultGramsPrediction = gHelper.GetTwoThreeGrams(dataPrediction.Where(x => x.Category == category).ToList(), directoryFoldersInfo, category, true);
            foreach (var gram in resultGramsLearn)
            {
                listBoxLearnGram3.Invoke((MethodInvoker)(() => listBoxLearnGram3.Items.Insert(0, gram.Content)));
                gramsDataLearn.Add(gram);
                gramsDataAll.Add(gram);
            }
            foreach (var gram in resultGramsPrediction)
            {
                listBoxPredictionGram3.Invoke((MethodInvoker)(() => listBoxPredictionGram3.Items.Insert(0, gram.Content)));
                gramsDataPrediction.Add(gram);
                gramsDataAll.Add(gram);
            }
            lblStepLearnGram3.Invoke((MethodInvoker)(() => lblStepLearnGram3.Text += "+ "));
            lblStepPredictionGram3.Invoke((MethodInvoker)(() => lblStepPredictionGram3.Text += "+ "));
            DateTime dateEnd = DateTime.Now;
        }
        private void ReadNaiveBayes(string category, Label lblCountCategory, ListBox listBoxCategory)
        {
            int resultCount = 0;
            var dataPR = dataPrediction.Where(x => x.Category == category).ToList();
            for (int i = 0; i < dataPR.Count; i++)
            {
                string resultCategory = NaiveBayesHelper.GetCategory(dataPR[i], gramsDataAll, gramsDataLearn, gramsDataPrediction, categories);
                dataPrediction.Remove(dataPR[i]);
                dataPR[i].GuessCategory = resultCategory;
                dataPrediction.Add(dataPR[i]);
                if (dataPR[i].Category == resultCategory) resultCount++;
                listBoxCategory.Invoke((MethodInvoker)(() => listBoxCategory.Items.Insert(0, String.Format("{0}/{1} - {2} - {3}", (i + 1).ToString(), resultCount.ToString(), dataPR[i].Category, resultCategory))));
            }
            lblCountCategory.Invoke((MethodInvoker)(() => lblCountCategory.Text = "Toplam : 58 / " + resultCount.ToString()));
            Console.WriteLine(String.Format("{0} kategorisi : {1}/{2}", category, dataPR.Count, resultCount));
        }
        private void ReadFormula(string category, Label lblPrecision, Label lblRecall, Label lblFeMeasure)
        {
            formula = formula.GetCalculate(dataPrediction, category);
            formulas.Add(formula);
            lblPrecision.Invoke((MethodInvoker)(() => lblPrecision.Text = "Precision : " + formula.Precision.ToString() + " - %" + formula.Precision.ToString().Substring(formula.Precision.ToString().IndexOf(".") + 1,2)));
            lblRecall.Invoke((MethodInvoker)(() => lblRecall.Text = "Re-call : " + formula.ReCall.ToString() + " - %" + formula.ReCall.ToString().Substring(formula.ReCall.ToString().IndexOf(".") + 1, 2)));
            lblFeMeasure.Invoke((MethodInvoker)(() => lblFeMeasure.Text = "Fe-measure : " + formula.FeMeasure.ToString() + " - %" + formula.FeMeasure.ToString().Substring(formula.FeMeasure.ToString().IndexOf(".") + 1, 2)));
        }
        private void CleanDirectory()
        {
            directoryFoldersInfo = new List<DirectoryFolderInfo>();
            directoryFilesInfo = new List<DirectoryFileInfo>();
            directoryFilesInfoEkonomi = new List<DirectoryFileInfo>();
            directoryFilesInfoSaglik = new List<DirectoryFileInfo>();
            directoryFilesInfoSiyasi = new List<DirectoryFileInfo>();
            directoryFilesInfoMagazin= new List<DirectoryFileInfo>();
            directoryFilesInfoSpor = new List<DirectoryFileInfo>();
            hasPermissionDirectory = true;

            progressBarFiles.Value = 0;
            progressBarFolders.Value = 0;
            if (listBoxFolders.Items.Count > 0) listBoxFolders.Items.Clear();
            if(listBoxFiles.Items.Count > 0) listBoxFiles.Items.Clear();
        }
        private void CleanNaiveBayes()
        {
            if (listBoxCatEkonomi.Items.Count > 0) listBoxCatEkonomi.Items.Clear();
            if (listBoxCatMagazin.Items.Count > 0) listBoxCatMagazin.Items.Clear();
            if (listboxCatSaglik.Items.Count > 0) listboxCatSaglik.Items.Clear();
            if (listBoxCatSiyasi.Items.Count > 0) listBoxCatSiyasi.Items.Clear();
            if (listBoxCatSpor.Items.Count > 0) listBoxCatSpor.Items.Clear();
            lblCountCatEkonomi.Text = "Toplam : 58 / 0";
            lblCountCatMagazin.Text = "Toplam : 58 / 0";
            lblCountCatSaglik.Text = "Toplam : 58 / 0";
            lblCountCatSiyasi.Text = "Toplam : 58 / 0";
            lblCountCatSpor.Text = "Toplam : 58 / 0";
        }
        private void CleanGrams()
        {
            gramsDataAll = new List<Gram>();
            gramsDataLearn = new List<Gram>();
            gramsDataPrediction = new List<Gram>();
            dataLearn = new List<DirectoryFileInfo>();
            dataPrediction = new List<DirectoryFileInfo>();

            if (listBoxLearn.Items.Count > 0) listBoxLearn.Items.Clear();
            if (listBoxPrediction.Items.Count > 0) listBoxPrediction.Items.Clear();
            if (listBoxLearnGram2.Items.Count > 0) listBoxLearnGram2.Items.Clear();
            if (listBoxLearnGram3.Items.Count > 0) listBoxLearnGram3.Items.Clear();
            if (listBoxPredictionGram2.Items.Count > 0) listBoxPredictionGram2.Items.Clear();
            if (listBoxPredictionGram3.Items.Count > 0) listBoxPredictionGram3.Items.Clear();

            lblStepLearnGram2.Text = "";
            lblStepLearnGram3.Text = "";
            lblStepPredictionGram2.Text = "";
            lblStepPredictionGram3.Text = "";

            progressBarLearn.Value = 0;
            progressBarPrediction.Value = 0;
        }


        private void btnZemberek_Click(object sender, EventArgs e)
        {
            CleanDirectory();
            //Thread tRead = new Thread(new ThreadStart(ReadDirectoryFolders));
            //tRead.Start();
            ReadDirectoryFolders();
        }

        private void tabMain_Click(object sender, EventArgs e)
        {
            /*int selectedIndex = tabMain.SelectedIndex;
            MessageBox.Show("Tıklanan : " + selectedIndex.ToString());*/
        }

        private void btnGram_Click(object sender, EventArgs e)
        {
            CleanGrams();
            foreach (var cat in categories)
            {
                Mixer mixer = MixerHelper.GetMixerData();
                List<DirectoryFileInfo> files = directoryFilesInfo.Where(x => x.Category == cat).ToList();
                foreach (int i in mixer.Data75)
                {
                    listBoxLearn.Items.Insert(0, files[i].Name + " - " + files[i].Category);
                    progressBarLearn.Value += 1;
                    dataLearn.Add(files[i]);
                }
                foreach (int i in mixer.Data25)
                {
                    listBoxPrediction.Items.Insert(0, files[i].Name + " - " + files[i].Category);
                    progressBarPrediction.Value += 1;
                    dataPrediction.Add(files[i]);
                }
            }
            foreach (var cat in categories)
            {
                Thread tTwoGramRead = new Thread(() => ReadDirectoryTwoGrams(cat));
                tTwoGramRead.Start();
                Thread tThreeGramRead = new Thread(() => ReadDirectoryThreeGrams(cat));
                tThreeGramRead.Start();
            }
        }
        private void btnNaiveBayes_Click(object sender, EventArgs e)
        {
            CleanNaiveBayes();
            foreach (var cat in categories)
            {
                Label lblCountCategory = new Label();
                ListBox listboxCategory = new ListBox();
                if (cat == "ekonomi")
                {
                    lblCountCategory = lblCountCatEkonomi;
                    listboxCategory = listBoxCatEkonomi;
                }
                if (cat == "spor")
                {
                    lblCountCategory = lblCountCatSpor;
                    listboxCategory = listBoxCatSpor;
                }
                if (cat == "magazin")
                {
                    lblCountCategory = lblCountCatMagazin;
                    listboxCategory = listBoxCatMagazin;
                }
                if (cat == "siyasi")
                {
                    lblCountCategory = lblCountCatSiyasi;
                    listboxCategory = listBoxCatSiyasi;
                }
                if (cat == "saglik")
                {
                    lblCountCategory = lblCountCatSaglik;
                    listboxCategory = listboxCatSaglik;
                }
                //ReadNaiveBayes(cat, lblCountCategory, listboxCategory);
                Thread tRead = new Thread(() => ReadNaiveBayes(cat, lblCountCategory, listboxCategory));
                tRead.Start();
            }
        }

        private void btnFormula_Click(object sender, EventArgs e)
        {
            foreach(var category in categories)
            {
                Label lblPrecision = new Label();
                Label lblRecall = new Label();
                Label lblFeMeasure = new Label();
                if (category == "ekonomi")
                {
                    lblPrecision = lblFormulaPrecisionEkonomi;
                    lblRecall = lblFormulaRecallEkonomi;
                    lblFeMeasure = lblFormulaFemeasureEkonomi;
                }
                if (category == "spor")
                {
                    lblPrecision = lblFormulaPrecisionSpor;
                    lblRecall = lblFormulaRecallSpor;
                    lblFeMeasure = lblFormulaFemeasureSpor;
                }
                if (category == "magazin")
                {
                    lblPrecision = lblFormulaPrecisionMagazin;
                    lblRecall = lblFormulaRecallMagazin;
                    lblFeMeasure = lblFormulaFemeasureMagazin;
                }
                if (category == "siyasi")
                {
                    lblPrecision = lblFormulaPrecisionSiyasi;
                    lblRecall = lblFormulaRecallSiyasi;
                    lblFeMeasure = lblFormulaFemeasureSiyasi;
                }
                if (category == "saglik")
                {
                    lblPrecision = lblFormulaPrecisionSaglik;
                    lblRecall = lblFormulaRecallSaglik;
                    lblFeMeasure = lblFormulaFemeasureSaglik;
                }
                ReadFormula(category, lblPrecision, lblRecall, lblFeMeasure);
                //Thread tRead = new Thread(() => ReadFormula(category, lblPrecision, lblRecall, lblFeMeasure));
                //tRead.Start();
            }
        }
    }
}