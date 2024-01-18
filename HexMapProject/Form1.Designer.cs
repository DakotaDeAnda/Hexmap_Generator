namespace HexMapProject
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
            this.button1 = new System.Windows.Forms.Button();
            this.nmrcSizeInput = new System.Windows.Forms.NumericUpDown();
            this.pnl1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcSizeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmrcSizeInput
            // 
            this.nmrcSizeInput.Location = new System.Drawing.Point(518, 88);
            this.nmrcSizeInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrcSizeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcSizeInput.Name = "nmrcSizeInput";
            this.nmrcSizeInput.Size = new System.Drawing.Size(189, 20);
            this.nmrcSizeInput.TabIndex = 2;
            this.nmrcSizeInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.DimGray;
            this.pnl1.Location = new System.Drawing.Point(12, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(500, 500);
            this.pnl1.TabIndex = 0;
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(719, 525);
            this.Controls.Add(this.nmrcSizeInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcSizeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nmrcSizeInput;
        private System.Windows.Forms.Panel pnl1;
    }
}

