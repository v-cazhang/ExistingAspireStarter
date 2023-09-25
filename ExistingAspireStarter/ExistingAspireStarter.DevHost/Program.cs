var builder = CloudApplication.CreateBuilder(args);

var catalog = builder.AddProject<ExistingAspireStarter.DevHost.Projects.CatalogService>("catalog");

builder.AddProject<ExistingAspireStarter.DevHost.Projects.Frontend>("frontend")
       .WithServiceReference(catalog);

builder.Build().Run();
