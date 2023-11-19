using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RokeBackend.data.DataContext;
using System.Text;
using RokeBackend.core.Interface;
using RokeBackend.data.Services;
using RokeBackend.core.Contracts;
using RokeBackend.data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<RokeContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    //opt.UseNpgsql(builder.Configuration.GetConnectionString("postgres"));

});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("https://localhost:7070", "http://localhost:4200", "http://69.197.150.152:8012")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});


builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<ITicketRepository, TicketRepository>();
builder.Services.AddTransient<ITicketService, TicketService>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddTransient<IUsuarioService, UsuarioService>();
builder.Services.AddTransient<ILocationRepository, LocationRepository>();
builder.Services.AddTransient<ILocationService, LocationService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IAssignedTaskRepository, AssignedTaskRepository>();
builder.Services.AddTransient<IAssignedTicketService, AssignedTaskService>();
builder.Services.AddTransient<IInventoryRepository, InventoryRepository>();
builder.Services.AddTransient<IInventoryService, InventoryService>();
builder.Services.AddTransient<IMonthRepository, MonthRepository>();
builder.Services.AddTransient<IMonthService, MonthService>();
builder.Services.AddTransient<ITemplateRepository, TemplateRepository>();
builder.Services.AddTransient<ITemplateService, TemplateService>();
builder.Services.AddTransient<IBrigadeRepository, BrigadeRepository>();
builder.Services.AddTransient<IBrigadeService, BrigadeService>();
builder.Services.AddTransient<IPlanningRepository, PlanningRepository>();
builder.Services.AddTransient<IPlanningService, PlanService>();
builder.Services.AddTransient<IMediaRepository, MediaRepository>();
builder.Services.AddTransient<IMediaService, MediaService>();
builder.Services.AddTransient<IFormRepository, FormRepository>();
builder.Services.AddTransient<IFormService, FormService>();
builder.Services.AddTransient<ITicketGestionRepository, TicketGestionRepository>();
builder.Services.AddTransient<ITicketGestionService, TicketGestionService>();
builder.Services.AddTransient<IFirmaRepository, FirmaRepository>();
builder.Services.AddTransient<IFirmaService, FirmaService>();





builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.MapControllers();

app.Run();
