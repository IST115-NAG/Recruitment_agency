//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecAgency.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vacancy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdOfAuthor { get; set; }
        public string Field { get; set; }
        public string Schedule { get; set; }
        public int Experience { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public System.DateTime DateOfPublication { get; set; }
        public string Info { get; set; }
    }
}