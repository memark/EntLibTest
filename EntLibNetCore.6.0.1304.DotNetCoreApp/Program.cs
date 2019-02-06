using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;

namespace EntLibNetCore._6._0._1304.DotNetCoreApp
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
