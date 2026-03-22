namespace ProiectPAW_OpreaAndreea_1059D
{
    partial class FormCantitate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCantitate));
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butonRenunta1 = new ProiectPAW_OpreaAndreea_1059D.ButonRenunta();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(249, 26);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(87, 22);
            this.tbCantitate.TabIndex = 0;
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.SteelBlue;
            this.btOK.Location = new System.Drawing.Point(46, 87);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(117, 44);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduceti cantitatea";
            // 
            // butonRenunta1
            // 
            this.butonRenunta1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butonRenunta1.ForeColor = System.Drawing.Color.SteelBlue;
            this.butonRenunta1.Location = new System.Drawing.Point(179, 51);
            this.butonRenunta1.Name = "butonRenunta1";
            this.butonRenunta1.Size = new System.Drawing.Size(178, 105);
            this.butonRenunta1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.butonRenunta1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.tbCantitate);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 159);
            this.panel1.TabIndex = 5;
            // 
            // FormCantitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 183);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCantitate";
            this.Text = "Cantitate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label1;
        private ButonRenunta butonRenunta1;
        private System.Windows.Forms.Panel panel1;
    }
}