namespace CW1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textStuID = new System.Windows.Forms.TextBox();
            this.textStuFirstName = new System.Windows.Forms.TextBox();
            this.textStuLastName = new System.Windows.Forms.TextBox();
            this.textStuEmail = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 278);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(59, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "Students with no group";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(228, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 35;
            this.button1.Text = "Add student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(393, 474);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 47);
            this.button2.TabIndex = 36;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textStuID
            // 
            this.textStuID.Location = new System.Drawing.Point(105, 399);
            this.textStuID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textStuID.Name = "textStuID";
            this.textStuID.Size = new System.Drawing.Size(132, 22);
            this.textStuID.TabIndex = 37;
            // 
            // textStuFirstName
            // 
            this.textStuFirstName.Location = new System.Drawing.Point(265, 399);
            this.textStuFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textStuFirstName.Name = "textStuFirstName";
            this.textStuFirstName.Size = new System.Drawing.Size(132, 22);
            this.textStuFirstName.TabIndex = 38;
            // 
            // textStuLastName
            // 
            this.textStuLastName.Location = new System.Drawing.Point(428, 399);
            this.textStuLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textStuLastName.Name = "textStuLastName";
            this.textStuLastName.Size = new System.Drawing.Size(132, 22);
            this.textStuLastName.TabIndex = 39;
            // 
            // textStuEmail
            // 
            this.textStuEmail.Location = new System.Drawing.Point(613, 399);
            this.textStuEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textStuEmail.Name = "textStuEmail";
            this.textStuEmail.Size = new System.Drawing.Size(132, 22);
            this.textStuEmail.TabIndex = 40;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Purple;
            this.button15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button15.Location = new System.Drawing.Point(548, 474);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(89, 47);
            this.button15.TabIndex = 41;
            this.button15.Text = "Exit";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 546);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.textStuEmail);
            this.Controls.Add(this.textStuLastName);
            this.Controls.Add(this.textStuFirstName);
            this.Controls.Add(this.textStuID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textStuID;
        private System.Windows.Forms.TextBox textStuFirstName;
        private System.Windows.Forms.TextBox textStuLastName;
        private System.Windows.Forms.TextBox textStuEmail;
        private System.Windows.Forms.Button button15;
    }
}