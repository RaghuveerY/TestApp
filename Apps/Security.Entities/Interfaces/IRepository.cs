using System;
using System.Collections.Generic;
using System.Text;

namespace Security.Models.Interfaces
{
    public interface IRepository
    {
        SecurityInfo GetSecurity(int id);
        IEnumerable<SecurityInfo> GetAllSecurities();
        SecurityInfo Add(SecurityInfo security);
        SecurityInfo Update(SecurityInfo security);
        SecurityInfo Delete(int id);
    }
}
