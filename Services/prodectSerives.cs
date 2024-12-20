using Aon_Test.models;
using Aon_Test.models.DTOs;

namespace Aon_Test.Services
{
    public class prodectSerives
    {

        public IList<Prodects> prodects = new List<Prodects>() ;

        public void AddNewProdect(Prodects prodect)
        {

            
            prodects.Add(prodect);
        }
        public Prodects GetProdectById(int prodectId)
        {
            return prodects.FirstOrDefault(p => p.Id == prodectId);
        }
    }
}
