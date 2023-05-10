namespace Lab9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Prob1Label = new System.Windows.Forms.Label();
            this.Prob2Label = new System.Windows.Forms.Label();
            this.Prob3Label = new System.Windows.Forms.Label();
            this.Prob4Label = new System.Windows.Forms.Label();
            this.Prob5Label = new System.Windows.Forms.Label();
            this.Prob1 = new System.Windows.Forms.NumericUpDown();
            this.Prob2 = new System.Windows.Forms.NumericUpDown();
            this.Prob3 = new System.Windows.Forms.NumericUpDown();
            this.Prob4 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumExperiments = new System.Windows.Forms.NumericUpDown();
            this.ExperimentsLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.TextBox();
            this.Variance = new System.Windows.Forms.TextBox();
            this.VarianceLabel = new System.Windows.Forms.Label();
            this.ChiSquaredLabel = new System.Windows.Forms.Label();
            this.ChiSquared = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumExperiments)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(289, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Freq";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(499, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Prob1Label
            // 
            this.Prob1Label.AutoSize = true;
            this.Prob1Label.Location = new System.Drawing.Point(12, 9);
            this.Prob1Label.Name = "Prob1Label";
            this.Prob1Label.Size = new System.Drawing.Size(46, 16);
            this.Prob1Label.TabIndex = 1;
            this.Prob1Label.Text = "Prob 1";
            // 
            // Prob2Label
            // 
            this.Prob2Label.AutoSize = true;
            this.Prob2Label.Location = new System.Drawing.Point(12, 37);
            this.Prob2Label.Name = "Prob2Label";
            this.Prob2Label.Size = new System.Drawing.Size(46, 16);
            this.Prob2Label.TabIndex = 2;
            this.Prob2Label.Text = "Prob 2";
            // 
            // Prob3Label
            // 
            this.Prob3Label.AutoSize = true;
            this.Prob3Label.Location = new System.Drawing.Point(12, 65);
            this.Prob3Label.Name = "Prob3Label";
            this.Prob3Label.Size = new System.Drawing.Size(46, 16);
            this.Prob3Label.TabIndex = 3;
            this.Prob3Label.Text = "Prob 3";
            // 
            // Prob4Label
            // 
            this.Prob4Label.AutoSize = true;
            this.Prob4Label.Location = new System.Drawing.Point(12, 93);
            this.Prob4Label.Name = "Prob4Label";
            this.Prob4Label.Size = new System.Drawing.Size(46, 16);
            this.Prob4Label.TabIndex = 4;
            this.Prob4Label.Text = "Prob 4";
            // 
            // Prob5Label
            // 
            this.Prob5Label.AutoSize = true;
            this.Prob5Label.Location = new System.Drawing.Point(12, 122);
            this.Prob5Label.Name = "Prob5Label";
            this.Prob5Label.Size = new System.Drawing.Size(46, 16);
            this.Prob5Label.TabIndex = 5;
            this.Prob5Label.Text = "Prob 5";
            // 
            // Prob1
            // 
            this.Prob1.Location = new System.Drawing.Point(64, 7);
            this.Prob1.Name = "Prob1";
            this.Prob1.Size = new System.Drawing.Size(120, 22);
            this.Prob1.TabIndex = 6;
            // 
            // Prob2
            // 
            this.Prob2.Location = new System.Drawing.Point(64, 35);
            this.Prob2.Name = "Prob2";
            this.Prob2.Size = new System.Drawing.Size(120, 22);
            this.Prob2.TabIndex = 7;
            // 
            // Prob3
            // 
            this.Prob3.Location = new System.Drawing.Point(64, 63);
            this.Prob3.Name = "Prob3";
            this.Prob3.Size = new System.Drawing.Size(120, 22);
            this.Prob3.TabIndex = 8;
            // 
            // Prob4
            // 
            this.Prob4.Location = new System.Drawing.Point(64, 91);
            this.Prob4.Name = "Prob4";
            this.Prob4.Size = new System.Drawing.Size(120, 22);
            this.Prob4.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Auto";
            // 
            // NumExperiments
            // 
            this.NumExperiments.Location = new System.Drawing.Point(183, 147);
            this.NumExperiments.Name = "NumExperiments";
            this.NumExperiments.Size = new System.Drawing.Size(100, 22);
            this.NumExperiments.TabIndex = 11;
            // 
            // ExperimentsLabel
            // 
            this.ExperimentsLabel.AutoSize = true;
            this.ExperimentsLabel.Location = new System.Drawing.Point(12, 149);
            this.ExperimentsLabel.Name = "ExperimentsLabel";
            this.ExperimentsLabel.Size = new System.Drawing.Size(145, 16);
            this.ExperimentsLabel.TabIndex = 12;
            this.ExperimentsLabel.Text = "Number of experiments";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(109, 175);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 13;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(12, 207);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(62, 16);
            this.AverageLabel.TabIndex = 14;
            this.AverageLabel.Text = "Average:";
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(12, 226);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(271, 22);
            this.Average.TabIndex = 15;
            // 
            // Variance
            // 
            this.Variance.Location = new System.Drawing.Point(12, 270);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(271, 22);
            this.Variance.TabIndex = 16;
            // 
            // VarianceLabel
            // 
            this.VarianceLabel.AutoSize = true;
            this.VarianceLabel.Location = new System.Drawing.Point(12, 251);
            this.VarianceLabel.Name = "VarianceLabel";
            this.VarianceLabel.Size = new System.Drawing.Size(64, 16);
            this.VarianceLabel.TabIndex = 17;
            this.VarianceLabel.Text = "Variance:";
            // 
            // ChiSquaredLabel
            // 
            this.ChiSquaredLabel.AutoSize = true;
            this.ChiSquaredLabel.Location = new System.Drawing.Point(12, 295);
            this.ChiSquaredLabel.Name = "ChiSquaredLabel";
            this.ChiSquaredLabel.Size = new System.Drawing.Size(83, 16);
            this.ChiSquaredLabel.TabIndex = 18;
            this.ChiSquaredLabel.Text = "Chi-squared:";
            // 
            // ChiSquared
            // 
            this.ChiSquared.Location = new System.Drawing.Point(12, 314);
            this.ChiSquared.Name = "ChiSquared";
            this.ChiSquared.Size = new System.Drawing.Size(271, 22);
            this.ChiSquared.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChiSquared);
            this.Controls.Add(this.ChiSquaredLabel);
            this.Controls.Add(this.VarianceLabel);
            this.Controls.Add(this.Variance);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ExperimentsLabel);
            this.Controls.Add(this.NumExperiments);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Prob4);
            this.Controls.Add(this.Prob3);
            this.Controls.Add(this.Prob2);
            this.Controls.Add(this.Prob1);
            this.Controls.Add(this.Prob5Label);
            this.Controls.Add(this.Prob4Label);
            this.Controls.Add(this.Prob3Label);
            this.Controls.Add(this.Prob2Label);
            this.Controls.Add(this.Prob1Label);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumExperiments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Prob1Label;
        private System.Windows.Forms.Label Prob2Label;
        private System.Windows.Forms.Label Prob3Label;
        private System.Windows.Forms.Label Prob4Label;
        private System.Windows.Forms.Label Prob5Label;
        private System.Windows.Forms.NumericUpDown Prob1;
        private System.Windows.Forms.NumericUpDown Prob2;
        private System.Windows.Forms.NumericUpDown Prob3;
        private System.Windows.Forms.NumericUpDown Prob4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown NumExperiments;
        private System.Windows.Forms.Label ExperimentsLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.TextBox Average;
        private System.Windows.Forms.TextBox Variance;
        private System.Windows.Forms.Label VarianceLabel;
        private System.Windows.Forms.Label ChiSquaredLabel;
        private System.Windows.Forms.TextBox ChiSquared;
    }
}

