using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Security.Models
{

    [Table("SecurityMaster")]
    public class SecurityInfo : SecurityMaster
    {
        public string Type { get; set; }
    }
}
