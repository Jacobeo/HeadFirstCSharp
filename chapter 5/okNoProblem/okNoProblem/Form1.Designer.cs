namespace okNoProblem
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.IsFancy = new System.Windows.Forms.CheckBox();
            this.IsHealth = new System.Windows.Forms.CheckBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of people";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(39, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // IsFancy
            // 
            this.IsFancy.AutoSize = true;
            this.IsFancy.Checked = true;
            this.IsFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsFancy.Location = new System.Drawing.Point(39, 74);
            this.IsFancy.Name = "IsFancy";
            this.IsFancy.Size = new System.Drawing.Size(113, 17);
            this.IsFancy.TabIndex = 2;
            this.IsFancy.Text = "Fancy decorations";
            this.IsFancy.UseVisualStyleBackColor = true;
            this.IsFancy.CheckedChanged += new System.EventHandler(this.IsFancy_CheckedChanged);
            // 
            // IsHealth
            // 
            this.IsHealth.AutoSize = true;
            this.IsHealth.Location = new System.Drawing.Point(39, 97);
            this.IsHealth.Name = "IsHealth";
            this.IsHealth.Size = new System.Drawing.Size(96, 17);
            this.IsHealth.TabIndex = 3;
            this.IsHealth.Text = "Healthy Option";
            this.IsHealth.UseVisualStyleBackColor = true;
            this.IsHealth.CheckedChanged += new System.EventHandler(this.IsHealth_CheckedChanged);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CostLabel.Location = new System.Drawing.Point(73, 121);
            this.CostLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(100, 15);
            this.CostLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 158);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.IsHealth);
            this.Controls.Add(this.IsFancy);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox IsFancy;
        private System.Windows.Forms.CheckBox IsHealth;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label label2;
    }
}

