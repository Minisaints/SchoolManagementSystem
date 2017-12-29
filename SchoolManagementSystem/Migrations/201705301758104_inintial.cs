namespace SchoolManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inintial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ClassSubject = c.String(nullable: false, unicode: false),
                        ClassTutor = c.String(nullable: false, unicode: false),
                        AddedBy = c.String(nullable: false, unicode: false),
                        AddedDate = c.DateTime(nullable: false, precision: 0),
                        Staff_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Staffs", t => t.Staff_id)
                .Index(t => t.Staff_id);
            
            CreateTable(
                "dbo.Pupils",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        LastName = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        Age = c.Int(nullable: false),
                        Telephone = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        Year = c.Int(nullable: false),
                        Grade = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Classid = c.Int(nullable: false),
                        AddedBy = c.String(nullable: false, unicode: false),
                        AddedDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Classes", t => t.Classid, cascadeDelete: true)
                .Index(t => t.Classid);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TutorFirstName = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        TutorLastName = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        TutorFullName = c.String(maxLength: 100, storeType: "nvarchar"),
                        Age = c.Int(nullable: false),
                        AddedBy = c.String(nullable: false, unicode: false),
                        AddedDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "Staff_id", "dbo.Staffs");
            DropForeignKey("dbo.Pupils", "Classid", "dbo.Classes");
            DropIndex("dbo.Pupils", new[] { "Classid" });
            DropIndex("dbo.Classes", new[] { "Staff_id" });
            DropTable("dbo.Staffs");
            DropTable("dbo.Pupils");
            DropTable("dbo.Classes");
        }
    }
}
