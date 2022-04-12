var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// var ConnectionString = builder.Configuration.GetConnectionString("TrackString");
// builder.Services.AddDbContext<DataContext>(Options => Options.UseSqlServer(ConnectionString));

builder.Services.AddCors(options => {
options.AddPolicy("TrackPolicy",
builder => {builder.WithOrigins("https://ontherighttrack22.azurewebsites.net/", "http://localhost:3000", "http://localhost:3001")
    .AllowAnyHeader()
    .AllowAnyMethod();
});
});

builder.Services.AddControllers();
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
app.UseCors("TrackPolicy");

// app.UseHttpsRedirection();

app.UseAuthorization(); 

app.MapControllers();

app.Run();
