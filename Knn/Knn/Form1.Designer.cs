namespace Knn
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Xcombo = new System.Windows.Forms.ComboBox();
            this.Ycombo = new System.Windows.Forms.ComboBox();
            this.UserSubmitTextBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.dividerBox = new System.Windows.Forms.TextBox();
            this.testFileSource = new System.Windows.Forms.TextBox();
            this.trainFileSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kPicker = new System.Windows.Forms.NumericUpDown();
            this.accuracyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.historyTextBox = new System.Windows.Forms.RichTextBox();
            this.GenAccu = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GenTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accuracyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            resources.ApplyResources(this.chart1, "chart1");
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Xcombo
            // 
            resources.ApplyResources(this.Xcombo, "Xcombo");
            this.Xcombo.FormattingEnabled = true;
            this.Xcombo.Name = "Xcombo";
            // 
            // Ycombo
            // 
            resources.ApplyResources(this.Ycombo, "Ycombo");
            this.Ycombo.FormattingEnabled = true;
            this.Ycombo.Name = "Ycombo";
            // 
            // UserSubmitTextBox
            // 
            resources.ApplyResources(this.UserSubmitTextBox, "UserSubmitTextBox");
            this.UserSubmitTextBox.Name = "UserSubmitTextBox";
            // 
            // Submit
            // 
            resources.ApplyResources(this.Submit, "Submit");
            this.Submit.Name = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // CreateButton
            // 
            resources.ApplyResources(this.CreateButton, "CreateButton");
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // dividerBox
            // 
            resources.ApplyResources(this.dividerBox, "dividerBox");
            this.dividerBox.Name = "dividerBox";
            // 
            // testFileSource
            // 
            resources.ApplyResources(this.testFileSource, "testFileSource");
            this.testFileSource.Name = "testFileSource";
            this.testFileSource.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.testFileSource_MouseDoubleClick);
            // 
            // trainFileSource
            // 
            resources.ApplyResources(this.trainFileSource, "trainFileSource");
            this.trainFileSource.Name = "trainFileSource";
            this.trainFileSource.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trainFileSource_MouseDoubleClick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // kPicker
            // 
            resources.ApplyResources(this.kPicker, "kPicker");
            this.kPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kPicker.Name = "kPicker";
            this.kPicker.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // accuracyChart
            // 
            resources.ApplyResources(this.accuracyChart, "accuracyChart");
            chartArea2.Name = "ChartArea1";
            this.accuracyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.accuracyChart.Legends.Add(legend2);
            this.accuracyChart.Name = "accuracyChart";
            this.accuracyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.accuracyChart.Series.Add(series2);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // historyTextBox
            // 
            resources.ApplyResources(this.historyTextBox, "historyTextBox");
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            // 
            // GenAccu
            // 
            resources.ApplyResources(this.GenAccu, "GenAccu");
            this.GenAccu.Name = "GenAccu";
            this.GenAccu.UseVisualStyleBackColor = true;
            this.GenAccu.Click += new System.EventHandler(this.GenAccu_Click);
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // GenTest
            // 
            resources.ApplyResources(this.GenTest, "GenTest");
            this.GenTest.Name = "GenTest";
            this.GenTest.UseVisualStyleBackColor = true;
            this.GenTest.Click += new System.EventHandler(this.GenTest_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenTest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.GenAccu);
            this.Controls.Add(this.historyTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.accuracyChart);
            this.Controls.Add(this.kPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trainFileSource);
            this.Controls.Add(this.testFileSource);
            this.Controls.Add(this.dividerBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.UserSubmitTextBox);
            this.Controls.Add(this.Ycombo);
            this.Controls.Add(this.Xcombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accuracyChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Xcombo;
        private System.Windows.Forms.ComboBox Ycombo;
        private System.Windows.Forms.TextBox UserSubmitTextBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox dividerBox;
        public System.Windows.Forms.TextBox testFileSource;
        public System.Windows.Forms.TextBox trainFileSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown kPicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart accuracyChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GenAccu;
        private System.Windows.Forms.RichTextBox historyTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button GenTest;
    }
}

