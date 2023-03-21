using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using School_Management_System.Data.Auth;
using School_Management_System.Data.Entity;
using School_Management_System.Data.MasterData;

namespace School_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor _httpContextAccessor) : base(options)
        {
            this._httpContextAccessor = _httpContextAccessor;
            Database.SetCommandTimeout(300000);
        }

        public DbSet<StudentInfo> studentInfos { get; set; }
        public DbSet<Section> sections { get; set; }
        public DbSet<Resultsheet> resultsheets { get; set; }
        public DbSet<ClassInfo> classInfos { get; set; }
        public DbSet<Gender> genders { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Division> divisions { get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<Thana> thanas { get; set; }
        public DbSet<Occupation> occupations { get; set; }
        public DbSet<Religion> religions { get; set; }
        public DbSet<BookName> bookNames { get; set; }

        #region ERP User Manage
        public DbSet<UserType> UserTypes { get; set; }

        #endregion
    }


}
