using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace SportsApp.Infrastructure.Data.Player
{
    public class PlayerDbContext : DbContext
    {

        private readonly string _jsonPath = "Jsons/Player/";

        public PlayerDbContext(DbContextOptions options) : base(options) { 
            
        }

        public DbSet<PlayerEntity> Players { get; set; }

        public DbSet<StatisticEntity> Statistics { get; set; }
        
        public DbSet<TeamEntity> Teams { get; set; }

        public DbSet<LeagueEntity> Leagues { get; set; }

        public DbSet<SubstituteEntity> Substitutes { get; set; }

        public DbSet<GameEntity> Games { get; set; }

        public DbSet<ShotEntity> Shots { get; set; }

        public DbSet<GoalEntity> Goals { get; set; }

        public DbSet<PassEntity> Passes { get; set; }

        public DbSet<TackleEntity> Tackles { get; set; }

        public DbSet<DuelEntity> Duels { get; set; }

        public DbSet<DribbleEntity> Dribbles { get; set; }

        public DbSet<FoulEntity> Fouls { get; set; }

        public DbSet<CardEntity> Cards { get; set; }

        public DbSet<PenaltyEntity> Penalties { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            

            AddTableWithSeed<PlayerEntity>(_jsonPath, "Players", ref modelBuilder);

            AddTableWithSeed<StatisticEntity>(_jsonPath,"Statistics", ref modelBuilder);

            AddTableWithSeed<TeamEntity>(_jsonPath, "Teams", ref modelBuilder);

            AddTableWithSeed<LeagueEntity>(_jsonPath, "Leagues", ref modelBuilder);

            AddTableWithSeed<SubstituteEntity>(_jsonPath, "Substitutes", ref modelBuilder);

            AddTableWithSeed<ShotEntity>(_jsonPath, "Shots", ref modelBuilder);

            AddTableWithSeed<GoalEntity>(_jsonPath, "Goals", ref modelBuilder);

            AddTableWithSeed<PassEntity>(_jsonPath, "Passes", ref modelBuilder);

            AddTableWithSeed<TackleEntity>(_jsonPath, "Tackles", ref modelBuilder);

            AddTableWithSeed<DuelEntity>(_jsonPath, "Duels", ref modelBuilder);

            AddTableWithSeed<DribbleEntity>(_jsonPath, "Dribbles", ref modelBuilder);

            AddTableWithSeed<FoulEntity>(_jsonPath, "Fouls", ref modelBuilder);

            AddTableWithSeed<CardEntity>(_jsonPath, "Cards", ref modelBuilder);

            AddTableWithSeed<PenaltyEntity>(_jsonPath, "Penalties", ref modelBuilder);

            AddTableWithSeed<GameEntity>(_jsonPath, "Games", ref modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public void AddTableWithSeed<T>(string filePath, string fileName, ref ModelBuilder modelBuilder) where T : class {
            modelBuilder.Entity<T>().ToTable(fileName);

            string readJson = File.ReadAllText(Path.Combine(filePath, (fileName.ToLower() + ".json")));
            T? deserializedJson = JsonConvert.DeserializeObject<T>(readJson);
            //T? deserializedJson = System.Text.Json.JsonSerializer.Deserialize<T>(readJson);
            modelBuilder.Entity<T>().HasData(deserializedJson);

        }
    }
}
