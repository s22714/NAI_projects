using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Knn
{
    public partial class Form1 : Form
    {

//=============================================================Form1 initialization=============================================================
        public Form1()
        {
            InitializeComponent();
            
        }
//=============================================================kNN object declaration=============================================================
        public Knn Newknn { set; get; }
        public List<double> Accuracies { get; set; }

//=============================================================Main graph creator function=============================================================
        private void ChartPaint()
        {
            //chart1 clear
            chart1.Series.Clear();
            
            //chart area declaration
            ChartArea chartArea = new ChartArea();

            //chart1 owerall options
            chart1.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            chart1.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;
            chart1.ApplyPaletteColors();

            //chart1 Y axis
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 10;

            //chart1 X axis
            chart1.ChartAreas[0].AxisX.Interval = 0.5;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 10;

            //list of x,y points declaration
            List<List<double>> points = new List<List<double>>();

            //adding point coordinates to list
            for (int i = 0; i < Newknn.TrainSet[0].Vector.Count; i++)
            {
                List<double> p = new List<double>();
                points.Add(p);
            }

            //list of names declaration
            List<string> labels = new List<string>();
            
            //adding names to list in accordance to point list
            foreach (var kn in Newknn.TrainSet)
            {
                for(int i = 0; i < kn.Vector.Count; i++)
                {
                    points[i].Add(kn.Vector[i]);
                }
                labels.Add(kn.Name);
            }

            //list of all available names in NewKnn object
            List<string> allNames = new List<string>();

            //adding all available distinct names to allNames list
            foreach(var s in labels.Distinct())
            {
                allNames.Add(s);
            }

            //adding variables to comboboxes if empty
            if(Xcombo.Items.Count == 0)
            {
                int num = 0;
                foreach(List<double> p in points)
                {
                    num++;
                    Xcombo.Items.Add(num);
                    Ycombo.Items.Add(num);
                }
            }
            
            //selecting combobox items if none selected
            if(Xcombo.SelectedItem == null)
            {
                Xcombo.SelectedItem = 1;
            }
            if (Ycombo.SelectedItem == null)
            {
                Ycombo.SelectedItem = 2;
            }
            
            //list of chart seriess
            List<Series> seriesList = new List<Series>();

            //adding series to the list
            for(int i = 0; i < allNames.Count; i++)
            {
                //create series
                Series series = new Series();
                
                //name series
                series.Name = allNames.ElementAt(i);

                //series options
                series.ChartType = SeriesChartType.Point;
                series.BorderWidth = 2;
                
                //adding series
                seriesList.Add(new Series());
                chart1.Series.Add(series);
            }

            //catch wrong divider given "HOPEFULLY"
            try
            {
                //adding points to a series
                for (int i = 0; i < points[Xcombo.SelectedIndex].Count; i++)
                {
                    
                    //searching for a right series by name
                    var ser = chart1.Series.First(val => val.Name == labels[i]);

                    //adding point
                    ser.Points.AddXY(points[Xcombo.SelectedIndex][i], points[Ycombo.SelectedIndex][i]);

                }

            }catch(ArgumentOutOfRangeException)
            {
                //clear chart1
                chart1.Series.Clear();
                accuracyChart.Series.Clear();

                //display window with message
                MessageBox.Show("Wrong divider selected.", "source file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                //exit function
                return;
            }

            //declare k maximum in k picker 
            kPicker.Maximum = Newknn.TrainSet.Count;
        }

//=============================================================Create button clicked functionality=============================================================

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //test for errors
            if (testFileSource.Text.Length == 0)
            {
                MessageBox.Show("Please enter path to test file.", "no path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (trainFileSource.Text.Length == 0)
            {
                MessageBox.Show("Please enter path to train file.", "no path",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(trainFileSource.Text))
            {
                MessageBox.Show("Train file does not exist.", "no path",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(testFileSource.Text))
            {
                MessageBox.Show("Train file does not exist.", "no path",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dividerBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter divider.", "no divider",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
            //create Knn object
            this.Newknn = new Knn(testFileSource.Text, trainFileSource.Text, Convert.ToChar(dividerBox.Text));

            //test clasification functionality of Knn Class
            var num = Newknn.TestClasify(unchecked((int)kPicker.Value));

            //create chart1
            Chart chart1 = new Chart();

            //add chart1 to controls
            this.Controls.Add(chart1);

            //start ChartPaint function
            ChartPaint();

        }

//=============================================================Submit button clicked functionality=============================================================

        private void Submit_Click(object sender, EventArgs e)
        {
            //checking for errors
            if (Newknn == null)
            {
                MessageBox.Show("Press create first.", "submit error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*if(!UserSubmitTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Please enter spaces as dividers.", "incorrect number of values",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            
            //table of string numbers
            var str = UserSubmitTextBox.Text.Split(Convert.ToChar(" "));
            var div = " ";
            //Console.WriteLine(dividerBox.Text);
            //additional error
            if (str.Length < Newknn.TrainSet.First().Vector.Count || str.Length > Newknn.TrainSet.First().Vector.Count)
            {
                str = UserSubmitTextBox.Text.Split(Convert.ToChar(dividerBox.Text));
                //Console.WriteLine(str);
                if (str.Length < Newknn.TrainSet.First().Vector.Count || str.Length > Newknn.TrainSet.First().Vector.Count)
                {
                    MessageBox.Show("Please enter " + Newknn.TrainSet.First().Vector.Count + " values to submit.", "incorrect number of values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                div = dividerBox.Text;
            }

            //check if are numbers
            bool areNumbers = false;
            int counter = 0;
            for(int i = 0; i < str.Length; i++)
            {
                double num;
                bool isNum = Double.TryParse(str[i].Replace(".", ","), out num);
                if (isNum) counter++;
                if(counter > 1)
                {
                    areNumbers = true;
                    break;
                }
            }

            //additional error
            if (!areNumbers)
            {
                MessageBox.Show("Please enter numbers only.", "incorrect number of numbers",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Clasify user imput
            var value = Newknn.ClasifyUserInput(UserSubmitTextBox.Text, unchecked((int)kPicker.Value), Convert.ToChar(div));


            //optional -> check if classification is right
            if (NameTextBox.Text != "" && NameTextBox.Text != value)
            {

                int lineIndex = historyTextBox.Lines.Count() - 1;
                int lineLength = historyTextBox.Lines[lineIndex].Length;

                historyTextBox.SelectionStart = historyTextBox.GetFirstCharIndexFromLine(lineIndex);
                historyTextBox.SelectionLength = lineLength;

                historyTextBox.SelectionColor = Color.Red;

            }
            else if (NameTextBox.Text != "" && NameTextBox.Text == value)
            {
                int lineIndex = historyTextBox.Lines.Count()-1;
                int lineLength = historyTextBox.Lines[lineIndex].Length;

                historyTextBox.SelectionStart = historyTextBox.GetFirstCharIndexFromLine(lineIndex);
                historyTextBox.SelectionLength = lineLength;

                historyTextBox.SelectionColor = Color.Green;
            }

            
            //output
            //Console.WriteLine("user: " + NameTextBox.Text + " " + UserSubmitTextBox.Text + " calc: " + value + "\n");
            if(Accuracies == null)
            {
                historyTextBox.AppendText("user: " 
                    + NameTextBox.Text 
                    + " " 
                    + UserSubmitTextBox.Text 
                    + " calc: " 
                    + value  
                    + Environment.NewLine);
                return;
            }
            historyTextBox.AppendText("user: " 
                + NameTextBox.Text 
                + " " 
                + UserSubmitTextBox.Text 
                + " calc: " 
                + value  
                + " accuracy: " 
                + Math.Round(Accuracies[unchecked((int)kPicker.Value)], 2) 
                + Environment.NewLine);

        }

//=============================================================accuracy chart creating function=============================================================

        public void AcChart(List<double> acList)
        {
            //clear accuracyChart
            accuracyChart.Series.Clear();

            //create chart area
            ChartArea chartArea = new ChartArea();

            //chart general options
            accuracyChart.ChartAreas[0].Axes[0].MajorGrid.Enabled = true;
            accuracyChart.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;
            accuracyChart.ApplyPaletteColors();

            //chart Y axis
            accuracyChart.ChartAreas[0].AxisY.Interval = 10;
            accuracyChart.ChartAreas[0].AxisY.Minimum = 0;
            accuracyChart.ChartAreas[0].AxisY.Maximum = 100;
            accuracyChart.ChartAreas[0].AxisY.Title = "%";

            //chart X axis
            accuracyChart.ChartAreas[0].AxisX.Interval = 5;
            accuracyChart.ChartAreas[0].AxisX.Minimum = 0;
            accuracyChart.ChartAreas[0].AxisX.Maximum = acList.Count;
            accuracyChart.ChartAreas[0].AxisX.Title = "K";

            //declear series
            Series series = new Series();
            series.Name = "accuracy";

            //series options
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            accuracyChart.Series.Add(series);

            //add points to series
            for (int i = 0; i < acList.Count; i++)
            {
                series.Points.AddXY(i, acList[i]);
            }
        }

//=============================================================train file sourse on double click function=============================================================

        private void trainFileSource_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //decleare file dialog
            OpenFileDialog newFileDialog = new OpenFileDialog();

            //file dialog options
            newFileDialog.InitialDirectory = "c:";
            newFileDialog.FilterIndex = 0;
            newFileDialog.RestoreDirectory = true;

            //waiting fo user to pick a file
            if (newFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = newFileDialog.FileName;
                trainFileSource.Text = selectedFile;
            }
        }

//=============================================================test file sourse on double click function=============================================================

        private void testFileSource_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //decleare file dialog
            OpenFileDialog newFileDialog = new OpenFileDialog();

            //file dialog options
            newFileDialog.InitialDirectory = "c:";
            newFileDialog.FilterIndex = 0;
            newFileDialog.RestoreDirectory = true;

            //waiting fo user to pick a file
            if (newFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = newFileDialog.FileName;
                trainFileSource.Text = selectedFile;
            }
        }

//=============================================================generate accuracy chart button functionality=============================================================

        private void GenAccu_Click(object sender, EventArgs e)
        {
            //check for errors
            if (Newknn == null)
            {
                MessageBox.Show("Press create first.", "submit error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //list of all accuracies declare
            List<double> accuracies = new List<double>();
            this.Accuracies = accuracies;
            //test classify with all possible k values
            for (int i = 1; i < this.Newknn.TrainSet.Count; i++)
            {
                var num = Newknn.TestClasify(i);
                accuracies.Add(num);
            }

            //create accuracy chart
            Chart accuracyChart = new Chart();
            this.Controls.Add(accuracyChart);
            AcChart(accuracies);
        }

//=============================================================generate test log button functionality=============================================================

        private void GenTest_Click(object sender, EventArgs e)
        {
            //check for errors
            if (Newknn == null)
            {
                MessageBox.Show("Press create first.", "submit error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //clear history
            historyTextBox.Clear();

            //test all test values
            foreach (var t in Newknn.TestSet)
            {
                //test classify
                var value = Newknn.ClasifyUserInput(string.Join(";",t.Vector), unchecked((int)kPicker.Value), Convert.ToChar(dividerBox.Text));

                //check if right value
                if (t.Name != value)
                {
                    var lineIndex = historyTextBox.Lines.Count();

                    historyTextBox.SelectionColor = Color.Red;
                } 
                else if (t.Name == value)
                {
                    var lineIndex = historyTextBox.Lines.Count();
                    
                    historyTextBox.SelectionColor = Color.Green;
                }

                //output
                //Console.WriteLine("test: " + t.Name + " " + string.Join(" ", t.Vector) + " calc: " + value + "\n");
                if (Accuracies == null)
                {
                    historyTextBox.AppendText("test: " 
                        + NameTextBox.Text 
                        + " " 
                        + UserSubmitTextBox.Text 
                        + " calc: " 
                        + value 
                        + Environment.NewLine);
                    
                }
                else
                {
                    historyTextBox.AppendText("test: " 
                        + NameTextBox.Text 
                        + " " 
                        + UserSubmitTextBox.Text 
                        + " calc: " 
                        + value 
                        + " accuracy: " 
                        + Math.Round(Accuracies[unchecked((int)kPicker.Value)],2) 
                        + Environment.NewLine);
                }

            }
        }
    }
}
