using ARKCRM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ARKCRM.DAL
{
    public class UserInitilazer:System.Data.Entity.DropCreateDatabaseIfModelChanges<ArkcrmContext>
    {
        public object Users { get; private set; }

        protected override void Seed(ArkcrmContext context)
        {
            
            context.Users.AddOrUpdate(x=>x.Id,
                new User() { Id = 1, UserName = "aura08", Password = "artemis1132", Authority = 1, AddDate = DateTime.Now, ClientId = 1 },
                new User() { Id = 2, UserName = "rafet", Password = "f4r3c1k", Authority = 1, AddDate = DateTime.Now, ClientId = 2 }

                );
            
           
           

        }
    }
}