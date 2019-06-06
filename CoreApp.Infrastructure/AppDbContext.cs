using CoreApp.Data.Entities;
using CoreApp.Data.Enums;
using CoreApp.Data.Interfaces;
using CoreApp.Persistence.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApp.Persistence
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Language> Languages { set; get; }

        public DbSet<SystemConfig> SystemConfigs { get; set; }

        public DbSet<Function> Functions { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AppRole> AppRoles { get; set; }

        public DbSet<Announcement> Announcements { set; get; }

        public DbSet<AnnouncementUser> AnnouncementUsers { set; get; }

        public DbSet<Blog> Bills { set; get; }

        public DbSet<BillDetail> BillDetails { set; get; }

        public DbSet<Blog> Blogs { set; get; }

        public DbSet<BlogTag> BlogTags { set; get; }

        public DbSet<Color> Colors { set; get; }

        public DbSet<Contact> Contacts { set; get; }

        public DbSet<Feedback> Feedbacks { set; get; }

        public DbSet<Footer> Footers { set; get; }

        public DbSet<Page> Pages { set; get; }

        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategories { set; get; }

        public DbSet<ProductImage> ProductImages { set; get; }

        public DbSet<ProductQuantity> ProductQuantities { set; get; }

        public DbSet<ProductTag> ProductTags { set; get; }


        public DbSet<Size> Sizes { set; get; }

        public DbSet<Slide> Slides { set; get; }

        public DbSet<UserInRole> UserInRoles { get; set; }

        public DbSet<Tag> Tags { set; get; }

        public DbSet<RolePermission> Permissions { get; set; }

        public DbSet<ControllerAuth> ControllerAuth { get; set; }

        public DbSet<ActionAuth> ActionAuth { get; set; }

        public DbSet<WholePrice> WholePrices { get; set; }

        public DbSet<AdvertistmentPage> AdvertistmentPages { get; set; }

        public DbSet<Advertistment> Advertistments { get; set; }

        public DbSet<AdvertistmentPosition> AdvertistmentPositions { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //AppUser and AppRole
            builder.Entity<UserInRole>().HasKey(t => new { t.AppUserId, t.AppRoleId });
            builder.Entity<UserInRole>()
                .HasOne(pt => pt.AppUser)
                .WithMany(pt => pt.UserInRoles)
                .HasForeignKey(pt => pt.AppUserId);

            builder.Entity<UserInRole>().HasKey(t => new { t.AppUserId, t.AppRoleId });
            builder.Entity<UserInRole>()
                .HasOne(pt => pt.AppRole)
                .WithMany(pt => pt.UserInRoles)
                .HasForeignKey(pt => pt.AppRoleId);

            //Product Tag
            builder.Entity<ProductTag>().HasKey(t => new { t.ProductId, t.TagId });
            builder.Entity<ProductTag>()
                .HasOne(pt => pt.Product)
                .WithMany(p => p.ProductTags)
                .HasForeignKey(pt => pt.ProductId);
            builder.Entity<ProductTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(p => p.ProductTags)
                .HasForeignKey(pt => pt.TagId);
            
            //Blog Tag
            builder.Entity<BlogTag>().HasKey(t => new { t.BlogId, t.TagId });
            builder.Entity<BlogTag>()
                .HasOne(pt => pt.Blog)
                .WithMany(p => p.BlogTags)
                .HasForeignKey(pt => pt.BlogId);
            builder.Entity<BlogTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(p => p.BlogTags)
                .HasForeignKey(pt => pt.TagId);

            //Role Controller
            builder.Entity<RolePermission>()
                .HasOne(pt => pt.AppRole)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(pt => pt.RoleId);
            builder.Entity<RolePermission>()
                .HasOne(pt => pt.ControllerAuth)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(pt => pt.ControllerId);

            //Role Action
            builder.Entity<RolePermission>()
                .HasOne(pt => pt.AppRole)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(pt => pt.RoleId);
            builder.Entity<RolePermission>()
                .HasOne(pt => pt.ActionAuth)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(pt => pt.ActionId);

            builder.Seed();
        }
    }
}
