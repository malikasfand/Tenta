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
    public partial class PartyRegistrationForm : Form
    {
        public PartyRegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {

            Party party = new Party();
            if (tbName.Text != "" && tbFörkortning.Text != "")
            {
                party.Name = tbName.Text;
                party.Abbreviation = tbFörkortning.Text;
                // party.NumberOfVotes = 0;
                // party.Percentage = 0;
                DigitalVal.election2017.Parties.Add(party);
                              
                MessageBox.Show("Party Added");
                tbName.Text = "";
                tbFörkortning.Text = "";

            }
            else
                MessageBox.Show("Fyll parti namn och förkortning");

        }
    }
}
