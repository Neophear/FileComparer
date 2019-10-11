using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileComparer
{
    public partial class Form1 : Form
    {
        private delegate void AppendTextDelegate(string text);
        private delegate void ResetAndSetProgressValueDelegate(int value);
        private delegate void PerformProgessStepDelegate();
        private delegate void SetMessageDelegate(string text);
        AppendTextDelegate atDelegate;
        ResetAndSetProgressValueDelegate raspvDelegate;
        PerformProgessStepDelegate ppsDelegate;
        SetMessageDelegate smDelegate;

        BackgroundWorker worker;
        List<FileCompareInfo> lib;

        public Form1()
        {
            InitializeComponent();

            atDelegate = new AppendTextDelegate(appendText);
            raspvDelegate = new ResetAndSetProgressValueDelegate(resetAndSetProgressValue);
            ppsDelegate = new PerformProgessStepDelegate(performProgressStep);
            smDelegate = new SetMessageDelegate(SetMessage);

            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            lib = new List<FileCompareInfo>();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnFindDuplicates.Enabled = true;
            Invoke(smDelegate, "Finished");
            Invoke(raspvDelegate, 100);
        }

        private void appendText(string text)
        {
            richTextBox1.AppendText(text);
        }

        private void resetAndSetProgressValue(int value)
        {
            tspbBottom.Value = 0;
            tspbBottom.Maximum = value;
        }

        private void performProgressStep()
        {
            tspbBottom.PerformStep();
        }

        private void SetMessage(string text)
        {
            tssBottom.Text = text;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(smDelegate, $"Building library...");
            BuildLibrary(txtFolder.Text);

            if (rdobtnCompareChecksum.Checked)
                CalculateChecksums();

            Invoke(raspvDelegate, lib.Count);

            for (int i = 0; i < lib.Count; i++)
            {
                FileCompareInfo file = lib[i];

                Invoke(smDelegate, $"Checking file '{file.FileName}...\n");

                FindDuplicates(file, i+1);

                if (file.Duplicates.Count > 0)
                {
                    Invoke(atDelegate, $"{file.FilePath}\n");

                    if (file.Duplicates.Count > 0)
                        foreach (string duplicate in file.Duplicates)
                            Invoke(atDelegate, $"\t{duplicate}\n");
                }

                Invoke(ppsDelegate);
            }
        }

        private void BuildLibrary(string folderpath)
        {
            foreach (string file in Directory.GetFiles(folderpath))
                lib.Add(new FileCompareInfo(file, new FileInfo(file).Length));

            if (chkbxRecursive.Checked)
                foreach (string dir in Directory.GetDirectories(folderpath))
                    BuildLibrary(dir);
        }

        private void CalculateChecksums()
        {
            Invoke(raspvDelegate, lib.Count);

            foreach (FileCompareInfo fi in lib)
            {
                Invoke(smDelegate, $"Calculating checksum: '{fi.FileName}");
                fi.Checksum = getChecksum(fi.FilePath);
                Invoke(ppsDelegate);
            }
        }

        private void FindDuplicates(FileCompareInfo file, int startIndex)
        {
            for (int i = startIndex; i < lib.Count; i++)
            {
                FileCompareInfo nextFile = lib[i];

                if (!nextFile.Checked
                    && ((rdobtnCompareChecksum.Checked && file.Checksum.Equals(nextFile.Checksum))
                    || rdobtnCompareSize.Checked && file.Size == nextFile.Size))
                {
                    file.Duplicates.AddLast(nextFile.FilePath);
                    nextFile.Checked = true;
                }
            }
        }

        private void btnFindFile1_Click(object sender, EventArgs e)
        {
            if (ofdFile1.ShowDialog() == DialogResult.OK)
            {
                txtFile1.Text = ofdFile1.FileName;
                txtChecksum1.Text = getChecksum(ofdFile1.FileName);
            }
        }

        private void btnFindFile2_Click(object sender, EventArgs e)
        {
            if (ofdFile2.ShowDialog() == DialogResult.OK)
            {
                txtFile2.Text = ofdFile2.FileName;
                txtChecksum2.Text = getChecksum(ofdFile2.FileName);
            }
        }

        private string getChecksum(string filename)
        {
            using (var md5 = MD5.Create())
                using (var stream = File.OpenRead(filename))
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
        }

        private void btnFindDuplicates_Click(object sender, EventArgs e)
        {
            lib.Clear();
            btnFindDuplicates.Enabled = false;
            worker.RunWorkerAsync();
        }

        private void btnFindFolder_Click(object sender, EventArgs e)
        {
            if (fbdFolder.ShowDialog() == DialogResult.OK)
                txtFolder.Text = fbdFolder.SelectedPath;
        }

        private class FileCompareInfo
        {
            public string Checksum { get; set; }
            public long Size { get; set; }
            private string _filePath;

            public string FilePath
            {
                get { return _filePath; }
                set
                {
                    _filePath = value;
                    FileName = Path.GetFileName(_filePath);
                }
            }

            public string FileName { get; private set; }
            public bool Checked { get; set; }
            public LinkedList<string> Duplicates { get; set; }

            public FileCompareInfo(string filePath)
            {
                FilePath = filePath;
                Duplicates = new LinkedList<string>();
            }

            public FileCompareInfo(string filePath, long size)
                : this(filePath)
            {
                Size = size;
            }
        }
    }
}
