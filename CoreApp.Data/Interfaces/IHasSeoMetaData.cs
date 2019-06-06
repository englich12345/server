
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { get; set; }

        string SeoAlias { get; set; }

        string SeoKeyWords { get; set; }

        string SeoDescription { get; set; }

        
    }
}
