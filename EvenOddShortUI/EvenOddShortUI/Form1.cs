using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenOddShortUI
{
    public partial class Form1 : Form
    {
        int oddCounter = 0;
        int evenCounter = 0;
        int showAllArrayIndex = 0;
        int []oddArray=new int[5];
        int []evenArray=new int[5];
        int []showAllArray=new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberTextBox.Text);
            if (number%2 == 0)
            {
                if (evenCounter < evenArray.Length)
                {
                    evenArray[evenCounter] = number;
                    
                    numberTextBox.Text = "";
                }
                evenCounter++;
                if (evenCounter > evenArray.Length)
                {
                    MessageBox.Show("Index of evennumber fillup !");
                }
            }

            if(number%2!=0)
            {
                if (oddCounter < oddArray.Length)
                {
                    oddArray[oddCounter] = number;

                    numberTextBox.Text = "";
                }
                oddCounter++;
                if (oddCounter > oddArray.Length)
                {
                    MessageBox.Show("Index of oddnumber fillup !");
                }
            }
        }

        private void oddButton_Click(object sender, EventArgs e)
        {
            string oddnumbers = "";
            Array.Sort(oddArray);
            for (int i = 0; i < oddArray.Length; i++)
            {
                oddnumbers = oddnumbers + oddArray[i].ToString()+"\n";
            }
            MessageBox.Show("Odd numbers"+"\n-------------\n"+oddnumbers);
        }

        private void evenButton_Click(object sender, EventArgs e)
        {
            string evennumbers = "";
            Array.Sort(evenArray);
            for (int i = 0; i < evenArray.Length; i++)
            {
                evennumbers = evennumbers + evenArray[i].ToString()+"\n";
            }
            MessageBox.Show("Even numbers" + "\n-------------\n" + evennumbers);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string showAllnumbers = "";
            for (int i = 0; i < evenArray.Length; i++)
            {
                showAllArray[i] = evenArray[i];
                showAllArrayIndex++;

            }
            for (int i = 0; i < oddArray.Length; i++)
            {
                showAllArray[showAllArrayIndex] = oddArray[i];
                showAllArrayIndex++;
            }

            Array.Sort(showAllArray);

            for (int i = 0; i < showAllArray.Length; i++)
            {
                showAllnumbers = showAllnumbers + showAllArray[i] + "\n";
            }

            MessageBox.Show("All numbers"+"\n----------------\n"+showAllnumbers);
        }
    }
}
