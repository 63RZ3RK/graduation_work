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
    
    public partial class Zayavki
    {
        public int IDZayavki { get; set; }
        public Nullable<int> IDKlient { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CarBrand { get; set; }
        public string ModelCar { get; set; }
        public Nullable<int> Cost { get; set; }
        public string YearAuto { get; set; }
        public string DateZayavki { get; set; }
        public string Complectation { get; set; }
        public string Color { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Klienti Klienti { get; set; }
    }
}
