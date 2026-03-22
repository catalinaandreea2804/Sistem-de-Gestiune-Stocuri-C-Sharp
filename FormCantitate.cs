using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_OpreaAndreea_1059D
{
    
    public partial class FormCantitate : Form
    {
        public int cantitatePrimita;
        public int stocMaxim;
        public FormCantitate(int maximDisponibil)
        {
            

            InitializeComponent();
            stocMaxim= maximDisponibil;
            this.tbCantitate.Text = "1";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbCantitate.Text, out int cantitate))
            {
                if (cantitate < 1)
                {
                    MessageBox.Show("Cantitate invalida");
                    return;
                }
                if (cantitate > stocMaxim)
                {
                    MessageBox.Show("Nu exista stoc suficient");
                    return;
                }

                cantitatePrimita = cantitate;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
               


        }
    }
}
