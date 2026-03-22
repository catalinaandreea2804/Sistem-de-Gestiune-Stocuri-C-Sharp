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
    public partial class ButonRenunta : UserControl
    {
  
        public ButonRenunta()
        {
            InitializeComponent();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Ai apasat Renunta.\n Doresti sa mai incerci?", "Avertizare!", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                Form parinte = this.FindForm();
                if( parinte != null )
                {
                    parinte.Close();
                }
            }

                

        }
    }
}
