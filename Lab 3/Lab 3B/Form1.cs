/*
 * Andy Le
 * 000805099
 * Implementation of hair salon pricing GUI
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

namespace Lab_3B
{
    public partial class Form1 : Form
    {
        public double Cost { get; set; }

        /// <summary>
        /// Initialize Form Component and default parameters
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            dresser.SelectedIndex = 0;
        }

        private void janeSamleyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method to enable add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (services.SelectedIndex != -1)
            {
                add.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method to add selected choices to list and cost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            int tempPrice;
            int dresserPrice;
            if (dresser.SelectedIndex == 0)
            {
                dresserPrice = 30;
            }
            else if (dresser.SelectedIndex == 1)
            {
                dresserPrice = 45;
            }
            else if (dresser.SelectedIndex == 2)
            {
                dresserPrice = 40;
            }
            else if (dresser.SelectedIndex == 3)
            {
                dresserPrice = 50;
            }
            else
            {
                dresserPrice = 55;
            }
            if (dresser.Enabled)
            {
                dresser.Enabled = false;
                items.Items.Add(dresser.SelectedItem.ToString());
                prices.Items.Add($"{dresserPrice:C}");
                Cost += dresserPrice;
            }
            if (services.SelectedIndex == 0)
            {
                tempPrice = 30;
                Cost += 30;
            }
            else if (services.SelectedIndex == 1)
            {
                tempPrice = 20;
                Cost += 20;
            }
            else if (services.SelectedIndex == 2)
            {
                tempPrice = 40;
                Cost += 40;
            }
            else if (services.SelectedIndex == 3)
            {
                tempPrice = 50;
                Cost += 50;
            }
            else if (services.SelectedIndex == 4)
            {
                tempPrice = 200;
                Cost += 200;
            }
            else
            {
                tempPrice = 600;
                Cost += 60;
            }
            items.Items.Add(services.SelectedItem.ToString());
            prices.Items.Add($"{tempPrice:C}");
            calculate.Enabled = true;
        }

        private void dresser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method to calculate and display total cost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculate_Click(object sender, EventArgs e)
        {
            output.Text = $"{Cost:C}";
        }

        /// <summary>
        /// Method to reset the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            dresser.Enabled = true;
            add.Enabled = false;
            calculate.Enabled = false;
            output.Text = string.Empty;
            Cost = 0.0;
            dresser.SelectedIndex = 0;
            services.ClearSelected();
            items.Items.Clear();
            prices.Items.Clear();
            dresser.Focus();
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

        private void items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
