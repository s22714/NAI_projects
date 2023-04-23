using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PerceptronOkno
{
    public class DataImport
    {
        public List<TestSubject> subList {  get; set; }
        public DataImport(string file, char divider)
        {
            
            List<TestSubject> subList = new List<TestSubject>();
            List<List<double>> vectors = new List<List<double>>();
            List<double> vec = new List<double>();
            //reading lines from file
            string[] lines = File.ReadAllLines(file);
            string name = "";
            //creating KnnObject for all lines in file
            foreach (string line in lines)
            {
                

                //Console.WriteLine(line);
                var divLine = line.Split(divider);

                string oldName = name;
                

                foreach (string val in divLine)
                {
                    double num;
                    bool isNum = Double.TryParse(val.Replace(".", ","), out num);
                    if (isNum)
                    {
                        vec.Add(num);
                    }
                    else
                    {
                        name = val;
                    }

                }

                if(name == oldName || oldName == "")
                {
                    vectors.Add(vec);
                    vec = new List<double>();
                }
                else
                {
                    var sub = new TestSubject
                    {
                        Name = oldName,
                        vectors = vectors
                    };
                    subList.Add(sub);
                    vectors = new List<List<double>>();
                    vectors.Add(vec);
                    vec = new List<double>();
                }

                
            }
            var su = new TestSubject
            {
                Name = name,
                vectors = vectors
            };
            subList.Add(su);
            this.subList = subList;
        }
    }
}
