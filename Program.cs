using LiftTrackerAPI.Types;
using LiftTrackerAPI.Data;
using LiftTrackerAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("")));

builder.Services
    .AddScoped<IDataService, DataService>();

builder.Services
    .AddGraphQL()
    .AddProjections()
    .AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
