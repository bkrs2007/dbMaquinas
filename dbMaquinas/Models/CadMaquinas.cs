using System.ComponentModel.DataAnnotations;

namespace dbMaquinas.Models
{
    public class CadMaquinas
    {
        [Key]
        public int IDMaquina { get; set; }
        public int Patrimonio { get; set; } 
        public string Memoria { get; set; }    
        public string HD {  get; set; } 
    }
}
