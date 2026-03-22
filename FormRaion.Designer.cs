namespace ProiectPAW_OpreaAndreea_1059D
{
    partial class FormRaion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMagazine = new System.Windows.Forms.ComboBox();
            this.tbNumeRaion = new System.Windows.Forms.TextBox();
            this.btnSalveazaRaion = new System.Windows.Forms.Button();
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
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteaza Magazin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume Raion";
            // 
            // cbMagazine
            // 
            this.cbMagazine.FormattingEnabled = true;
            this.cbMagazine.Location = new System.Drawing.Point(240, 22);
            this.cbMagazine.Name = "cbMagazine";
            this.cbMagazine.Size = new System.Drawing.Size(178, 24);
            this.cbMagazine.TabIndex = 1;
            this.cbMagazine.Validating += new System.ComponentModel.CancelEventHandler(this.cbMagazine_Validating);
            this.cbMagazine.Validated += new System.EventHandler(this.cbMagazine_Validated);
            // 
            // tbNumeRaion
            // 
            this.tbNumeRaion.Location = new System.Drawing.Point(240, 57);
            this.tbNumeRaion.Name = "tbNumeRaion";
            this.tbNumeRaion.Size = new System.Drawing.Size(178, 22);
            this.tbNumeRaion.TabIndex = 3;
            // 
            // btnSalveazaRaion
            // 
            this.btnSalveazaRaion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveazaRaion.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalveazaRaion.Location = new System.Drawing.Point(52, 140);
            this.btnSalveazaRaion.Name = "btnSalveazaRaion";
            this.btnSalveazaRaion.Size = new System.Drawing.Size(162, 64);
            this.btnSalveazaRaion.TabIndex = 4;
            this.btnSalveazaRaion.Text = "Salveaza Raion";
            this.btnSalveazaRaion.UseVisualStyleBackColor = true;
            this.btnSalveazaRaion.Click += new System.EventHandler(this.btSalveazaRaion_Click);
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
            this.panel1.Controls.Add(this.btnSalveazaRaion);
            this.panel1.Controls.Add(this.cbMagazine);
            this.panel1.Controls.Add(this.tbNumeRaion);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 240);
            this.panel1.TabIndex = 6;
            // 
            // butonRenunta1
            // 
            this.butonRenunta1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butonRenunta1.ForeColor = System.Drawing.Color.SteelBlue;
            this.butonRenunta1.Location = new System.Drawing.Point(240, 112);
            this.butonRenunta1.Name = "butonRenunta1";
            this.butonRenunta1.Size = new System.Drawing.Size(178, 107);
            this.butonRenunta1.TabIndex = 5;
            // 
            // FormRaion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 264);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRaion";
            this.Text = "Raion";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRaion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMagazine;
        private System.Windows.Forms.TextBox tbNumeRaion;
        private System.Windows.Forms.Button btnSalveazaRaion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private ButonRenunta butonRenunta1;
    }
}