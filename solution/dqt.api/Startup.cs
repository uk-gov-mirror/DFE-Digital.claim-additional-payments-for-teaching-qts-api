﻿using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using dqt.datalayer.Database;
using dqt.domain;
using dqt.datalayer.Repository;
using dqt.datalayer.Model;

[assembly: FunctionsStartup(typeof(dqt.api.Startup))]
namespace dqt.api
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<DQTDataContext>(options => options.UseNpgsql(GetConnStr()));
            builder.Services.AddLogging();
            builder.Services.AddTransient<IQualifiedTeachersService, QualifiedTeachersService>();
            builder.Services.AddTransient<IRepository<QualifiedTeacher>, QualifiedTeachersRepository>();
        }

        private string GetConnStr()
        {
            var server = Environment.GetEnvironmentVariable("DatabaseServerName") ;
            var database = Environment.GetEnvironmentVariable("DatabaseName");
            var username = Environment.GetEnvironmentVariable("DatabaseUsername");
            var password = Environment.GetEnvironmentVariable("DatabasePassword");

            return @$" Server={server};Database={database};Port=5432;User Id={username};Password={password};Ssl Mode=Require;";
        }
    }
}