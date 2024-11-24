var builder = DistributedApplication.CreateBuilder(args);


// Add the frontend project to the application and configure it to use the 
// Redis server, defined as a referenced dependency.
builder.AddProject<Projects.Web>("Frontend");
builder.AddProject<Projects.ApiService>("ApiService");
builder.AddProject<Projects.CodeAnalyzer>("CodeAnalyzer");
builder.AddProject<Projects.LMIntegration>("LMIntegration");
builder.AddProject<Projects.BatchDocumentationTool>("Batch");

builder.Build().Run();