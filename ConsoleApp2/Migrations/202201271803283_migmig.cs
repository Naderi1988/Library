namespace ConsoleApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        BookAuthor = c.String(),
                        BookTranslator = c.String(),
                        BookPublisher = c.String(),
                        BookSubjects = c.String(),
                        BookDate = c.Int(nullable: false),
                        Booklink = c.String(),
                    })
                .PrimaryKey(t => t.BookID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MembersId = c.Int(nullable: false, identity: true),
                        MembersName = c.String(),
                        MemberslastName = c.String(),
                        Memberspassword = c.String(),
                        Membersmobilenumbe = c.String(),
                    })
                .PrimaryKey(t => t.MembersId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
            DropTable("dbo.Books");
        }
    }
}
