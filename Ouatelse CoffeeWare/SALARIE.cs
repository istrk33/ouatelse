//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ouatelse_CoffeeWare
{
    using System;
    using System.Collections.Generic;
    
    public partial class SALARIE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALARIE()
        {
            this.CONGEs = new HashSet<CONGE>();
            this.PANIERs = new HashSet<PANIER>();
            this.travailles = new HashSet<travaille>();
        }
    
        public int idSalarie { get; set; }
        public string nomPrenom { get; set; }
        public System.DateTime dateNaissance { get; set; }
        public string adresse { get; set; }
        public string telephone { get; set; }
        public string mail { get; set; }
        public string motDePasse { get; set; }
        public int idMyVille { get; set; }
        public int idMyRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGE> CONGEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PANIER> PANIERs { get; set; }
        public virtual ROLE ROLE { get; set; }
        public virtual VILLE VILLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<travaille> travailles { get; set; }
    }
}
