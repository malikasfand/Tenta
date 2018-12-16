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
    public partial class DigitalVal : Form
    {
        public static int[] votesCollector = new int[3];
        public static Election election2017 = new Election();
        
       

        public DigitalVal()
        {
          InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Folkomröstning folkomröstning = new Folkomröstning();
            folkomröstning.Show();
            
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoteCounter voteCounter = new VoteCounter();
            MessageBox.Show(voteCounter.CountVotes(votesCollector));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MandatForm mandatForm = new MandatForm();
            mandatForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PartyRegistrationForm partyRegistration = new PartyRegistrationForm();
            partyRegistration.Show();
        }

        private void btnRaapportera_Click(object sender, EventArgs e)
        {
            RöstresultatForm röstresultat = new RöstresultatForm();
            röstresultat.Show();

        }

        private void btnPartiList_Click(object sender, EventArgs e)
        {
            lbPartiList.Items.Clear();
            List<Party> riksdagParties = election2017.GetRiksdagParties();
            foreach (Party p in riksdagParties)
            {
                 lbPartiList.Items.Add(p.Name);              

            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Party party = election2017.Search(lblförkortning.Text);
            if (party != null)
                lblPartiNamn.Text = party.Name;
            else
                lblPartiNamn.Text = "Partiet saknas";
        }
        private bool isValid(String partyName,String förkortning)
        {
           
            int count = 0;
            char[] partyNameChars = partyName.ToCharArray();
            char[] förkortningChars = förkortning.ToCharArray();

            // Loop through array.
            
           
                for (int j = 0; j < förkortningChars.Length; j++)
                {
                    for (int i = 0; i < partyNameChars.Length; i++)
                    {
                         if (partyNameChars[i].Equals(förkortningChars[j]) || partyNameChars[i].Equals(Char.ToLower(förkortningChars[j])))
                         {
                        //the char is found so we remove it from partynameChars (set it as 1)
                        partyNameChars[i] = '1';
                        count = count + 1;
                        break;


                         }
                   

                    }

                }
            if (count == förkortningChars.Length)
            {
                return true;
            }
            else
                return false;
           
            
        }
        private bool isContains(char[] partyNameChars,char förkortningChar)
        {
            bool result = false;
            for (int i = 0; i < partyNameChars.Length; i++)
            {
                if (partyNameChars[i].Equals(förkortningChar))
                {
                    result= true;
                }
                else
                    result = false;

            }
            return result;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isValid(tbPartyName.Text, tbFörkortning.Text))
                lblMessage.Text = "Förkortning tillåten";
            else
                lblMessage.Text = "Otillåten förkortning .....!";
        }
    }
}
