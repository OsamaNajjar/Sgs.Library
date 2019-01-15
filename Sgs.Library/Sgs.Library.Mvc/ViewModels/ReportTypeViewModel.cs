using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sgs.Library.Mvc.ViewModels
{
    public class ReportTypeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required ..!")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Unvalid Name !")]
        public string Name { get; set; }

    }
}
