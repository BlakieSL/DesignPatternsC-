﻿namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        //public static IDatabase CreateDatabase(...)
        //{
        //  ...
        //}
        public static IDatabase CreateDatabase(DatabaseType type)
        {
            return type switch
            {
                DatabaseType.SqlServer => new SqlServerDatabase(),
                DatabaseType.Oracle => new OracleDatabase(),
                _ => throw new Exception()
            };
        }
    }
}
