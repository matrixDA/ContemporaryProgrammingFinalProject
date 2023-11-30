using ContemporaryProgrammingFinalProject.Data;
using Microsoft.EntityFrameworkCore;
using static System.Formats.Asn1.AsnWriter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add context from JSON
//FavoriteFood
builder.Services.AddDbContext<FFContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FFContext")));
//PersonalInfo
builder.Services.AddDbContext<PIContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("PIContext")));
//Hobbies
builder.Services.AddDbContext<HContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("HContext")));
//VideoGames
builder.Services.AddDbContext<VGContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("VGContext")));

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
    var contextFF = scope.ServiceProvider.GetRequiredService<FFContext>();
    contextFF.Database.EnsureCreated();
}
//PersonalInfo
using (var scope = app.Services.CreateScope())
{ 
	var contextPI = scope.ServiceProvider.GetRequiredService<PIContext>();
    contextPI.Database.EnsureCreated();
}
//Hobbies
using (var scope = app.Services.CreateScope())
{
	var contextH = scope.ServiceProvider.GetRequiredService<HContext>();
	contextH.Database.EnsureCreated();
}
//VideoGames
using (var scope = app.Services.CreateScope())
{
	var contextVG = scope.ServiceProvider.GetRequiredService<VGContext>();
	contextVG.Database.EnsureCreated();
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
