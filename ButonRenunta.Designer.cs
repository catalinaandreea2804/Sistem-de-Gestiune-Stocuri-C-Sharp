namespace ProiectPAW_OpreaAndreea_1059D
{
    partial class ButonRenunta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRenunta
            // 
            this.btnRenunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenunta.Location = new System.Drawing.Point(21, 30);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(134, 56);
            this.btnRenunta.TabIndex = 0;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // ButonRenunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnRenunta);
            this.Name = "ButonRenunta";
            this.Size = new System.Drawing.Size(178, 107);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRenunta;
    }
}
