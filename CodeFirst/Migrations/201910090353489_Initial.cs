namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParentTasks",
                c => new
                    {
                        Parent_Id = c.Int(nullable: false, identity: true),
                        Parent_Task = c.String(),
                    })
                .PrimaryKey(t => t.Parent_Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Task_Id = c.Int(nullable: false, identity: true),
                        ParentTaskParent_Id = c.Int(nullable: false),
                        TaskName = c.String(),
                        Start_Date = c.String(),
                        End_Date = c.String(),
                        Priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Task_Id)
                .ForeignKey("dbo.ParentTasks", t => t.ParentTaskParent_Id, cascadeDelete: true)
                .Index(t => t.ParentTaskParent_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "ParentTaskParent_Id", "dbo.ParentTasks");
            DropIndex("dbo.Tasks", new[] { "ParentTaskParent_Id" });
            DropTable("dbo.Tasks");
            DropTable("dbo.ParentTasks");
        }
    }
}
