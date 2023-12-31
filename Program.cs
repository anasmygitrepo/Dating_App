using API.Extensions;
using Date.Data;
using Date.Interfaces;
using Date.Services;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
// builder.Services.AddDbContext<DataContext>(options=>{
//     options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));

// });


builder.Services.AddIdentityServiceExtensions(builder.Configuration);
var app = builder.Build();

app.UseCors(builder=>builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));

// app.UseStaticFiles();
// app.UseStaticFiles(new StaticFileOptions(){
//     FileProvider=new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath,"Staticfiles"))
// });
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
   