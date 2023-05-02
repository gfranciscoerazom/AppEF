using System.ComponentModel.DataAnnotations;

namespace AppEF.Models
{
    public class Cliente
    {
        // [Key]
        public int ClienteId
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Numero
        {
            get;
            set;
        }

        public Cliente(int clienteId, string nombre, string email, string numero)
        {
            ClienteId = clienteId;
            Nombre = nombre;
            Email = email;
            Numero = numero;
        }
    }
}
