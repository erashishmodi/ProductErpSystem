using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductErpSystem.Areas.Admin.Models
{
    public class UnitViewModel
    {
        public int UnitId { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public String UnitName { get; set;}
        public bool IsDeleted { get; set; }
    }
}