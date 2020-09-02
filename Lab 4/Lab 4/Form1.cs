/*
 * Andy Le
 * 000805099
 * Implementation of HTML tester
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        private Stack<Tag> tags = new Stack<Tag>();
        private StreamReader text;
        private DialogResult result;
        private string path;
        private FileInfo info;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens HTML document and reads the text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                fileChooser.Filter = "HTML files (*.html)|*.html";
                result = fileChooser.ShowDialog();
                path = fileChooser.FileName;
                info = new FileInfo(path);
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(path))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream input = new FileStream(path, FileMode.Open, FileAccess.Read);
                        text = new StreamReader(input);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                checkTag.Enabled = true;
            }

            label.Text = $"Loaded: {info.Name}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitTab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Determines if HTML tags are balanced
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            htmlText.Items.Clear();
            string line;
            string type = "opening";
            while ((line = text.ReadLine()) != null)
            {
                int start = -1;
                int end = -1;
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i].Equals('<'))
                    {
                        start = i;
                        if (line[i + 1].Equals('/'))
                        {
                            type = "closing";
                        }
                        else
                        {
                            type = "opening";
                        }
                    }
                    if (line[i].Equals('>'))
                    {
                        end = i;
                    }
                    if ((start != -1) && (end != -1))
                    {
                        string tempTag = line.Substring(start, end - start + 1);
                        if (tempTag.IndexOf(" ") != -1)
                        {
                            tempTag = tempTag.Substring(0, tempTag.IndexOf(" ")) + ">";
                        }
                        htmlText.Items.Add($"Found {type} tag: {tempTag}");
                        List<string> ignore = new List<string>();
                        ignore.Add("<img>");
                        ignore.Add("<br>");
                        ignore.Add("<hr>");
                        if (!(ignore.Contains(tempTag)))
                        {
                            if (type == "closing")
                            {
                                tempTag = tempTag.Remove(1, 1);
                            }
                            check(tempTag, type);
                        }
                        start = -1;
                        end = -1;
                    }
                }
            }
            if (tags.Count() == 0)
            {
                label.Text = $"{info.Name} has balanced tags";
            }
            else
            {
                label.Text = $"{info.Name} does not have balanced tags";
            }
        }

        public void check(string tempTag, string type)
        {
            if (type == "closing")
            {
                if ((tags.Peek().Type == "opening") && (tags.Peek().Text == tempTag.ToLower()))
                {
                    tags.Pop();
                }
            }
            else
            {
                tags.Push(new Lab_4.Tag { Text = tempTag.ToLower(), Type = type.ToLower() });
            }
        }
    }
}
