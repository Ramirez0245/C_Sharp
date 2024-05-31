
// ASP.NET Core apps created with the web templates contain the application startup code in the Program.cs file.

// The following app startup code supports:

// Razor Pages
// MVC controllers with views
// Web API with controllers
// Minimal APIs

namespace App_Startup
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddRazorPages();
    builder.Services.AddControllersWithViews();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseAuthorization();

    app.MapGet("/hi", () => "Hello!");

    app.MapDefaultControllerRoute();
    app.MapRazorPages();

    app.Run()
}

