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
    
    public partial class STOCK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STOCK()
        {
            this.contients = new HashSet<contient>();
            this.FOURNISSEURs = new HashSet<FOURNISSEUR>();
        }
    
        public int idMyMagasin { get; set; }
        public int idMyProduit { get; set; }
        public int prix { get; set; }
        public int quantiteStock { get; set; }
        public string etatStock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contient> contients { get; set; }
        public virtual MAGASIN MAGASIN { get; set; }
        public virtual PRODUIT PRODUIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOURNISSEUR> FOURNISSEURs { get; set; }
    }
}
