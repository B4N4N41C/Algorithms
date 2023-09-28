using Laba1_class_library_;
using System;
using System.Windows.Forms;

namespace Laba1_AlgorithmsForSortingLinearDataCollections_
{
    public partial class Form1 : Form
    {
        int[] arrayNoSort;
        int quantity;

        public Form1()
        {
            InitializeComponent();
        }

        private void Clean()
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void PrintOnTextBox(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                textBox1.Text += array[i] + " ";
                progressBar1.Value = i;
            }
        }

        private void ProgressBarBoundaries()
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = arrayNoSort.Length - 1;
        }

        private void TimerPrint(Timer timer, IStrategy typeSort)
        {
            textBox4.Text = timer.ToString();
            textBox5.Text = Convert.ToString(typeSort.OutComparisonCount());
            textBox6.Text = Convert.ToString(typeSort.OutReplacementCount());
        }

        //Random number generator
        private void button4_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
            quantity = int.Parse(textBox3.Text);
            arrayNoSort = new int[quantity];
            Random random = new Random();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = arrayNoSort.Length - 1;

            for (int i = 0; i < arrayNoSort.Length; i++)
            {
                arrayNoSort[i] = random.Next(0, 100);
                progressBar1.Value = i;
            }

        }

        //Output of the generated array
        private void button11_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = arrayNoSort.Length - 1;

            for (int i = 0; i < arrayNoSort.Length; i++)
            {
                textBox2.Text += arrayNoSort[i] + " ";
                progressBar1.Value = i;
            }
        }

        //Cocktail Sort
        private void button1_Click(object sender, EventArgs e)
        {
            Clean();

            Timer timer = new Timer();
            CocktailSort cocktailSort = new CocktailSort();

            ProgressBarBoundaries();

            timer.Start();
            int[] cloneArray = (int[])arrayNoSort.Clone();
            int[] returnArray = cocktailSort.Sort(cloneArray);
            timer.Stop();
            
            PrintOnTextBox(returnArray);

            TimerPrint(timer, cocktailSort);
        }

        //Gnome Sort
        private void button2_Click(object sender, EventArgs e)
        {
            Clean();

            Timer timer = new Timer();
            GnomeSort gnomeSort = new GnomeSort();

            ProgressBarBoundaries();

            timer.Start();
            int[] cloneArray = (int[])arrayNoSort.Clone();
            int[] returnArray = gnomeSort.Sort(cloneArray);
            timer.Stop();
            
            PrintOnTextBox(returnArray);

            TimerPrint(timer, gnomeSort);
        }

        //Merge Sort
        private void button3_Click(object sender, EventArgs e)
        {
            Clean();

            MergeSort mergeSort = new MergeSort();
            Timer timer = new Timer();

            ProgressBarBoundaries();

            timer.Start();
            int[] cloneArray = (int[])arrayNoSort.Clone();
            int[] returnArray = mergeSort.Sort(cloneArray);
            timer.Stop();
            
            PrintOnTextBox(returnArray);

            TimerPrint(timer, mergeSort);
        }

        //Bubble Sort
        private void button5_Click(object sender, EventArgs e)
        {
            Clean();

            BubbleSort bubbleSort = new BubbleSort();
            Timer timer = new Timer();

            ProgressBarBoundaries();

            timer.Start();
            int[] cloneArray = (int[])arrayNoSort.Clone();
            int[] returnArray = bubbleSort.Sort(cloneArray);
            timer.Stop();
            
            PrintOnTextBox(returnArray);

            TimerPrint(timer, bubbleSort);
        }

        //Insertion Sort
        private void button7_Click(object sender, EventArgs e)
        {
            Clean();

            InsertionSort insertionSort = new InsertionSort();
            Timer timer = new Timer();

            ProgressBarBoundaries();

            timer.Start();
            int[] cloneArray = (int[])arrayNoSort.Clone();
            int[] returnArray = insertionSort.Sort(cloneArray);
            timer.Stop();
            
            PrintOnTextBox(returnArray);

            TimerPrint(timer, insertionSort);
        }

        //Selection Sort
        private void button9_Click(object sender, EventArgs e)
        {
            Clean();

            SelectionSort selectionSort = new SelectionSort();
            Timer timer = new Timer();

            ProgressBarBoundaries();

            timer.Start();
            int[] cloneArray = (int[])arrayNoSort.Clone();
            int[] returnArray = selectionSort.Sort(cloneArray);
            timer.Stop();
            
            PrintOnTextBox(returnArray);

            TimerPrint(timer, selectionSort);
        }

        //Comb Sort
        private void button6_Click(object sender, EventArgs e)
        {
            Clean();

            CombSort combSort = new CombSort();
            Timer timer = new Timer();

            ProgressBarBoundaries();

            timer.Start();
            int[] cloneArray = (int[])arrayNoSort.Clone();
            int[] returnArray = combSort.Sort(cloneArray);
            timer.Stop();
            
            PrintOnTextBox(returnArray);

            TimerPrint(timer, combSort);
        }

        //Shell Sort
        private void button8_Click(object sender, EventArgs e)
        {
            Clean();

            ShellSort shellSort = new ShellSort();
            Timer timer = new Timer();

            ProgressBarBoundaries();

            timer.Start();
            int[] cloneArray = (int[])arrayNoSort.Clone();
            int[] returnArray = shellSort.Sort(cloneArray);
            timer.Stop();
            
            PrintOnTextBox(returnArray);

            TimerPrint(timer, shellSort);
        }

        //Counting Sort
        private void button10_Click(object sender, EventArgs e)
        {
            Clean();

            CountingSort countingSort = new CountingSort();
            Timer timer = new Timer();

            ProgressBarBoundaries();

            timer.Start();
            int[] cloneArray = (int[])arrayNoSort.Clone();
            int[] returnArray = countingSort.Sort(cloneArray);
            timer.Stop();
            
            PrintOnTextBox(returnArray);

            TimerPrint(timer, countingSort);
        }
    }
}