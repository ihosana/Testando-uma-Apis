using System.ComponentModel.DataAnnotations;
namespace test_api.Models
{
    public class Pedido
    {
         public int Id { get; set; }

        [StringLength(128)]
        
        public string Cliente { get; set; }
        
        [StringLength(128)]
        
        public string Endereco { get; set; }

        public int PratoId { get; set; }
        public Prato Prato { get; set; }
    }
}