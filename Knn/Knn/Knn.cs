using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Knn
{
    public class Knn
    {
        //declaration of variables
        public List<KnnObject> TestSet { get; set; }
        public List<KnnObject> TrainSet { get; set; }

//=============================================================Knn class construcjion function=============================================================

        public Knn(string testfile, string trainfile, char divider)
        {
            //list declaration
            List<KnnObject> trainingList = new List<KnnObject>();
            List<KnnObject> testList = new List<KnnObject>();

            //reading lines from file
            string[] trainLines = File.ReadAllLines(trainfile);
            
            //creating KnnObject for all lines in file
            foreach (string line in trainLines)
            {
                //Console.WriteLine(line);
                var divLine = line.Split(divider);

                string name = "";
                List<double> vec = new List<double>();

                foreach(string val  in divLine)
                {
                    double num;
                    bool isNum = Double.TryParse(val.Replace(".",","), out num);
                    if (isNum)
                    {
                        vec.Add(num); 
                    }
                    else
                    {
                        name = val; 
                    }
                    
                }
                KnnObject kn = new KnnObject();
                kn.Name = name;
                kn.Vector = vec;
                trainingList.Add(kn);
            }

            this.TrainSet = trainingList;

            //reading lines from file
            string[] testLines = File.ReadAllLines(testfile);

            //creating KnnObject for all lines in file
            foreach (string line in testLines)
            {
                //Console.WriteLine(line);
                var divLine = line.Split(divider);

                string name = "";
                List<double> vec = new List<double>();

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
                KnnObject kn = new KnnObject();
                kn.Name = name;
                kn.Vector = vec;
                testList.Add(kn);
            }

            this.TestSet = testList;
        }

//=============================================================TestClasify function implementation=============================================================

        public double TestClasify(int k)
        {
            double success = 0;
            double tries = 0;

            foreach (KnnObject o in this.TestSet)
            {

                // distance map
                Dictionary<KnnObject,double> distmap = new Dictionary<KnnObject,double>();

                foreach (KnnObject t in this.TrainSet)
                {
                    distmap.Add(t, CalcDistance(o.Vector,t.Vector));
                    //Console.WriteLine(distmap.Count);
                }

                // k closest
                var sortedDict = (from entry in distmap orderby entry.Value ascending select entry)
                    .ToDictionary(pair => pair.Key, pair => pair.Value)
                    .Take(k);

                List<string> closestNames = new List<string>();
                foreach(var c in sortedDict)
                {
                    closestNames.Add(c.Key.Name);
                }

                // count names
                var dup = closestNames.GroupBy(val => val)
                    .Where(a => a.Count() > 0)
                    .Select(b => new {Name = b.Key, Count = b.Count()})
                    .OrderBy(b => b.Count)
                    .ToList();


                //Console.WriteLine(dup.Last().Name + " " + o.Name);
                tries++;
                if(dup.Last().Name == o.Name)
                {
                    success++;
                }
                
            }


            //Console.WriteLine("accuracy " + (success / tries) * 100);
            return ((success/tries)*100);
            
        }

//=============================================================ClasifyUserImput function implementation=============================================================

        public string ClasifyUserInput(string str, int k, char divider)
        {
            if (str.Length == 0) return "";

            var divLine = str.Split(divider);

            string name = "";
            List<double> vec = new List<double>();

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

            KnnObject knnObject = new KnnObject();
            knnObject.Name = name;
            knnObject.Vector = vec;
            

            // distance map
            Dictionary<KnnObject, double> distmap = new Dictionary<KnnObject, double>();

            foreach (KnnObject t in this.TrainSet)
            {
                distmap.Add(t, CalcDistance(knnObject.Vector, t.Vector));
                //Console.WriteLine(distmap.Count);
            }

            // k closest
            var sortedDict = (from entry in distmap orderby entry.Value ascending select entry)
                .ToDictionary(pair => pair.Key, pair => pair.Value)
                .Take(k);

            List<string> closestNames = new List<string>();
            foreach (var c in sortedDict)
            {
                closestNames.Add(c.Key.Name);
            }

            // count names
            var dup = closestNames.GroupBy(val => val)
                .Where(a => a.Count() > 0)
                .Select(b => new { Name = b.Key, Count = b.Count() })
                .OrderBy(b => b.Count)
                .ToList();

            return dup.Last().Name;
        }

//=============================================================CalcDistance function implementation=============================================================

        public double CalcDistance(List<double> vec1, List<double> vec2)
        {
            double distance = 0;
            for(int i = 0; i < vec1.Count; i++)
            {
                distance += Math.Pow(vec1[i] - vec2[i],2);
            }
            return Math.Sqrt(distance);
        }

        
    }
}
