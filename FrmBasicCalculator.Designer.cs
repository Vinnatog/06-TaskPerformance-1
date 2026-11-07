namespace BasicCalculator
{
    partial class FrmBasicCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtA = new TextBox();
            comboBox1 = new ComboBox();
            txtB = new TextBox();
            panel2 = new Panel();
            lblValue = new Label();
            label2 = new Label();
            btnCompute = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkKhaki;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 89);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.apple_calculator;
            pictureBox1.Location = new Point(24, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 21);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtA.Location = new Point(65, 207);
            txtA.Name = "txtA";
            txtA.Size = new Size(237, 33);
            txtA.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 260);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(82, 29);
            comboBox1.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtB.Location = new Point(65, 314);
            txtB.Name = "txtB";
            txtB.Size = new Size(237, 29);
            txtB.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(lblValue);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 73);
            panel2.TabIndex = 4;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValue.ForeColor = Color.Chartreuse;
            lblValue.Location = new Point(14, 36);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(49, 20);
            lblValue.TabIndex = 5;
            lblValue.Text = "XXXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 5;
            label2.Text = "Total:";
            // 
            // btnCompute
            // 
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Location = new Point(115, 360);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(99, 32);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(383, 415);
            Controls.Add(btnCompute);
            Controls.Add(panel2);
            Controls.Add(txtB);
            Controls.Add(comboBox1);
            Controls.Add(txtA);
            Controls.Add(panel1);
            Name = "FrmBasicCalculator";
            Text = "FrmBasicCalculator";
            Load += FrmBasicCalculator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtA;
        private ComboBox comboBox1;
        private TextBox txtB;
        private Panel panel2;
        private Label lblValue;
        private Label label2;
        private Button btnCompute;
    }
}
