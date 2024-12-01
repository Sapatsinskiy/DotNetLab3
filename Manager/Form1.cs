using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxPriority.Items.AddRange(new string[] { "Idle", "BelowNormal", "Normal", "AboveNormal", "High", "RealTime" });
            comboBoxPriority.SelectedIndex = 2;

            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();

        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
                openFileDialog.Title = "Виберіть програму для запуску";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        Process process = Process.Start(filePath);

                        foreach (DataGridViewRow row in dataGridViewProcesses.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == process.ProcessName)
                            {
                                return;
                            }
                        }

                        dataGridViewProcesses.Rows.Add(
                            process.Id,
                            process.ProcessName,
                            (process.WorkingSet64 / 1024 / 1024) + " MB",
                            process.StartTime.ToString("g"),
                            process.PriorityClass.ToString(),
                            process.Threads.Count
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка запуску програми: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (dataGridViewProcesses.SelectedRows.Count > 0)
            {
                try
                {
                    int processId = Convert.ToInt32(dataGridViewProcesses.SelectedRows[0].Cells["Id"].Value);

                    Process process = Process.GetProcessById(processId);
                    process.Kill();

                    dataGridViewProcesses.Rows.RemoveAt(dataGridViewProcesses.SelectedRows[0].Index);

                    MessageBox.Show("Процес зупинено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося зупинити процес: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Виберіть процес для зупинки!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonChangePriority_Click(object sender, EventArgs e)
        {
            panelPriority.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            panelPriority.Visible = false;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewProcesses.SelectedRows.Count > 0)
            {
                try
                {
                    int processId = Convert.ToInt32(dataGridViewProcesses.SelectedRows[0].Cells["Id"].Value);
                    Process process = Process.GetProcessById(processId);

                    string selectedPriority = comboBoxPriority.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(selectedPriority))
                    {
                        MessageBox.Show("Виберіть новий пріоритет!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    switch (selectedPriority)
                    {
                        case "Idle":
                            process.PriorityClass = ProcessPriorityClass.Idle;
                            break;
                        case "BelowNormal":
                            process.PriorityClass = ProcessPriorityClass.BelowNormal;
                            break;
                        case "Normal":
                            process.PriorityClass = ProcessPriorityClass.Normal;
                            break;
                        case "AboveNormal":
                            process.PriorityClass = ProcessPriorityClass.AboveNormal;
                            break;
                        case "High":
                            process.PriorityClass = ProcessPriorityClass.High;
                            break;
                        case "RealTime":
                            process.PriorityClass = ProcessPriorityClass.RealTime;
                            break;
                    }

                    dataGridViewProcesses.SelectedRows[0].Cells["Priority"].Value = process.PriorityClass.ToString();
                    MessageBox.Show("Пріоритет успішно змінено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelPriority.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося змінити пріоритет: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateInfo()
        {
            foreach (DataGridViewRow row in dataGridViewProcesses.Rows)
            {
                try
                {
                    int processId = Convert.ToInt32(row.Cells["Id"].Value);
                    Process process = Process.GetProcessById(processId);

                    if (process != null)
                    {
                        row.Cells["usegeMemory"].Value = $"{process.WorkingSet64 / 1024 / 1024} MB";
                        row.Cells["countPotoks"].Value = process.Threads.Count;
                        row.Cells["priority"].Value = process.PriorityClass.ToString();
                        row.Cells["time"].Value = process.StartTime.ToString("G");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка оновлення процесу: {ex.Message}");
                }
            }
        }
    }
}