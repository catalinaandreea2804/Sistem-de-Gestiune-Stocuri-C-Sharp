using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPAW_OpreaAndreea_1059D
{
    public partial class FormProdus : Form
    {
        public Produs plocal = new Produs();
        public List<Magazin> listaMagazineLocala;
        public FormProdus(List<Magazin> listaMagazine)
        {
            InitializeComponent();
            this.listaMagazineLocala = listaMagazine;

            cbMagazine2.DataSource = listaMagazineLocala;


        }

        public void SeteazaProdusPentruEditare(Produs produsDeEditat)
        {
            plocal = produsDeEditat;

            tbNumeProdus.Text = produsDeEditat.denumire;
            tbPret.Text = produsDeEditat.pret.ToString();
            tbCantitate.Text = produsDeEditat.stoc.ToString();
            this.Text = "Editeaza Produs";
            button1.Text = "Editeaza Produs";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNumeProdus.Text.Length > 3)
            {
                plocal = new Produs();
                plocal.denumire = tbNumeProdus.Text;
                plocal.pret = double.Parse(tbPret.Text);
                plocal.stoc = int.Parse(tbCantitate.Text);

                Raion raionSelectat = (Raion)cbRaioane.SelectedItem;
                raionSelectat.listaProduse.Add(plocal);
                

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (
                MessageBox.Show("Selectati numele produsului!", "Mesaj Informare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void cbMagazine2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Magazin magazinSelectat = (Magazin)cbMagazine2.SelectedItem;
            cbRaioane.DataSource = null;
            cbRaioane.DataSource = magazinSelectat.listaRaioane;
        }

        private void cbMagazine2_Validating(object sender, CancelEventArgs e)
        {
            if(cbMagazine2.SelectedIndex<0)
            {
                e.Cancel=true;
                errorProvider1.SetError(cbMagazine2, "Trebuie sa alegeti magazinul");


            }
        }

        private void cbMagazine2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbMagazine2, "");
        }

        private void cbRaioane_Validating(object sender, CancelEventArgs e)
        {
            if (cbMagazine2.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbMagazine2, "Trebuie sa alegeti Raionul");


            }
        }

        private void cbRaioane_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbMagazine2, "");
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            string text = tbPret.Text;

            if (e.KeyChar == '.' && text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            if (text.Contains("."))
            {
                int indexPunct = text.IndexOf('.');
                string zecimale = text.Substring(indexPunct + 1);

                if (tbPret.SelectionStart > indexPunct && zecimale.Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void tbCantitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Blochează orice alt caracter
            }
            if (char.IsDigit(e.KeyChar) && tbCantitate.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }
    }
}
