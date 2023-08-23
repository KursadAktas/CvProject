using CvProject.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CvContext>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<CvContext>();

builder.Services.AddMvc(config =>
{     
	var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddMvc();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
	x.LoginPath = "/Login/Index/";
	x.LogoutPath = "/Login/Index/";
});

// Add services to the container.


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
