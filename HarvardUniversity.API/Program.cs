using AutoMapper;
using HarvardUniversity.API.Contracts;
using HarvardUniversity.API.Properties;
using HarvardUniversity.API.Properties.SwaggerResponseExamples;
using HarvardUniversity.API.Repositories;
using HarvardUniversity.DataAccessLayer.Data;
using HarvardUniversity.LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using NLog;
using System.ComponentModel;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//NLog configuring
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
builder.Services.AddSingleton<ILoggerManager, LoggerManager>();

builder.Services.AddControllers()
                .AddNewtonsoftJson(opt =>
                {
                    opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    opt.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                });
builder.Services.AddDbContext<HarvardUniversityContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//AutoMapper configuration
var mapperConfig = new MapperConfiguration(mc => { mc.AddProfile(new Mapping()); });
var mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "HarvardUniversity API",
        Description = "An ASP.NET Core Web API for managing HarvardUniversity items",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
    options.CustomSchemaIds(x => x.GetCustomAttributes<DisplayNameAttribute>().SingleOrDefault().DisplayName);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.
    options.EnableAnnotations();
    options.SchemaFilter<SwaggerIgnoreFilter>();
    options.CustomOperationIds(e => $"{e.ActionDescriptor.RouteValues["action"]}");
    //options.OperationFilter<SwaggerExamples>();

    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
