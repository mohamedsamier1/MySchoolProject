using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySchoolProject.Date.Entities;
using MySchoolProject.Date.Entities.Identity;

namespace MySchoolProject.Infrustructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {

        private readonly IEncryptionProvider _encryptionProvider;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            _encryptionProvider = new GenerateEncryptionProvider("47f5d1312e654dfeb4ebc5ea48a8af96");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DepartmentSubject>()
                        .HasKey(x => new { x.SubId, x.DeptId });
            modelBuilder.Entity<StudentSubject>()
                        .HasKey(x => new { x.StudId, x.SubId });
            modelBuilder.Entity<InstructorSubject>()
                        .HasKey(x => new { x.IntructorId, x.SubjectId });

            modelBuilder.Entity<Instructor>()
                        .HasOne(x => x.Supervisor)
                        .WithMany(x => x.ListInstructors)
                        .HasForeignKey(x => x.SupervisorId)
                        .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Department>()
                       .HasOne(d => d.InstructorMangers)
                       .WithOne(i => i.DepartmentManager)
                       .HasForeignKey<Department>(d => d.Instructor_ManagerId)
                       .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.UseEncryption(_encryptionProvider);
        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<StudentSubject> studentSubjects { get; set; }
        public DbSet<DepartmentSubject> departmentsSubjects { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<InstructorSubject> instructorSubjects { get; set; }
        public DbSet<UserRefreshToken> UserRefreshToken { get; set; }
    }
}
