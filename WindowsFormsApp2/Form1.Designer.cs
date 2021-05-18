
namespace WindowsFormsApp2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NumberOfExper = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.RelAver = new System.Windows.Forms.Label();
            this.RelVariance = new System.Windows.Forms.Label();
            this.ResChi = new System.Windows.Forms.Label();
            this.Pprob = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfExper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pprob)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.Location = new System.Drawing.Point(252, 33);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.IsValueShownAsLabel = true;
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(536, 405);
            this.chart1.TabIndex = 0;
            title7.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title7.BorderWidth = 10;
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            title7.Name = "Title1";
            title7.Text = "Probability";
            this.chart1.Titles.Add(title7);
            // 
            // NumberOfExper
            // 
            this.NumberOfExper.Location = new System.Drawing.Point(5, 316);
            this.NumberOfExper.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.NumberOfExper.Name = "NumberOfExper";
            this.NumberOfExper.Size = new System.Drawing.Size(120, 22);
            this.NumberOfExper.TabIndex = 5;
            this.NumberOfExper.ThousandsSeparator = true;
            this.NumberOfExper.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of experiments:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(131, 328);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 47);
            this.Start.TabIndex = 13;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 488);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            this.Status.TabIndex = 15;
            // 
            // RelAver
            // 
            this.RelAver.AutoSize = true;
            this.RelAver.Location = new System.Drawing.Point(48, 400);
            this.RelAver.Name = "RelAver";
            this.RelAver.Size = new System.Drawing.Size(0, 17);
            this.RelAver.TabIndex = 16;
            // 
            // RelVariance
            // 
            this.RelVariance.AutoSize = true;
            this.RelVariance.Location = new System.Drawing.Point(48, 429);
            this.RelVariance.Name = "RelVariance";
            this.RelVariance.Size = new System.Drawing.Size(0, 17);
            this.RelVariance.TabIndex = 17;
            // 
            // ResChi
            // 
            this.ResChi.AutoSize = true;
            this.ResChi.Location = new System.Drawing.Point(48, 463);
            this.ResChi.Name = "ResChi";
            this.ResChi.Size = new System.Drawing.Size(0, 17);
            this.ResChi.TabIndex = 18;
            // 
            // Pprob
            // 
            this.Pprob.DecimalPlaces = 2;
            this.Pprob.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Pprob.Location = new System.Drawing.Point(76, 127);
            this.Pprob.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pprob.Name = "Pprob";
            this.Pprob.Size = new System.Drawing.Size(114, 22);
            this.Pprob.TabIndex = 19;
            this.Pprob.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "P0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pprob);
            this.Controls.Add(this.ResChi);
            this.Controls.Add(this.RelVariance);
            this.Controls.Add(this.RelAver);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumberOfExper);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfExper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pprob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown NumberOfExper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label RelAver;
        private System.Windows.Forms.Label RelVariance;
        private System.Windows.Forms.Label ResChi;
        private System.Windows.Forms.NumericUpDown Pprob;
        private System.Windows.Forms.Label label1;
    }
}

