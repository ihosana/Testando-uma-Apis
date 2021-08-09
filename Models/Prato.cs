using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_api.Models
{
    public class Prato
    {
         public int Id { get; set; }
        
        [StringLength(64)]
        public string Nome { get; set; }
        
        [StringLength(512)]
        public string Descricao { get; set; }
        
        [Column(TypeName="DECIMAL(5,2)")]
        public decimal Preco { get; set; }
    }
}