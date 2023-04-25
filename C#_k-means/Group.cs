using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__k_means
{
    public class Group
    {
        public List<double> Centroid { get; set; } = new List<double>();
        public List<List<double>> Vectors { get; set; } = new List<List<double>>();

        public double CalcDistances()
        {
            double result = 0;
            foreach(var vec in Vectors)
            {
                double distance = 0;
                for (int i = 0; i < Centroid.Count; i++)
                {
                    distance += Math.Pow(vec[i] - Centroid[i], 2);
                }
                result += Math.Pow(distance,2);
            }
            
            return result;
        }

        public double ClasifyToCentroid(List<double> vector)
        {
            double result = 0;

            for(int i = 0; i < vector.Count; i++)
            {
                result += Math.Pow(vector[i] - Centroid[i],2);
            }
            return result;
        }

        public void CountCentroid()
        {
            if (Centroid.Count > 0) 
            {
                Centroid = new List<double>();
            }
            if (Vectors.Count == 0)
            {
                return;
            }
            for(int i = 0; i < Vectors[0].Count; i++)
            {
                double x = 0;
                foreach(var vec in Vectors)
                {
                    x += vec[i];
                }
                Centroid.Add(x/Vectors.Count);
            }
        }

        public void Flush()
        {
            Vectors = new List<List<double>>();
        }

        public override string ToString()
        {

            var str = $"\n============\nCentroid:\n";
            foreach (var v in Centroid)
            {
                str += $"{v} " ;
            }
            str += "\nVectors:\n";
            foreach (var vec in Vectors)
            {
                foreach(var v in vec)
                {
                    str += $"{v} ";
                }
                str += "\n";
            }
            str += "============\n";
            return str;
        }
    }
}
