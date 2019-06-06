using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApp.Utilities.Dtos
{
    public class PagedList<T> where T : class
    {
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }
        public IList<T> Sources { get; set; }

        public PagedList(IList<T> source, int pageIndex, int pageSize)
        {
            var total = source.Count();
            TotalCount = total;
            TotalPages = total / pageSize;

            if (total % pageSize > 0)
                TotalPages++;

            PageSize = pageSize;
            PageIndex = pageIndex;
            Sources = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
