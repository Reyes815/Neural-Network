namespace NeuralNetworks
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
            this.input_txt1 = new System.Windows.Forms.TextBox();
            this.input_txt2 = new System.Windows.Forms.TextBox();
            this.Create_BPNNBtn = new System.Windows.Forms.Button();
            this.Train_Btn = new System.Windows.Forms.Button();
            this.Test_Btn = new System.Windows.Forms.Button();
            this.input_txt4 = new System.Windows.Forms.TextBox();
            this.input_txt3 = new System.Windows.Forms.TextBox();
            this.Answer_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_txt1
            // 
            this.input_txt1.Location = new System.Drawing.Point(42, 36);
            this.input_txt1.Name = "input_txt1";
            this.input_txt1.Size = new System.Drawing.Size(129, 20);
            this.input_txt1.TabIndex = 0;
            this.input_txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input_txt2
            // 
            this.input_txt2.Location = new System.Drawing.Point(42, 62);
            this.input_txt2.Name = "input_txt2";
            this.input_txt2.Size = new System.Drawing.Size(129, 20);
            this.input_txt2.TabIndex = 1;
            this.input_txt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Create_BPNNBtn
            // 
            this.Create_BPNNBtn.Location = new System.Drawing.Point(42, 140);
            this.Create_BPNNBtn.Name = "Create_BPNNBtn";
            this.Create_BPNNBtn.Size = new System.Drawing.Size(83, 35);
            this.Create_BPNNBtn.TabIndex = 2;
            this.Create_BPNNBtn.Text = "Create BPNN";
            this.Create_BPNNBtn.UseVisualStyleBackColor = true;
            this.Create_BPNNBtn.Click += new System.EventHandler(this.Create_BPNNBtn_Click);
            // 
            // Train_Btn
            // 
            this.Train_Btn.Location = new System.Drawing.Point(131, 140);
            this.Train_Btn.Name = "Train_Btn";
            this.Train_Btn.Size = new System.Drawing.Size(83, 35);
            this.Train_Btn.TabIndex = 3;
            this.Train_Btn.Text = "Train the Neural Net";
            this.Train_Btn.UseVisualStyleBackColor = true;
            this.Train_Btn.Click += new System.EventHandler(this.Train_Btn_Click);
            // 
            // Test_Btn
            // 
            this.Test_Btn.Location = new System.Drawing.Point(220, 140);
            this.Test_Btn.Name = "Test_Btn";
            this.Test_Btn.Size = new System.Drawing.Size(83, 35);
            this.Test_Btn.TabIndex = 4;
            this.Test_Btn.Text = "Test";
            this.Test_Btn.UseVisualStyleBackColor = true;
            this.Test_Btn.Click += new System.EventHandler(this.Test_Btn_Click);
            // 
            // input_txt4
            // 
            this.input_txt4.Location = new System.Drawing.Point(42, 114);
            this.input_txt4.Name = "input_txt4";
            this.input_txt4.Size = new System.Drawing.Size(129, 20);
            this.input_txt4.TabIndex = 7;
            this.input_txt4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // input_txt3
            // 
            this.input_txt3.Location = new System.Drawing.Point(42, 88);
            this.input_txt3.Name = "input_txt3";
            this.input_txt3.Size = new System.Drawing.Size(129, 20);
            this.input_txt3.TabIndex = 6;
            this.input_txt3.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Answer_txt
            // 
            this.Answer_txt.Enabled = false;
            this.Answer_txt.Location = new System.Drawing.Point(192, 79);
            this.Answer_txt.Name = "Answer_txt";
            this.Answer_txt.Size = new System.Drawing.Size(111, 20);
            this.Answer_txt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 211);
            this.Controls.Add(this.input_txt4);
            this.Controls.Add(this.input_txt3);
            this.Controls.Add(this.Answer_txt);
            this.Controls.Add(this.Test_Btn);
            this.Controls.Add(this.Train_Btn);
            this.Controls.Add(this.Create_BPNNBtn);
            this.Controls.Add(this.input_txt2);
            this.Controls.Add(this.input_txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_txt1;
        private System.Windows.Forms.TextBox input_txt2;
        private System.Windows.Forms.Button Create_BPNNBtn;
        private System.Windows.Forms.Button Train_Btn;
        private System.Windows.Forms.Button Test_Btn;
        private System.Windows.Forms.TextBox input_txt4;
        private System.Windows.Forms.TextBox input_txt3;
        private System.Windows.Forms.TextBox Answer_txt;
    }
}

