/*
Console.WriteLine("podaj plik: ");
string filepath = Console.ReadLine();

Console.WriteLine("podaj k: ");
int k = Convert.ToInt32(Console.ReadLine());
*/

using C__k_means;

string filepath = ".\\test.csv";
int k = 20;

var ex = false;

while (!ex)
{
    try
    {
        
        List<double> listE = new();
        var import = new FileImport(filepath);
        var allVectors = import.Vectors;
        var allGroups = new List<Group>();

        for (int i = 0; i < k; i++)
        {
            allGroups.Add(new Group());
        }

        //Console.WriteLine(allGroups.Count);
        Random random = new();
        allVectors = allVectors.OrderBy(_ => random.Next()).ToList();

        var index = 0;
        foreach (var vec in allVectors)
        {
            allGroups[index].Vectors.Add(vec);
            index++;
            if (index == k) index = 0;
        }

        foreach (var group in allGroups)
        {
            Console.WriteLine(group);
        }


        double E = -1;
        listE.Add(E);

        foreach (var group in allGroups)
        {
            group.CountCentroid();
            Console.WriteLine(group);
            group.Flush();
        }

        foreach (var vec in allVectors)
        {
            var dists = new List<double>();
            foreach (var group in allGroups)
            {
                dists.Add(group.ClasifyToCentroid(vec));
            }
            allGroups[dists.IndexOf(dists.Max())].Vectors.Add(vec);
        }
        Console.WriteLine("==========================1=======================");
        double newE = 0;
        foreach (var group in allGroups)
        {
            group.CountCentroid();
            Console.WriteLine(group);
            newE += group.CalcDistances();
            group.Flush();
        }

        listE.Add(newE);

        index = 1;
        while (true)
        {
            index++;
            Console.WriteLine($"=========================={index}=======================");
            foreach (var vec in allVectors)
            {
                var dists = new List<double>();
                foreach (var group in allGroups)
                {
                    dists.Add(group.ClasifyToCentroid(vec));
                }
                allGroups[dists.IndexOf(dists.Max())].Vectors.Add(vec);
            }

            foreach (var group in allGroups)
            {
                group.CountCentroid();
                Console.WriteLine(group);
                newE += group.CalcDistances();
                group.Flush();
            }
            listE.Add(newE);
            Console.WriteLine("E: " + newE);


            if (E == newE) break;
            E = newE;
            newE = 0;

        }
        foreach (var e in listE)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("k: " + k);
        ex = true;
    }
    catch (Exception)
    {
        k--;
        Console.WriteLine("\n================================================================================\n" +
            "===============================K ZMNIEJSZONE====================================\n" +
            "================================================================================");
    }
    
}



