namespace tugas_week_8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbok1 = new System.Windows.Forms.ComboBox();
            this.cbok2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chooese team";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose match";
            // 
            // cbok1
            // 
            this.cbok1.FormattingEnabled = true;
            this.cbok1.Location = new System.Drawing.Point(163, 49);
            this.cbok1.Name = "cbok1";
            this.cbok1.Size = new System.Drawing.Size(172, 24);
            this.cbok1.TabIndex = 1;
            this.cbok1.SelectionChangeCommitted += new System.EventHandler(this.cbok1_SelectionChangeCommitted);
            // 
            // cbok2
            // 
            this.cbok2.FormattingEnabled = true;
            this.cbok2.Location = new System.Drawing.Point(650, 49);
            this.cbok2.Name = "cbok2";
            this.cbok2.Size = new System.Drawing.Size(240, 24);
            this.cbok2.TabIndex = 1;
            this.cbok2.SelectionChangeCommitted += new System.EventHandler(this.cbok2_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(222, 501);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(267, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(232, 501);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(650, 181);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(616, 431);
            this.dataGridView3.TabIndex = 2;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(938, 13);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(23, 16);
            this.p1.TabIndex = 0;
            this.p1.Text = "P1";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(1069, 13);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(23, 16);
            this.p2.TabIndex = 0;
            this.p2.Text = "P2";
            this.p2.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(999, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "VS";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(938, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Score Home :";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(938, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Score Away :";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(938, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "referee :";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(938, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date Match :";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(1033, 54);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(0, 16);
            this.lab1.TabIndex = 0;
            this.lab1.Click += new System.EventHandler(this.label4_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(1033, 83);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(0, 16);
            this.lab2.TabIndex = 0;
            this.lab2.Click += new System.EventHandler(this.label4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1033, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 0;
            this.label12.Click += new System.EventHandler(this.label4_Click);
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(1033, 136);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(0, 16);
            this.lab4.TabIndex = 0;
            this.lab4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 676);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbok2);
            this.Controls.Add(this.cbok1);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbok1;
        private System.Windows.Forms.ComboBox cbok2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lab4;
    }
}