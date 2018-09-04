namespace Tutorial_10_3
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRequiredHours = new System.Windows.Forms.Label();
            this.rbSoftEngineer = new System.Windows.Forms.RadioButton();
            this.rbInfoSystems = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnHours = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblRequiredHours);
            this.groupBox1.Controls.Add(this.rbSoftEngineer);
            this.groupBox1.Controls.Add(this.rbInfoSystems);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Required Hours:";
            // 
            // lblRequiredHours
            // 
            this.lblRequiredHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRequiredHours.Location = new System.Drawing.Point(133, 179);
            this.lblRequiredHours.Name = "lblRequiredHours";
            this.lblRequiredHours.Size = new System.Drawing.Size(146, 20);
            this.lblRequiredHours.TabIndex = 7;
            // 
            // rbSoftEngineer
            // 
            this.rbSoftEngineer.AutoSize = true;
            this.rbSoftEngineer.Checked = true;
            this.rbSoftEngineer.Location = new System.Drawing.Point(153, 129);
            this.rbSoftEngineer.Name = "rbSoftEngineer";
            this.rbSoftEngineer.Size = new System.Drawing.Size(126, 17);
            this.rbSoftEngineer.TabIndex = 6;
            this.rbSoftEngineer.TabStop = true;
            this.rbSoftEngineer.Text = "Software Engineering";
            this.rbSoftEngineer.UseVisualStyleBackColor = true;
            // 
            // rbInfoSystems
            // 
            this.rbInfoSystems.AutoSize = true;
            this.rbInfoSystems.Location = new System.Drawing.Point(153, 106);
            this.rbInfoSystems.Name = "rbInfoSystems";
            this.rbInfoSystems.Size = new System.Drawing.Size(119, 17);
            this.rbInfoSystems.TabIndex = 5;
            this.rbInfoSystems.TabStop = true;
            this.rbInfoSystems.Text = "Information Systems";
            this.rbInfoSystems.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Academic Track:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(133, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnHours
            // 
            this.btnHours.Location = new System.Drawing.Point(63, 292);
            this.btnHours.Name = "btnHours";
            this.btnHours.Size = new System.Drawing.Size(87, 36);
            this.btnHours.TabIndex = 9;
            this.btnHours.Text = "Get Required Hours";
            this.btnHours.UseVisualStyleBackColor = true;
            this.btnHours.Click += new System.EventHandler(this.btnHours_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(189, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 36);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 352);
            this.Controls.Add(this.btnHours);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Computer Science Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSoftEngineer;
        private System.Windows.Forms.RadioButton rbInfoSystems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRequiredHours;
        private System.Windows.Forms.Button btnHours;
        private System.Windows.Forms.Button btnExit;
    }
}

