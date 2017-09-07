using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}
