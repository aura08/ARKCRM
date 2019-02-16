using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARKCRM.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string URL { get; set; }
        public virtual ICollection<UserPage> UserPages { get; set; }

    }
}