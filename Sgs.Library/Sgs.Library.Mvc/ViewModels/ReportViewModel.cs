﻿using Sgs.Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sgs.Library.Mvc.ViewModels
{
    public class ReportViewModel:BookViewModel
    {
        [Required(ErrorMessage = "{0} is Required !")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Unvalid {0} !")]
        [DisplayName("Report Id")]
        public override string Code { get; set; }

        [StringLength(30, ErrorMessage = "Unvalid Region !")]
        public string Region { get; set; }

        public int ReportTypeId { get; set; }

        public ReportType ReportType { get; set; }

        public bool HasAttachment { get; set; }

        [Required(ErrorMessage = "Abstract is Required !")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Unvalid Abstract !")]
        public string Abstract { get; set; }

        [StringLength(300, ErrorMessage = "Unvalid Note!")]
        public string Note { get; set; }

        public string Status { get; set; }

        public List<ReportType> AllReportsTypes { get; set; }
    }
}
