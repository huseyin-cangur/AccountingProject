

using AccountingProject.Domain.App.Entities.Identity;
using AccountingProject.WebAPI.Configurations;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
    // app.UseSwaggerUI(options=>{
    //     options.SwaggerEndpoint("/swagger/v1/swagger.json","My Test Api V1");
    // });
}

app.UseHttpsRedirection();

using (var scoped = app.Services.CreateScope())
{
    var userManager = scoped.ServiceProvider.GetService<UserManager<AppUser>>();
    if (!userManager.Users.Any())
    {
        userManager.CreateAsync(new AppUser{
         UserName="huseyin",
         Email="huseyin@gmail.com",
         Id=Guid.NewGuid().ToString(),
         FullName="huseyincangur",
         

        },"Password12*").Wait();

    }


}


app.Run();
