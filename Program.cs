using CredWise_Trail.Models;
using CredWise_Trail.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<LoanUpdateOrchestratorService>();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BankLoanManagementDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Landing";
        options.AccessDeniedPath = "/Account/AccessDenied";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        options.SlidingExpiration = true;
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
    });

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BankLoanManagementDbContext>();
    dbContext.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
// v-- ADD THIS MIDDLEWARE BLOCK --v
app.Use(async (context, next) =>
{
    try
    {
        await next(context);
    }
    catch (Exception ex)
    {
        // Log the fatal exception to a file before the application dies
        var logPath = Path.Combine(app.Environment.ContentRootPath, "fatal_crash_log.txt");
        var errorDetails = $"[{DateTime.UtcNow}] CRASH DETAILS:\n{ex.ToString()}\n\n";

        // Use non-async method to increase chance of success before shutdown
        File.AppendAllText(logPath, errorDetails);

        // Let the default error handling take over
        throw;
    }
});
// ^-- END OF MIDDLEWARE BLOCK --^

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Landing}/{id?}");

app.Run();