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
    public partial class Folkomröstning : Form
    {
        public Folkomröstning()
        {
            InitializeComponent();
                             
        }

        int[] allVotes = DigitalVal.votesCollector;

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (alternativA.Checked)
                allVotes[0] = allVotes[0] + 1;
            else if (alternativB.Checked)
                allVotes[1] = allVotes[1] + 1;
            else if (alternativC.Checked)
                allVotes[2] = allVotes[2] + 1;
              Console.WriteLine("A: "+allVotes[0].ToString());
             Console.WriteLine("B: "+allVotes[1].ToString());
             Console.WriteLine("C: "+allVotes[2].ToString());
            Console.WriteLine("_________________________ " );


            lblTack.Visible = true;
              lblTack.Text = "Tack ! din röst är registrerad.";
              gbRost.Visible = false;
            lnlRöstaigen.Visible = true;



        }

        private void lnlRöstaigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gbRost.Visible = true;
            lnlRöstaigen.Visible = false;
            lblTack.Visible = false;
        }
    }
}
