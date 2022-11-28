using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StudentLib.Models
{
    public partial class StudentManagementContext : DbContext
    {
        public StudentManagementContext()
        {
        }

        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountRole> AccountRoles { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<ExamResult> ExamResults { get; set; }
        public virtual DbSet<ExamType> ExamTypes { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=StudentManagement;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.DateOfJoin).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .HasColumnName("DOB");

                entity.Property(e => e.PassWord).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(100);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK__Account__Roleid__38996AB5");
            });

            modelBuilder.Entity<AccountRole>(entity =>
            {
                entity.HasKey(e => e.Roleid)
                    .HasName("PK__AccountR__8AF5CA32764CB50E");

                entity.ToTable("AccountRole");

                entity.Property(e => e.Roleid).ValueGeneratedNever();

                entity.Property(e => e.Rolename).HasMaxLength(50);
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("Attendance");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(100)
                    .HasColumnName("CourseID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Attendanc__Accou__48CFD27E");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Attendanc__Cours__47DBAE45");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(100)
                    .HasColumnName("CourseID");

                entity.Property(e => e.SubjectName).HasMaxLength(100);

                entity.Property(e => e.TeacherName).HasMaxLength(100);
            });

            modelBuilder.Entity<ExamResult>(entity =>
            {
                entity.HasKey(e => e.ExamId)
                    .HasName("PK__ExamResu__297521A7346E3353");

                entity.ToTable("ExamResult");

                entity.Property(e => e.ExamId)
                    .HasMaxLength(100)
                    .HasColumnName("ExamID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(100)
                    .HasColumnName("CourseID");

                entity.Property(e => e.ExamStartDate).HasColumnType("date");

                entity.Property(e => e.ExamType).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ExamResults)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__ExamResul__Accou__440B1D61");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.ExamResults)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__ExamResul__Cours__4316F928");

                entity.HasOne(d => d.ExamTypeNavigation)
                    .WithMany(p => p.ExamResults)
                    .HasForeignKey(d => d.ExamType)
                    .HasConstraintName("FK__ExamResul__ExamT__44FF419A");
            });

            modelBuilder.Entity<ExamType>(entity =>
            {
                entity.ToTable("ExamType");

                entity.Property(e => e.ExamtypeId)
                    .HasMaxLength(50)
                    .HasColumnName("ExamtypeID");

                entity.Property(e => e.ExamTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(100)
                    .HasColumnName("CourseID");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Schedule__Accoun__3D5E1FD2");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Schedule__Course__3E52440B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
