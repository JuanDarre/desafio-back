namespace BE_CRUDClientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int Identificacion { get; set;}
        public int Edad { get; set;}
        public string Genero { get; set;}
        public bool Estado { get; set;}
        public bool Maneja { get; set;} 
        public bool Lentes { get; set;}
        public bool Diabetico { get; set; }
        public string OtraEnfermedad { get; set; }
        public DateTime FechaCreacion { get; set; } 

    }
}
