using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Security.Models
{
    public abstract class SecurityMaster
    {
        protected SecurityMaster()
        {

        }
        [Key]
        public int SecurityMasterId { get; set; }

        public string Name { get; set; }

      

    }
}
