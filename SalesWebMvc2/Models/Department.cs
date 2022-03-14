
using System.Collections.Generic;
namespace SalesWebMvc2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }
        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
