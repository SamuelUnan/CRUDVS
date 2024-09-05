


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<ITestService, TestService>();
var app = builder.Build();
//app.UseSwagger();
//app.UseSwaggerUI();
app.UseRouting();
app.MapControllers();
app.UseHttpsRedirection();
app.Run();