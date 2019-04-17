namespace Critical_path_is_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.next = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pre_input = new System.Windows.Forms.TextBox();
            this.num_pred = new System.Windows.Forms.Label();
            this.pre_AC = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pre_id = new System.Windows.Forms.TextBox();
            this.du_input = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Button();
            this.Duration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_input = new System.Windows.Forms.TextBox();
            this.N_predecessor = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AC_num = new System.Windows.Forms.Label();
            this.Num_AC = new System.Windows.Forms.TextBox();
            this.Ans = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.Highlight;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.next.Location = new System.Drawing.Point(354, 300);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(63, 37);
            this.next.TabIndex = 1;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.Location = new System.Drawing.Point(12, 301);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 37);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "To Show The Answer Press :";
            // 
            // Answer
            // 
            this.Answer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Answer.Location = new System.Drawing.Point(221, 16);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(64, 39);
            this.Answer.TabIndex = 7;
            this.Answer.Text = "Answer";
            this.Answer.UseVisualStyleBackColor = false;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 679);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "The Critical Path Is :";
            // 
            // pre_input
            // 
            this.pre_input.BackColor = System.Drawing.SystemColors.Window;
            this.pre_input.Enabled = false;
            this.pre_input.Location = new System.Drawing.Point(202, 144);
            this.pre_input.Name = "pre_input";
            this.pre_input.Size = new System.Drawing.Size(54, 20);
            this.pre_input.TabIndex = 23;
            this.pre_input.TextChanged += new System.EventHandler(this.pre_input_TextChanged);
            // 
            // num_pred
            // 
            this.num_pred.AutoSize = true;
            this.num_pred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_pred.ForeColor = System.Drawing.Color.DimGray;
            this.num_pred.Location = new System.Drawing.Point(40, 145);
            this.num_pred.Name = "num_pred";
            this.num_pred.Size = new System.Drawing.Size(156, 15);
            this.num_pred.TabIndex = 22;
            this.num_pred.Text = "Number Of  predecessors : ";
            // 
            // pre_AC
            // 
            this.pre_AC.AutoSize = true;
            this.pre_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_AC.ForeColor = System.Drawing.Color.DimGray;
            this.pre_AC.Location = new System.Drawing.Point(119, 173);
            this.pre_AC.Name = "pre_AC";
            this.pre_AC.Size = new System.Drawing.Size(77, 15);
            this.pre_AC.TabIndex = 25;
            this.pre_AC.Text = "Activity_1 ID :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox1.Location = new System.Drawing.Point(23, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 19);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Have predecessors.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // pre_id
            // 
            this.pre_id.Enabled = false;
            this.pre_id.Location = new System.Drawing.Point(202, 173);
            this.pre_id.Name = "pre_id";
            this.pre_id.Size = new System.Drawing.Size(54, 20);
            this.pre_id.TabIndex = 26;
            // 
            // du_input
            // 
            this.du_input.Location = new System.Drawing.Point(91, 83);
            this.du_input.Name = "du_input";
            this.du_input.Size = new System.Drawing.Size(54, 20);
            this.du_input.TabIndex = 20;
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.LightGreen;
            this.input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.input.Location = new System.Drawing.Point(328, 243);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(56, 29);
            this.input.TabIndex = 27;
            this.input.Text = "Next";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click_1);
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.ForeColor = System.Drawing.Color.DimGray;
            this.Duration.Location = new System.Drawing.Point(20, 90);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(65, 13);
            this.Duration.TabIndex = 19;
            this.Duration.Text = "Duration_1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(119, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "To add anthor Activity press :";
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(90, 57);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(54, 20);
            this.id_input.TabIndex = 18;
            // 
            // N_predecessor
            // 
            this.N_predecessor.BackColor = System.Drawing.Color.Snow;
            this.N_predecessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.N_predecessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_predecessor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.N_predecessor.Location = new System.Drawing.Point(228, 204);
            this.N_predecessor.Name = "N_predecessor";
            this.N_predecessor.Size = new System.Drawing.Size(51, 23);
            this.N_predecessor.TabIndex = 29;
            this.N_predecessor.Text = "Next";
            this.N_predecessor.UseVisualStyleBackColor = false;
            this.N_predecessor.Click += new System.EventHandler(this.N_predecessor_Click_1);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.ForeColor = System.Drawing.Color.DimGray;
            this.ID.Location = new System.Drawing.Point(35, 60);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(33, 13);
            this.ID.TabIndex = 17;
            this.ID.Text = "ID_1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(20, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "To add anthor predecessor press :";
            // 
            // AC_num
            // 
            this.AC_num.AutoSize = true;
            this.AC_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AC_num.ForeColor = System.Drawing.Color.DimGray;
            this.AC_num.Location = new System.Drawing.Point(15, 16);
            this.AC_num.Name = "AC_num";
            this.AC_num.Size = new System.Drawing.Size(134, 16);
            this.AC_num.TabIndex = 15;
            this.AC_num.Text = "Number Of Activities :";
            // 
            // Num_AC
            // 
            this.Num_AC.Location = new System.Drawing.Point(155, 15);
            this.Num_AC.Name = "Num_AC";
            this.Num_AC.Size = new System.Drawing.Size(54, 20);
            this.Num_AC.TabIndex = 16;
            this.Num_AC.TextChanged += new System.EventHandler(this.Num_AC_TextChanged_1);
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Ans.Location = new System.Drawing.Point(19, 93);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(147, 20);
            this.Ans.TabIndex = 9;
            this.Ans.Text = "The Critical Path is !";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(198, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.AC_num);
            this.panel1.Controls.Add(this.Num_AC);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.N_predecessor);
            this.panel1.Controls.Add(this.input);
            this.panel1.Controls.Add(this.num_pred);
            this.panel1.Controls.Add(this.pre_AC);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.id_input);
            this.panel1.Controls.Add(this.Duration);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pre_id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pre_input);
            this.panel1.Controls.Add(this.du_input);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 282);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Ans);
            this.panel2.Controls.Add(this.Answer);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 282);
            this.panel2.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(452, 352);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.next);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CPM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Ans;
        private System.Windows.Forms.TextBox Num_AC;
        private System.Windows.Forms.Label AC_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button N_predecessor;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.TextBox du_input;
        private System.Windows.Forms.TextBox pre_id;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label num_pred;
        private System.Windows.Forms.TextBox pre_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label pre_AC;
        private System.Windows.Forms.Panel panel2;
    }
}

