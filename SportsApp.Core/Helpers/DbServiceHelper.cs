using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using static SportsApp.Core.Domain.Entities.Players;

namespace SportsApp.Core.Helpers {
    public class DbServiceHelper : IDbServiceHelper {
        private readonly string[] _playerTables = new string[] {
            "Players",
            "Statistics",
            "Cards",
            "Dribbles",
            "Duels",
            "Fouls",
            "Games",
            "Goals",
            "Leagues",
            "Passes",
            "Penalties",
            "Shots",
            "Substitutes",
            "Tackles",
            "Teams" 
        };
        
        public void AddSeed<T>(string path, ref ModelBuilder modelBuilder) where T : class {

        }

        public void AddTable<T>(ref ModelBuilder modelBuilder) where T : class{

        }

        public void AddTableWithSeed<T>(string filePath, string fileName, ref ModelBuilder modelBuilder) where T : class {
            modelBuilder.Entity<T>().ToTable(fileName);
            string searchFilePath = $"{fileName.ToLower()}.json";
            string readJson = File.ReadAllText(Path.Combine(filePath, searchFilePath));
            T? deserializedJson = System.Text.Json.JsonSerializer.Deserialize<T>(readJson);
            modelBuilder.Entity<T>().HasData(deserializedJson);
            
        }
    }
}
