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
    public partial class FormRaion : Form
    {

        public Raion rlocal = new Raion();
        public List<Magazin> listaMagazineLocala;
        public FormRaion(List<Magazin> listaMagazine, Raion raion = null)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.listaMagazineLocala = listaMagazine;
            //raion = null;
            if (raion != null)
            {
                rlocal = raion;
                cbMagazine.DataSource = listaMagazineLocala;
                this.Text = "Editeaza Raion";
                btnSalveazaRaion.Text = "Editeaza Raion";

                label2.Text = "&Nume Raion: ";

                this.KeyDown += FormRaion_KeyDown;

            }
            else
            {
                rlocal = new Raion();
                this.Text = "Adauga Raion";
                btnSalveazaRaion.Text = "Salveaza Raion";
            }



        }

        private void btSalveazaRaion_Click(object sender, EventArgs e)
        {
            if (tbNumeRaion.Text.Length > 3)
            {
                
                rlocal.nume = tbNumeRaion.Text;

                Magazin magazinSelectat = (Magazin)cbMagazine.SelectedItem;
                magazinSelectat.listaRaioane.Add(rlocal);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                if (
                MessageBox.Show("Selectati numele raionului!", "Mesaj Informare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    == DialogResult.Cancel)
                {
                    this.Close();
                }
            }

            
        }

        private void cbMagazine_Validating(object sender, CancelEventArgs e)
        {
            if (cbMagazine.SelectedIndex < 0) 
            {
                e.Cancel= true;
                errorProvider1.SetError(cbMagazine, "Trebuie sa selectezi o optiune.");
            }
            
        }

        private void cbMagazine_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbMagazine, "");
        }

        private void FormRaion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.N)  
            {
                tbNumeRaion.Focus();  
                e.Handled = true;
            }
        }
    }
   }
