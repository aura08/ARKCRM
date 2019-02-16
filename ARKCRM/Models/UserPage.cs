using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARKCRM.Models
{
    public class UserPage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PageId { get; set; }
        public DateTime AddDate { get; set; }
        public User User { get; set; }
        public Page Pagg { get; set; }


    }
}