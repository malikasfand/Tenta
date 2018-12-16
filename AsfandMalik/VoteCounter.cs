using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsfandMalik
{
   class VoteCounter
    {
     public String CountVotes(int[] allVotes)
        {
           // int greatest = allVotes[0];
            String resultat;

            if (allVotes[0] > allVotes[1] && allVotes[0] > allVotes[2])
                resultat = "Alternativ A fick flest röster";
            else if (allVotes[1] > allVotes[0] && allVotes[1] > allVotes[2])
                resultat = "Alternativ B fick flest röster";
            else if (allVotes[2] > allVotes[0] && allVotes[2] > allVotes[1])
                resultat = "Alternativ C fick flest röster";
            else
                resultat = "Det går inte att avgöra vinnande alternativ";


            return resultat;
        }
    }
}
