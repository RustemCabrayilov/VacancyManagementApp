﻿using Microsoft.Extensions.Configuration;

namespace VacancyManagementApp.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "C:\\Users\\99470\\Desktop\\VacancyManagementApp\\Presentation\\VacancyManagementApp.API"));
                configurationManager.AddJsonFile("appsettings.json");

                var connectionString = configurationManager.GetConnectionString("DefaultConnection");

                return connectionString;
            }
        }
    }
}