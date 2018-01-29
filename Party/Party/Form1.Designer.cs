namespace Party
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
            this.Fancy = new System.Windows.Forms.CheckBox();
            this.Healthy = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Fancy
            // 
            this.Fancy.AutoSize = true;
            this.Fancy.Checked = true;
            this.Fancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Fancy.Location = new System.Drawing.Point(15, 51);
            this.Fancy.Name = "Fancy";
            this.Fancy.Size = new System.Drawing.Size(115, 17);
            this.Fancy.TabIndex = 2;
            this.Fancy.Text = "Fancy Decorations";
            this.Fancy.UseVisualStyleBackColor = true;
            this.Fancy.CheckedChanged += new System.EventHandler(this.Fancy_CheckedChanged);
            // 
            // Healthy
            // 
            this.Healthy.AutoSize = true;
            this.Healthy.Location = new System.Drawing.Point(15, 74);
            this.Healthy.Name = "Healthy";
            this.Healthy.Size = new System.Drawing.Size(96, 17);
            this.Healthy.TabIndex = 3;
            this.Healthy.Text = "Healthy Option";
            this.Healthy.UseVisualStyleBackColor = true;
            this.Healthy.CheckedChanged += new System.EventHandler(this.Healthy_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(46, 102);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(65, 23);
            this.costLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(140, 147);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Healthy);
            this.Controls.Add(this.Fancy);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox Fancy;
        private System.Windows.Forms.CheckBox Healthy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costLabel;
    }
}

