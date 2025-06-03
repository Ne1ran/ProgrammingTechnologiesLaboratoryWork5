namespace ProgrammingTechnologiesLaboratoryWork5;

public delegate void ThreadCallback(double[,] arrayOfValuesZ, int arraySize, int threadId);

public class ThreadWithState(int threadId, double minX, double maxX, double minY, double maxY, int sizeOfArrays, ThreadCallback callback)
{
    private readonly double[] _arrayOfArgumentsX = new double[sizeOfArrays];
    private readonly double[] _arrayOfArgumentsY = new double[sizeOfArrays];
    private readonly double[,] _arrayOfValuesZ = new double[sizeOfArrays, sizeOfArrays];
    private readonly double _maxX = maxX * threadId;
    private readonly double _minX = minX * threadId;
    private readonly double _maxY = maxY * threadId;
    private readonly double _minY = minY * threadId;
    private double _stepX;
    private double _stepY;

    private static readonly object _fileLock = new();

    public void ThreadDoWork()
    {
        FillArgumentsArrays();
        CalculateVariantFunction();

        lock (_fileLock) {
            PrintToFile();
        }

        callback(_arrayOfValuesZ, sizeOfArrays, threadId);
    }

    private void FillArgumentsArrays()
    {
        _stepX = (_maxX - _minX) / (sizeOfArrays - 1);
        _stepY = (_maxY - _minY) / (sizeOfArrays - 1);

        for (int i = 0; i < sizeOfArrays; i++) {
            _arrayOfArgumentsX[i] = _minX + _stepX * i;
            _arrayOfArgumentsY[i] = _minY + _stepY * i;
        }
    }

    private void CalculateVariantFunction()
    {
        for (int i = 0; i < sizeOfArrays; i++) {
            for (int j = 0; j < sizeOfArrays; j++) {
                _arrayOfValuesZ[i, j] = Function13(_arrayOfArgumentsX[i], _arrayOfArgumentsY[j]);
            }
        }
    }

    private void PrintToFile()
    {
        string fileName = Path.Combine("C:", "Save\\results.txt");
        using var writer = new StreamWriter(fileName, true);

        for (int i = 0; i < sizeOfArrays; i++) {
            string line = string.Empty;
            for (int j = 0; j < sizeOfArrays; j++) {
                line += $"Z[{i}][{j}] = {_arrayOfValuesZ[i, j]}; ";
                if (j == sizeOfArrays - 1) {
                    line += "\n";
                }
            }
            writer.Write(line);
        }

        DateTime finishTime = DateTime.Now;
        writer.WriteLine($"\nПоток номер - {threadId}; Время - {finishTime:HH:mm:ss.fff};\n\n");
    }

    private static double Function13(double x, double y)
    {
        return (Math.Exp(x) * (Math.Sin(y) - Math.Pow(Math.Cos(y), 2))) / (Math.Pow(Math.Sin(x), 2) + Math.Cos(x));
    }
}