using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PerceptronOkno
{
    public class Perceptron
    {
        public List<double> W { get; set; }
        public List<OneSub> TestSubs { get; set; }
        public List<OneSub> TrainSubs { get; set; }
        public double T { get; set; }
        public string LookedFor { get; set; }
        public string TheOther { get; set; }
        public double Acc1 { get; set; }
        public double Acc2 { get; set; }
        public double AccSum { get; set; }

        public void Percept(List<TestSubject> test, List<TestSubject> train, double alpha, string lookedFor, string theOther)
        {
            this.LookedFor = lookedFor;
            this.TheOther = theOther;

            List<double> w = new List<double>();
            this.TrainSubs = new List<OneSub>();
            this.TestSubs = new List<OneSub>();

            Random random = new Random();
            //wagi
            foreach(var i in test[0].vectors[0])
            {
                var r = random.NextDouble() * (5 - (-5)) + (-5);
                w.Add(r);
                //Console.WriteLine(r);
            }
            this.W = w;
            var t = random.NextDouble() * (5 - (-5)) + (-5);
            //Console.WriteLine(t);

            foreach(var subject in train)
            {
                for(int i  = 0; i < subject.vectors.Count; i++)
                {
                    this.TrainSubs.Add(new OneSub
                    {
                        Name = subject.Name,
                        vector = subject.vectors[i]
                    });
                }
            }
            foreach (var subject in test)
            {
                for (int i = 0; i < subject.vectors.Count; i++)
                {
                    this.TestSubs.Add(new OneSub
                    {
                        Name = subject.Name,
                        vector = subject.vectors[i]
                    });
                }
            }

            this.TestSubs = TestSubs.OrderBy(_ => random.Next()).ToList();
            this.TrainSubs = TrainSubs.OrderBy(_ => random.Next()).ToList();
            double acc1 = 0;
            double acc2 = 0;
            double allAcc = 0;
            double y;
            int d;
            while (acc1 < 95 && acc2 < 95)
            {
                
                foreach (var trainSub in this.TrainSubs)
                {
                    if (trainSub.Name == lookedFor) d = 1;
                    else d = 0;
                    y = CalcY(trainSub.vector, this.W, t);

                    t = NewT(t, y, d, alpha);
                    this.W = NewW(this.W, d, y, alpha, trainSub.vector);
                }
                double good = 0;
                double all = 0;
                double allall = all;
                double allgood = good;
                foreach (var testSub in this.TestSubs)
                {
                    double res = CalcY(testSub.vector, this.W, t);
                    if (testSub.Name == lookedFor && res == 1) good++;
                    if (testSub.Name != lookedFor && res == 0) good++;
                    Console.WriteLine($"testSub Name {testSub.Name} {res}");
                    all++;
                }
                acc1 = (good / all) * 100;
                Console.WriteLine(acc1);
                allall = all;
                allgood = good;
                good = 0;
                all = 0;
                foreach (var testSub in this.TestSubs)
                {
                    double res = CalcY(testSub.vector, this.W, t);
                    if (testSub.Name != lookedFor && res == 0) good++;
                    if (testSub.Name == lookedFor && res == 1) good++;
                    Console.WriteLine($"testSub Name {testSub.Name} {res}");
                    all++;
                }
                acc2 = (good / all) * 100;
                Console.WriteLine(acc2);
                Console.WriteLine("============================================================");
                allall += all;
                allgood += good;
                allAcc = (allgood / allall) * 100;
            }

            this.T = t;
            this.Acc1 = acc1;
            this.Acc2 = acc2;
            this.AccSum = allAcc;
        }

        public List<double> NewW(List<double> w, int d, double y, double a, List<double> vector)
        {
            List<double> newW = new List<double>();
            var cos = (d - y) * a;
            for(int i  = 0; i < vector.Count; i++)
            {
                var res = 0.0;
                res = (vector[i] * cos)+ w[i];
                
                newW.Add(res);
            }
            
            return newW;
        }
        public double NewT(double t, double y, int d, double a)
        {
            return (t -(d-y)*a);
        }
        public double CalcY(List<double> vector, List<double> w, double t) 
        {
            double res = 0;
            for(int i = 0; i < vector.Count; i++)
            {
                res += vector[i] * w[i];
            }
            res -= t;

            if (res >= 0)
                return 1;
            else
                return 0;

        }

        public string CalcUser(List<double> vector)
        {
            double res = 0;
            for (int i = 0; i < vector.Count; i++)
            {
                res += vector[i] * this.W[i];
            }
            res -= this.T;

            if (res >= 0)
                return this.LookedFor;
            else
                return this.TheOther;
        }

    }
}
