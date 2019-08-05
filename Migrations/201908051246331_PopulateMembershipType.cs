﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,Discountrate) VALUES(1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,Discountrate) VALUES(2,30,1,10)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,Discountrate) VALUES(3,50,6,40)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,Discountrate) VALUES(4,300,12,60)");

        }

        public override void Down()
        {
        }
    }
}
