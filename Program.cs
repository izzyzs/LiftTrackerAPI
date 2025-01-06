using LiftTrackerAPI.Types;
using LiftTrackerAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<IDataService, DataService>()
    .AddGraphQL()
    .AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
