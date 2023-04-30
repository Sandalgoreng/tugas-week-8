namespace tugas_week_8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbok1 = new System.Windows.Forms.ComboBox();
            this.cbok2 = new System.Windows.Forms.ComboBox();
            this.nama = new System.Windows.Forms.Label();
            this.tteam = new System.Windows.Forms.Label();
            this.posisi = new System.Windows.Forms.Label();
            this.negara = new System.Windows.Forms.Label();
            this.nomorp = new System.Windows.Forms.Label();
            this.kkuning = new System.Windows.Forms.Label();
            this.kmerah = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.gakgol = new System.Windows.Forms.Label();
            this.owngoal = new System.Windows.Forms.Label();
            this.pinalti = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            // 
            // cbok1
            // 
            this.cbok1.FormattingEnabled = true;
            this.cbok1.Location = new System.Drawing.Point(13, 32);
            this.cbok1.Name = "cbok1";
            this.cbok1.Size = new System.Drawing.Size(121, 24);
            this.cbok1.TabIndex = 1;
            this.cbok1.Visible = false;
            this.cbok1.SelectionChangeCommitted += new System.EventHandler(this.cbok1_SelectionChangeCommitted);
            // 
            // cbok2
            // 
            this.cbok2.FormattingEnabled = true;
            this.cbok2.Location = new System.Drawing.Point(140, 32);
            this.cbok2.Name = "cbok2";
            this.cbok2.Size = new System.Drawing.Size(121, 24);
            this.cbok2.TabIndex = 1;
            this.cbok2.Visible = false;
            this.cbok2.SelectionChangeCommitted += new System.EventHandler(this.cbok2_SelectionChangeCommitted);
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(29, 87);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(44, 16);
            this.nama.TabIndex = 2;
            this.nama.Text = "label1";
            this.nama.Visible = false;
            // 
            // tteam
            // 
            this.tteam.AutoSize = true;
            this.tteam.Location = new System.Drawing.Point(29, 103);
            this.tteam.Name = "tteam";
            this.tteam.Size = new System.Drawing.Size(44, 16);
            this.tteam.TabIndex = 2;
            this.tteam.Text = "label1";
            this.tteam.Visible = false;
            // 
            // posisi
            // 
            this.posisi.AutoSize = true;
            this.posisi.Location = new System.Drawing.Point(29, 119);
            this.posisi.Name = "posisi";
            this.posisi.Size = new System.Drawing.Size(44, 16);
            this.posisi.TabIndex = 2;
            this.posisi.Text = "label1";
            this.posisi.Visible = false;
            // 
            // negara
            // 
            this.negara.AutoSize = true;
            this.negara.Location = new System.Drawing.Point(29, 135);
            this.negara.Name = "negara";
            this.negara.Size = new System.Drawing.Size(44, 16);
            this.negara.TabIndex = 2;
            this.negara.Text = "label1";
            this.negara.Visible = false;
            // 
            // nomorp
            // 
            this.nomorp.AutoSize = true;
            this.nomorp.Location = new System.Drawing.Point(29, 152);
            this.nomorp.Name = "nomorp";
            this.nomorp.Size = new System.Drawing.Size(44, 16);
            this.nomorp.TabIndex = 2;
            this.nomorp.Text = "label1";
            this.nomorp.Visible = false;
            // 
            // kkuning
            // 
            this.kkuning.AutoSize = true;
            this.kkuning.Location = new System.Drawing.Point(29, 168);
            this.kkuning.Name = "kkuning";
            this.kkuning.Size = new System.Drawing.Size(44, 16);
            this.kkuning.TabIndex = 2;
            this.kkuning.Text = "label1";
            this.kkuning.Visible = false;
            // 
            // kmerah
            // 
            this.kmerah.AutoSize = true;
            this.kmerah.Location = new System.Drawing.Point(29, 184);
            this.kmerah.Name = "kmerah";
            this.kmerah.Size = new System.Drawing.Size(44, 16);
            this.kmerah.TabIndex = 2;
            this.kmerah.Text = "label1";
            this.kmerah.Visible = false;
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Location = new System.Drawing.Point(29, 200);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(44, 16);
            this.goal.TabIndex = 2;
            this.goal.Text = "label1";
            this.goal.Visible = false;
            // 
            // gakgol
            // 
            this.gakgol.AutoSize = true;
            this.gakgol.Location = new System.Drawing.Point(29, 249);
            this.gakgol.Name = "gakgol";
            this.gakgol.Size = new System.Drawing.Size(44, 16);
            this.gakgol.TabIndex = 2;
            this.gakgol.Text = "label1";
            this.gakgol.Visible = false;
            // 
            // owngoal
            // 
            this.owngoal.AutoSize = true;
            this.owngoal.Location = new System.Drawing.Point(29, 216);
            this.owngoal.Name = "owngoal";
            this.owngoal.Size = new System.Drawing.Size(44, 16);
            this.owngoal.TabIndex = 2;
            this.owngoal.Text = "label1";
            this.owngoal.Visible = false;
            // 
            // pinalti
            // 
            this.pinalti.AutoSize = true;
            this.pinalti.Location = new System.Drawing.Point(29, 232);
            this.pinalti.Name = "pinalti";
            this.pinalti.Size = new System.Drawing.Size(44, 16);
            this.pinalti.TabIndex = 2;
            this.pinalti.Text = "label1";
            this.pinalti.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kkuning);
            this.Controls.Add(this.pinalti);
            this.Controls.Add(this.negara);
            this.Controls.Add(this.owngoal);
            this.Controls.Add(this.gakgol);
            this.Controls.Add(this.posisi);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.nomorp);
            this.Controls.Add(this.kmerah);
            this.Controls.Add(this.tteam);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.cbok2);
            this.Controls.Add(this.cbok1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbok1;
        private System.Windows.Forms.ComboBox cbok2;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label tteam;
        private System.Windows.Forms.Label posisi;
        private System.Windows.Forms.Label negara;
        private System.Windows.Forms.Label nomorp;
        private System.Windows.Forms.Label kkuning;
        private System.Windows.Forms.Label kmerah;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Label gakgol;
        private System.Windows.Forms.Label owngoal;
        private System.Windows.Forms.Label pinalti;
    }
}

