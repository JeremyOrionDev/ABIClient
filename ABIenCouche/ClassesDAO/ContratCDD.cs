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
    /// classe publique de contrat CDD
    /// </summary>
    public partial class ContratCDD : Contrats
    {
        /// <summary>
        /// référence de la date de fin du contrat
        /// </summary>
        public System.DateTime DateFin { get; set; }
        /// <summary>
        /// référence du motif du contrat
        /// </summary>
        public string Motif { get; set; }
        /// <summary>
        /// référence du salaire du collaborateur
        /// </summary>
        public double Salaire { get; set; }
    }
}
