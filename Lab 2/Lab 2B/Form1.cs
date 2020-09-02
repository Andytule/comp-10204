/*
 * Andy Le
 * 000805099
 * Implementation of a form that detrermines pricing for a hair salon
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

namespace Lab_2B
{
    public partial class Form1 : Form
    {
        private double Dresser { get; set; }
        private double Serve { get; set; }
        private double Type { get; set; }
        private double Discount { get; set; }

        /// <summary>
        /// Initialize Form Component and default parameters
        /// </summary>
        public Form1()
        {
            Dresser = 30;
            Serve = 0;
            Type = 1;
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void type_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method that runs when calculate button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculate_Click(object sender, EventArgs e)
        {
            int i;
            bool isNumeric = int.TryParse(input.Text, out i);
            if ((cut.Checked != true) && (colour.Checked != true) && (highlights.Checked != true) && (extensions.Checked != true))
            {
                MessageBox.Show("You must select at least one service", "Mssing Service(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((input.Text == string.Empty) || (isNumeric == false) || (i < 1))
            {
                MessageBox.Show("Number of Visits must be an integer greater than 0", "Incorrect Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Hairdresser
                if (name1.Checked)
                {
                    Dresser = 30;
                }
                else if (name2.Checked)
                {
                    Dresser = 45;
                }
                else if (name3.Checked)
                {
                    Dresser = 40;
                }
                else if (name4.Checked)
                {
                    Dresser = 50;
                }
                else if (name5.Checked)
                {
                    Dresser = 55;
                }

                // Client Type
                if (type1.Checked)
                {
                    Type = 0;
                }
                else if (type2.Checked)
                {
                    Type = 10;
                }
                else if (type3.Checked)
                {
                    Type = 5;
                }
                else if (type4.Checked)
                {
                    Type = 15;
                }

                // Services
                

                // Visits Discount
                if (i < 4)
                {
                    Discount = 0;
                }
                else if (i < 9)
                {
                    Discount = 5;
                }
                else if (i < 14)
                {
                    Discount = 10;
                }
                else
                {
                    Discount = 15;
                }

                output.Text = $"{(Dresser + Serve) * (1 - ((Type + Discount) / 100)):F}";
            }

        }

        /// <summary>
        /// Method to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void input_Validating(object sender, CancelEventArgs e)
        {

        }

        /// <summary>
        /// Method to update price for cut service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cut_CheckedChanged(object sender, EventArgs e)
        {
            if (cut.Checked == true)
            {
                Serve += 30;
            }
            else
            {
                Serve -= 30;
            }
        }

        /// <summary>
        /// Method to clear form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = String.Empty;
            output.Text = String.Empty;
            cut.Checked = false;
            colour.Checked = false;
            highlights.Checked = false;
            extensions.Checked = false;
            name1.Checked = true;
            type1.Checked = true;
        }

        /// <summary>
        /// Method to update price for colour service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colour_CheckedChanged(object sender, EventArgs e)
        {
            if (colour.Checked == true)
            {
                Serve += 40;
            }
            else
            {
                Serve -= 40;
            }
        }

        /// <summary>
        /// Method to update price for highlights service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highlights_CheckedChanged(object sender, EventArgs e)
        {
            if (highlights.Checked == true)
            {
                Serve += 50;
            }
            else
            {
                Serve -= 50;
            }
        }

        /// <summary>
        /// Method to update price for extensions service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void extensions_CheckedChanged(object sender, EventArgs e)
        {
            if (extensions.Checked == true)
            {
                Serve += 200;
            }
            else
            {
                Serve -= 200;
            }
        }

        private void title2_Click(object sender, EventArgs e)
        {

        }
    }
}
