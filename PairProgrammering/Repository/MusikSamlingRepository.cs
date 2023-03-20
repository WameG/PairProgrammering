using PairProgrammering.Models;
using System.Security.Cryptography.Xml;

namespace PairProgrammering.Repository
{
    public class MusikSamlingRepository
    {
        public List<MusikSamling> musikSamlings;

        public MusikSamlingRepository()
        {
            musikSamlings = new List<MusikSamling>()
            {
            new MusikSamling() { Titel = "Get Low", Artist = "Jan", Duration = 3, PublicationYear = "2021" },
            new MusikSamling() { Titel = "Gunna", Artist = "Josh", Duration = 3, PublicationYear = "2022" },
            new MusikSamling() { Titel = "Don't push me", Artist = "John", Duration = 3, PublicationYear = "2023" },
            };

        }

        public List<MusikSamling> Get()
        {
         
            return musikSamlings; 

        }

        public List<MusikSamling> GetFiltered(string title = null, string sortBy= null)
        {

            list<musikSamlings> 
            if(title != null)
            {
                musikSamlings.FindAll(x => x.Titel == title).or
            }

            


        }
    }
}
