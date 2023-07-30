namespace Hierarchical_Community
{
    partial class Main
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
            this.Dataset_Cmbo = new System.Windows.Forms.ComboBox();
            this.Run_Btn = new System.Windows.Forms.Button();
            this.Read_Btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Time_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NMI_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mod_Txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dataset_Cmbo);
            this.groupBox1.Controls.Add(this.Run_Btn);
            this.groupBox1.Controls.Add(this.Read_Btn);
            this.groupBox1.Location = new System.Drawing.Point(31, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // Dataset_Cmbo
            // 
            this.Dataset_Cmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dataset_Cmbo.FormattingEnabled = true;
            this.Dataset_Cmbo.Items.AddRange(new object[] {
            "karate",
            "dolphins"});
            this.Dataset_Cmbo.Location = new System.Drawing.Point(74, 40);
            this.Dataset_Cmbo.Name = "Dataset_Cmbo";
            this.Dataset_Cmbo.Size = new System.Drawing.Size(94, 21);
            this.Dataset_Cmbo.TabIndex = 1;
            // 
            // Run_Btn
            // 
            this.Run_Btn.Location = new System.Drawing.Point(56, 134);
            this.Run_Btn.Name = "Run_Btn";
            this.Run_Btn.Size = new System.Drawing.Size(127, 31);
            this.Run_Btn.TabIndex = 1;
            this.Run_Btn.Text = "Run";
            this.Run_Btn.UseVisualStyleBackColor = true;
            this.Run_Btn.Click += new System.EventHandler(this.Run_Btn_Click);
            // 
            // Read_Btn
            // 
            this.Read_Btn.Location = new System.Drawing.Point(56, 82);
            this.Read_Btn.Name = "Read_Btn";
            this.Read_Btn.Size = new System.Drawing.Size(127, 32);
            this.Read_Btn.TabIndex = 2;
            this.Read_Btn.Text = "Read Dataset";
            this.Read_Btn.UseVisualStyleBackColor = true;
            this.Read_Btn.Click += new System.EventHandler(this.Read_Btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Time_Txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Mod_Txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NMI_Txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(338, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // Time_Txt
            // 
            this.Time_Txt.BackColor = System.Drawing.Color.LightGray;
            this.Time_Txt.Enabled = false;
            this.Time_Txt.Location = new System.Drawing.Point(76, 134);
            this.Time_Txt.Name = "Time_Txt";
            this.Time_Txt.Size = new System.Drawing.Size(73, 20);
            this.Time_Txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time:";
            // 
            // NMI_Txt
            // 
            this.NMI_Txt.BackColor = System.Drawing.Color.LightGray;
            this.NMI_Txt.Enabled = false;
            this.NMI_Txt.Location = new System.Drawing.Point(76, 45);
            this.NMI_Txt.Name = "NMI_Txt";
            this.NMI_Txt.Size = new System.Drawing.Size(73, 20);
            this.NMI_Txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NMI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Modularity:";
            // 
            // Mod_Txt
            // 
            this.Mod_Txt.BackColor = System.Drawing.Color.LightGray;
            this.Mod_Txt.Enabled = false;
            this.Mod_Txt.Location = new System.Drawing.Point(76, 89);
            this.Mod_Txt.Name = "Mod_Txt";
            this.Mod_Txt.Size = new System.Drawing.Size(73, 20);
            this.Mod_Txt.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Read_Btn;
        private System.Windows.Forms.Button Run_Btn;
        private System.Windows.Forms.ComboBox Dataset_Cmbo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NMI_Txt;
        private System.Windows.Forms.TextBox Time_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mod_Txt;
        private System.Windows.Forms.Label label3;
    }
}

