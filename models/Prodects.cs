using System.ComponentModel.DataAnnotations;

namespace Aon_Test.models
{
    public class Prodects
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
    }
}
