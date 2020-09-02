namespace Lab_3B
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dresser = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.services = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.items = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.prices = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dresser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hairdresser:";
            // 
            // dresser
            // 
            this.dresser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dresser.FormattingEnabled = true;
            this.dresser.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laura Renkins"});
            this.dresser.Location = new System.Drawing.Point(6, 25);
            this.dresser.Name = "dresser";
            this.dresser.Size = new System.Drawing.Size(188, 28);
            this.dresser.TabIndex = 0;
            this.dresser.SelectedIndexChanged += new System.EventHandler(this.dresser_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.services);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service:";
            // 
            // services
            // 
            this.services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.services.FormattingEnabled = true;
            this.services.ItemHeight = 20;
            this.services.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extensions",
            "Up-do"});
            this.services.Location = new System.Drawing.Point(6, 25);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(188, 164);
            this.services.TabIndex = 0;
            this.services.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.items);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged Items:";
            // 
            // items
            // 
            this.items.Enabled = false;
            this.items.FormattingEnabled = true;
            this.items.ItemHeight = 20;
            this.items.Location = new System.Drawing.Point(6, 25);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(188, 164);
            this.items.TabIndex = 0;
            this.items.SelectedIndexChanged += new System.EventHandler(this.items_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.prices);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(630, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 200);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price:";
            // 
            // prices
            // 
            this.prices.Enabled = false;
            this.prices.FormattingEnabled = true;
            this.prices.ItemHeight = 20;
            this.prices.Location = new System.Drawing.Point(9, 25);
            this.prices.Name = "prices";
            this.prices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prices.Size = new System.Drawing.Size(85, 164);
            this.prices.TabIndex = 0;
            // 
            // add
            // 
            this.add.Enabled = false;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add.Location = new System.Drawing.Point(207, 269);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 30);
            this.add.TabIndex = 4;
            this.add.Text = "Add Service";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // calculate
            // 
            this.calculate.Enabled = false;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculate.Location = new System.Drawing.Point(338, 269);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(125, 30);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate Total";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reset.Location = new System.Drawing.Point(469, 269);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(125, 30);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exit.Location = new System.Drawing.Point(600, 269);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 30);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.output.Location = new System.Drawing.Point(640, 226);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(85, 30);
            this.output.TabIndex = 8;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(509, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox services;
        private System.Windows.Forms.ListBox items;
        private System.Windows.Forms.ListBox prices;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dresser;
    }
}

