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
    public partial class FormMagazin : Form
    {
        public Magazin mlocal;
        public FormMagazin(Magazin magazin)
        {
            InitializeComponent();


            if(magazin != null )
            {
                tbNumeMagazin.Text = magazin.nume;
                tbLocatieMagazin.Text = magazin.locatie;
                this.Text = "Editeaza Magazinul";
                btnSalveazaMagazin.Text = "Editeaza Magazinul";
                mlocal = magazin;
            }
            else
            {
                this.Text = "Adauga Magazin Nou";
                btnSalveazaMagazin.Text = "Salveaza Magazinul";
                mlocal = new Magazin();
            }
            
        }

        private void btnSalveazaMagazin_Click(object sender, EventArgs e)
        {
            mlocal.nume = tbNumeMagazin.Text;
            mlocal.locatie = tbLocatieMagazin.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tbNumeMagazin_Validating(object sender, CancelEventArgs e)
        {
            if(tbNumeMagazin.Text.Length < 3)
            {
                errorProvider1.SetError(tbNumeMagazin, "Corectati numele!");
                e.Cancel=true;
            }
        }

        private void tbNumeMagazin_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbNumeMagazin, "");
        }


    }
}
