//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace equip
{
    using System;
    using System.Collections.Generic;
    
    public partial class EquipmentStatus
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int Status { get; set; }
        public string SerialNumber { get; set; }
    
        public virtual Equipment Equipment { get; set; }
    }
}
