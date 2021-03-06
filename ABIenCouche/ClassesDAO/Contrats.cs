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
    
    public partial class Contrats
    {
        /// <summary>
        /// Référence du numéro du contrat
        /// </summary>
        public int NumContrat { get; set; }
        /// <summary>
        /// référence du statut cadre
        /// </summary>
        public bool Statut { get; set; }
        /// <summary>
        /// référence à la qualification
        /// </summary>
        public string Qualification { get; set; }
        /// <summary>
        /// référence au libellé du contrat
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        /// référence a la fonction
        /// </summary>
        public string Fonction { get; set; }
        /// <summary>
        /// référence a la date de début du contrat
        /// </summary>
        public System.DateTime DateDebut { get; set; }
        /// <summary>
        /// référence a l'id du contrat
        /// </summary>
        public int idContrat { get; set; }
        /// <summary>
        /// collection des collaborateur
        /// </summary>
        public virtual Collaborateurs Collaborateurs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        ///collection des avenants
        public virtual ICollection<Avenant> Avenant { get; set; }
    }
}
