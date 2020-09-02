using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Color Liquid { get; set; }
        public Form1()
        {
            Liquid = Color.Blue;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                Liquid = colorDialog1.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Graphics myGraphics = base.CreateGraphics())

            using (Pen myPen = new Pen(Color.DarkRed))

            using (SolidBrush mySolidBrush = new SolidBrush(Color.DarkRed))
            {
                myGraphics.Clear(Color.White);
                myGraphics.DrawRectangle(myPen, 50, 50, 100, 100);
            }
        }
    }
}
