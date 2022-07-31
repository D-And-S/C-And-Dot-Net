using dotnetwithmongo.DataContext;
using dotnetwithmongo.IRepository;
using dotnetwithmongo.Repository;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//basically it is telling get all the data from appsettings.json where StudentStoreDatabaseSetting define and map
// that data with StudentStoreDatabaseSettings class 

builder.Services.Configure<StudentStoreDatabaseSettings>(builder.Configuration.GetSection("StudentStoreDatabaseSettings"));

// whenever we need IStudentStoreDatabaseSettings service this line will provide value from StudentStoreDatabaseSettings
builder.Services.AddSingleton<IStudentStoreDatabaseSettings>(sp=> sp.GetRequiredService<IOptions<StudentStoreDatabaseSettings>>().Value);


builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("StudentStoreDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
