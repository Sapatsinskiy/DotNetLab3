using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Shifrator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void buttonFindWay1_Click(object sender, EventArgs e)
        {
            wayToPath(textBoxFilePath1);
        }

        void wayToPath(System.Windows.Forms.TextBox textBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Усі файли (*.*)|*.*|Текстові файли (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = openFileDialog.FileName;
            }
        }

        private void buttonGenKey_Click(object sender, EventArgs e)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder keyBuilder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                keyBuilder.Append(chars[random.Next(chars.Length)]);
            }
            textBoxKey1.Text = keyBuilder.ToString();
        }

        private void buttonFindWay2_Click(object sender, EventArgs e)
        {
            wayToPath(textBoxFilePath2);
        }

        string FormatFileSize(long bytes)
        {
            if (bytes >= 1_073_741_824)
                return $"{bytes / 1_073_741_824.0:F2} ГБ";
            else if (bytes >= 1_048_576)
                return $"{bytes / 1_048_576.0:F2} МБ";
            else if (bytes >= 1024)
                return $"{bytes / 1024.0:F2} КБ";
            else
                return $"{bytes} Б";
        }

        private DateTime startTime;
        private DateTime endTime;
        private void buttonStart1_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;

            string filePath = textBoxFilePath1.Text;
            string key = textBoxKey1.Text;

            if (key.Length != 0)
            {
                buttonStart1.Enabled = false; 

                backgroundWorker1.RunWorkerAsync(new object[] { filePath, key, "encrypt" });
            }
            else
            {
                MessageBox.Show("Створіть ключ для шифрування", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStart2_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;

            string filePath = textBoxFilePath2.Text;
            string key = textBoxKey2.Text;

            if (key.Length != 0)
            {
                buttonStart2.Enabled = false;

                backgroundWorker1.RunWorkerAsync(new object[] { filePath, key, "decrypt" });
            }
            else
            {
                MessageBox.Show("Введіть ключ для дешифрування", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;
            string filePath = (string)args[0];
            string key = (string)args[1];
            string operation = (string)args[2];


            FileInfo fileInfo = new FileInfo(filePath);
            long fileSize = fileInfo.Length;

            string content = File.ReadAllText(filePath, Encoding.UTF8);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < content.Length; i++)
            {
                char processedChar = XorEncryptDecrypt(content[i].ToString(), key)[0];

                result.Append(processedChar);

                int progress = (int)((i / (float)content.Length) * 100);
                backgroundWorker1.ReportProgress(progress);
            }

            File.WriteAllText(filePath, result.ToString(), Encoding.UTF8);
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;

            endTime = DateTime.Now;
            TimeSpan duration = endTime - startTime;

            string time = duration.ToString(@"hh\:mm\:ss");
            MessageBox.Show($"Операція завершена!\nЧас виконання: {time}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            buttonStart1.Enabled = true;
            buttonStart2.Enabled = true;

            progressBar1.Value = 0;
        }

        string XorEncryptDecrypt(string text, string key)
        {
            StringBuilder result = new StringBuilder();
            int keyLength = key.Length;

            for (int i = 0; i < text.Length; i++)
            {
                result.Append((char)(text[i] ^ key[i % keyLength]));
            }

            return result.ToString();
        }
    }
}
