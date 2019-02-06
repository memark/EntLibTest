using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;

namespace EntLib._6._0._1304.DotNetFramework
{
    class Program
    {
        static void Main()
        {
            var database = new SqlDatabase(Config.Config.connectionString);
            Console.WriteLine($"DbProviderFactory: {database.DbProviderFactory}");

            var command = database.GetStoredProcCommand(Config.Config.StoredProcedureName, Config.Config.parameterValues);
            Console.WriteLine($"command: {command}");
        }
    }
}
