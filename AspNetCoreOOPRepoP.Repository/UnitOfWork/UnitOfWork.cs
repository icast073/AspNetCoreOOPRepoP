using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreOOPRepoP.Repository.Interfaces;

namespace AspNetCoreOOPRepoP.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        

        public UnitOfWork()//inject context
        {
           
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public async Task<bool> CommitAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }

}
