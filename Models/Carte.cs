using System.Collections.Generic;

namespace ProiectMSOA.Models
{
    public class Carte
    {
        public int Id { get; set; }
        public string Titlu { get; set; } = string.Empty;
        public string Editura { get; set; } = string.Empty;
        public string Categorie { get; set; } = string.Empty;
        public bool Retrasa { get; set; } = false;
        public int Stoc { get; set; }
        public bool Disponibilitate => Stoc > 0;

        public Autor? Autor { get; set; }
        public int AutorId { get; set; }

        public List<Imprumut> Imprumuturi { get; set; } = new List<Imprumut>();
    }
}