﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Webase.Data;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<PriorityStatus> Prioritystatuses { get; set; }

    public virtual DbSet<Profission> Profissions { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectType> Projecttypes { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<TaskStatus> Taskstatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Webase_1;Username=postgres;Password=postgres;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("employee_pkey");

            entity.ToTable("employee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("lastname");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(15)
                .HasColumnName("phonenumber");
            entity.Property(e => e.Profissionid).HasColumnName("profissionid");

            entity.HasOne(d => d.Profission).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Profissionid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("employee_profissionid_fkey");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("organization_pkey");

            entity.ToTable("organization");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accounter).HasColumnName("accounter");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Director).HasColumnName("director");
            entity.Property(e => e.Inn)
                .HasMaxLength(20)
                .HasColumnName("inn");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Okedid).HasColumnName("okedid");
        });

        modelBuilder.Entity<PriorityStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("prioritystatus_pkey");

            entity.ToTable("prioritystatus");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Statusname)
                .HasMaxLength(50)
                .HasColumnName("statusname");
        });

        modelBuilder.Entity<Profission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("profission_pkey");

            entity.ToTable("profission");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("project_pkey");

            entity.ToTable("project");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deadline).HasColumnName("deadline");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Organizationid).HasColumnName("organizationid");
            entity.Property(e => e.Priorityid).HasColumnName("priorityid");
            entity.Property(e => e.Typeid).HasColumnName("typeid");

            entity.HasOne(d => d.Organization).WithMany(p => p.Projects)
                .HasForeignKey(d => d.Organizationid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("project_organizationid_fkey");

            entity.HasOne(d => d.Priority).WithMany(p => p.Projects)
                .HasForeignKey(d => d.Priorityid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("project_priorityid_fkey");

            entity.HasOne(d => d.Type).WithMany(p => p.Projects)
                .HasForeignKey(d => d.Typeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("project_typeid_fkey");
        });

        modelBuilder.Entity<ProjectType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("projecttype_pkey");

            entity.ToTable("projecttype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Typename)
                .HasMaxLength(50)
                .HasColumnName("typename");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("task_pkey");

            entity.ToTable("task");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Completiondate).HasColumnName("completiondate");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Statusid).HasColumnName("statusid");

            entity.HasOne(d => d.Project).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.Projectid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("task_projectid_fkey");

            entity.HasOne(d => d.Status).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.Statusid)
                .HasConstraintName("task_statusid_fkey");

            entity.HasMany(d => d.Employees).WithMany(p => p.Tasks)
                .UsingEntity<Dictionary<string, object>>(
                    "Taskemployee",
                    r => r.HasOne<Employee>().WithMany()
                        .HasForeignKey("Employeeid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("taskemployee_employeeid_fkey"),
                    l => l.HasOne<Task>().WithMany()
                        .HasForeignKey("Taskid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("taskemployee_taskid_fkey"),
                    j =>
                    {
                        j.HasKey("Taskid", "Employeeid").HasName("taskemployee_pkey");
                        j.ToTable("taskemployee");
                        j.IndexerProperty<int>("Taskid").HasColumnName("taskid");
                        j.IndexerProperty<int>("Employeeid").HasColumnName("employeeid");
                    });
        });

        modelBuilder.Entity<TaskStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("taskstatus_pkey");

            entity.ToTable("taskstatus");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Statusname)
                .HasMaxLength(50)
                .HasColumnName("statusname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
