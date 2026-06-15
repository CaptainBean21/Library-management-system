using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMSOA.Models
{
    public class Utilizator
    {
        public int Id { get; set; } 
        public string Nume { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Parola { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;

        public List<Imprumut> Imprumuturi { get; set; } = new List<Imprumut>();
    }
}
