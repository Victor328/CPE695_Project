namespace CPE695_Project
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_epsilon = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton_false = new System.Windows.Forms.RadioButton();
            this.radioButton_true = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_unknown = new System.Windows.Forms.RadioButton();
            this.radioButton_intervened = new System.Windows.Forms.RadioButton();
            this.radioButton_observed = new System.Windows.Forms.RadioButton();
            this.radioButton_target = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textbox_epsilon);
            this.groupBox1.Location = new System.Drawing.Point(766, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate Network";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "input.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ε";
            // 
            // textbox_epsilon
            // 
            this.textbox_epsilon.Location = new System.Drawing.Point(88, 33);
            this.textbox_epsilon.Name = "textbox_epsilon";
            this.textbox_epsilon.Size = new System.Drawing.Size(104, 22);
            this.textbox_epsilon.TabIndex = 0;
            this.textbox_epsilon.Text = "0.2";
            this.textbox_epsilon.TextChanged += new System.EventHandler(this.textbox_epsilon_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_result);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(766, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculation";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton_false);
            this.groupBox4.Controls.Add(this.radioButton_true);
            this.groupBox4.Location = new System.Drawing.Point(13, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(97, 75);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Value";
            // 
            // radioButton_false
            // 
            this.radioButton_false.AutoSize = true;
            this.radioButton_false.Location = new System.Drawing.Point(27, 48);
            this.radioButton_false.Name = "radioButton_false";
            this.radioButton_false.Size = new System.Drawing.Size(63, 21);
            this.radioButton_false.TabIndex = 5;
            this.radioButton_false.TabStop = true;
            this.radioButton_false.Text = "False";
            this.radioButton_false.UseVisualStyleBackColor = true;
            this.radioButton_false.CheckedChanged += new System.EventHandler(this.radioButton_false_CheckedChanged);
            // 
            // radioButton_true
            // 
            this.radioButton_true.AutoSize = true;
            this.radioButton_true.Location = new System.Drawing.Point(27, 21);
            this.radioButton_true.Name = "radioButton_true";
            this.radioButton_true.Size = new System.Drawing.Size(59, 21);
            this.radioButton_true.TabIndex = 4;
            this.radioButton_true.TabStop = true;
            this.radioButton_true.Text = "True";
            this.radioButton_true.UseVisualStyleBackColor = true;
            this.radioButton_true.CheckedChanged += new System.EventHandler(this.radioButton_true_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_unknown);
            this.groupBox3.Controls.Add(this.radioButton_intervened);
            this.groupBox3.Controls.Add(this.radioButton_observed);
            this.groupBox3.Controls.Add(this.radioButton_target);
            this.groupBox3.Location = new System.Drawing.Point(13, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 134);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event Type";
            // 
            // radioButton_unknown
            // 
            this.radioButton_unknown.AutoSize = true;
            this.radioButton_unknown.Location = new System.Drawing.Point(27, 102);
            this.radioButton_unknown.Name = "radioButton_unknown";
            this.radioButton_unknown.Size = new System.Drawing.Size(85, 21);
            this.radioButton_unknown.TabIndex = 3;
            this.radioButton_unknown.TabStop = true;
            this.radioButton_unknown.Text = "unknown";
            this.radioButton_unknown.UseVisualStyleBackColor = true;
            this.radioButton_unknown.CheckedChanged += new System.EventHandler(this.radioButton_unknown_CheckedChanged);
            // 
            // radioButton_intervened
            // 
            this.radioButton_intervened.AutoSize = true;
            this.radioButton_intervened.Location = new System.Drawing.Point(27, 75);
            this.radioButton_intervened.Name = "radioButton_intervened";
            this.radioButton_intervened.Size = new System.Drawing.Size(96, 21);
            this.radioButton_intervened.TabIndex = 2;
            this.radioButton_intervened.TabStop = true;
            this.radioButton_intervened.Text = "Intervened";
            this.radioButton_intervened.UseVisualStyleBackColor = true;
            this.radioButton_intervened.CheckedChanged += new System.EventHandler(this.radioButton_intervened_CheckedChanged);
            // 
            // radioButton_observed
            // 
            this.radioButton_observed.AutoSize = true;
            this.radioButton_observed.Location = new System.Drawing.Point(27, 48);
            this.radioButton_observed.Name = "radioButton_observed";
            this.radioButton_observed.Size = new System.Drawing.Size(91, 21);
            this.radioButton_observed.TabIndex = 1;
            this.radioButton_observed.TabStop = true;
            this.radioButton_observed.Text = "Observed";
            this.radioButton_observed.UseVisualStyleBackColor = true;
            this.radioButton_observed.CheckedChanged += new System.EventHandler(this.radioButton_observed_CheckedChanged);
            // 
            // radioButton_target
            // 
            this.radioButton_target.AutoSize = true;
            this.radioButton_target.Location = new System.Drawing.Point(27, 21);
            this.radioButton_target.Name = "radioButton_target";
            this.radioButton_target.Size = new System.Drawing.Size(144, 21);
            this.radioButton_target.TabIndex = 0;
            this.radioButton_target.TabStop = true;
            this.radioButton_target.Text = "Calculation Target";
            this.radioButton_target.UseVisualStyleBackColor = true;
            this.radioButton_target.CheckedChanged += new System.EventHandler(this.radioButton_target_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input Path";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(8, 262);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(108, 25);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "P=0.00000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CPE 695";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_epsilon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton_false;
        private System.Windows.Forms.RadioButton radioButton_true;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_unknown;
        private System.Windows.Forms.RadioButton radioButton_intervened;
        private System.Windows.Forms.RadioButton radioButton_observed;
        private System.Windows.Forms.RadioButton radioButton_target;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_result;
    }
}

