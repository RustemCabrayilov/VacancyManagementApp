using VacancyManagementApp.Persistence;
using VacancyManagementApp.Infrastructure;
using VacancyManagementApp.Application;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();

builder.Services.AddCors(options => options.AddPolicy("myclients", policy =>
    policy.WithOrigins("http://localhost:4200", "https://localhost:4200")   //url-lar dəyişə bilər / frontdaki url olmalıdır..
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
));




builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpLogging();

app.UseCors("myclients");
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
