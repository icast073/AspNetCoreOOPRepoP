using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreOOPRepoPattern.Data.Dto.Interface
{
    public interface IBaseDto<TKey> where TKey : IComparable
    {
        TKey Id { get; set; }
    }
}
