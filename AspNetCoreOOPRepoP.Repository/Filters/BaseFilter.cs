using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreOOPRepoP.Repository.Filters
{
    public class BaseFilter
    {
        const int MaxPageSize = 20;
        public string MainCategory { get; set; }
        public string SearchQuery { get; set; }
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value > MaxPageSize ? MaxPageSize : value;
        }
    }
}
