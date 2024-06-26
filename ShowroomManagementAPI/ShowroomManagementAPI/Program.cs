using Microsoft.EntityFrameworkCore;
using ShowroomManagmentAPI.Data;
using ShowroomManagmentAPI.Models;
using ShowroomManagmentAPI.Models.Marketing_Promotion_Module;
using ShowroomManagmentAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(x => 
                 x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<IDepartment, DepartmentModel>();
builder.Services.AddScoped<IRole, RoleModel>();
builder.Services.AddScoped<IEmployee, EmployeeModel>();
builder.Services.AddScoped<IVehicle, VehicleModel>();
builder.Services.AddScoped<ICustomer, CustomerModel>();
builder.Services.AddScoped<ICampaign, CampaignModel>();
builder.Services.AddScoped<IPromotion, PromotionModel>();
builder.Services.AddScoped<IChannel, ChannelModel>();
builder.Services.AddScoped<ICustomer_segment, CustomerSegmentModel>();
builder.Services.AddScoped<ICampaignChannelMapping, CampaignChannelMappingModel>();
builder.Services.AddScoped<ICampaignCustomerSegmentMapping, CampaignCustomerSegmentMappingModel>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
