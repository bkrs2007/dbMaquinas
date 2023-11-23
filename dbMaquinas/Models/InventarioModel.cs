using System.ComponentModel.DataAnnotations;

namespace dbMaquinas.Models
{
    public class InventarioModel
    {
        [Key]
        public int IDInventario { get; set; }
        public int IDCliente { get; set; } 
        public int IDMaquina { get; set; }  
        public string Valor {  get; set; }  
        public int Quantidade { get; set; } 

        public List<CadClientes> ListaClientes { get; set; }  
        public List<CadMaquinas> ListaMaquinas { get; set; }
    }
}
