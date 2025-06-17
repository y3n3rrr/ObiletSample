using ObiletJourneyApp.Models.DTO;
using ObiletJourneyApp.Services;
using ObiletJourneyApp.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<IObiletService, ObiletApiClient>(c =>
{
    var baseUrl = builder.Configuration["ObiletApi:BaseUrl"];
    if (string.IsNullOrEmpty(baseUrl))
    {
        throw new InvalidOperationException("The configuration value for 'ObiletApi:BaseUrl' is missing or empty.");
    }

    c.BaseAddress = new Uri(baseUrl);
});

builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseRequestLocalization(); 
app.UseHttpsRedirection(); 
app.UseStaticFiles();

app.UseMiddleware<ExceptionMiddleware>();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();