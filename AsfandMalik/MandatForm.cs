using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsfandMalik
{
    public partial class MandatForm : Form
    {
        public MandatForm()
        {
            InitializeComponent();
        }
        int[] chairs = new int[] { 70, 31, 20, 22, 100, 28, 16, 62 };


        private void btnFördelaMandat_Click(object sender, EventArgs e)
        {

            bool[] checkedValues = new bool[]
            {
                (bool)chkModeraterna.Checked,
                (bool)chkCenterpartiet.Checked,
                (bool)chkLiberalerna.Checked,
                (bool)chkKristdemokraterna.Checked,
                (bool)chkSocialdemokraterna.Checked,
                (bool)chkVänsterpartiet.Checked,
                (bool)chkMiljöpartiet.Checked,
                (bool)chkSveriedemokraterna.Checked
            };


            lblResultat.Text = "Resultat :" + räknaResultat(checkedValues).ToString() + " av 349";
            if (räknaResultat(checkedValues) < 174)
                lblMajoritet.Text = "Majoritet :Nej";
            else
                lblMajoritet.Text = "Majoritet: Ja";

        }

        private int räknaResultat(bool[] checkedValues)
        {
            int resultat = 0;
            for (int i = 0; i < 8; i++)
            {
                if (checkedValues[i])
                    resultat = resultat + chairs[i];
            }
            return resultat;
        }
    }
}
