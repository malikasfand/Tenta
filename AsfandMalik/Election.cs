using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsfandMalik
{
   public class Election
    {
        public List<Party> Parties { get; set; }

       public Election()
        {
            this.Parties= new List<Party>();

            //Ta bort denna Parties.Add efter testning
            Parties.Add(new Party() { Name = "Moderaterna", Abbreviation = "M", NumberOfVotes = 1284698 });
            Parties.Add(new Party() { Name = "Centerpartiet", Abbreviation = "C", NumberOfVotes = 557500 });
            Parties.Add(new Party() { Name = "Liberalerna", Abbreviation = "L", NumberOfVotes = 355546 });
            Parties.Add(new Party() { Name = "Kristdemokraterna", Abbreviation = "KD", NumberOfVotes = 409478 });
            Parties.Add(new Party() { Name = "Socialdemokraterna", Abbreviation = "S", NumberOfVotes = 355546 });
            Parties.Add(new Party() { Name = "Vänsterpartiet", Abbreviation = "V", NumberOfVotes = 518454 });
            Parties.Add(new Party() { Name = "Miljöpartiet de gröna", Abbreviation = "MP", NumberOfVotes = 285899});
            Parties.Add(new Party() { Name = "Sverigedemokraterna", Abbreviation = "SD", NumberOfVotes = 1135627 });
           
            Parties.Add(new Party() { Name = "Feminist Initiativ", Abbreviation = "FI", NumberOfVotes = 29665 });
            Parties.Add(new Party() { Name = "Överiga anmälda partier", Abbreviation = "ÖVR", NumberOfVotes = 69472 });


        }

        public Party Search(String förkortning)
        {
            Party partyfound;
            partyfound=Parties.Find(Party => Party.Abbreviation == förkortning.ToUpper());
            if (partyfound == null)
                return null;
            else return partyfound;



        }
        private Double GetTotalAntalRöster()
        {
            Double total = 0;
            foreach(Party p in Parties)
            {
                total = total + p.NumberOfVotes;
            }


            return total;

        }

        public List<Party> GetRiksdagParties()
        {
            List<Party> riksdagParties=new List<Party>();
            foreach (Party p in Parties)
            {
                if ((p.NumberOfVotes / GetTotalAntalRöster()) * 100 >= 4)
                    riksdagParties.Add(p);

            }



            return riksdagParties;
        }
    }
}
