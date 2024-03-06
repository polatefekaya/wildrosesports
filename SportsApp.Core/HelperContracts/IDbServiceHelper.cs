using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.HelperContracts {
    public interface IDbServiceHelper {
        public void AddTableWithSeed<T>(string filePath, string fileName, ref ModelBuilder modelBuilder) where T : class;

        public void AddTable<T>(ref ModelBuilder modelBuilder) where T : class;

        public void AddSeed<T>(string path, ref ModelBuilder modelBuilder) where T : class;
    }
}
