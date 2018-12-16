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
    public partial class RöstresultatForm : Form
    {
        public RöstresultatForm()
        {
            InitializeComponent();
        }

        private void Röstresultat_Load(object sender, EventArgs e)
        {
            foreach(Party p in DigitalVal.election2017.Parties)
            {
                lbPartiList.Items.Add(p.Name);
                
            }
            tbAntalRöster.Enabled = false;
            lblPartiNamn.Text = "";

        }

        private void lbPartiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbAntalRöster.Enabled = true;
            lblPartiNamn.Text = lbPartiList.Text;
            tbAntalRöster.Text= DigitalVal.election2017.Parties.Find(Party => Party.Name == lblPartiNamn.Text).NumberOfVotes.ToString();
        }

        private void btnRapportera_Click(object sender, EventArgs e)
        {
            DigitalVal.election2017.Parties.Find(Party => Party.Name == lblPartiNamn.Text).NumberOfVotes = Convert.ToInt32(tbAntalRöster.Text);
           
        }
    }
}
