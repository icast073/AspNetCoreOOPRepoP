using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreOOPRepoP.Repository.Interfaces
{
    interface IUnitOfWork
    {
        //collect instances of repositories entities interfaces
        bool Commit();
        Task<bool> CommitAsync();
    }
}
