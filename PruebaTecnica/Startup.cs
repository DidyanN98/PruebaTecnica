public void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages();
    services.AddScoped<ApiService>(provider => new ApiService("MEYwMEJGQ0E3QUNDN0MxNTg2M0UyOEE1QTU0MTcwM0FBQjUwNjE4MkFGNjQ0RjMyQUNCMDI1OTdDMjUwMDREOA=="));
    services.AddScoped<DatabaseService>(provider => 
        new DatabaseService(Configuration.GetConnectionString("DefaultConnection")));
}
