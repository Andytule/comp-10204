namespace Lab_2B
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
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.names = new System.Windows.Forms.GroupBox();
            this.name5 = new System.Windows.Forms.RadioButton();
            this.name4 = new System.Windows.Forms.RadioButton();
            this.name3 = new System.Windows.Forms.RadioButton();
            this.name2 = new System.Windows.Forms.RadioButton();
            this.name1 = new System.Windows.Forms.RadioButton();
            this.services = new System.Windows.Forms.GroupBox();
            this.extensions = new System.Windows.Forms.CheckBox();
            this.highlights = new System.Windows.Forms.CheckBox();
            this.colour = new System.Windows.Forms.CheckBox();
            this.cut = new System.Windows.Forms.CheckBox();
            this.type = new System.Windows.Forms.GroupBox();
            this.type4 = new System.Windows.Forms.RadioButton();
            this.type3 = new System.Windows.Forms.RadioButton();
            this.type2 = new System.Windows.Forms.RadioButton();
            this.type1 = new System.Windows.Forms.RadioButton();
            this.visits = new System.Windows.Forms.GroupBox();
            this.input = new System.Windows.Forms.TextBox();
            this.title1 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.names.SuspendLayout();
            this.services.SuspendLayout();
            this.type.SuspendLayout();
            this.visits.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(25, 426);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(185, 426);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(325, 426);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // names
            // 
            this.names.Controls.Add(this.name5);
            this.names.Controls.Add(this.name4);
            this.names.Controls.Add(this.name3);
            this.names.Controls.Add(this.name2);
            this.names.Controls.Add(this.name1);
            this.names.Location = new System.Drawing.Point(25, 25);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(200, 200);
            this.names.TabIndex = 6;
            this.names.TabStop = false;
            this.names.Text = "Hairdresser";
            // 
            // name5
            // 
            this.name5.AutoSize = true;
            this.name5.Location = new System.Drawing.Point(25, 165);
            this.name5.Name = "name5";
            this.name5.Size = new System.Drawing.Size(94, 17);
            this.name5.TabIndex = 4;
            this.name5.Text = "Laura Renkins";
            this.name5.UseVisualStyleBackColor = true;
            // 
            // name4
            // 
            this.name4.AutoSize = true;
            this.name4.Location = new System.Drawing.Point(25, 130);
            this.name4.Name = "name4";
            this.name4.Size = new System.Drawing.Size(76, 17);
            this.name4.TabIndex = 3;
            this.name4.Text = "Sue Pallon";
            this.name4.UseVisualStyleBackColor = true;
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Location = new System.Drawing.Point(25, 95);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(89, 17);
            this.name3.TabIndex = 2;
            this.name3.Text = "Ron Chamers";
            this.name3.UseVisualStyleBackColor = true;
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Location = new System.Drawing.Point(25, 60);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(84, 17);
            this.name2.TabIndex = 1;
            this.name2.Text = "Pat Johnson";
            this.name2.UseVisualStyleBackColor = true;
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Checked = true;
            this.name1.Location = new System.Drawing.Point(25, 25);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(85, 17);
            this.name1.TabIndex = 0;
            this.name1.TabStop = true;
            this.name1.Text = "Jane Samley";
            this.name1.UseVisualStyleBackColor = true;
            // 
            // services
            // 
            this.services.Controls.Add(this.extensions);
            this.services.Controls.Add(this.highlights);
            this.services.Controls.Add(this.colour);
            this.services.Controls.Add(this.cut);
            this.services.Location = new System.Drawing.Point(250, 25);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(150, 160);
            this.services.TabIndex = 7;
            this.services.TabStop = false;
            this.services.Text = "Services";
            // 
            // extensions
            // 
            this.extensions.AutoSize = true;
            this.extensions.Location = new System.Drawing.Point(25, 130);
            this.extensions.Name = "extensions";
            this.extensions.Size = new System.Drawing.Size(77, 17);
            this.extensions.TabIndex = 3;
            this.extensions.Text = "Extensions";
            this.extensions.UseVisualStyleBackColor = true;
            this.extensions.CheckedChanged += new System.EventHandler(this.extensions_CheckedChanged);
            // 
            // highlights
            // 
            this.highlights.AutoSize = true;
            this.highlights.Location = new System.Drawing.Point(25, 95);
            this.highlights.Name = "highlights";
            this.highlights.Size = new System.Drawing.Size(75, 17);
            this.highlights.TabIndex = 2;
            this.highlights.Text = "Hightlights";
            this.highlights.UseVisualStyleBackColor = true;
            this.highlights.CheckedChanged += new System.EventHandler(this.highlights_CheckedChanged);
            // 
            // colour
            // 
            this.colour.AutoSize = true;
            this.colour.Location = new System.Drawing.Point(25, 60);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(56, 17);
            this.colour.TabIndex = 1;
            this.colour.Text = "Colour";
            this.colour.UseVisualStyleBackColor = true;
            this.colour.CheckedChanged += new System.EventHandler(this.colour_CheckedChanged);
            // 
            // cut
            // 
            this.cut.AutoSize = true;
            this.cut.Location = new System.Drawing.Point(25, 25);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(42, 17);
            this.cut.TabIndex = 0;
            this.cut.Text = "Cut";
            this.cut.UseVisualStyleBackColor = true;
            this.cut.CheckedChanged += new System.EventHandler(this.cut_CheckedChanged);
            // 
            // type
            // 
            this.type.Controls.Add(this.type4);
            this.type.Controls.Add(this.type3);
            this.type.Controls.Add(this.type2);
            this.type.Controls.Add(this.type1);
            this.type.Location = new System.Drawing.Point(25, 250);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(200, 160);
            this.type.TabIndex = 8;
            this.type.TabStop = false;
            this.type.Text = "Client Type";
            this.type.Enter += new System.EventHandler(this.type_Enter);
            // 
            // type4
            // 
            this.type4.AutoSize = true;
            this.type4.Location = new System.Drawing.Point(25, 130);
            this.type4.Name = "type4";
            this.type4.Size = new System.Drawing.Size(100, 17);
            this.type4.TabIndex = 3;
            this.type4.Text = "Senior (over 65)";
            this.type4.UseVisualStyleBackColor = true;
            // 
            // type3
            // 
            this.type3.AutoSize = true;
            this.type3.Location = new System.Drawing.Point(25, 95);
            this.type3.Name = "type3";
            this.type3.Size = new System.Drawing.Size(62, 17);
            this.type3.TabIndex = 2;
            this.type3.Text = "Student";
            this.type3.UseVisualStyleBackColor = true;
            // 
            // type2
            // 
            this.type2.AutoSize = true;
            this.type2.Location = new System.Drawing.Point(25, 60);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(120, 17);
            this.type2.TabIndex = 1;
            this.type2.Text = "Child (12 and under)";
            this.type2.UseVisualStyleBackColor = true;
            // 
            // type1
            // 
            this.type1.AutoSize = true;
            this.type1.Checked = true;
            this.type1.Location = new System.Drawing.Point(25, 25);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(95, 17);
            this.type1.TabIndex = 0;
            this.type1.TabStop = true;
            this.type1.Text = "Standard Adult";
            this.type1.UseVisualStyleBackColor = true;
            // 
            // visits
            // 
            this.visits.Controls.Add(this.input);
            this.visits.Controls.Add(this.title1);
            this.visits.Location = new System.Drawing.Point(250, 205);
            this.visits.Name = "visits";
            this.visits.Size = new System.Drawing.Size(150, 100);
            this.visits.TabIndex = 9;
            this.visits.TabStop = false;
            this.visits.Text = "Client Visits";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(15, 60);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 1;
            this.input.Validating += new System.ComponentModel.CancelEventHandler(this.input_Validating);
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Location = new System.Drawing.Point(15, 25);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(115, 13);
            this.title1.TabIndex = 0;
            this.title1.Text = "Number of Client Visits:";
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Location = new System.Drawing.Point(250, 350);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(64, 13);
            this.title2.TabIndex = 10;
            this.title2.Text = "Total Price: ";
            this.title2.Click += new System.EventHandler(this.title2_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(325, 350);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.output);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.visits);
            this.Controls.Add(this.type);
            this.Controls.Add(this.services);
            this.Controls.Add(this.names);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.names.ResumeLayout(false);
            this.names.PerformLayout();
            this.services.ResumeLayout(false);
            this.services.PerformLayout();
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            this.visits.ResumeLayout(false);
            this.visits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox names;
        private System.Windows.Forms.RadioButton name5;
        private System.Windows.Forms.RadioButton name4;
        private System.Windows.Forms.RadioButton name3;
        private System.Windows.Forms.RadioButton name2;
        private System.Windows.Forms.RadioButton name1;
        private System.Windows.Forms.GroupBox services;
        private System.Windows.Forms.CheckBox extensions;
        private System.Windows.Forms.CheckBox highlights;
        private System.Windows.Forms.CheckBox colour;
        private System.Windows.Forms.CheckBox cut;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.RadioButton type1;
        private System.Windows.Forms.RadioButton type4;
        private System.Windows.Forms.RadioButton type3;
        private System.Windows.Forms.RadioButton type2;
        private System.Windows.Forms.GroupBox visits;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label output;
    }
}

