/*
 * Andy Le
 * 000805099
 * Part 3
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3
{
    public partial class Form1 : Form
    {
        public string Expression { get; set; }
        public int Counter { get; set; }
        Stack<char> item = new Stack<char>();
        public int Answer { get; set; }
        public Form1()
        {
            InitializeComponent();
            Counter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
            {
                MessageBox.Show("Empty Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Expression = input.Text;
                while (Counter < Expression.Length)
                {
                    char x = char.Parse(Expression.Substring(Counter, 1));
                    Console.WriteLine(x);

                    if (x == '+')
                    {

                    }
                    else if (x == '-')
                    {

                    }
                    else if (x == '*')
                    {

                    }
                    else if (x == '/')
                    {

                    }
                    else
                    {
                        item.Push(x);
                    }
                    Counter++;
                }
            }
            output.Text = $"The answer to the expression {Expression} is {Answer}";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
