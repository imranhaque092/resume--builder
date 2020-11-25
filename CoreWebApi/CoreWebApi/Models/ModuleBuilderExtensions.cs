using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public static class ModuleBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "AAA" },
                new Category { CategoryID = 2, CategoryName = "Napa" },
                new Category { CategoryID = 3, CategoryName = "Ace+" }
                );
            modelBuilder.Entity<Specialist>().HasData(
               new Specialist { SpecialistID = 1, SpecialistName = "Dental" },
               new Specialist { SpecialistID = 2, SpecialistName = "Cardiology" },
               new Specialist { SpecialistID = 3, SpecialistName = "Orthopaedics" }
               );
            modelBuilder.Entity<Bank>().HasData(
               new Bank
               {
                   BankID = 1,
                   BankName = "Sonali Bank"

               },
                  new Bank
                  {
                      BankID = 2,
                      BankName = "Rupali Bank"

                  },
                  new Bank
                  {
                      BankID = 3,
                      BankName = "Janota Bank"

                  }
             );
        }
    }
}
