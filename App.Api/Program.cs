using App.Repositories;
using App.Repositories.Repositories;
using App.Services;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));


builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ISchoolClassService, SchoolClassService>();
builder.Services.AddScoped<ICourseService, CourseService>();



builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ISchoolClassRepository, SchoolClassRepository>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
	var connectionStrings = builder.Configuration.GetSection(ConnectionStringOption.Key).Get<ConnectionStringOption>();
	options.UseSqlServer(connectionStrings!.SqlServer);

	options.UseSqlServer(connectionStrings!.SqlServer, sqlServerOptionsAction =>
	{
		sqlServerOptionsAction.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
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

app.UseAuthorization();

app.MapControllers();

app.Run();
