using System.Collections.Generic;

namespace ProiectMSOA.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nume { get; set; } = string.Empty;
        public string Biografie { get; set; } = string.Empty;

        public List<Carte> Carti { get; set; } = new List<Carte>();
    }
}