namespace ProgrammingTechnologiesLaboratoryWork5;

public partial class MainForm : Form
{
    private DateTime _startTime;
    private DateTime _finishTime;
    private TimeSpan _durationOfProcess;
    private ThreadWithState[] _threadStates = null!;
    private Thread[] _threads = null!;

    public MainForm()
    {
        InitializeComponent();
        _startTime = DateTime.Now;
        _finishTime = DateTime.Now;
    }

    private void CreateThreads(int threadsCount, double minX, double maxX, double minY, double maxY, int cycleSize)
    {
        _threadStates = new ThreadWithState[threadsCount];
        _threads = new Thread[threadsCount];

        for (int i = 0; i < threadsCount; i++) {
            _threadStates[i] = new(i, minX, maxX, minY, maxY, cycleSize, ThreadCallback);
            _threads[i] = new(_threadStates[i].ThreadDoWork);
        }
    }

    private void StartThreads(int threadsCount)
    {
        for (int i = 0; i < threadsCount; i++) {
            _threads[i].Start();
        }
    }

    private void JoinThreads(int threadsCount)
    {
        for (int i = 0; i < threadsCount; i++) {
            _threads[i].Join();
        }
    }

    private void AbortThreads(int threadsCount)
    {
        for (int i = 0; i < threadsCount; i++) {
            _threads[i].Interrupt();
        }
    }

    private static void ThreadCallback(double[,] resultArray, int arraySize, int threadId)
    {
        string fileName = Path.Combine("C:", $"Save\\verifyResults{threadId}.txt");
        using var writer = new StreamWriter(fileName);

        for (int i = 0; i < arraySize; i++) {
            string line = string.Empty;
            for (int j = 0; j < arraySize; j++) {
                line += $"Z[{i}][{j}] = {resultArray[i, j]}; ";
                if (j == arraySize - 1) {
                    line += "\n";
                }
            }
            writer.Write(line);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try {
            _startTime = DateTime.Now;
            progressBar1.Value = 0;

            double minX = double.Parse(textBox1.Text);
            double maxX = double.Parse(textBox4.Text);
            double minY = double.Parse(textBox2.Text);
            double maxY = double.Parse(textBox3.Text);
            int threadsCount = int.Parse(textBox5.Text);
            int cycleSize = int.Parse(textBox6.Text);

            CreateThreads(threadsCount, minX, maxX, minY, maxY, cycleSize);
            StartThreads(threadsCount);
            JoinThreads(threadsCount);

            _finishTime = DateTime.Now;
            _durationOfProcess = _finishTime - _startTime;

            progressBar1.Value = 100;
            label13.Text = _startTime.ToString("HH:mm:ss.fff");
            label14.Text = _finishTime.ToString("HH:mm:ss.fff");
            label15.Text = _durationOfProcess.TotalMilliseconds.ToString("F3") + " мс";
        } catch (Exception ex) {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        AbortThreads(int.Parse(textBox5.Text));
        progressBar1.Value = 0;
    }
}