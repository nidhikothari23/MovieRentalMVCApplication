namespace MovieRentalMVCApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataInUserstable : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'269a4494-3baa-46e4-8af7-dd41c74c8fd2', N'domain@admin.com', 0, N'AGlKOwu4q2D8I2j6xIEtd6IaPGWvbd0xpN6mYgHqsxclD6zQnio0X5uEc5P5iBREAg==', N'514adc90-b8c4-444a-8286-683c04243f51', NULL, 0, 0, NULL, 1, 0, N'domain@admin.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f2ea48b0-805e-4870-a898-057235558a07', N'nidhi@user.com', 0, N'AE0oe9BXU69tBHrRRZ9RtJV9PiL/Mjr2EZorsEUccvWOaYzX25J/Iow41cigmwta9A==', N'ef7a374b-310b-486d-88e9-f8ed9e339918', NULL, 0, 0, NULL, 1, 0, N'nidhi@user.com')
                 INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'16fe2bf1-8e03-4750-a70f-8fe7af865537', N'Admin')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'269a4494-3baa-46e4-8af7-dd41c74c8fd2', N'16fe2bf1-8e03-4750-a70f-8fe7af865537')
                  ");
        }
        
        public override void Down()
        {
        }
    }
}
