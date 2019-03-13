namespace SchoolMascotAllanL
{
    partial class frmSchoolMascot
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
            this.mnuSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGlebe = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCantebury = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHillcrest = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSchool = new System.Windows.Forms.Label();
            this.grbSchoolMascot = new System.Windows.Forms.GroupBox();
            this.lblMascot = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbSchoolMascot.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSchools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSchools
            // 
            this.mnuSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniGlebe,
            this.mniCantebury,
            this.mniHillcrest});
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(60, 20);
            this.mnuSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(180, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniGlebe
            // 
            this.mniGlebe.Name = "mniGlebe";
            this.mniGlebe.Size = new System.Drawing.Size(180, 22);
            this.mniGlebe.Text = "Glebe";
            this.mniGlebe.Click += new System.EventHandler(this.mniGlebe_Click);
            // 
            // mniCantebury
            // 
            this.mniCantebury.Name = "mniCantebury";
            this.mniCantebury.Size = new System.Drawing.Size(180, 22);
            this.mniCantebury.Text = "Cantebury";
            this.mniCantebury.Click += new System.EventHandler(this.mniCantebury_Click);
            // 
            // mniHillcrest
            // 
            this.mniHillcrest.Name = "mniHillcrest";
            this.mniHillcrest.Size = new System.Drawing.Size(180, 22);
            this.mniHillcrest.Text = "Hillcrest";
            this.mniHillcrest.Click += new System.EventHandler(this.mniHillcrest_Click);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(84, 48);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(0, 20);
            this.lblSchool.TabIndex = 1;
            // 
            // grbSchoolMascot
            // 
            this.grbSchoolMascot.Controls.Add(this.lblMascot);
            this.grbSchoolMascot.Controls.Add(this.lblSchool);
            this.grbSchoolMascot.Location = new System.Drawing.Point(78, 107);
            this.grbSchoolMascot.Name = "grbSchoolMascot";
            this.grbSchoolMascot.Size = new System.Drawing.Size(271, 181);
            this.grbSchoolMascot.TabIndex = 2;
            this.grbSchoolMascot.TabStop = false;
            this.grbSchoolMascot.Text = "School Mascots";
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.Location = new System.Drawing.Point(84, 115);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(0, 20);
            this.lblMascot.TabIndex = 2;
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 338);
            this.Controls.Add(this.grbSchoolMascot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot by Allan L";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbSchoolMascot.ResumeLayout(false);
            this.grbSchoolMascot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniGlebe;
        private System.Windows.Forms.ToolStripMenuItem mniCantebury;
        private System.Windows.Forms.ToolStripMenuItem mniHillcrest;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.GroupBox grbSchoolMascot;
        private System.Windows.Forms.Label lblMascot;
    }
}

