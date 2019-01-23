namespace MyECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProductsAndCategory : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[ProductCategories] ([Id], [Name]) VALUES (1, N'Datorer')
INSERT INTO [dbo].[ProductCategories] ([Id], [Name]) VALUES (2, N'Telefoner')
INSERT INTO [dbo].[ProductCategories] ([Id], [Name]) VALUES (3, N'Ljud & Bild')
SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([Id], [Name], [Description], [Price], [Category_Id]) VALUES (13, N'Surface Notebook', N'i7 Geforce 1080, RAM 16GB', 15700, 1)
INSERT INTO [dbo].[Products] ([Id], [Name], [Description], [Price], [Category_Id]) VALUES (15, N'IPhone 8', N'Apple Iphone 8 64GB', 6438, 2)
INSERT INTO [dbo].[Products] ([Id], [Name], [Description], [Price], [Category_Id]) VALUES (16, N'S8+', N'Samsung Galaxy S8', 4350, 2)
INSERT INTO [dbo].[Products] ([Id], [Name], [Description], [Price], [Category_Id]) VALUES (17, N'Apple AirPods', N'Wireless earphones from Apple', 1596, 3)
INSERT INTO [dbo].[Products] ([Id], [Name], [Description], [Price], [Category_Id]) VALUES (18, N'Samsung Gear Icon', N'Wireless earphones from Samsung', 857, 3)
INSERT INTO [dbo].[Products] ([Id], [Name], [Description], [Price], [Category_Id]) VALUES (21, N's7 edge', N'Samsung new Edge desing Model', 3158, 2)
SET IDENTITY_INSERT [dbo].[Products] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
