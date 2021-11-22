using Security.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Security.Models.ClassFiles
{
    public class Repository : IRepository
    {
        SampleDBContext _context;
        public Repository(SampleDBContext context)
        {
            this._context = context;
        }
     
        public SecurityInfo Add(SecurityInfo security)
        {
            _context.SecurityMaster.Add(security);
            return security;
        }

        public SecurityInfo Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SecurityInfo> GetAllSecurities()
        {
            return _context.SecurityMaster;
        }

        public SecurityInfo GetSecurity(int id)
        {
            throw new NotImplementedException();
        }

        public SecurityInfo Update(SecurityInfo security)
        {
            throw new NotImplementedException();
        }
    
        public void SaveChanges()
        {
            this._context.SaveChanges();
        }
    
    }
}
