//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassesDAO
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Classe partielle de l'entity framework des collaborateurs
    /// </summary>
    public partial class Collaborateurs
    {
        /// <summary>
        /// référence du matricule du collaborateur
        /// </summary>
        public int matricule { get; set; }
        /// <summary>
        /// référence du nom du collaborateur
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// référence du prénom du collaborateur
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// référence de la civilité
        /// </summary>
        public string Civilite { get; set; }
        /// <summary>
        /// référence de la rue
        /// </summary>
        public string Rue { get; set; }
        /// <summary>
        /// référence de la ville
        /// </summary>
        public string Ville { get; set; }
        /// <summary>
        /// référence du code postal
        /// </summary>
        public string CodePostal { get; set; }
        /// <summary>
        /// référence du téléphone
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// référence de la situation maritale
        /// </summary>
        public string SituationMaritale { get; set; }
        /// <summary>
        /// référence de l'état d'archivage
        /// </summary>
        public bool Archive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        ///Collection de contrats du collaborateurs
        public virtual ICollection<Contrats> Contrats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        ///collection des augmentations
        public virtual ICollection<Augmentations> Augmentations { get; set; }
    }
}
