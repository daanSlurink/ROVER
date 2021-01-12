using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROVER
{
    public partial class AangifteInvoerenForm : Form  
    {
        databees db = new databees();

        public AangifteInvoerenForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if(!String.IsNullOrEmpty(txtMisdrijf.Text)&& !string.IsNullOrEmpty(txtEigenWN.Text))
            {
                db.AddCase(new Case
                {
                    waarneming = txtEigenWN.Text,
                    misdrijf = txtMisdrijf.Text,
                    meldingsnummer = txtTemp.Text,
                    datumVoor = dateTimePicker1.Value,
                    svGetuige = txtVhGetuige.Text,
                    svVerdachte = txtVhVerdachte.Text,

                });
                db.AddPerson(new Case
                {
                   meldingsnummer = txtTemp.Text,
                   aNaam = txtAnaam.Text,
                    vNaam = txtVnaam.Text,
                    bsn = txtBsn.Text
                    
                });
                txtEigenWN.Text = string.Empty;
                txtMisdrijf.Text = string.Empty;
                txtTemp.Text = string.Empty;
            }
        }
    }
}
