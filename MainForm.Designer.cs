namespace ProgrammingTechnologiesLaboratoryWork5;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        label1 = new Label();
        textBox1 = new TextBox();
        progressBar1 = new ProgressBar();
        button1 = new Button();
        textBox2 = new TextBox();
        label2 = new Label();
        textBox3 = new TextBox();
        label3 = new Label();
        textBox4 = new TextBox();
        label4 = new Label();
        textBox5 = new TextBox();
        label5 = new Label();
        textBox6 = new TextBox();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        button2 = new Button();
        label15 = new Label();
        label16 = new Label();
        SuspendLayout();

        // label1
        label1.AutoSize = true;
        label1.Location = new Point(570, 9);
        label1.Name = "label1";
        label1.Size = new Size(122, 13);
        label1.TabIndex = 0;
        label1.Text = "Начальное значение X";

        // textBox1
        textBox1.Location = new Point(592, 25);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 20);
        textBox1.TabIndex = 1;
        textBox1.Text = "1";

        // progressBar1
        progressBar1.Location = new Point(15, 219);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(1037, 23);
        progressBar1.TabIndex = 2;

        // button1
        button1.Location = new Point(977, 646);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 3;
        button1.Text = "Запуск";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;

        // textBox2
        textBox2.Location = new Point(592, 64);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(100, 20);
        textBox2.TabIndex = 5;
        textBox2.Text = "5";

        // label2
        label2.AutoSize = true;
        label2.Location = new Point(570, 48);
        label2.Name = "label2";
        label2.Size = new Size(122, 13);
        label2.TabIndex = 4;
        label2.Text = "Начальное значение Y";

        // textBox3
        textBox3.Location = new Point(755, 64);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(100, 20);
        textBox3.TabIndex = 9;
        textBox3.Text = "50";

        // label3
        label3.AutoSize = true;
        label3.Location = new Point(740, 48);
        label3.Name = "label3";
        label3.Size = new Size(115, 13);
        label3.TabIndex = 8;
        label3.Text = "Конечное значение Y";

        // textBox4
        textBox4.Location = new Point(755, 25);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(100, 20);
        textBox4.TabIndex = 7;
        textBox4.Text = "10";

        // label4
        label4.AutoSize = true;
        label4.Location = new Point(740, 9);
        label4.Name = "label4";
        label4.Size = new Size(115, 13);
        label4.TabIndex = 6;
        label4.Text = "Конечное значение X";

        // textBox5
        textBox5.Location = new Point(592, 103);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(100, 20);
        textBox5.TabIndex = 11;
        textBox5.Text = "4";

        // label5
        label5.AutoSize = true;
        label5.Location = new Point(570, 87);
        label5.Name = "label5";
        label5.Size = new Size(107, 13);
        label5.TabIndex = 10;
        label5.Text = "Количество потоков";

        // textBox6
        textBox6.Location = new Point(755, 103);
        textBox6.Name = "textBox6";
        textBox6.Size = new Size(100, 20);
        textBox6.TabIndex = 13;
        textBox6.Text = "100";

        // label6
        label6.AutoSize = true;
        label6.Location = new Point(740, 87);
        label6.Name = "label6";
        label6.Size = new Size(99, 13);
        label6.TabIndex = 12;
        label6.Text = "Размер массивов";

        // label7
        label7.AutoSize = true;
        label7.Location = new Point(12, 9);
        label7.Name = "label7";
        label7.Size = new Size(35, 13);
        label7.TabIndex = 14;
        label7.Text = "Время запуска:";

        // label8
        label8.AutoSize = true;
        label8.Location = new Point(12, 48);
        label8.Name = "label8";
        label8.Size = new Size(35, 13);
        label8.TabIndex = 15;
        label8.Text = "Время завершения:";

        // label9
        label9.AutoSize = true;
        label9.Location = new Point(12, 87);
        label9.Name = "label9";
        label9.Size = new Size(35, 13);
        label9.TabIndex = 16;
        label9.Text = "Длительность:";

        // label13
        label13.AutoSize = true;
        label13.Location = new Point(53, 9);
        label13.Name = "label13";
        label13.Size = new Size(0, 13);
        label13.TabIndex = 20;

        // label14
        label14.AutoSize = true;
        label14.Location = new Point(53, 48);
        label14.Name = "label14";
        label14.Size = new Size(0, 13);
        label14.TabIndex = 21;

        // label15
        label15.AutoSize = true;
        label15.Location = new Point(53, 87);
        label15.Name = "label15";
        label15.Size = new Size(0, 13);
        label15.TabIndex = 22;

        // button2
        button2.Location = new Point(896, 646);
        button2.Name = "button2";
        button2.Size = new Size(75, 23);
        button2.TabIndex = 23;
        button2.Text = "Стоп";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;

        // MainForm
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1064, 681);
        Controls.Add(button2);
        Controls.Add(label15);
        Controls.Add(label14);
        Controls.Add(label13);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(textBox6);
        Controls.Add(label6);
        Controls.Add(textBox5);
        Controls.Add(label5);
        Controls.Add(textBox3);
        Controls.Add(label3);
        Controls.Add(textBox4);
        Controls.Add(label4);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(button1);
        Controls.Add(progressBar1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "MainForm";
        Text = "Лабораторная работа 5";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private TextBox textBox1;
    private ProgressBar progressBar1;
    private Button button1;
    private TextBox textBox2;
    private Label label2;
    private TextBox textBox3;
    private Label label3;
    private TextBox textBox4;
    private Label label4;
    private TextBox textBox5;
    private Label label5;
    private TextBox textBox6;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private Label label15;
    private Label label16;
    private Button button2;
} 