using System.ComponentModel.DataAnnotations;

namespace dbMaquinas.Models
{
    public class CadClientes
    {
        [Key]
        public int IDCliente { get; set; }  
        public string NomeCliente { get; set; } 
        public string CPF {  get; set; }    
    }
}
