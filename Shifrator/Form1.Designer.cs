namespace Shifrator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilePath1 = new System.Windows.Forms.TextBox();
            this.textBoxFilePath2 = new System.Windows.Forms.TextBox();
            this.buttonFindWay1 = new System.Windows.Forms.Button();
            this.buttonFindWay2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKey1 = new System.Windows.Forms.TextBox();
            this.textBoxKey2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGenKey = new System.Windows.Forms.Button();
            this.buttonStart1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шифрування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(477, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дешифрування";
            // 
            // buttonStart2
            // 
            this.buttonStart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart2.Location = new System.Drawing.Point(489, 289);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(183, 52);
            this.buttonStart2.TabIndex = 3;
            this.buttonStart2.Text = "Start";
            this.buttonStart2.UseVisualStyleBackColor = true;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxFilePath1
            // 
            this.textBoxFilePath1.Location = new System.Drawing.Point(104, 148);
            this.textBoxFilePath1.Name = "textBoxFilePath1";
            this.textBoxFilePath1.Size = new System.Drawing.Size(189, 22);
            this.textBoxFilePath1.TabIndex = 4;
            // 
            // textBoxFilePath2
            // 
            this.textBoxFilePath2.Location = new System.Drawing.Point(483, 148);
            this.textBoxFilePath2.Name = "textBoxFilePath2";
            this.textBoxFilePath2.Size = new System.Drawing.Size(189, 22);
            this.textBoxFilePath2.TabIndex = 5;
            // 
            // buttonFindWay1
            // 
            this.buttonFindWay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindWay1.Location = new System.Drawing.Point(299, 137);
            this.buttonFindWay1.Name = "buttonFindWay1";
            this.buttonFindWay1.Size = new System.Drawing.Size(45, 45);
            this.buttonFindWay1.TabIndex = 6;
            this.buttonFindWay1.Text = "...";
            this.buttonFindWay1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFindWay1.UseVisualStyleBackColor = true;
            this.buttonFindWay1.Click += new System.EventHandler(this.buttonFindWay1_Click);
            // 
            // buttonFindWay2
            // 
            this.buttonFindWay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindWay2.Location = new System.Drawing.Point(678, 137);
            this.buttonFindWay2.Name = "buttonFindWay2";
            this.buttonFindWay2.Size = new System.Drawing.Size(45, 45);
            this.buttonFindWay2.TabIndex = 7;
            this.buttonFindWay2.Text = "...";
            this.buttonFindWay2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFindWay2.UseVisualStyleBackColor = true;
            this.buttonFindWay2.Click += new System.EventHandler(this.buttonFindWay2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(131, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Шлях до файлу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(507, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Шлях до файлу";
            // 
            // textBoxKey1
            // 
            this.textBoxKey1.Location = new System.Drawing.Point(104, 205);
            this.textBoxKey1.Name = "textBoxKey1";
            this.textBoxKey1.Size = new System.Drawing.Size(189, 22);
            this.textBoxKey1.TabIndex = 10;
            // 
            // textBoxKey2
            // 
            this.textBoxKey2.Location = new System.Drawing.Point(483, 205);
            this.textBoxKey2.Name = "textBoxKey2";
            this.textBoxKey2.Size = new System.Drawing.Size(189, 22);
            this.textBoxKey2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(112, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ключ шифрування";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(491, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ключ шифрування";
            // 
            // buttonGenKey
            // 
            this.buttonGenKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenKey.Location = new System.Drawing.Point(299, 197);
            this.buttonGenKey.Name = "buttonGenKey";
            this.buttonGenKey.Size = new System.Drawing.Size(53, 41);
            this.buttonGenKey.TabIndex = 14;
            this.buttonGenKey.Text = "Gen";
            this.buttonGenKey.UseVisualStyleBackColor = true;
            this.buttonGenKey.Click += new System.EventHandler(this.buttonGenKey_Click);
            // 
            // buttonStart1
            // 
            this.buttonStart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart1.Location = new System.Drawing.Point(116, 289);
            this.buttonStart1.Name = "buttonStart1";
            this.buttonStart1.Size = new System.Drawing.Size(183, 52);
            this.buttonStart1.TabIndex = 15;
            this.buttonStart1.Text = "Start";
            this.buttonStart1.UseVisualStyleBackColor = true;
            this.buttonStart1.Click += new System.EventHandler(this.buttonStart1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(116, 371);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(562, 20);
            this.progressBar1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Прогрес";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStart1);
            this.Controls.Add(this.buttonGenKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKey2);
            this.Controls.Add(this.textBoxKey1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFindWay2);
            this.Controls.Add(this.buttonFindWay1);
            this.Controls.Add(this.textBoxFilePath2);
            this.Controls.Add(this.textBoxFilePath1);
            this.Controls.Add(this.buttonStart2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Шифратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFilePath1;
        private System.Windows.Forms.TextBox textBoxFilePath2;
        private System.Windows.Forms.Button buttonFindWay1;
        private System.Windows.Forms.Button buttonFindWay2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKey1;
        private System.Windows.Forms.TextBox textBoxKey2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGenKey;
        private System.Windows.Forms.Button buttonStart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

