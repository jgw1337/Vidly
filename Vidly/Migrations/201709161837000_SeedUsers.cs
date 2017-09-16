namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'39669812-6be6-4882-9f53-0b3effba95a0', N'admin@vidly.com', 0, N'ADcsCUkDrzS/O2I86LG3b+r6uZRbKXjS2XwuhafLjLcLphh++PWiQyw6oyVrKiBmJQ==', N'b99992ea-ca0c-4001-a96c-28ac7bdc385b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f76fb65-4b97-47a9-b9e0-a34a4bc05422', N'guest@vidly.com', 0, N'ANJz0FL4II0AyPnvvlo1t3w4US9PtQVPnRnMVqiAQFEKvIxANDS+W9Q4rdsXueTDng==', N'72c5c7b5-37f5-4202-9907-9e4946f6ff96', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'24346f2c-281a-47c9-802b-1c9e864dc070', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'39669812-6be6-4882-9f53-0b3effba95a0', N'24346f2c-281a-47c9-802b-1c9e864dc070')
");
        }
        
        public override void Down()
        {
        }
    }
}
