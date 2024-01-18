using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TutoApp.DBAccess;
using TutoApp.DBAccess.IRepository;
using TutoApp.DBAccess.Repository;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Implementation;
using TutoApp.Metier.Interface;
using TutoApp.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TutoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("tuto")));

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = false;
})
    .AddEntityFrameworkStores<TutoContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
builder.Services.AddScoped<ICategoryRepository<Category>, CategoryRepository<Category>>();
builder.Services.AddScoped<ICategoryService<CategoryDTO,Category>, CategoryService<CategoryDTO,Category>>();
builder.Services.AddScoped<IClientRepository<Client>, ClientRepositoy<Client>>();
builder.Services.AddScoped<IClientService<ClientDTO, Client>, ClientService<ClientDTO, Client>>();
builder.Services.AddScoped<ICommandeRepository<Commande>, CommandeRepository<Commande>>();
builder.Services.AddScoped<ICommandeService<CommandeDTO, Commande>, CommandeService<CommandeDTO, Commande>>();
builder.Services.AddScoped<ILigneCommandeRepository<LigneCommande>, LigneCommandeRepositoy<LigneCommande>>();
builder.Services.AddScoped<ILigneCommandeService<LigneCommandeDTO, LigneCommande>, LigneCommandeService<LigneCommandeDTO, LigneCommande>>();
builder.Services.AddScoped<IProductRepository<Product>, ProductRepository<Product>>();
builder.Services.AddScoped<IProductService<ProductDTO, Product>, ProductService<ProductDTO, Product>>();

builder.Services.AddScoped<ITagRepository<Tag>, TagRepository<Tag>>();
builder.Services.AddScoped<ITagServicecse<TagDTO, Tag>, TagService<TagDTO, Tag>>();

builder.Services.AddScoped<IBrandRepository<Brand>, BrandRepository<Brand>>();
builder.Services.AddScoped<IBrandServicee<BrandDTO, Brand>, BrandService<BrandDTO, Brand>>();

builder.Services.AddScoped<IAuthService,AuthService>();
var configuration = new MapperConfiguration(cfg => {
    cfg.AddProfile<ClientProfile>();
    cfg.AddProfile<CategoryProfile>();
    cfg.AddProfile<CommandeProfile>();
    cfg.AddProfile<LigneCommandeProfile>();
    cfg.AddProfile<ProductProfile>();
    cfg.AddProfile<BrandProfile>();
    cfg.AddProfile<TagProfile>();
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
     .AddJwtBearer(options =>
     {
         options.TokenValidationParameters = new TokenValidationParameters
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
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowOrigin");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
