namespace ProfileSearchApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profiles", "firstName", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "lastName", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "userName", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "street", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "city", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "state", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Profiles", "zipcode", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Profiles", "phoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "profilePicture", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profiles", "profilePicture", c => c.String());
            AlterColumn("dbo.Profiles", "phoneNumber", c => c.String());
            AlterColumn("dbo.Profiles", "zipcode", c => c.String());
            AlterColumn("dbo.Profiles", "state", c => c.String());
            AlterColumn("dbo.Profiles", "city", c => c.String());
            AlterColumn("dbo.Profiles", "street", c => c.String());
            AlterColumn("dbo.Profiles", "userName", c => c.String());
            AlterColumn("dbo.Profiles", "lastName", c => c.String());
            AlterColumn("dbo.Profiles", "firstName", c => c.String());
        }
    }
}
