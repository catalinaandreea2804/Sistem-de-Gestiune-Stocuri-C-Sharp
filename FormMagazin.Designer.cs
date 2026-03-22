namespace ProiectPAW_OpreaAndreea_1059D
{
    partial class FormMagazin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagazin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeMagazin = new System.Windows.Forms.TextBox();
            this.tbLocatieMagazin = new System.Windows.Forms.TextBox();
            this.btnSalveazaMagazin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.butonRenunta1 = new ProiectPAW_OpreaAndreea_1059D.ButonRenunta();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Magazin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Locatie";
            // 
            // tbNumeMagazin
            // 
            this.tbNumeMagazin.Location = new System.Drawing.Point(180, 24);
            this.tbNumeMagazin.Name = "tbNumeMagazin";
            this.tbNumeMagazin.Size = new System.Drawing.Size(243, 22);
            this.tbNumeMagazin.TabIndex = 2;
            this.tbNumeMagazin.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeMagazin_Validating);
            this.tbNumeMagazin.Validated += new System.EventHandler(this.tbNumeMagazin_Validated);
            // 
            // tbLocatieMagazin
            // 
            this.tbLocatieMagazin.Location = new System.Drawing.Point(180, 70);
            this.tbLocatieMagazin.Name = "tbLocatieMagazin";
            this.tbLocatieMagazin.Size = new System.Drawing.Size(243, 22);
            this.tbLocatieMagazin.TabIndex = 3;
            // 
            // btnSalveazaMagazin
            // 
            this.btnSalveazaMagazin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveazaMagazin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalveazaMagazin.Location = new System.Drawing.Point(41, 128);
            this.btnSalveazaMagazin.Name = "btnSalveazaMagazin";
            this.btnSalveazaMagazin.Size = new System.Drawing.Size(173, 63);
            this.btnSalveazaMagazin.TabIndex = 4;
            this.btnSalveazaMagazin.Text = "Salveaza Magazin";
            this.btnSalveazaMagazin.UseVisualStyleBackColor = true;
            this.btnSalveazaMagazin.Click += new System.EventHandler(this.btnSalveazaMagazin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.butonRenunta1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalveazaMagazin);
            this.panel1.Controls.Add(this.tbLocatieMagazin);
            this.panel1.Controls.Add(this.tbNumeMagazin);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 231);
            this.panel1.TabIndex = 7;
            // 
            // butonRenunta1
            // 
            this.butonRenunta1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butonRenunta1.ForeColor = System.Drawing.Color.SteelBlue;
            this.butonRenunta1.Location = new System.Drawing.Point(245, 103);
            this.butonRenunta1.Name = "butonRenunta1";
            this.butonRenunta1.Size = new System.Drawing.Size(178, 107);
            this.butonRenunta1.TabIndex = 5;
            // 
            // FormMagazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 264);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMagazin";
            this.Text = "Magazin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeMagazin;
        private System.Windows.Forms.TextBox tbLocatieMagazin;
        private System.Windows.Forms.Button btnSalveazaMagazin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private ButonRenunta butonRenunta1;
    }
}