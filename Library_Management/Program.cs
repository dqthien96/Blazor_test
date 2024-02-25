using Library_Management.Components;
using Library_Management.Components.Data;
using Library_Management.Components.Service;
using Microsoft.Extensions.Configuration;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//add service off project


//Dbcontext
//builder.Services.AddDbContext<Dbcontext>(options =>
//       options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


//service User
builder.Services.AddScoped<IUserService, UserService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
