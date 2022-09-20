using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiniApp1.API.Requirements;
using SharedLibrary.Configurations;
using SharedLibrary.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.Configure<CustomTokenOption>(builder.Configuration.GetSection("TokenOption"));
var tokenOptions = builder.Configuration.GetSection("TokenOption").Get<CustomTokenOption>();
builder.Services.AddCustomTokenAuth(tokenOptions);

builder.Services.AddSingleton<IAuthorizationHandler, BirthDayRequirementHandler>();
builder.Services.AddAuthorization(opts =>
{
    opts.AddPolicy("AnkaraPolicy", policy =>
    {
        policy.RequireClaim("city", "ankara");
    });


    opts.AddPolicy("AgePolicy", policy =>
    {
        policy.Requirements.Add(new BirthDayRequirement(18));
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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
