//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABIenCouche
{
    using System;
    using System.Collections.Generic;
    
    public partial class Collaborateurs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Collaborateurs()
        {
            this.Contrats = new HashSet<Contrats>();
        }
    
        internal int matricule { get; set; }
        internal string Nom { get; set; }
        internal string Prenom { get; set; }
        internal string Rue { get; set; }
        internal string Ville { get; set; }
        internal string CodePostal { get; set; }
        internal int Augmentation { get; set; }
        internal string SituationMaritale { get; set; }
        internal string Civilite { get; set; }
        internal string Telephone { get; set; }
        internal string Photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrats> Contrats { get; set; }
    }
}
