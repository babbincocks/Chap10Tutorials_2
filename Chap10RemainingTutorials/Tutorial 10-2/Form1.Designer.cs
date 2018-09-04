namespace Tutorial_10_2
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
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnimal
            // 
            this.btnAnimal.Location = new System.Drawing.Point(72, 89);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(75, 35);
            this.btnAnimal.TabIndex = 0;
            this.btnAnimal.Text = "Create an Animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(192, 89);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(75, 35);
            this.btnDog.TabIndex = 1;
            this.btnDog.Text = "Create a Dog";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(307, 89);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(75, 35);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "Create a Cat";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(192, 139);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.btnAnimal);
            this.Name = "frmMain";
            this.Text = "Polymorphism Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnExit;
    }
}

