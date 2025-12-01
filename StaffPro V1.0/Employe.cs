using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPro_V1._0
{
    class Employe
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Sexe { get; set; }
        public string Poste { get; set; }
        public string Departement { get; set; }
        public DateTime DateInsertion { get; set; }
        public DateTime DerniereModification { get; set; }
        public string Statut { get; set; }
        public string Salaire { get; set; }
        public string Duree { get; set; }
    }
}
