namespace PacMan
{
    partial class Bienvenida
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
            this.TI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BEmpezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TI
            // 
            this.TI.Location = new System.Drawing.Point(51, 186);
            this.TI.Name = "TI";
            this.TI.Size = new System.Drawing.Size(212, 20);
            this.TI.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // BEmpezar
            // 
            this.BEmpezar.Location = new System.Drawing.Point(299, 184);
            this.BEmpezar.Name = "BEmpezar";
            this.BEmpezar.Size = new System.Drawing.Size(75, 23);
            this.BEmpezar.TabIndex = 3;
            this.BEmpezar.Text = "Empezar";
            this.BEmpezar.UseVisualStyleBackColor = true;
            this.BEmpezar.Click += new System.EventHandler(this.BEmpezar_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 237);
            this.Controls.Add(this.BEmpezar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TI);
            this.Controls.Add(this.label1);
            this.Name = "Bienvenida";
            this.Text = "Bienvenida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BEmpezar;
    }
}