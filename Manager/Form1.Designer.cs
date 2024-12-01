namespace Manager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.dataGridViewProcesses = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usegeMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPotoks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.panelPriority = new System.Windows.Forms.Panel();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonChangePriority = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesses)).BeginInit();
            this.panelPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLaunch.Location = new System.Drawing.Point(26, 284);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(229, 54);
            this.buttonLaunch.TabIndex = 0;
            this.buttonLaunch.Text = "Почати процес";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // dataGridViewProcesses
            // 
            this.dataGridViewProcesses.AllowUserToAddRows = false;
            this.dataGridViewProcesses.AllowUserToDeleteRows = false;
            this.dataGridViewProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.usegeMemory,
            this.countPotoks,
            this.priority,
            this.time});
            this.dataGridViewProcesses.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProcesses.Name = "dataGridViewProcesses";
            this.dataGridViewProcesses.ReadOnly = true;
            this.dataGridViewProcesses.RowHeadersWidth = 51;
            this.dataGridViewProcesses.RowTemplate.Height = 24;
            this.dataGridViewProcesses.Size = new System.Drawing.Size(918, 266);
            this.dataGridViewProcesses.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Назва процесу";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // usegeMemory
            // 
            this.usegeMemory.HeaderText = "Об\'єм пам\'яті";
            this.usegeMemory.MinimumWidth = 6;
            this.usegeMemory.Name = "usegeMemory";
            this.usegeMemory.ReadOnly = true;
            this.usegeMemory.Width = 125;
            // 
            // countPotoks
            // 
            this.countPotoks.HeaderText = "Кількість потоків";
            this.countPotoks.MinimumWidth = 6;
            this.countPotoks.Name = "countPotoks";
            this.countPotoks.ReadOnly = true;
            this.countPotoks.Width = 125;
            // 
            // priority
            // 
            this.priority.HeaderText = "Пріоритет виконання ";
            this.priority.MinimumWidth = 6;
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            this.priority.Width = 125;
            // 
            // time
            // 
            this.time.HeaderText = "Час";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 125;
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 5000;
            // 
            // panelPriority
            // 
            this.panelPriority.Controls.Add(this.buttonChange);
            this.panelPriority.Controls.Add(this.buttonExit);
            this.panelPriority.Controls.Add(this.label1);
            this.panelPriority.Controls.Add(this.comboBoxPriority);
            this.panelPriority.Location = new System.Drawing.Point(142, 39);
            this.panelPriority.Name = "panelPriority";
            this.panelPriority.Size = new System.Drawing.Size(501, 214);
            this.panelPriority.TabIndex = 2;
            this.panelPriority.Visible = false;
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(243, 114);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(144, 54);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "Обрати";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(93, 114);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(144, 54);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Скасувати";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оберіть пріоритет";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(93, 80);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(294, 28);
            this.comboBoxPriority.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(261, 284);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(229, 54);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Зупинити процес";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonChangePriority
            // 
            this.buttonChangePriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePriority.Location = new System.Drawing.Point(496, 284);
            this.buttonChangePriority.Name = "buttonChangePriority";
            this.buttonChangePriority.Size = new System.Drawing.Size(229, 54);
            this.buttonChangePriority.TabIndex = 4;
            this.buttonChangePriority.Text = "Змінити пріоритет";
            this.buttonChangePriority.UseVisualStyleBackColor = true;
            this.buttonChangePriority.Click += new System.EventHandler(this.buttonChangePriority_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.buttonChangePriority);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.panelPriority);
            this.Controls.Add(this.dataGridViewProcesses);
            this.Controls.Add(this.buttonLaunch);
            //this.Name = "Form1";
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesses)).EndInit();
            this.panelPriority.ResumeLayout(false);
            this.panelPriority.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.DataGridView dataGridViewProcesses;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Panel panelPriority;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonChangePriority;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn usegeMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPotoks;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}

