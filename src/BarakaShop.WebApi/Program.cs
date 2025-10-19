var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<AppDbContext>(option
//    => option.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));


var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();