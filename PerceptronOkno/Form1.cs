using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerceptronOkno
{
    public partial class Form1 : Form
    {
        public List<TestSubject> SubList { get; set; }
        public List<TestSubject> TestSubList { get; set; }
        public Perceptron p { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            var sub = new DataImport(testFileSource.Text, Convert.ToChar(dividerBox.Text));
            this.TestSubList = sub.subList;

            sub = new DataImport(trainFileSource.Text, Convert.ToChar(dividerBox.Text));
            this.SubList = sub.subList;

            var names = SubList.Select(x => x.Name).Distinct().ToList();

            foreach(var s in names)
            {
                SeekedValueCombo.Items.Add(s);
                SecoundSetCombo.Items.Add(s);
            }
            SeekedValueCombo.SelectedIndex = 0;
            SecoundSetCombo.SelectedIndex = 1;
            
            this.p = new Perceptron();
            
        }

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

        private void FileClasButton_Click(object sender, EventArgs e)
        {
            var alpha = Convert.ToDouble(StałaUczeniaBox.Value);
            
            this.p.Percept(TestSubList.Where(a => a.Name == SecoundSetCombo.Text || a.Name == SeekedValueCombo.Text).ToList(), SubList.Where(a => a.Name == SeekedValueCombo.Text || a.Name == SecoundSetCombo.Text).ToList(), alpha, SeekedValueCombo.Text, SecoundSetCombo.Text);

            Acc1Text.Text = p.Acc1.ToString();
            Acc2Text.Text = p.Acc2.ToString();
            AccSumTextBox.Text = p.AccSum.ToString();
        }

        private void UserClasifyButton_Click(object sender, EventArgs e)
        {
            var str = UserInputTextBox.Text.Split(Convert.ToChar(";"));
            var vec = new List<double>();  
            foreach(var s in str)
            {
                double num;
                bool isNum = Double.TryParse(s.Replace(".", ","), out num);
                vec.Add(num);
            }
            if (vec.Count == 0) return;
            var res = p.CalcUser(vec);
            
            UserInputTextBox.Text = res;
        }
    }
}
