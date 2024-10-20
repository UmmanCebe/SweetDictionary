using Microsoft.EntityFrameworkCore;
using SweetDictionary.Repositories.Contexts;
using SweetDictionary.Repositories.Repositories.Abstracts;
using SweetDictionary.Repositories.Repositories.Concretes;
using SweetDictionary.Services.Abstracts;
using SweetDictionary.Services.Concretes;
using SweetDictionary.Services.Mappings;
using SweetDictionary.Services.Rules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IPostRepository, EfPostRepository>();

builder.Services.AddScoped<IUserRepository, EfUserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<ICategoryRepository, EfCategoryRepsoitory>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<ICommentRepository, EfCommentRepository>();
builder.Services.AddScoped<ICommentService,CommentService>();

builder.Services.AddScoped<PostBusinessRules>();
builder.Services.AddDbContext<BaseDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));
builder.Services.AddAutoMapper(typeof(MappingProfiles));

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