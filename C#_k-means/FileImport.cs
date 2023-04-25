using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__k_means
{
    public class FileImport
    {
        public List<List<double>> Vectors { get; set; }
        public FileImport(string filepath) 
        {
            List<List<double>> vectors = new List<List<double>>();

            string[] lines = File.ReadAllLines(filepath);

            foreach (string line in lines)
            {
                var divLine = line.Split(',');

                List<double> vector = new List<double>();

                foreach(string s in divLine)
                {
                    double num;
                    bool isNum = Double.TryParse(s.Replace(".", ","), out num);
                    if (isNum)
                    {
                        vector.Add(num);
                    }
                }
                vectors.Add(vector);
            }
            this.Vectors = vectors;
        }
    }
}
