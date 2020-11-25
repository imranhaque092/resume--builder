using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<CareerInformation> CareerInformations { get; set; }
        public DbSet<EducationalInfomation> EducationalInfomations { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<RefereeInformation> RefereeInformations { get; set; }
        public DbSet<TrainingInfornation> TrainingInfornation { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }


    }
}
