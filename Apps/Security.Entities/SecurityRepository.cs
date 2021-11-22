using Security.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Security.Models.ClassFiles
{
    public class SecurityRepository : Repository,ISecurityRepository
    {
        public SecurityRepository(SampleDBContext context):base(context)
        {

        }

       
    }
}
