namespace NaiveBayesClassiffication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblHeadFiles = new System.Windows.Forms.Label();
            this.lblHeadFolders = new System.Windows.Forms.Label();
            this.lblCountFiles = new System.Windows.Forms.Label();
            this.lblCountFolders = new System.Windows.Forms.Label();
            this.progressBarFiles = new System.Windows.Forms.ProgressBar();
            this.progressBarFolders = new System.Windows.Forms.ProgressBar();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.btnZemberek = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxPrediction = new System.Windows.Forms.GroupBox();
            this.lblStepPredictionGram3 = new System.Windows.Forms.Label();
            this.lblStepPredictionGram2 = new System.Windows.Forms.Label();
            this.lblHeadPredictionGram2 = new System.Windows.Forms.Label();
            this.listBoxPredictionGram3 = new System.Windows.Forms.ListBox();
            this.lblHeadPredictionGram3 = new System.Windows.Forms.Label();
            this.listBoxPredictionGram2 = new System.Windows.Forms.ListBox();
            this.groupBoxLearn = new System.Windows.Forms.GroupBox();
            this.lblStepLearnGram3 = new System.Windows.Forms.Label();
            this.lblStepLearnGram2 = new System.Windows.Forms.Label();
            this.lblHeadLearnGram2 = new System.Windows.Forms.Label();
            this.listBoxLearnGram3 = new System.Windows.Forms.ListBox();
            this.lblHeadLearnGram3 = new System.Windows.Forms.Label();
            this.listBoxLearnGram2 = new System.Windows.Forms.ListBox();
            this.progressBarPrediction = new System.Windows.Forms.ProgressBar();
            this.progressBarLearn = new System.Windows.Forms.ProgressBar();
            this.btnGram = new System.Windows.Forms.Button();
            this.lblHeadPrediction = new System.Windows.Forms.Label();
            this.lblHeadLearn = new System.Windows.Forms.Label();
            this.listBoxPrediction = new System.Windows.Forms.ListBox();
            this.listBoxLearn = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblCountCatSpor = new System.Windows.Forms.Label();
            this.lblCountCatMagazin = new System.Windows.Forms.Label();
            this.lblCountCatSiyasi = new System.Windows.Forms.Label();
            this.lblCountCatSaglik = new System.Windows.Forms.Label();
            this.lblCountCatEkonomi = new System.Windows.Forms.Label();
            this.lblHeadCatSaglik = new System.Windows.Forms.Label();
            this.lblHeadCarSiyasi = new System.Windows.Forms.Label();
            this.lblHeadCatMagazin = new System.Windows.Forms.Label();
            this.lblHeadCatSpor = new System.Windows.Forms.Label();
            this.lblHeadCatEkonomi = new System.Windows.Forms.Label();
            this.listBoxCatSpor = new System.Windows.Forms.ListBox();
            this.listBoxCatMagazin = new System.Windows.Forms.ListBox();
            this.listBoxCatSiyasi = new System.Windows.Forms.ListBox();
            this.listboxCatSaglik = new System.Windows.Forms.ListBox();
            this.listBoxCatEkonomi = new System.Windows.Forms.ListBox();
            this.btnNaiveBayes = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnFormula = new System.Windows.Forms.Button();
            this.groupBoxFormulaSaglik = new System.Windows.Forms.GroupBox();
            this.lblFormulaFemeasureSaglik = new System.Windows.Forms.Label();
            this.lblFormulaRecallSaglik = new System.Windows.Forms.Label();
            this.lblFormulaPrecisionSaglik = new System.Windows.Forms.Label();
            this.groupBoxFormulaMagazin = new System.Windows.Forms.GroupBox();
            this.lblFormulaFemeasureMagazin = new System.Windows.Forms.Label();
            this.lblFormulaRecallMagazin = new System.Windows.Forms.Label();
            this.lblFormulaPrecisionMagazin = new System.Windows.Forms.Label();
            this.groupBoxFormulaSpor = new System.Windows.Forms.GroupBox();
            this.lblFormulaFemeasureSpor = new System.Windows.Forms.Label();
            this.lblFormulaRecallSpor = new System.Windows.Forms.Label();
            this.lblFormulaPrecisionSpor = new System.Windows.Forms.Label();
            this.groupBoxFormulaSiyasi = new System.Windows.Forms.GroupBox();
            this.lblFormulaFemeasureSiyasi = new System.Windows.Forms.Label();
            this.lblFormulaRecallSiyasi = new System.Windows.Forms.Label();
            this.lblFormulaPrecisionSiyasi = new System.Windows.Forms.Label();
            this.groupBoxFormulaEkonomi = new System.Windows.Forms.GroupBox();
            this.lblFormulaFemeasureEkonomi = new System.Windows.Forms.Label();
            this.lblFormulaRecallEkonomi = new System.Windows.Forms.Label();
            this.lblFormulaPrecisionEkonomi = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxPrediction.SuspendLayout();
            this.groupBoxLearn.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBoxFormulaSaglik.SuspendLayout();
            this.groupBoxFormulaMagazin.SuspendLayout();
            this.groupBoxFormulaSpor.SuspendLayout();
            this.groupBoxFormulaSiyasi.SuspendLayout();
            this.groupBoxFormulaEkonomi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1004, 656);
            this.tabMain.TabIndex = 8;
            this.tabMain.Click += new System.EventHandler(this.tabMain_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblHeadFiles);
            this.tabPage1.Controls.Add(this.lblHeadFolders);
            this.tabPage1.Controls.Add(this.lblCountFiles);
            this.tabPage1.Controls.Add(this.lblCountFolders);
            this.tabPage1.Controls.Add(this.progressBarFiles);
            this.tabPage1.Controls.Add(this.progressBarFolders);
            this.tabPage1.Controls.Add(this.listBoxFiles);
            this.tabPage1.Controls.Add(this.listBoxFolders);
            this.tabPage1.Controls.Add(this.btnZemberek);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1 - Zemberek";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblHeadFiles
            // 
            this.lblHeadFiles.AutoSize = true;
            this.lblHeadFiles.Location = new System.Drawing.Point(523, 18);
            this.lblHeadFiles.Name = "lblHeadFiles";
            this.lblHeadFiles.Size = new System.Drawing.Size(64, 17);
            this.lblHeadFiles.TabIndex = 9;
            this.lblHeadFiles.Text = "Dosyalar";
            // 
            // lblHeadFolders
            // 
            this.lblHeadFolders.AutoSize = true;
            this.lblHeadFolders.Location = new System.Drawing.Point(22, 18);
            this.lblHeadFolders.Name = "lblHeadFolders";
            this.lblHeadFolders.Size = new System.Drawing.Size(77, 17);
            this.lblHeadFolders.TabIndex = 8;
            this.lblHeadFolders.Text = "Kategoriler";
            // 
            // lblCountFiles
            // 
            this.lblCountFiles.AutoSize = true;
            this.lblCountFiles.Location = new System.Drawing.Point(523, 528);
            this.lblCountFiles.Name = "lblCountFiles";
            this.lblCountFiles.Size = new System.Drawing.Size(75, 17);
            this.lblCountFiles.TabIndex = 7;
            this.lblCountFiles.Text = "Toplam : 0";
            // 
            // lblCountFolders
            // 
            this.lblCountFolders.AutoSize = true;
            this.lblCountFolders.Location = new System.Drawing.Point(24, 528);
            this.lblCountFolders.Name = "lblCountFolders";
            this.lblCountFolders.Size = new System.Drawing.Size(75, 17);
            this.lblCountFolders.TabIndex = 6;
            this.lblCountFolders.Text = "Toplam : 0";
            // 
            // progressBarFiles
            // 
            this.progressBarFiles.Location = new System.Drawing.Point(526, 490);
            this.progressBarFiles.Maximum = 1150;
            this.progressBarFiles.Name = "progressBarFiles";
            this.progressBarFiles.Size = new System.Drawing.Size(432, 35);
            this.progressBarFiles.TabIndex = 5;
            // 
            // progressBarFolders
            // 
            this.progressBarFolders.Location = new System.Drawing.Point(25, 490);
            this.progressBarFolders.Name = "progressBarFolders";
            this.progressBarFolders.Size = new System.Drawing.Size(459, 35);
            this.progressBarFolders.TabIndex = 4;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(526, 45);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(432, 436);
            this.listBoxFiles.TabIndex = 3;
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.ItemHeight = 16;
            this.listBoxFolders.Location = new System.Drawing.Point(25, 45);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(459, 436);
            this.listBoxFolders.TabIndex = 2;
            // 
            // btnZemberek
            // 
            this.btnZemberek.Location = new System.Drawing.Point(25, 564);
            this.btnZemberek.Name = "btnZemberek";
            this.btnZemberek.Size = new System.Drawing.Size(944, 43);
            this.btnZemberek.TabIndex = 1;
            this.btnZemberek.Text = "ZEMBEREK";
            this.btnZemberek.UseVisualStyleBackColor = true;
            this.btnZemberek.Click += new System.EventHandler(this.btnZemberek_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxPrediction);
            this.tabPage2.Controls.Add(this.groupBoxLearn);
            this.tabPage2.Controls.Add(this.progressBarPrediction);
            this.tabPage2.Controls.Add(this.progressBarLearn);
            this.tabPage2.Controls.Add(this.btnGram);
            this.tabPage2.Controls.Add(this.lblHeadPrediction);
            this.tabPage2.Controls.Add(this.lblHeadLearn);
            this.tabPage2.Controls.Add(this.listBoxPrediction);
            this.tabPage2.Controls.Add(this.listBoxLearn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2 - Gram Böl";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrediction
            // 
            this.groupBoxPrediction.Controls.Add(this.lblStepPredictionGram3);
            this.groupBoxPrediction.Controls.Add(this.lblStepPredictionGram2);
            this.groupBoxPrediction.Controls.Add(this.lblHeadPredictionGram2);
            this.groupBoxPrediction.Controls.Add(this.listBoxPredictionGram3);
            this.groupBoxPrediction.Controls.Add(this.lblHeadPredictionGram3);
            this.groupBoxPrediction.Controls.Add(this.listBoxPredictionGram2);
            this.groupBoxPrediction.Location = new System.Drawing.Point(711, 51);
            this.groupBoxPrediction.Name = "groupBoxPrediction";
            this.groupBoxPrediction.Size = new System.Drawing.Size(255, 504);
            this.groupBoxPrediction.TabIndex = 19;
            this.groupBoxPrediction.TabStop = false;
            this.groupBoxPrediction.Text = "Test Veriseti";
            // 
            // lblStepPredictionGram3
            // 
            this.lblStepPredictionGram3.AutoSize = true;
            this.lblStepPredictionGram3.Location = new System.Drawing.Point(122, 457);
            this.lblStepPredictionGram3.Name = "lblStepPredictionGram3";
            this.lblStepPredictionGram3.Size = new System.Drawing.Size(0, 17);
            this.lblStepPredictionGram3.TabIndex = 24;
            // 
            // lblStepPredictionGram2
            // 
            this.lblStepPredictionGram2.AutoSize = true;
            this.lblStepPredictionGram2.Location = new System.Drawing.Point(18, 457);
            this.lblStepPredictionGram2.Name = "lblStepPredictionGram2";
            this.lblStepPredictionGram2.Size = new System.Drawing.Size(0, 17);
            this.lblStepPredictionGram2.TabIndex = 20;
            // 
            // lblHeadPredictionGram2
            // 
            this.lblHeadPredictionGram2.AutoSize = true;
            this.lblHeadPredictionGram2.Location = new System.Drawing.Point(18, 30);
            this.lblHeadPredictionGram2.Name = "lblHeadPredictionGram2";
            this.lblHeadPredictionGram2.Size = new System.Drawing.Size(80, 17);
            this.lblHeadPredictionGram2.TabIndex = 18;
            this.lblHeadPredictionGram2.Text = "2 - Gramlar";
            // 
            // listBoxPredictionGram3
            // 
            this.listBoxPredictionGram3.FormattingEnabled = true;
            this.listBoxPredictionGram3.ItemHeight = 16;
            this.listBoxPredictionGram3.Location = new System.Drawing.Point(125, 61);
            this.listBoxPredictionGram3.Name = "listBoxPredictionGram3";
            this.listBoxPredictionGram3.Size = new System.Drawing.Size(114, 372);
            this.listBoxPredictionGram3.TabIndex = 23;
            // 
            // lblHeadPredictionGram3
            // 
            this.lblHeadPredictionGram3.AutoSize = true;
            this.lblHeadPredictionGram3.Location = new System.Drawing.Point(122, 30);
            this.lblHeadPredictionGram3.Name = "lblHeadPredictionGram3";
            this.lblHeadPredictionGram3.Size = new System.Drawing.Size(80, 17);
            this.lblHeadPredictionGram3.TabIndex = 19;
            this.lblHeadPredictionGram3.Text = "3 - Gramlar";
            // 
            // listBoxPredictionGram2
            // 
            this.listBoxPredictionGram2.FormattingEnabled = true;
            this.listBoxPredictionGram2.ItemHeight = 16;
            this.listBoxPredictionGram2.Location = new System.Drawing.Point(21, 61);
            this.listBoxPredictionGram2.Name = "listBoxPredictionGram2";
            this.listBoxPredictionGram2.Size = new System.Drawing.Size(98, 372);
            this.listBoxPredictionGram2.TabIndex = 22;
            // 
            // groupBoxLearn
            // 
            this.groupBoxLearn.Controls.Add(this.lblStepLearnGram3);
            this.groupBoxLearn.Controls.Add(this.lblStepLearnGram2);
            this.groupBoxLearn.Controls.Add(this.lblHeadLearnGram2);
            this.groupBoxLearn.Controls.Add(this.listBoxLearnGram3);
            this.groupBoxLearn.Controls.Add(this.lblHeadLearnGram3);
            this.groupBoxLearn.Controls.Add(this.listBoxLearnGram2);
            this.groupBoxLearn.Location = new System.Drawing.Point(462, 51);
            this.groupBoxLearn.Name = "groupBoxLearn";
            this.groupBoxLearn.Size = new System.Drawing.Size(243, 504);
            this.groupBoxLearn.TabIndex = 18;
            this.groupBoxLearn.TabStop = false;
            this.groupBoxLearn.Text = "Öğrenme Veriseti";
            // 
            // lblStepLearnGram3
            // 
            this.lblStepLearnGram3.AutoSize = true;
            this.lblStepLearnGram3.Location = new System.Drawing.Point(125, 457);
            this.lblStepLearnGram3.Name = "lblStepLearnGram3";
            this.lblStepLearnGram3.Size = new System.Drawing.Size(0, 17);
            this.lblStepLearnGram3.TabIndex = 19;
            // 
            // lblStepLearnGram2
            // 
            this.lblStepLearnGram2.AutoSize = true;
            this.lblStepLearnGram2.Location = new System.Drawing.Point(24, 457);
            this.lblStepLearnGram2.Name = "lblStepLearnGram2";
            this.lblStepLearnGram2.Size = new System.Drawing.Size(0, 17);
            this.lblStepLearnGram2.TabIndex = 18;
            // 
            // lblHeadLearnGram2
            // 
            this.lblHeadLearnGram2.AutoSize = true;
            this.lblHeadLearnGram2.Location = new System.Drawing.Point(21, 30);
            this.lblHeadLearnGram2.Name = "lblHeadLearnGram2";
            this.lblHeadLearnGram2.Size = new System.Drawing.Size(80, 17);
            this.lblHeadLearnGram2.TabIndex = 11;
            this.lblHeadLearnGram2.Text = "2 - Gramlar";
            // 
            // listBoxLearnGram3
            // 
            this.listBoxLearnGram3.FormattingEnabled = true;
            this.listBoxLearnGram3.ItemHeight = 16;
            this.listBoxLearnGram3.Location = new System.Drawing.Point(128, 61);
            this.listBoxLearnGram3.Name = "listBoxLearnGram3";
            this.listBoxLearnGram3.Size = new System.Drawing.Size(109, 372);
            this.listBoxLearnGram3.TabIndex = 17;
            // 
            // lblHeadLearnGram3
            // 
            this.lblHeadLearnGram3.AutoSize = true;
            this.lblHeadLearnGram3.Location = new System.Drawing.Point(125, 30);
            this.lblHeadLearnGram3.Name = "lblHeadLearnGram3";
            this.lblHeadLearnGram3.Size = new System.Drawing.Size(80, 17);
            this.lblHeadLearnGram3.TabIndex = 12;
            this.lblHeadLearnGram3.Text = "3 - Gramlar";
            // 
            // listBoxLearnGram2
            // 
            this.listBoxLearnGram2.FormattingEnabled = true;
            this.listBoxLearnGram2.ItemHeight = 16;
            this.listBoxLearnGram2.Location = new System.Drawing.Point(24, 61);
            this.listBoxLearnGram2.Name = "listBoxLearnGram2";
            this.listBoxLearnGram2.Size = new System.Drawing.Size(98, 372);
            this.listBoxLearnGram2.TabIndex = 16;
            // 
            // progressBarPrediction
            // 
            this.progressBarPrediction.Location = new System.Drawing.Point(226, 487);
            this.progressBarPrediction.Maximum = 290;
            this.progressBarPrediction.Name = "progressBarPrediction";
            this.progressBarPrediction.Size = new System.Drawing.Size(181, 50);
            this.progressBarPrediction.TabIndex = 10;
            // 
            // progressBarLearn
            // 
            this.progressBarLearn.Location = new System.Drawing.Point(22, 487);
            this.progressBarLearn.Maximum = 860;
            this.progressBarLearn.Name = "progressBarLearn";
            this.progressBarLearn.Size = new System.Drawing.Size(181, 50);
            this.progressBarLearn.TabIndex = 9;
            // 
            // btnGram
            // 
            this.btnGram.Location = new System.Drawing.Point(22, 561);
            this.btnGram.Name = "btnGram";
            this.btnGram.Size = new System.Drawing.Size(944, 45);
            this.btnGram.TabIndex = 8;
            this.btnGram.Text = "Gramlara Ayır";
            this.btnGram.UseVisualStyleBackColor = true;
            this.btnGram.Click += new System.EventHandler(this.btnGram_Click);
            // 
            // lblHeadPrediction
            // 
            this.lblHeadPrediction.AutoSize = true;
            this.lblHeadPrediction.Location = new System.Drawing.Point(223, 20);
            this.lblHeadPrediction.Name = "lblHeadPrediction";
            this.lblHeadPrediction.Size = new System.Drawing.Size(87, 17);
            this.lblHeadPrediction.TabIndex = 5;
            this.lblHeadPrediction.Text = "Test Verisati";
            // 
            // lblHeadLearn
            // 
            this.lblHeadLearn.AutoSize = true;
            this.lblHeadLearn.Location = new System.Drawing.Point(19, 20);
            this.lblHeadLearn.Name = "lblHeadLearn";
            this.lblHeadLearn.Size = new System.Drawing.Size(118, 17);
            this.lblHeadLearn.TabIndex = 4;
            this.lblHeadLearn.Text = "Öğrenme Veriseti";
            // 
            // listBoxPrediction
            // 
            this.listBoxPrediction.FormattingEnabled = true;
            this.listBoxPrediction.ItemHeight = 16;
            this.listBoxPrediction.Location = new System.Drawing.Point(226, 51);
            this.listBoxPrediction.Name = "listBoxPrediction";
            this.listBoxPrediction.Size = new System.Drawing.Size(181, 420);
            this.listBoxPrediction.TabIndex = 3;
            // 
            // listBoxLearn
            // 
            this.listBoxLearn.FormattingEnabled = true;
            this.listBoxLearn.ItemHeight = 16;
            this.listBoxLearn.Location = new System.Drawing.Point(22, 51);
            this.listBoxLearn.Name = "listBoxLearn";
            this.listBoxLearn.Size = new System.Drawing.Size(181, 420);
            this.listBoxLearn.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblCountCatSpor);
            this.tabPage3.Controls.Add(this.lblCountCatMagazin);
            this.tabPage3.Controls.Add(this.lblCountCatSiyasi);
            this.tabPage3.Controls.Add(this.lblCountCatSaglik);
            this.tabPage3.Controls.Add(this.lblCountCatEkonomi);
            this.tabPage3.Controls.Add(this.lblHeadCatSaglik);
            this.tabPage3.Controls.Add(this.lblHeadCarSiyasi);
            this.tabPage3.Controls.Add(this.lblHeadCatMagazin);
            this.tabPage3.Controls.Add(this.lblHeadCatSpor);
            this.tabPage3.Controls.Add(this.lblHeadCatEkonomi);
            this.tabPage3.Controls.Add(this.listBoxCatSpor);
            this.tabPage3.Controls.Add(this.listBoxCatMagazin);
            this.tabPage3.Controls.Add(this.listBoxCatSiyasi);
            this.tabPage3.Controls.Add(this.listboxCatSaglik);
            this.tabPage3.Controls.Add(this.listBoxCatEkonomi);
            this.tabPage3.Controls.Add(this.btnNaiveBayes);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(996, 627);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3 - Naive Bayes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblCountCatSpor
            // 
            this.lblCountCatSpor.AutoSize = true;
            this.lblCountCatSpor.Location = new System.Drawing.Point(729, 472);
            this.lblCountCatSpor.Name = "lblCountCatSpor";
            this.lblCountCatSpor.Size = new System.Drawing.Size(103, 17);
            this.lblCountCatSpor.TabIndex = 18;
            this.lblCountCatSpor.Text = "Toplam : 58 / 0";
            // 
            // lblCountCatMagazin
            // 
            this.lblCountCatMagazin.AutoSize = true;
            this.lblCountCatMagazin.Location = new System.Drawing.Point(550, 472);
            this.lblCountCatMagazin.Name = "lblCountCatMagazin";
            this.lblCountCatMagazin.Size = new System.Drawing.Size(103, 17);
            this.lblCountCatMagazin.TabIndex = 17;
            this.lblCountCatMagazin.Text = "Toplam : 58 / 0";
            // 
            // lblCountCatSiyasi
            // 
            this.lblCountCatSiyasi.AutoSize = true;
            this.lblCountCatSiyasi.Location = new System.Drawing.Point(377, 472);
            this.lblCountCatSiyasi.Name = "lblCountCatSiyasi";
            this.lblCountCatSiyasi.Size = new System.Drawing.Size(103, 17);
            this.lblCountCatSiyasi.TabIndex = 16;
            this.lblCountCatSiyasi.Text = "Toplam : 58 / 0";
            // 
            // lblCountCatSaglik
            // 
            this.lblCountCatSaglik.AutoSize = true;
            this.lblCountCatSaglik.Location = new System.Drawing.Point(203, 472);
            this.lblCountCatSaglik.Name = "lblCountCatSaglik";
            this.lblCountCatSaglik.Size = new System.Drawing.Size(103, 17);
            this.lblCountCatSaglik.TabIndex = 15;
            this.lblCountCatSaglik.Text = "Toplam : 58 / 0";
            // 
            // lblCountCatEkonomi
            // 
            this.lblCountCatEkonomi.AutoSize = true;
            this.lblCountCatEkonomi.Location = new System.Drawing.Point(31, 472);
            this.lblCountCatEkonomi.Name = "lblCountCatEkonomi";
            this.lblCountCatEkonomi.Size = new System.Drawing.Size(103, 17);
            this.lblCountCatEkonomi.TabIndex = 14;
            this.lblCountCatEkonomi.Text = "Toplam : 58 / 0";
            // 
            // lblHeadCatSaglik
            // 
            this.lblHeadCatSaglik.AutoSize = true;
            this.lblHeadCatSaglik.Location = new System.Drawing.Point(203, 35);
            this.lblHeadCatSaglik.Name = "lblHeadCatSaglik";
            this.lblHeadCatSaglik.Size = new System.Drawing.Size(46, 17);
            this.lblHeadCatSaglik.TabIndex = 13;
            this.lblHeadCatSaglik.Text = "Sağlık";
            // 
            // lblHeadCarSiyasi
            // 
            this.lblHeadCarSiyasi.AutoSize = true;
            this.lblHeadCarSiyasi.Location = new System.Drawing.Point(377, 35);
            this.lblHeadCarSiyasi.Name = "lblHeadCarSiyasi";
            this.lblHeadCarSiyasi.Size = new System.Drawing.Size(45, 17);
            this.lblHeadCarSiyasi.TabIndex = 12;
            this.lblHeadCarSiyasi.Text = "Siyasi";
            // 
            // lblHeadCatMagazin
            // 
            this.lblHeadCatMagazin.AutoSize = true;
            this.lblHeadCatMagazin.Location = new System.Drawing.Point(550, 35);
            this.lblHeadCatMagazin.Name = "lblHeadCatMagazin";
            this.lblHeadCatMagazin.Size = new System.Drawing.Size(61, 17);
            this.lblHeadCatMagazin.TabIndex = 11;
            this.lblHeadCatMagazin.Text = "Magazin";
            // 
            // lblHeadCatSpor
            // 
            this.lblHeadCatSpor.AutoSize = true;
            this.lblHeadCatSpor.Location = new System.Drawing.Point(729, 35);
            this.lblHeadCatSpor.Name = "lblHeadCatSpor";
            this.lblHeadCatSpor.Size = new System.Drawing.Size(38, 17);
            this.lblHeadCatSpor.TabIndex = 10;
            this.lblHeadCatSpor.Text = "Spor";
            // 
            // lblHeadCatEkonomi
            // 
            this.lblHeadCatEkonomi.AutoSize = true;
            this.lblHeadCatEkonomi.Location = new System.Drawing.Point(31, 35);
            this.lblHeadCatEkonomi.Name = "lblHeadCatEkonomi";
            this.lblHeadCatEkonomi.Size = new System.Drawing.Size(62, 17);
            this.lblHeadCatEkonomi.TabIndex = 9;
            this.lblHeadCatEkonomi.Text = "Ekonomi";
            // 
            // listBoxCatSpor
            // 
            this.listBoxCatSpor.FormattingEnabled = true;
            this.listBoxCatSpor.ItemHeight = 16;
            this.listBoxCatSpor.Location = new System.Drawing.Point(732, 55);
            this.listBoxCatSpor.Name = "listBoxCatSpor";
            this.listBoxCatSpor.Size = new System.Drawing.Size(180, 404);
            this.listBoxCatSpor.TabIndex = 8;
            // 
            // listBoxCatMagazin
            // 
            this.listBoxCatMagazin.FormattingEnabled = true;
            this.listBoxCatMagazin.ItemHeight = 16;
            this.listBoxCatMagazin.Location = new System.Drawing.Point(553, 55);
            this.listBoxCatMagazin.Name = "listBoxCatMagazin";
            this.listBoxCatMagazin.Size = new System.Drawing.Size(173, 404);
            this.listBoxCatMagazin.TabIndex = 7;
            // 
            // listBoxCatSiyasi
            // 
            this.listBoxCatSiyasi.FormattingEnabled = true;
            this.listBoxCatSiyasi.ItemHeight = 16;
            this.listBoxCatSiyasi.Location = new System.Drawing.Point(380, 55);
            this.listBoxCatSiyasi.Name = "listBoxCatSiyasi";
            this.listBoxCatSiyasi.Size = new System.Drawing.Size(167, 404);
            this.listBoxCatSiyasi.TabIndex = 6;
            // 
            // listboxCatSaglik
            // 
            this.listboxCatSaglik.FormattingEnabled = true;
            this.listboxCatSaglik.ItemHeight = 16;
            this.listboxCatSaglik.Location = new System.Drawing.Point(206, 55);
            this.listboxCatSaglik.Name = "listboxCatSaglik";
            this.listboxCatSaglik.Size = new System.Drawing.Size(168, 404);
            this.listboxCatSaglik.TabIndex = 5;
            // 
            // listBoxCatEkonomi
            // 
            this.listBoxCatEkonomi.FormattingEnabled = true;
            this.listBoxCatEkonomi.ItemHeight = 16;
            this.listBoxCatEkonomi.Location = new System.Drawing.Point(34, 55);
            this.listBoxCatEkonomi.Name = "listBoxCatEkonomi";
            this.listBoxCatEkonomi.Size = new System.Drawing.Size(166, 404);
            this.listBoxCatEkonomi.TabIndex = 4;
            // 
            // btnNaiveBayes
            // 
            this.btnNaiveBayes.Location = new System.Drawing.Point(34, 529);
            this.btnNaiveBayes.Name = "btnNaiveBayes";
            this.btnNaiveBayes.Size = new System.Drawing.Size(878, 51);
            this.btnNaiveBayes.TabIndex = 3;
            this.btnNaiveBayes.Text = "Naive Bayes";
            this.btnNaiveBayes.UseVisualStyleBackColor = true;
            this.btnNaiveBayes.Click += new System.EventHandler(this.btnNaiveBayes_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnFormula);
            this.tabPage4.Controls.Add(this.groupBoxFormulaSaglik);
            this.tabPage4.Controls.Add(this.groupBoxFormulaMagazin);
            this.tabPage4.Controls.Add(this.groupBoxFormulaSpor);
            this.tabPage4.Controls.Add(this.groupBoxFormulaSiyasi);
            this.tabPage4.Controls.Add(this.groupBoxFormulaEkonomi);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(996, 627);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4 - Formüller";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnFormula
            // 
            this.btnFormula.Location = new System.Drawing.Point(16, 485);
            this.btnFormula.Name = "btnFormula";
            this.btnFormula.Size = new System.Drawing.Size(958, 49);
            this.btnFormula.TabIndex = 10;
            this.btnFormula.Text = "FORMÜLLERİ GÖSTER";
            this.btnFormula.UseVisualStyleBackColor = true;
            this.btnFormula.Click += new System.EventHandler(this.btnFormula_Click);
            // 
            // groupBoxFormulaSaglik
            // 
            this.groupBoxFormulaSaglik.Controls.Add(this.lblFormulaFemeasureSaglik);
            this.groupBoxFormulaSaglik.Controls.Add(this.lblFormulaRecallSaglik);
            this.groupBoxFormulaSaglik.Controls.Add(this.lblFormulaPrecisionSaglik);
            this.groupBoxFormulaSaglik.Location = new System.Drawing.Point(334, 120);
            this.groupBoxFormulaSaglik.Name = "groupBoxFormulaSaglik";
            this.groupBoxFormulaSaglik.Size = new System.Drawing.Size(322, 177);
            this.groupBoxFormulaSaglik.TabIndex = 9;
            this.groupBoxFormulaSaglik.TabStop = false;
            this.groupBoxFormulaSaglik.Text = "Sağlık";
            // 
            // lblFormulaFemeasureSaglik
            // 
            this.lblFormulaFemeasureSaglik.AutoSize = true;
            this.lblFormulaFemeasureSaglik.Location = new System.Drawing.Point(21, 126);
            this.lblFormulaFemeasureSaglik.Name = "lblFormulaFemeasureSaglik";
            this.lblFormulaFemeasureSaglik.Size = new System.Drawing.Size(96, 17);
            this.lblFormulaFemeasureSaglik.TabIndex = 5;
            this.lblFormulaFemeasureSaglik.Text = "Fe-measure : ";
            // 
            // lblFormulaRecallSaglik
            // 
            this.lblFormulaRecallSaglik.AutoSize = true;
            this.lblFormulaRecallSaglik.Location = new System.Drawing.Point(21, 80);
            this.lblFormulaRecallSaglik.Name = "lblFormulaRecallSaglik";
            this.lblFormulaRecallSaglik.Size = new System.Drawing.Size(64, 17);
            this.lblFormulaRecallSaglik.TabIndex = 4;
            this.lblFormulaRecallSaglik.Text = "Re-call : ";
            // 
            // lblFormulaPrecisionSaglik
            // 
            this.lblFormulaPrecisionSaglik.AutoSize = true;
            this.lblFormulaPrecisionSaglik.Location = new System.Drawing.Point(21, 34);
            this.lblFormulaPrecisionSaglik.Name = "lblFormulaPrecisionSaglik";
            this.lblFormulaPrecisionSaglik.Size = new System.Drawing.Size(78, 17);
            this.lblFormulaPrecisionSaglik.TabIndex = 3;
            this.lblFormulaPrecisionSaglik.Text = "Precision : ";
            // 
            // groupBoxFormulaMagazin
            // 
            this.groupBoxFormulaMagazin.Controls.Add(this.lblFormulaFemeasureMagazin);
            this.groupBoxFormulaMagazin.Controls.Add(this.lblFormulaRecallMagazin);
            this.groupBoxFormulaMagazin.Controls.Add(this.lblFormulaPrecisionMagazin);
            this.groupBoxFormulaMagazin.Location = new System.Drawing.Point(16, 303);
            this.groupBoxFormulaMagazin.Name = "groupBoxFormulaMagazin";
            this.groupBoxFormulaMagazin.Size = new System.Drawing.Size(307, 175);
            this.groupBoxFormulaMagazin.TabIndex = 9;
            this.groupBoxFormulaMagazin.TabStop = false;
            this.groupBoxFormulaMagazin.Text = "Magazin";
            // 
            // lblFormulaFemeasureMagazin
            // 
            this.lblFormulaFemeasureMagazin.AutoSize = true;
            this.lblFormulaFemeasureMagazin.Location = new System.Drawing.Point(23, 125);
            this.lblFormulaFemeasureMagazin.Name = "lblFormulaFemeasureMagazin";
            this.lblFormulaFemeasureMagazin.Size = new System.Drawing.Size(96, 17);
            this.lblFormulaFemeasureMagazin.TabIndex = 5;
            this.lblFormulaFemeasureMagazin.Text = "Fe-measure : ";
            // 
            // lblFormulaRecallMagazin
            // 
            this.lblFormulaRecallMagazin.AutoSize = true;
            this.lblFormulaRecallMagazin.Location = new System.Drawing.Point(23, 79);
            this.lblFormulaRecallMagazin.Name = "lblFormulaRecallMagazin";
            this.lblFormulaRecallMagazin.Size = new System.Drawing.Size(64, 17);
            this.lblFormulaRecallMagazin.TabIndex = 4;
            this.lblFormulaRecallMagazin.Text = "Re-call : ";
            // 
            // lblFormulaPrecisionMagazin
            // 
            this.lblFormulaPrecisionMagazin.AutoSize = true;
            this.lblFormulaPrecisionMagazin.Location = new System.Drawing.Point(23, 33);
            this.lblFormulaPrecisionMagazin.Name = "lblFormulaPrecisionMagazin";
            this.lblFormulaPrecisionMagazin.Size = new System.Drawing.Size(78, 17);
            this.lblFormulaPrecisionMagazin.TabIndex = 3;
            this.lblFormulaPrecisionMagazin.Text = "Precision : ";
            // 
            // groupBoxFormulaSpor
            // 
            this.groupBoxFormulaSpor.Controls.Add(this.lblFormulaFemeasureSpor);
            this.groupBoxFormulaSpor.Controls.Add(this.lblFormulaRecallSpor);
            this.groupBoxFormulaSpor.Controls.Add(this.lblFormulaPrecisionSpor);
            this.groupBoxFormulaSpor.Location = new System.Drawing.Point(16, 120);
            this.groupBoxFormulaSpor.Name = "groupBoxFormulaSpor";
            this.groupBoxFormulaSpor.Size = new System.Drawing.Size(303, 177);
            this.groupBoxFormulaSpor.TabIndex = 9;
            this.groupBoxFormulaSpor.TabStop = false;
            this.groupBoxFormulaSpor.Text = "Spor";
            // 
            // lblFormulaFemeasureSpor
            // 
            this.lblFormulaFemeasureSpor.AutoSize = true;
            this.lblFormulaFemeasureSpor.Location = new System.Drawing.Point(23, 127);
            this.lblFormulaFemeasureSpor.Name = "lblFormulaFemeasureSpor";
            this.lblFormulaFemeasureSpor.Size = new System.Drawing.Size(96, 17);
            this.lblFormulaFemeasureSpor.TabIndex = 2;
            this.lblFormulaFemeasureSpor.Text = "Fe-measure : ";
            // 
            // lblFormulaRecallSpor
            // 
            this.lblFormulaRecallSpor.AutoSize = true;
            this.lblFormulaRecallSpor.Location = new System.Drawing.Point(23, 81);
            this.lblFormulaRecallSpor.Name = "lblFormulaRecallSpor";
            this.lblFormulaRecallSpor.Size = new System.Drawing.Size(64, 17);
            this.lblFormulaRecallSpor.TabIndex = 1;
            this.lblFormulaRecallSpor.Text = "Re-call : ";
            // 
            // lblFormulaPrecisionSpor
            // 
            this.lblFormulaPrecisionSpor.AutoSize = true;
            this.lblFormulaPrecisionSpor.Location = new System.Drawing.Point(23, 35);
            this.lblFormulaPrecisionSpor.Name = "lblFormulaPrecisionSpor";
            this.lblFormulaPrecisionSpor.Size = new System.Drawing.Size(78, 17);
            this.lblFormulaPrecisionSpor.TabIndex = 0;
            this.lblFormulaPrecisionSpor.Text = "Precision : ";
            // 
            // groupBoxFormulaSiyasi
            // 
            this.groupBoxFormulaSiyasi.Controls.Add(this.lblFormulaFemeasureSiyasi);
            this.groupBoxFormulaSiyasi.Controls.Add(this.lblFormulaRecallSiyasi);
            this.groupBoxFormulaSiyasi.Controls.Add(this.lblFormulaPrecisionSiyasi);
            this.groupBoxFormulaSiyasi.Location = new System.Drawing.Point(674, 120);
            this.groupBoxFormulaSiyasi.Name = "groupBoxFormulaSiyasi";
            this.groupBoxFormulaSiyasi.Size = new System.Drawing.Size(300, 177);
            this.groupBoxFormulaSiyasi.TabIndex = 9;
            this.groupBoxFormulaSiyasi.TabStop = false;
            this.groupBoxFormulaSiyasi.Text = "Siyasi";
            // 
            // lblFormulaFemeasureSiyasi
            // 
            this.lblFormulaFemeasureSiyasi.AutoSize = true;
            this.lblFormulaFemeasureSiyasi.Location = new System.Drawing.Point(23, 127);
            this.lblFormulaFemeasureSiyasi.Name = "lblFormulaFemeasureSiyasi";
            this.lblFormulaFemeasureSiyasi.Size = new System.Drawing.Size(96, 17);
            this.lblFormulaFemeasureSiyasi.TabIndex = 5;
            this.lblFormulaFemeasureSiyasi.Text = "Fe-measure : ";
            // 
            // lblFormulaRecallSiyasi
            // 
            this.lblFormulaRecallSiyasi.AutoSize = true;
            this.lblFormulaRecallSiyasi.Location = new System.Drawing.Point(23, 81);
            this.lblFormulaRecallSiyasi.Name = "lblFormulaRecallSiyasi";
            this.lblFormulaRecallSiyasi.Size = new System.Drawing.Size(64, 17);
            this.lblFormulaRecallSiyasi.TabIndex = 4;
            this.lblFormulaRecallSiyasi.Text = "Re-call : ";
            // 
            // lblFormulaPrecisionSiyasi
            // 
            this.lblFormulaPrecisionSiyasi.AutoSize = true;
            this.lblFormulaPrecisionSiyasi.Location = new System.Drawing.Point(23, 35);
            this.lblFormulaPrecisionSiyasi.Name = "lblFormulaPrecisionSiyasi";
            this.lblFormulaPrecisionSiyasi.Size = new System.Drawing.Size(78, 17);
            this.lblFormulaPrecisionSiyasi.TabIndex = 3;
            this.lblFormulaPrecisionSiyasi.Text = "Precision : ";
            // 
            // groupBoxFormulaEkonomi
            // 
            this.groupBoxFormulaEkonomi.Controls.Add(this.lblFormulaFemeasureEkonomi);
            this.groupBoxFormulaEkonomi.Controls.Add(this.lblFormulaRecallEkonomi);
            this.groupBoxFormulaEkonomi.Controls.Add(this.lblFormulaPrecisionEkonomi);
            this.groupBoxFormulaEkonomi.Location = new System.Drawing.Point(334, 303);
            this.groupBoxFormulaEkonomi.Name = "groupBoxFormulaEkonomi";
            this.groupBoxFormulaEkonomi.Size = new System.Drawing.Size(322, 175);
            this.groupBoxFormulaEkonomi.TabIndex = 8;
            this.groupBoxFormulaEkonomi.TabStop = false;
            this.groupBoxFormulaEkonomi.Text = "Ekonomi";
            // 
            // lblFormulaFemeasureEkonomi
            // 
            this.lblFormulaFemeasureEkonomi.AutoSize = true;
            this.lblFormulaFemeasureEkonomi.Location = new System.Drawing.Point(7, 125);
            this.lblFormulaFemeasureEkonomi.Name = "lblFormulaFemeasureEkonomi";
            this.lblFormulaFemeasureEkonomi.Size = new System.Drawing.Size(96, 17);
            this.lblFormulaFemeasureEkonomi.TabIndex = 5;
            this.lblFormulaFemeasureEkonomi.Text = "Fe-measure : ";
            // 
            // lblFormulaRecallEkonomi
            // 
            this.lblFormulaRecallEkonomi.AutoSize = true;
            this.lblFormulaRecallEkonomi.Location = new System.Drawing.Point(7, 79);
            this.lblFormulaRecallEkonomi.Name = "lblFormulaRecallEkonomi";
            this.lblFormulaRecallEkonomi.Size = new System.Drawing.Size(64, 17);
            this.lblFormulaRecallEkonomi.TabIndex = 4;
            this.lblFormulaRecallEkonomi.Text = "Re-call : ";
            // 
            // lblFormulaPrecisionEkonomi
            // 
            this.lblFormulaPrecisionEkonomi.AutoSize = true;
            this.lblFormulaPrecisionEkonomi.Location = new System.Drawing.Point(7, 33);
            this.lblFormulaPrecisionEkonomi.Name = "lblFormulaPrecisionEkonomi";
            this.lblFormulaPrecisionEkonomi.Size = new System.Drawing.Size(78, 17);
            this.lblFormulaPrecisionEkonomi.TabIndex = 3;
            this.lblFormulaPrecisionEkonomi.Text = "Precision : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 682);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Form Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxPrediction.ResumeLayout(false);
            this.groupBoxPrediction.PerformLayout();
            this.groupBoxLearn.ResumeLayout(false);
            this.groupBoxLearn.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBoxFormulaSaglik.ResumeLayout(false);
            this.groupBoxFormulaSaglik.PerformLayout();
            this.groupBoxFormulaMagazin.ResumeLayout(false);
            this.groupBoxFormulaMagazin.PerformLayout();
            this.groupBoxFormulaSpor.ResumeLayout(false);
            this.groupBoxFormulaSpor.PerformLayout();
            this.groupBoxFormulaSiyasi.ResumeLayout(false);
            this.groupBoxFormulaSiyasi.PerformLayout();
            this.groupBoxFormulaEkonomi.ResumeLayout(false);
            this.groupBoxFormulaEkonomi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnZemberek;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.ProgressBar progressBarFiles;
        private System.Windows.Forms.ProgressBar progressBarFolders;
        private System.Windows.Forms.Label lblHeadFiles;
        private System.Windows.Forms.Label lblHeadFolders;
        private System.Windows.Forms.Label lblCountFiles;
        private System.Windows.Forms.Label lblCountFolders;
        private System.Windows.Forms.Button btnGram;
        private System.Windows.Forms.Label lblHeadPrediction;
        private System.Windows.Forms.Label lblHeadLearn;
        private System.Windows.Forms.ListBox listBoxPrediction;
        private System.Windows.Forms.ListBox listBoxLearn;
        private System.Windows.Forms.ProgressBar progressBarPrediction;
        private System.Windows.Forms.ProgressBar progressBarLearn;
        private System.Windows.Forms.ListBox listBoxLearnGram3;
        private System.Windows.Forms.ListBox listBoxLearnGram2;
        private System.Windows.Forms.Label lblHeadLearnGram3;
        private System.Windows.Forms.Label lblHeadLearnGram2;
        private System.Windows.Forms.GroupBox groupBoxPrediction;
        private System.Windows.Forms.GroupBox groupBoxLearn;
        private System.Windows.Forms.Label lblHeadPredictionGram2;
        private System.Windows.Forms.ListBox listBoxPredictionGram3;
        private System.Windows.Forms.Label lblHeadPredictionGram3;
        private System.Windows.Forms.ListBox listBoxPredictionGram2;
        private System.Windows.Forms.Button btnNaiveBayes;
        private System.Windows.Forms.Label lblHeadCatSaglik;
        private System.Windows.Forms.Label lblHeadCarSiyasi;
        private System.Windows.Forms.Label lblHeadCatMagazin;
        private System.Windows.Forms.Label lblHeadCatSpor;
        private System.Windows.Forms.Label lblHeadCatEkonomi;
        private System.Windows.Forms.ListBox listBoxCatSpor;
        private System.Windows.Forms.ListBox listBoxCatMagazin;
        private System.Windows.Forms.ListBox listboxCatSaglik;
        private System.Windows.Forms.ListBox listBoxCatEkonomi;
        private System.Windows.Forms.Label lblCountCatSpor;
        private System.Windows.Forms.Label lblCountCatMagazin;
        private System.Windows.Forms.Label lblCountCatSiyasi;
        private System.Windows.Forms.Label lblCountCatSaglik;
        private System.Windows.Forms.Label lblCountCatEkonomi;
        private System.Windows.Forms.ListBox listBoxCatSiyasi;
        private System.Windows.Forms.Button btnFormula;
        private System.Windows.Forms.GroupBox groupBoxFormulaSaglik;
        private System.Windows.Forms.GroupBox groupBoxFormulaMagazin;
        private System.Windows.Forms.GroupBox groupBoxFormulaSpor;
        private System.Windows.Forms.GroupBox groupBoxFormulaSiyasi;
        private System.Windows.Forms.GroupBox groupBoxFormulaEkonomi;
        private System.Windows.Forms.Label lblFormulaFemeasureSaglik;
        private System.Windows.Forms.Label lblFormulaRecallSaglik;
        private System.Windows.Forms.Label lblFormulaPrecisionSaglik;
        private System.Windows.Forms.Label lblFormulaFemeasureMagazin;
        private System.Windows.Forms.Label lblFormulaRecallMagazin;
        private System.Windows.Forms.Label lblFormulaPrecisionMagazin;
        private System.Windows.Forms.Label lblFormulaFemeasureSpor;
        private System.Windows.Forms.Label lblFormulaRecallSpor;
        private System.Windows.Forms.Label lblFormulaPrecisionSpor;
        private System.Windows.Forms.Label lblFormulaFemeasureSiyasi;
        private System.Windows.Forms.Label lblFormulaRecallSiyasi;
        private System.Windows.Forms.Label lblFormulaPrecisionSiyasi;
        private System.Windows.Forms.Label lblFormulaFemeasureEkonomi;
        private System.Windows.Forms.Label lblFormulaRecallEkonomi;
        private System.Windows.Forms.Label lblFormulaPrecisionEkonomi;
        private System.Windows.Forms.Label lblStepPredictionGram3;
        private System.Windows.Forms.Label lblStepPredictionGram2;
        private System.Windows.Forms.Label lblStepLearnGram3;
        private System.Windows.Forms.Label lblStepLearnGram2;
    }
}

