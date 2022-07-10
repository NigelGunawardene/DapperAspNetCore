﻿using DapperAspNetCore.Entities;
using FluentMigrator;

namespace DapperAspNetCore.Migrations;

[Migration(202207120002)]
public class InitialSeed_202207120002 : Migration
{
    public override void Down()
    {
        Delete.FromTable("Employees")
            .Row(new Employee
            {
                Id = new Guid("59c0d403-71ce-4ac8-9c2c-b0e54e7c043b"),
                Age = 34,
                Name = "Test Employee",
                Position = "Test Position",
                CompanyId = new Guid("67fbac34-1ee1-4697-b916-1748861dd275")
            });
        Delete.FromTable("Companies")
            .Row(new Company
            {
                Id = new Guid("67fbac34-1ee1-4697-b916-1748861dd275"),
                Address = "Test Address",
                Country = "USA",
                Name = "Test Name"
            });
    }
    public override void Up()
    {
        Insert.IntoTable("Companies")
            .Row(new Company
            {
                Id = new Guid("67fbac34-1ee1-4697-b916-1748861dd275"),
                Address = "Test Address",
                Country = "USA",
                Name = "Test Name"
            });
        Insert.IntoTable("Employees")
            .Row(new Employee
            {
                Id = new Guid("59c0d403-71ce-4ac8-9c2c-b0e54e7c043b"),
                Age = 34,
                Name = "Test Employee",
                Position = "Test Position",
                CompanyId = new Guid("67fbac34-1ee1-4697-b916-1748861dd275")
            });
    }
}
