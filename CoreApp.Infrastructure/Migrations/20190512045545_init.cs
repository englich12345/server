using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Persistence.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionAuth",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionAuth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertistmentPages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertistmentPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false),
                    Avatar = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Image = table.Column<string>(maxLength: 256, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Content = table.Column<string>(nullable: true),
                    HomeFlag = table.Column<bool>(nullable: true),
                    HotFlag = table.Column<bool>(nullable: true),
                    ViewCount = table.Column<int>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SeoPageTitle = table.Column<string>(maxLength: 256, nullable: true),
                    SeoAlias = table.Column<string>(maxLength: 256, nullable: true),
                    SeoKeyWords = table.Column<string>(maxLength: 256, nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Code = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    Website = table.Column<string>(maxLength: 250, nullable: true),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    Other = table.Column<string>(nullable: true),
                    Lat = table.Column<double>(nullable: true),
                    Lng = table.Column<double>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControllerAuth",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControllerAuth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    Message = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Footers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    URL = table.Column<string>(maxLength: 250, nullable: false),
                    ParentId = table.Column<Guid>(maxLength: 128, nullable: false),
                    IconCss = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    Resources = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Alias = table.Column<string>(maxLength: 256, nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ParentId = table.Column<Guid>(nullable: true),
                    HomeOrder = table.Column<int>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    HomeFlag = table.Column<bool>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SeoPageTitle = table.Column<string>(nullable: true),
                    SeoAlias = table.Column<string>(nullable: true),
                    SeoKeyWords = table.Column<string>(nullable: true),
                    SeoDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: false),
                    Url = table.Column<string>(maxLength: 250, nullable: true),
                    DisplayOrder = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    GroupAlias = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfigs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value1 = table.Column<string>(nullable: true),
                    Value2 = table.Column<int>(nullable: true),
                    Value3 = table.Column<bool>(nullable: true),
                    Value4 = table.Column<DateTime>(nullable: true),
                    Value5 = table.Column<decimal>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertistmentPositions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PageId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertistmentPositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertistmentPositions_AdvertistmentPages_PageId",
                        column: x => x.PageId,
                        principalTable: "AdvertistmentPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    Content = table.Column<string>(maxLength: 250, nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CustomerName = table.Column<string>(maxLength: 256, nullable: false),
                    CustomerAddress = table.Column<string>(maxLength: 256, nullable: false),
                    CustomerMobile = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerMessage = table.Column<string>(maxLength: 256, nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    BillStatus = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_AppUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserInRoles",
                columns: table => new
                {
                    AppUserId = table.Column<Guid>(nullable: false),
                    AppRoleId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInRoles", x => new { x.AppUserId, x.AppRoleId });
                    table.UniqueConstraint("AK_UserInRoles_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInRoles_AppRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInRoles_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    ActionId = table.Column<Guid>(nullable: false),
                    ControllerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_ActionAuth_ActionId",
                        column: x => x.ActionId,
                        principalTable: "ActionAuth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_ControllerAuth_ControllerId",
                        column: x => x.ControllerId,
                        principalTable: "ControllerAuth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PromotionPrice = table.Column<decimal>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    Content = table.Column<string>(nullable: true),
                    HotFlag = table.Column<bool>(nullable: true),
                    ViewCount = table.Column<int>(nullable: true),
                    Tags = table.Column<string>(maxLength: 255, nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    SeoPageTitle = table.Column<string>(nullable: true),
                    SeoAlias = table.Column<string>(maxLength: 255, nullable: true),
                    SeoKeyWords = table.Column<string>(maxLength: 255, nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 255, nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    BlogId = table.Column<Guid>(nullable: false),
                    TagId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => new { x.BlogId, x.TagId });
                    table.UniqueConstraint("AK_BlogTags_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogTags_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Advertistments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    Url = table.Column<string>(maxLength: 250, nullable: true),
                    PositionId = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertistments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertistments_AdvertistmentPositions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "AdvertistmentPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AnnouncementId = table.Column<Guid>(maxLength: 128, nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    HasRead = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnouncementUsers_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BillId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ColorId = table.Column<Guid>(nullable: false),
                    SizeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(maxLength: 250, nullable: true),
                    Caption = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductQuantities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    SizeId = table.Column<Guid>(nullable: false),
                    ColorId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductQuantities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductQuantities_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductQuantities_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductQuantities_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    TagId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => new { x.ProductId, x.TagId });
                    table.UniqueConstraint("AK_ProductTags_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WholePrices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    FromQuantity = table.Column<int>(nullable: false),
                    ToQuantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WholePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WholePrices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { new Guid("075c1072-92a2-4f99-ac11-bf985b13da6e"), "Admin" },
                    { new Guid("e6b40c0d-bb16-49ab-afac-9f4479bc044a"), "Staff" },
                    { new Guid("58261edb-e684-4495-918d-6151314692d8"), "Customer" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Avatar", "Balance", "BirthDay", "DateCreated", "DateModified", "Email", "FullName", "Name", "Password", "PhoneNumber", "Status" },
                values: new object[] { new Guid("075c1072-92a2-4f99-ac11-bf985b23da6e"), null, 0m, null, new DateTime(2019, 5, 12, 11, 55, 44, 723, DateTimeKind.Local).AddTicks(4031), new DateTime(2019, 5, 12, 11, 55, 44, 724, DateTimeKind.Local).AddTicks(1341), "admin@gmail.com", "Administrator", "admin", "admin", null, 1 });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("ca128c25-e3c1-42b2-9fac-f1332699f193"), "#000000", "Black" },
                    { new Guid("c3210055-b3a3-4f91-9f45-3b332de15256"), "#FFFFFF", "White" },
                    { new Guid("bd9887a7-4166-41e2-adc1-6884b921c8b1"), "#ff0000", "Red" },
                    { new Guid("28df8436-a2fc-4185-a5ae-9bb2dcdf9434"), "#1000ff", "Blue" }
                });

            migrationBuilder.InsertData(
                table: "ContactDetails",
                columns: new[] { "Id", "Address", "Email", "Lat", "Lng", "Name", "Other", "Phone", "Status", "Website" },
                values: new object[] { new Guid("dde8058d-76cf-4829-809b-266009871068"), "P.Hai-Phong Dien-TT Hue", "englich@gmail.com.com", 21.043500900000002, 105.78947580000001, "Panda Shop", null, "0942 324 543", 1, "http://pandashop.com" });

            migrationBuilder.InsertData(
                table: "Footers",
                columns: new[] { "Id", "Content" },
                values: new object[] { new Guid("e3ca1125-98d4-4866-a80c-38d1aabefa97"), "Footer" });

            migrationBuilder.InsertData(
                table: "Functions",
                columns: new[] { "Id", "IconCss", "Name", "ParentId", "SortOrder", "Status", "URL" },
                values: new object[,]
                {
                    { new Guid("71c05c3d-f03d-4d4d-9a34-f419a651b5e4"), "fa-clone", "Utilities", new Guid("16b05aac-5d33-471e-b5bf-8d926e52aca0"), 4, 1, "/" },
                    { new Guid("0ba1d5a0-da77-4d0a-a119-ccb8fd52ca03"), "fa-clone", "Footer", new Guid("52185929-47a4-491a-ad7e-3860b047fcc1"), 1, 1, "/admin/footer/index" },
                    { new Guid("d03f70fb-85ce-4446-b78a-68814b09d36d"), "fa-clone", "Feedback", new Guid("16a55dc8-1b16-4abd-b8f4-d19a91eefb90"), 2, 1, "/admin/feedback/index" },
                    { new Guid("43860cbd-649c-488b-a6df-4c0ce76fb22c"), "fa-clone", "Announcement", new Guid("5c39cbe9-d91a-4fe2-8763-6d6a508be593"), 3, 1, "/admin/announcement/index" },
                    { new Guid("c88076aa-7756-4263-af2c-ffbc51eb222d"), "fa-clone", "Contact", new Guid("7d0f5dca-0371-44b5-9920-6832bf6ea303"), 4, 1, "/admin/contact/index" },
                    { new Guid("1776f0dc-df00-42a2-b378-8873ddd84303"), "fa-bar-chart-o", "Reader Report", new Guid("f8f01a03-fdca-4d82-b813-92c7d546b6c8"), 3, 1, "/admin/report/reader" },
                    { new Guid("d17104a7-1471-454f-aeff-ed8d3bbd55dd"), "fa-bar-chart-o", "Report", new Guid("a1f67f84-6a7d-4fd8-9809-6b5e7314c7f7"), 5, 1, "/" },
                    { new Guid("94d1aa79-4c9e-44d5-9966-51b8fe83dfee"), "fa-bar-chart-o", "Revenue report", new Guid("2337a730-dba6-460e-8702-d2ce078474f0"), 1, 1, "/admin/report/revenues" },
                    { new Guid("4fdf9897-4471-4495-9716-4dd5825e1939"), "fa-bar-chart-o", "Visitor Report", new Guid("e46bbaf1-a5a2-4d45-b234-7c9ca9d5e04e"), 2, 1, "/admin/report/visitor" },
                    { new Guid("f62f3ef1-7839-438d-9ccd-c5498c0f4846"), "fa-table", "Page", new Guid("6b2971a6-1120-4162-bfb0-f592064de1c9"), 2, 1, "/admin/page/index" },
                    { new Guid("2ead40de-ca16-44e2-9050-190deebe8791"), "fa-clone", "Advertisment", new Guid("71dafe3a-be25-4281-9bda-74705a05ecce"), 6, 1, "/admin/advertistment/index" },
                    { new Guid("78609316-2df1-4d04-a924-1acd49a1f77b"), "fa-table", "Blog", new Guid("4410403c-b4a9-4ad7-aa12-83e8861a39f7"), 1, 1, "/admin/blog/index" },
                    { new Guid("78b2b69f-9b41-4145-8272-c4f3028224b1"), "fa-clone", "Slide", new Guid("0592512d-06c9-402b-a4cc-ec2a0c841ddc"), 5, 1, "/admin/slide/index" },
                    { new Guid("59672901-f5c6-4d59-a53e-3f610b8f4343"), "fa-chevron-down", "Bill", new Guid("bdaa83ca-42fb-4820-99e6-2f6c3bbbe967"), 3, 1, "/admin/bill/index" },
                    { new Guid("5b816512-de1a-4c8f-b9d8-7706e49e5479"), "fa-chevron-down", "Product", new Guid("acf82ea7-a213-4a1d-8d2f-f7b244a84ff0"), 2, 1, "/admin/product/index" },
                    { new Guid("8502c968-8b68-4794-8278-7e3a6d9bfdbc"), "fa-chevron-down", "Category", new Guid("76e76b11-e760-4499-a825-0b84990a6b31"), 1, 1, "/admin/productcategory/index" },
                    { new Guid("2d272548-2982-429d-836b-d72824977e55"), "fa-chevron-down", "Product Management", new Guid("f562bbbe-8e2b-46a6-82f0-513ae52445b4"), 2, 1, "/" },
                    { new Guid("14cac5e9-21c7-44c7-a16e-9704f2945512"), "fa-home", "Configuration", new Guid("d9dd116b-022d-4012-9077-297be388e311"), 6, 1, "/admin/setting/index" },
                    { new Guid("c091c3f6-c2e4-41b8-8246-d7f0f077f843"), "fa-home", "Error", new Guid("ba65b7b6-c7e0-40a3-8e0b-fa971151e39a"), 5, 1, "/admin/error/index" },
                    { new Guid("23d21d8d-7838-4e4b-99b2-067fa11297a4"), "fa-home", "Activity", new Guid("b21376b4-4556-4a48-a25b-7f2fed8660c3"), 4, 1, "/admin/activity/index" },
                    { new Guid("ce3a3a6e-e2db-4f62-a472-557d43ebf699"), "fa-home", "User", new Guid("e5e29919-a5e6-4811-8983-805c879a36dd"), 3, 1, "/admin/user/index" },
                    { new Guid("92365c62-59ea-4c2b-bba7-b76af35ece89"), "fa-home", "Function", new Guid("3f852d2d-624d-4068-bcf8-68c15ff84e4b"), 2, 1, "/admin/function/index" },
                    { new Guid("87baa38b-55f8-4e10-81f9-cf570c9f1418"), "fa-home", "Role", new Guid("2fd41460-7077-49b2-a602-b5e7697ef147"), 1, 1, "/admin/role/index" },
                    { new Guid("b145d66b-e701-4cfe-91fa-ad7aa5def84b"), "fa-desktop", "System", new Guid("518d23fe-0672-487e-a660-7d0d178519e0"), 1, 1, "/" },
                    { new Guid("cc20ffa1-83f6-4cc8-8dd5-90d1cbd72f47"), "fa-table", "Content", new Guid("af082282-f006-4cf1-a710-6814557334ae"), 3, 1, "/" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "HomeFlag", "HomeOrder", "Image", "Name", "ParentId", "SeoAlias", "SeoDescription", "SeoKeyWords", "SeoPageTitle", "SortOrder", "Status" },
                values: new object[,]
                {
                    { new Guid("075c1072-92a2-4f99-ac11-bf985b23da6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Men shirt", null, "men-shirt", null, null, null, 1, 1 },
                    { new Guid("075c1072-92a2-4f95-ac11-bf985b23da6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Women shirt", null, "women-shirt", null, null, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("41e45803-5f86-4910-8192-06d770446b14"), "XS" },
                    { new Guid("2e7c6d19-468b-45fc-8942-f7bf99436c7d"), "M" },
                    { new Guid("40ccd247-05c4-4936-8f3c-2f88ade7dc57"), "S" },
                    { new Guid("6fc7ec10-370e-45d6-a700-0038f38952e4"), "XL" },
                    { new Guid("6fd3e2cc-fb0d-42d2-8922-446676c93e80"), "XXL" },
                    { new Guid("fccea93f-d97b-40cb-b8a4-c090dc09ea71"), "L" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "Content", "Description", "DisplayOrder", "GroupAlias", "Image", "Name", "Status", "Url" },
                values: new object[,]
                {
                    { new Guid("901bf352-3e13-4e9f-ade4-fb3da9cced48"), null, null, 11, "brand", "/client-side/images/brand11.png", "Slide 11", true, "#" },
                    { new Guid("8ee512af-a1f6-4e52-8f09-4a4d167c7e89"), null, null, 10, "brand", "/client-side/images/brand10.png", "Slide 10", true, "#" },
                    { new Guid("c6bd376d-4920-4eb1-81ee-97c0afdbd65b"), null, null, 9, "brand", "/client-side/images/brand9.png", "Slide 9", true, "#" },
                    { new Guid("a8573ef5-7fc9-4b7d-9412-8f85f2baaef6"), null, null, 8, "brand", "/client-side/images/brand8.png", "Slide 8", true, "#" },
                    { new Guid("78929c1d-a60a-4dc8-9320-e4ae70945e96"), null, null, 7, "brand", "/client-side/images/brand7.png", "Slide 7", true, "#" },
                    { new Guid("43a2dcab-1ab5-4566-a6eb-7031182b6bcf"), null, null, 6, "brand", "/client-side/images/brand6.png", "Slide 6", true, "#" },
                    { new Guid("7da54abf-974a-4fda-a35e-f6f70e73c935"), null, null, 5, "brand", "/client-side/images/brand5.png", "Slide 5", true, "#" },
                    { new Guid("d7bdd071-cf39-41e2-9e2c-c7293eab5ecc"), null, null, 4, "brand", "/client-side/images/brand4.png", "Slide 4", true, "#" },
                    { new Guid("848ee67d-4074-481f-ae4a-c50e3099612d"), null, null, 2, "brand", "/client-side/images/brand2.png", "Slide 2", true, "#" },
                    { new Guid("d38ab7b8-6f96-4505-899b-f66a4a8cab44"), null, null, 1, "brand", "/client-side/images/brand1.png", "Slide 1", true, "#" },
                    { new Guid("3597ed87-007a-432b-96c5-54bc7dae0bea"), null, null, 2, "top", "/client-side/images/slider/slide-3.jpg", "Slide 3", true, "#" },
                    { new Guid("412ae596-babf-44b5-bf76-c10cd267b4e8"), null, null, 1, "top", "/client-side/images/slider/slide-2.jpg", "Slide 2", true, "#" },
                    { new Guid("20a96b1e-da44-42e1-b736-1fcdd38cf35a"), null, null, 0, "top", "/client-side/images/slider/slide-1.jpg", "Slide 1", true, "#" },
                    { new Guid("df075864-98b3-4877-bc56-a71255aeecec"), null, null, 3, "brand", "/client-side/images/brand3.png", "Slide 3", true, "#" }
                });

            migrationBuilder.InsertData(
                table: "SystemConfigs",
                columns: new[] { "Id", "Name", "Status", "Value1", "Value2", "Value3", "Value4", "Value5" },
                values: new object[,]
                {
                    { new Guid("52ff089b-b1cb-4468-a1b6-98823953c49d"), "Home's title", 1, "Shop", null, null, null, null },
                    { new Guid("a158d15b-1772-44e3-a46e-c2288740d46c"), "Home's title", 1, "Shop", null, null, null, null },
                    { new Guid("3538d178-763f-49c7-9452-362992391bce"), "Home's title", 1, "Shop", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Content", "DateCreated", "DateModified", "Description", "HotFlag", "Image", "Name", "OriginalPrice", "Price", "PromotionPrice", "SeoAlias", "SeoDescription", "SeoKeyWords", "SeoPageTitle", "Status", "Tags", "Unit", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("96a5f45f-dfe3-4c38-ab0c-d5f7f2a4d5be"), new Guid("075c1072-92a2-4f99-ac11-bf985b23da6e"), null, new DateTime(2019, 5, 12, 11, 55, 44, 728, DateTimeKind.Local).AddTicks(4101), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/client-side/images/products/product-1.jpg", "Product 18", 1000m, 1000m, 0m, "san-pham-18", null, null, null, 1, null, null, null },
                    { new Guid("4ac7d971-e4ad-499f-9dd1-0b6003af1c40"), new Guid("075c1072-92a2-4f95-ac11-bf985b23da6e"), null, new DateTime(2019, 5, 12, 11, 55, 44, 728, DateTimeKind.Local).AddTicks(1157), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/client-side/images/products/product-1.jpg", "Product 16", 1000m, 1000m, 0m, "san-pham-16", null, null, null, 1, null, null, null },
                    { new Guid("2cff3cc9-55e3-4537-b29a-208e36a5ba33"), new Guid("075c1072-92a2-4f95-ac11-bf985b23da6e"), null, new DateTime(2019, 5, 12, 11, 55, 44, 728, DateTimeKind.Local).AddTicks(4071), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "/client-side/images/products/product-1.jpg", "Product 17", 1000m, 1000m, 0m, "san-pham-17", null, null, null, 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserInRoles",
                columns: new[] { "AppUserId", "AppRoleId", "Id" },
                values: new object[] { new Guid("075c1072-92a2-4f99-ac11-bf985b23da6e"), new Guid("075c1072-92a2-4f99-ac11-bf985b13da6e"), new Guid("c094d5ef-9fe0-43d6-b4c3-3db705a611be") });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertistmentPositions_PageId",
                table: "AdvertistmentPositions",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertistments_PositionId",
                table: "Advertistments",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_UserId",
                table: "Announcements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementUsers_AnnouncementId",
                table: "AnnouncementUsers",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_BillId",
                table: "BillDetails",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_ColorId",
                table: "BillDetails",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_ProductId",
                table: "BillDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_SizeId",
                table: "BillDetails",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CustomerId",
                table: "Bills",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_TagId",
                table: "BlogTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductQuantities_ColorId",
                table: "ProductQuantities",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductQuantities_ProductId",
                table: "ProductQuantities",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductQuantities_SizeId",
                table: "ProductQuantities",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_ActionId",
                table: "RolePermissions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_ControllerId",
                table: "RolePermissions",
                column: "ControllerId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleId",
                table: "RolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInRoles_AppRoleId",
                table: "UserInRoles",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WholePrices_ProductId",
                table: "WholePrices",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertistments");

            migrationBuilder.DropTable(
                name: "AnnouncementUsers");

            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Footers");

            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductQuantities");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "SystemConfigs");

            migrationBuilder.DropTable(
                name: "UserInRoles");

            migrationBuilder.DropTable(
                name: "WholePrices");

            migrationBuilder.DropTable(
                name: "AdvertistmentPositions");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "ActionAuth");

            migrationBuilder.DropTable(
                name: "ControllerAuth");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AdvertistmentPages");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
