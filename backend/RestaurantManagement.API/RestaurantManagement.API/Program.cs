using Hangfire;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RestaurantManagement.API.Data;
using RestaurantManagement.API.Interfaces;
using RestaurantManagement.API.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Identity;
using RestaurantManagement.API.Models;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        // Configure System.Text.Json options
        options.JsonSerializerOptions.PropertyNamingPolicy = null; // Preserve capitalization
    });


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging();

builder.Services.AddScoped<IWeekService,WeekService>();
builder.Services.AddScoped<IShiftService, ShiftService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<IConfigService, ConfigService>();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestaurantManagementAPIContext"))
);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactFrontend", builder =>
    {
        builder.WithOrigins("http://localhost:5173", "https://localhost:5173") 
               .AllowAnyHeader()
               .AllowAnyMethod()
               .AllowCredentials(); 
    });
});

builder.Services.AddIdentity<Employee, IdentityRole>(options => {
    
})
.AddEntityFrameworkStores<DataContext>()
.AddDefaultTokenProviders();

builder.Services.AddDistributedMemoryCache();

// Add session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthorization();


builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
})
 .AddCookie(options =>
 {
     options.Cookie.Name = "ResturantManagmentApi.Cookie"; // Update with your desired cookie name
     options.Cookie.SecurePolicy = CookieSecurePolicy.Always ; // Prevent JavaScript access to cookies
     options.Cookie.SameSite = SameSiteMode.None; // Adjust as necessary for your application
     options.ExpireTimeSpan = TimeSpan.FromDays(1); // Adjust expiration as needed


 })
.AddGoogle(options =>
{

    options.ClientId = builder.Configuration["Authentication:Google:ClientId"];
    options.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];

});



builder.Services.AddHangfire((sp, config) =>
{
    var connectionString = sp.GetRequiredService<IConfiguration>().GetConnectionString("RestaurantManagementAPIContext");
    config.UseSqlServerStorage(connectionString);
});
builder.Services.AddHangfireServer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });

    // Add support for authentication
    c.AddSecurityDefinition("cookie", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.ApiKey,
        In = ParameterLocation.Cookie,
        Name = ".AspNetCore.Cookies" // This should match your cookie name
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "cookie" }
            },
            new string[] { }
        }
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseCors("AllowReactFrontend");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseHangfireDashboard("/hangfire");

//run recurring services
using (var scope = app.Services.CreateScope())
{
    var jobService = scope.ServiceProvider.GetRequiredService<IJobService>();
    jobService.RunWeekClosingRecurringJob();
    jobService.RunWeekFinalizingRecurringJob();
}

app.Run();
