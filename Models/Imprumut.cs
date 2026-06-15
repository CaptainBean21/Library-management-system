using System;
using System.Collections.Generic;

namespace ProiectMSOA.Models
{
    public class Imprumut
    {
        public int Id { get; set; }
        public DateTime DataImprumut { get; set; } = DateTime.Now;
        public DateTime DataScadenta { get; set; }
        public int UtilizatorId { get; set; }
        public required Utilizator Utilizator { get; set; }
        public required Carte Carte { get; set; }
        public DateTime? DataReturnare { get; set; } = null;
        public DateTime DataUltimeiPlati { get; set; }
        public bool Platit { get; set; } = false;
        public string Status
        {
            get
            {
                if (!DataReturnare.HasValue && DateTime.Now.Date <= DataScadenta.Date)
                    return "Activ";

                else if (DateTime.Now.Date <= DataScadenta.Date)
                    return "Returnat";

                if (Platit && !DataReturnare.HasValue && DateTime.Now.Date > DataUltimeiPlati.Date)
                    return "Intarziat";

                if (Platit)
                    return "Platit";

                return "Intarziat";

                //if (!DataReturnare.HasValue && DateTime.Now.Date <= DataScadenta.Date)
                //    return "Activ";
                //else if (DateTime.Now.Date <= DataScadenta.Date)
                //    return "Returnat";

                //if (DataReturnare.HasValue && Platit)
                //    return "Plătit";

                //return "Întârziat";
            }
        }
        public decimal Penalizare
        {
            get
            {
                if (Status == "Activ" || Status == "Returnat")
                    return 0.00m;

                int zileIntarziere = (DateTime.Now.Date - DataUltimeiPlati.Date).Days;
                if (DataUltimeiPlati == DataScadenta)
                    return 30 + zileIntarziere * 5;
                return zileIntarziere * 5;
            }
        }
    }
}