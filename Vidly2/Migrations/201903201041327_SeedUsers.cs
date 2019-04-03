namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'28db5145-7e6c-4b6b-89c9-2e2a4b7bbbc4', N'admin@vidly.com', 0, N'AJoDNfiukH/38U+I3aRKKgUxnUqRGCDMPhXGcxuzTT3AzI9kJyNFF7UQDbHa6yuxxQ==', N'f1548766-11b4-4668-8cb6-33d437e62ea3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'38d2dd7c-31e6-44cb-9763-6cea24b64ad8', N'guest@vidly.com', 0, N'ADT1caer0zsgWIS+vP2fCqrQ0o8CTNKsl2Cy95b5/6U8yG63oUGwHho661SziIaXQQ==', N'1707399a-a548-43af-b64d-d498bf35892b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'590c2287-ddd0-4ddd-a11f-81e694a77985', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'28db5145-7e6c-4b6b-89c9-2e2a4b7bbbc4', N'590c2287-ddd0-4ddd-a11f-81e694a77985')
");
        }
        
        public override void Down()
        {
        }
    }
}
