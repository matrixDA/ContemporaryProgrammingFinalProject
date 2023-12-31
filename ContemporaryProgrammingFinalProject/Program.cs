using ContemporaryProgrammingFinalProject.Data;
using Microsoft.EntityFrameworkCore;
using static System.Formats.Asn1.AsnWriter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add context from JSON
builder.Services.AddDbContext<FinalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FinalContext")));


builder.Services.AddSwaggerDocument();


// add contract
//FavoriteFood
builder.Services.AddScoped<InFFService, FFService>();
//PersonalInfo
builder.Services.AddScoped<InPIService, PIService>();
//Hobbies
builder.Services.AddScoped<InHService, HService>();
//VideoGames
builder.Services.AddScoped<InVGService, VGService>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Add scope so the database updates automatically
//FavoriteFood
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<FinalContext>();
    context.Database.EnsureCreated();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseOpenApi();
app.UseSwaggerUi3();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
