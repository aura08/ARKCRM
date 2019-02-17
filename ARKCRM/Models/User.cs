﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ARKCRM.Models
{
    public class User
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Authority { get; set; }
        public System.DateTime AddDate { get; set; }
        public int ClientId { get; set; }
        public virtual ICollection<UserPage> UserPages { get; set; }

    }
}