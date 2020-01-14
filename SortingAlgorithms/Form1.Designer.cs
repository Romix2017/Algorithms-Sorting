namespace SortingAlgorithms
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddRandom = new System.Windows.Forms.Button();
            this.AddRandomTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.verticalProgressBar1 = new VerticalProgressBar.VerticalProgressBar();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Controls.Add(this.AddTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 56);
            this.panel3.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.AccessibleName = "AddButton";
            this.AddButton.Location = new System.Drawing.Point(216, 21);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.AccessibleName = "AddTextBox";
            this.AddTextBox.Location = new System.Drawing.Point(7, 21);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(203, 20);
            this.AddTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add element";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AddRandom);
            this.panel4.Controls.Add(this.AddRandomTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 56);
            this.panel4.TabIndex = 1;
            // 
            // AddRandom
            // 
            this.AddRandom.AccessibleName = "AddRandom";
            this.AddRandom.Location = new System.Drawing.Point(216, 21);
            this.AddRandom.Name = "AddRandom";
            this.AddRandom.Size = new System.Drawing.Size(75, 20);
            this.AddRandom.TabIndex = 2;
            this.AddRandom.Text = "Add random";
            this.AddRandom.UseVisualStyleBackColor = true;
            this.AddRandom.Click += new System.EventHandler(this.AddRandom_Click);
            // 
            // AddRandomTextBox
            // 
            this.AddRandomTextBox.AccessibleName = "AddRandomTextBox";
            this.AddRandomTextBox.Location = new System.Drawing.Point(7, 21);
            this.AddRandomTextBox.Name = "AddRandomTextBox";
            this.AddRandomTextBox.Size = new System.Drawing.Size(203, 20);
            this.AddRandomTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add random set";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.verticalProgressBar1);
            this.panel5.Location = new System.Drawing.Point(333, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(746, 118);
            this.panel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 90);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            this.verticalProgressBar1.Color = System.Drawing.Color.Blue;
            this.verticalProgressBar1.Location = new System.Drawing.Point(6, 21);
            this.verticalProgressBar1.Maximum = 100;
            this.verticalProgressBar1.Minimum = 0;
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(0, 0);
            this.verticalProgressBar1.Step = 1;
            this.verticalProgressBar1.Style = VerticalProgressBar.Styles.Solid;
            this.verticalProgressBar1.TabIndex = 0;
            this.verticalProgressBar1.Value = 50;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1091, 560);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddRandom;
        private System.Windows.Forms.TextBox AddRandomTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private VerticalProgressBar.VerticalProgressBar verticalProgressBar1;
        private System.Windows.Forms.Label label5;
    }
}

