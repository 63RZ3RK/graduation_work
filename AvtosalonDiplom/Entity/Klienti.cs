//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AvtosalonDiplom.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klienti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klienti()
        {
            this.Prodazhi = new HashSet<Prodazhi>();
            this.Zayavki = new HashSet<Zayavki>();
        }
    
        public int IDKlient { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PasportNumber { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string GotFrom { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prodazhi> Prodazhi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zayavki> Zayavki { get; set; }
    }
}
