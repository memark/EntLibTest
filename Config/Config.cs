namespace Config
{
    public static class Config
    {
        public static string connectionString = @"Server=(LocalDB)\ProjectsV13;Database=master";

        public static string StoredProcedureName = "sys.sp_help";

        public static string[] parameterValues = new[] { "abc" };
    }
}
