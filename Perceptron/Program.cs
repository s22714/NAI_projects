using Perceptron;

var a = args[0];
var trainFile = args[1];
var testFile = args[2];

List<CLObject> trainingList = new List<CLObject>();
List<CLObject> testList = new List<CLObject>();

//reading lines from file
string[] trainLines = File.ReadAllLines(trainFile);

//creating KnnObject for all lines in file
foreach (string line in trainLines)
{
    //Console.WriteLine(line);
    var divLine = line.Split(";");

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
    CLObject kn = new CLObject();
    kn.Name = name;
    kn.Vector = vec;
    trainingList.Add(kn);
}



//reading lines from file
string[] testLines = File.ReadAllLines(testFile);

//creating KnnObject for all lines in file
foreach (string line in testLines)
{
    //Console.WriteLine(line);
    var divLine = line.Split(";");

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
    CLObject kn = new CLObject();
    kn.Name = name;
    kn.Vector = vec;
    testList.Add(kn);
}


