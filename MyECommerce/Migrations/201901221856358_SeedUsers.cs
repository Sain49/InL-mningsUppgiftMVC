namespace MyECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bf6faa8a-dad9-40db-8d93-65416b63f243', N'guest@myecommerce.com', 0, N'ACwp8Pqf5bRS2UTZnDGpm9aHAJdyT9ofTSoZxih0fmflHBzLkBuWhcOFx8Fki1kQGQ==', N'0c32d646-06e1-44ce-9df0-5210b95d2711', NULL, 0, 0, NULL, 1, 0, N'guest@myecommerce.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c235051e-82a4-4f8f-9670-4f432d36e1f6', N'admin@myecommerce.com', 0, N'ACGu6c8w9NZF8v3sIZ68MsE+KfbGsvzuu+oPv29jz6SfcLkns8/bgtLmDeLIfFe2ew==', N'6acae156-25fa-45b5-bf5e-b50943e46bac', NULL, 0, 0, NULL, 1, 0, N'admin@myecommerce.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f61f9190-4521-4e2a-8118-b3b7bc5b07ff', N'CanManageProducts')
               
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c235051e-82a4-4f8f-9670-4f432d36e1f6', N'f61f9190-4521-4e2a-8118-b3b7bc5b07ff')

");
        }

        public override void Down()
        {
        }
    }
}