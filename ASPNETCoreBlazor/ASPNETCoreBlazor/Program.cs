var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

// In the March/April 2025 CODE Magazine article, on p. 43, step 7 says to add the following 2 lines of code in the Program.cs file. What it doesn't
// say is which Program.cs file do I add it to; the one in the ASP.NET Core app or the one in the Blazor app? I'm going to assume it's the one in the
// ASP.NET Core app.
app.UseBlazorFrameworkFiles();
app.MapFallbackToFile("index.html");    // What's missing from this line of code is the path to the index.html file. It is in the other project.
                                        // However, the app object here, is not defined in the Program.cs file in the other project. I'm not
                                        // sure how to resolve this issue. Therefore, I'm committing this code as is.

app.Run();
