using System.Collections.Generic;
using System.Linq;

namespace test_api.Models
{
    public class Services
    {
        
        public int CriaPedido(Pedido novoPedido)
        {
            using(var contexto = new BdContext())
            {
                contexto.Add(novoPedido);
                contexto.SaveChanges();
                return novoPedido.Id;
            }
        }

        public List<Prato> ListaPratos()
        {
            using(var contexto = new BdContext())
            {
                return contexto.Pratos.ToList<Prato>();
            }
        }

        public List<Pedido> ListaPedidos()
        {
            using(var contexto = new BdContext())
            {
                return contexto.Pedidos.ToList<Pedido>();
            }
        }
    }
}