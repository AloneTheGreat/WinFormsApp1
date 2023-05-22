namespace WinFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ISBN = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        PathOfImage = c.String(),
                        Author = c.String(),
                        TotalCopies = c.Int(nullable: false),
                        AvailableCopies = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsReturned = c.Boolean(nullable: false),
                        Duration = c.Int(nullable: false),
                        Book_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Book_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        SSN = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBooks", "User_ID", "dbo.Users");
            DropForeignKey("dbo.UserBooks", "Book_ID", "dbo.Books");
            DropForeignKey("dbo.Books", "Category_Id", "dbo.Categories");
            DropIndex("dbo.UserBooks", new[] { "User_ID" });
            DropIndex("dbo.UserBooks", new[] { "Book_ID" });
            DropIndex("dbo.Books", new[] { "Category_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.UserBooks");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
            DropTable("dbo.Admins");
        }
    }
}
