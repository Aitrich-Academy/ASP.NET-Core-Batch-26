using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class HireMeNowDbContext:DbContext
    {

        public HireMeNowDbContext()
        {
        }

        public HireMeNowDbContext(DbContextOptions<HireMeNowDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthUser> AuthUsers { get; set; }
        
        public virtual DbSet<CompanyUser> CompanyUsers { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<JobCategory> JobCategories { get; set; }
        public virtual DbSet<JobPost> JobPosts { get; set; }
        public virtual DbSet<JobProviderCompany> JobProviderCompanies { get; set; }
       
        public virtual DbSet<JobSeeker> JobSeekers { get; set; }
       
        public virtual DbSet<Location> Locations { get; set; }
        
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-C6EG1OJ;Initial Catalog=ADMINWEBAPI;Integrated Security=True;Trust Server Certificate=True").UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<CompanyUser>(entity =>
            {
                entity.ToTable("CompanyUser");

                entity.Property(e => e.CompanyUserId).ValueGeneratedNever();

                entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.CompanyUsers)
                      .HasForeignKey(d => d.Company)
                      .HasConstraintName("FK_CompanyUser_JobProviderCompany");
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.ToTable("Industry");

                entity.Property(e => e.IndustryId).ValueGeneratedNever();
                entity.Property(e => e.Description)
                      .HasMaxLength(50)
                      .IsUnicode(false);
                entity.Property(e => e.Name)
                      .HasMaxLength(50)
                      .IsUnicode(false);

            });

            modelBuilder.Entity<JobCategory>(entity =>
            {
                entity.ToTable("JobCategory");

                entity.Property(e => e.Description)
                      .HasMaxLength(50)
                      .IsUnicode(false);
                entity.Property(e => e.Name)
                      .HasMaxLength(50)
                      .IsUnicode(false);
            });

            modelBuilder.Entity<JobPost>(entity =>
            {
                entity.ToTable("JobPost");

                entity.Property(e => e.JobPostId).ValueGeneratedNever();
                entity.Property(e => e.JobSummary).HasMaxLength(50);
                entity.Property(e => e.JobTitle)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.PostedDate).HasColumnType("datetime");

               

                entity.HasOne(j => j.Company) 
                      .WithMany(c => c.JobPosts) 
                      .HasForeignKey(j => j.CompanyId) 
                      .OnDelete(DeleteBehavior.ClientSetNull)  
                      .HasConstraintName("FK_JobPost_JobProviderCompany");

               
                entity.HasOne(d => d.Location)
                    .WithMany(p => p.JobPosts)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)  
                    .HasConstraintName("FK_JobPost_Location");

                
                entity.HasOne(d => d.PostedByNavigation)
                    .WithMany(p => p.JobPosts)
                    .HasForeignKey(d => d.PostedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull) 
                    .HasConstraintName("FK_JobPost_PostedByNavigation");

               
                entity.HasOne(d => d.JobCategory)
                    .WithMany()
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)  
                    .HasConstraintName("FK_JobPost_JobCategory_CategoryId");

                
                entity.HasOne(d => d.Industry)
                    .WithMany()
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)  
                    .HasConstraintName("FK_JobPost_Industry_IndustryId");

            });

            modelBuilder.Entity<JobProviderCompany>(entity =>
            {
                entity.ToTable("JobProviderCompany");

                entity.Property(e => e.JobProviderCompanyId).ValueGeneratedNever();
                entity.Property(e => e.Address)
                      .HasMaxLength(50)
                      .IsUnicode(false);
                entity.Property(e => e.Email)
                      .HasMaxLength(50)
                      .IsUnicode(false);
                entity.Property(e => e.LegalName)
                      .HasMaxLength(50)
                      .IsUnicode(false);
                entity.Property(e => e.Summary)
                      .HasMaxLength(50)
                      .IsUnicode(false);
                entity.Property(e => e.Website)
                      .HasMaxLength(50)
                      .IsUnicode(false);

                entity.HasOne(d => d.LocationNavigation).WithMany(p => p.JobProviderCompanies)
                      .HasForeignKey(d => d.Location)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_JobProviderCompany_Location");

            });

           

           

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.LocationId).ValueGeneratedNever();
                entity.Property(e => e.Description)
                      .HasMaxLength(10)
                      .IsFixedLength();
                entity.Property(e => e.Name)
                      .HasMaxLength(10)
                      .IsFixedLength();
            });

           

            

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.SkillId);
                entity.Property(e => e.Description)
                      .HasMaxLength(50)
                      .IsUnicode(false);
                entity.Property(e => e.Name)
                      .HasMaxLength(50)
                      .IsUnicode(false);

            });

            

            

           

            OnModelCreatingPartial(modelBuilder);




        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
    }
}
