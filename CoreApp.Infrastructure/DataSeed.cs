
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApp.Data.Entities;
using CoreApp.Data.Enums;
using CoreApp.Persistence.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CoreApp.Persistence
{

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = AppUserConstant.AppUserId1,
                    Name = "admin",
                    FullName = "Administrator",
                    Email = "admin@gmail.com",
                    Balance = 0,
                    Password = "admin",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Status = Status.Active
                }
            );
            

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = AppRoleConstant.AppUserId1,
                    name = "Admin"
                },
                new AppRole()
                {
                    Id = Guid.NewGuid(),
                    name = "Staff"
                },
                new AppRole()
                {
                    Id = Guid.NewGuid(),
                    name = "Customer"
                }
            );

            modelBuilder.Entity<UserInRole>().HasData(
                new UserInRole()
                {
                    Id = Guid.NewGuid(),
                    AppUserId = AppUserConstant.AppUserId1,
                    AppRoleId = AppRoleConstant.AppUserId1
                }
            );

            //modelBuilder.Entity<ControllerAuth>().HasData(
            //    new ControllerAuth()
            //    {
            //        Id = ControllerConstant.ControllerId1,
            //        Name = "User"
            //    }
            //);

            //modelBuilder.Entity<ActionAuth>().HasData(
            //    new ActionAuth()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "GetList"
            //    },
            //    new ActionAuth()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "getById"
            //    },
            //    new ActionAuth()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "updateUser"
            //    },
            //    new ActionAuth()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "deleteUser"
            //    }
            //);

            //modelBuilder.Entity<RolePermission>().HasData(
            //    new RolePermission()
            //    {
            //        Id = Guid.NewGuid(),
            //        RoleId = AppRoleConstant.AppUserId1,
            //        ControllerId = ControllerConstant.ControllerId1,
            //        ActionId = ActionConstant.ActionId1
            //    }
            //);

            modelBuilder.Entity<Contact>().HasData(
                new Contact()
                {
                    Id = Guid.NewGuid(),
                    Address = "P.Hai-Phong Dien-TT Hue",
                    Email = "englich@gmail.com.com",
                    Name = "Panda Shop",
                    Phone = "0942 324 543",
                    Status = Status.Active,
                    Website = "http://pandashop.com",
                    Lat = 21.0435009,
                    Lng = 105.7894758
                }
           );

            modelBuilder.Entity<Function>().HasData(
                    new Function() { Id = Guid.NewGuid(), Name = "System", ParentId = Guid.NewGuid(), SortOrder = 1, Status = Status.Active, URL = "/", IconCss = "fa-desktop" },
                    new Function() { Id = Guid.NewGuid(), Name = "Role", ParentId = Guid.NewGuid(), SortOrder = 1, Status = Status.Active, URL = "/admin/role/index", IconCss = "fa-home" },
                    new Function() { Id = Guid.NewGuid(), Name = "Function", ParentId = Guid.NewGuid(), SortOrder = 2, Status = Status.Active, URL = "/admin/function/index", IconCss = "fa-home" },
                    new Function() { Id = Guid.NewGuid(), Name = "User", ParentId = Guid.NewGuid(), SortOrder = 3, Status = Status.Active, URL = "/admin/user/index", IconCss = "fa-home" },
                    new Function() { Id = Guid.NewGuid(), Name = "Activity", ParentId = Guid.NewGuid(), SortOrder = 4, Status = Status.Active, URL = "/admin/activity/index", IconCss = "fa-home" },
                    new Function() { Id = Guid.NewGuid(), Name = "Error", ParentId = Guid.NewGuid(), SortOrder = 5, Status = Status.Active, URL = "/admin/error/index", IconCss = "fa-home" },
                    new Function() { Id = Guid.NewGuid(), Name = "Configuration", ParentId = Guid.NewGuid(), SortOrder = 6, Status = Status.Active, URL = "/admin/setting/index", IconCss = "fa-home" },

                    new Function() { Id = Guid.NewGuid(), Name = "Product Management", ParentId = Guid.NewGuid(), SortOrder = 2, Status = Status.Active, URL = "/", IconCss = "fa-chevron-down" },
                    new Function() { Id = Guid.NewGuid(), Name = "Category", ParentId = Guid.NewGuid(), SortOrder = 1, Status = Status.Active, URL = "/admin/productcategory/index", IconCss = "fa-chevron-down" },
                    new Function() { Id = Guid.NewGuid(), Name = "Product", ParentId = Guid.NewGuid(), SortOrder = 2, Status = Status.Active, URL = "/admin/product/index", IconCss = "fa-chevron-down" },
                    new Function() { Id = Guid.NewGuid(), Name = "Bill", ParentId = Guid.NewGuid(), SortOrder = 3, Status = Status.Active, URL = "/admin/bill/index", IconCss = "fa-chevron-down" },

                    new Function() { Id = Guid.NewGuid(), Name = "Content", ParentId = Guid.NewGuid(), SortOrder = 3, Status = Status.Active, URL = "/", IconCss = "fa-table" },
                    new Function() { Id = Guid.NewGuid(), Name = "Blog", ParentId = Guid.NewGuid(), SortOrder = 1, Status = Status.Active, URL = "/admin/blog/index", IconCss = "fa-table" },
                    new Function() { Id = Guid.NewGuid(), Name = "Page", ParentId = Guid.NewGuid(), SortOrder = 2, Status = Status.Active, URL = "/admin/page/index", IconCss = "fa-table" },

                    new Function() { Id = Guid.NewGuid(), Name = "Utilities", ParentId = Guid.NewGuid(), SortOrder = 4, Status = Status.Active, URL = "/", IconCss = "fa-clone" },
                    new Function() { Id = Guid.NewGuid(), Name = "Footer", ParentId = Guid.NewGuid(), SortOrder = 1, Status = Status.Active, URL = "/admin/footer/index", IconCss = "fa-clone" },
                    new Function() { Id = Guid.NewGuid(), Name = "Feedback", ParentId = Guid.NewGuid(), SortOrder = 2, Status = Status.Active, URL = "/admin/feedback/index", IconCss = "fa-clone" },
                    new Function() { Id = Guid.NewGuid(), Name = "Announcement", ParentId = Guid.NewGuid(), SortOrder = 3, Status = Status.Active, URL = "/admin/announcement/index", IconCss = "fa-clone" },
                    new Function() { Id = Guid.NewGuid(), Name = "Contact", ParentId = Guid.NewGuid(), SortOrder = 4, Status = Status.Active, URL = "/admin/contact/index", IconCss = "fa-clone" },
                    new Function() { Id = Guid.NewGuid(), Name = "Slide", ParentId = Guid.NewGuid(), SortOrder = 5, Status = Status.Active, URL = "/admin/slide/index", IconCss = "fa-clone" },
                    new Function() { Id = Guid.NewGuid(), Name = "Advertisment", ParentId = Guid.NewGuid(), SortOrder = 6, Status = Status.Active, URL = "/admin/advertistment/index", IconCss = "fa-clone" },

                    new Function() { Id = Guid.NewGuid(), Name = "Report", ParentId = Guid.NewGuid(), SortOrder = 5, Status = Status.Active, URL = "/", IconCss = "fa-bar-chart-o" },
                    new Function() { Id = Guid.NewGuid(), Name = "Revenue report", ParentId = Guid.NewGuid(), SortOrder = 1, Status = Status.Active, URL = "/admin/report/revenues", IconCss = "fa-bar-chart-o" },
                    new Function() { Id = Guid.NewGuid(), Name = "Visitor Report", ParentId = Guid.NewGuid(), SortOrder = 2, Status = Status.Active, URL = "/admin/report/visitor", IconCss = "fa-bar-chart-o" },
                    new Function() { Id = Guid.NewGuid(), Name = "Reader Report", ParentId = Guid.NewGuid(), SortOrder = 3, Status = Status.Active, URL = "/admin/report/reader", IconCss = "fa-bar-chart-o" }
               );

            string content = "Footer";
            modelBuilder.Entity<Footer>().HasData(
                new Footer()
                {
                    Id = Guid.NewGuid(),
                    Content = content
                }
           );

            modelBuilder.Entity<Color>().HasData(
                new Color() { Id = Guid.NewGuid(), Name = "Black", Code = "#000000"  },
                 new Color() { Id = Guid.NewGuid(), Name = "White", Code = "#FFFFFF" },
                  new Color() { Id = Guid.NewGuid(), Name = "Red", Code = "#ff0000" },
                   new Color() { Id = Guid.NewGuid(), Name = "Blue", Code = "#1000ff" }
           );

            //modelBuilder.Entity<AdvertistmentPage>().HasData(
            //    new AdvertistmentPage()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Home",
            //        AdvertistmentPositions = new List<AdvertistmentPosition>(){
            //            new AdvertistmentPosition(){Id=Guid.NewGuid(), Name="In the left"}
            //        }
            //    },
            //    new AdvertistmentPage()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Product category",
            //        AdvertistmentPositions = new List<AdvertistmentPosition>(){
            //            new AdvertistmentPosition(){Id=Guid.NewGuid(),Name="In the left"}
            //        }
            //    },
            //    new AdvertistmentPage()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Product detail",
            //        AdvertistmentPositions = new List<AdvertistmentPosition>(){
            //            new AdvertistmentPosition(){Id=Guid.NewGuid(),Name="In the left"}
            //        }
            //    }
            //);

            modelBuilder.Entity<Slide>().HasData(
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 1", Image = "/client-side/images/slider/slide-1.jpg", Url = "#", DisplayOrder = 0, GroupAlias = "top", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 2", Image = "/client-side/images/slider/slide-2.jpg", Url = "#", DisplayOrder = 1, GroupAlias = "top", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 3", Image = "/client-side/images/slider/slide-3.jpg", Url = "#", DisplayOrder = 2, GroupAlias = "top", Status = true },

                new Slide() { Id = Guid.NewGuid(), Name = "Slide 1", Image = "/client-side/images/brand1.png", Url = "#", DisplayOrder = 1, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 2", Image = "/client-side/images/brand2.png", Url = "#", DisplayOrder = 2, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 3", Image = "/client-side/images/brand3.png", Url = "#", DisplayOrder = 3, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 4", Image = "/client-side/images/brand4.png", Url = "#", DisplayOrder = 4, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 5", Image = "/client-side/images/brand5.png", Url = "#", DisplayOrder = 5, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 6", Image = "/client-side/images/brand6.png", Url = "#", DisplayOrder = 6, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 7", Image = "/client-side/images/brand7.png", Url = "#", DisplayOrder = 7, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 8", Image = "/client-side/images/brand8.png", Url = "#", DisplayOrder = 8, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 9", Image = "/client-side/images/brand9.png", Url = "#", DisplayOrder = 9, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 10", Image = "/client-side/images/brand10.png", Url = "#", DisplayOrder = 10, GroupAlias = "brand", Status = true },
                new Slide() { Id = Guid.NewGuid(), Name = "Slide 11", Image = "/client-side/images/brand11.png", Url = "#", DisplayOrder = 11, GroupAlias = "brand", Status = true }
           );

            modelBuilder.Entity<Size>().HasData(
                new Size() { Id = Guid.NewGuid(), Name = "XXL" },
                new Size() { Id = Guid.NewGuid(), Name = "XL" },
                new Size() { Id = Guid.NewGuid(), Name = "L" },
                new Size() { Id = Guid.NewGuid(), Name = "M" },
                new Size() { Id = Guid.NewGuid(), Name = "S" },
                new Size() { Id = Guid.NewGuid(), Name = "XS" }
            );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory()
                {
                    Id = AppUserConstant.AppUserId1,
                    Name = "Men shirt",
                    SeoAlias = "men-shirt",
                    ParentId = null, 
                    Status = Status.Active,
                    SortOrder = 1
                },
                new ProductCategory()
                {
                    Id = AppUserConstant.AppUserId2,
                    Name = "Women shirt",
                    SeoAlias = "women-shirt",
                    ParentId = null,
                    Status = Status.Active,
                    SortOrder = 2
                }
            );

           modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Product 16", CategoryId = AppUserConstant.AppUserId2, DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-16", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                new Product() { Id = Guid.NewGuid(), Name = "Product 17", CategoryId = AppUserConstant.AppUserId2, DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-17", Price = 1000, Status = Status.Active, OriginalPrice = 1000 },
                new Product() { Id = Guid.NewGuid(), Name = "Product 18", CategoryId = AppUserConstant.AppUserId1, DateCreated = DateTime.Now, Image = "/client-side/images/products/product-1.jpg", SeoAlias = "san-pham-18", Price = 1000, Status = Status.Active, OriginalPrice = 1000 }
               
           );
           modelBuilder.Entity<SystemConfig>().HasData(
                new SystemConfig()
                {
                    Id = Guid.NewGuid(),
                    Name = "Home's title",
                    Value1 = "Shop",
                    Status = Status.Active
                },
                new SystemConfig()
                {
                    Id = Guid.NewGuid(),
                    Name = "Home's title",
                    Value1 = "Shop",
                    Status = Status.Active
                },
                new SystemConfig()
                {
                    Id = Guid.NewGuid(),
                    Name = "Home's title",
                    Value1 = "Shop",
                    Status = Status.Active
                }
           );
        }
    }
}
        