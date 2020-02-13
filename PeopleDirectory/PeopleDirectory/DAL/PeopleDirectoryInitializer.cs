using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PeopleDirectory.Models;

namespace PeopleDirectory.DAL
{
    public class PeopleDirectoryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PeopleDirectoryContext>
    {
        protected override void Seed(PeopleDirectoryContext context)
        {
            var clients = new List<Client>
            {
                new Client{ UserId = 1, FirstName = "A", LastName = "F", Gender = 'M', City = "A", Country = "F", Email = "K", Mobile = "1" },
                new Client{ UserId = 2, FirstName = "B", LastName = "G", Gender = 'M', City = "B", Country = "G", Email = "L", Mobile = "2" },
                new Client{ UserId = 3, FirstName = "C", LastName = "H", Gender = 'M', City = "C", Country = "H", Email = "M", Mobile = "3" },
                new Client{ UserId = 4, FirstName = "D", LastName = "I", Gender = 'F', City = "D", Country = "I", Email = "N", Mobile = "4" },
                new Client{ UserId = 5, FirstName = "E", LastName = "J", Gender = 'F', City = "E", Country = "J", Email = "O", Mobile = "5" }
            };
        }

        public List<Client> GetClients()
        {
            var clients = new List<Client>
            {
                new Client{ UserId = 1, FirstName = "A", LastName = "F", Gender = 'M', City = "A", Country = "F", Email = "K", Mobile = "1" },
                new Client{ UserId = 2, FirstName = "B", LastName = "G", Gender = 'M', City = "B", Country = "G", Email = "L", Mobile = "2" },
                new Client{ UserId = 3, FirstName = "C", LastName = "H", Gender = 'M', City = "C", Country = "H", Email = "M", Mobile = "3" },
                new Client{ UserId = 4, FirstName = "D", LastName = "I", Gender = 'F', City = "D", Country = "I", Email = "N", Mobile = "4" },
                new Client{ UserId = 5, FirstName = "E", LastName = "J", Gender = 'F', City = "E", Country = "J", Email = "O", Mobile = "5" }
            };

            return clients;
        }
    }
}