using BookingApp.Application.Interfaces;
using BookingApp.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace BookingApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Cấu hình để MongoDB lưu Guid dưới dạng chuỗi (dễ đọc hơn)
        BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));

        var mongoClient = new MongoClient(configuration.GetConnectionString("MongoDb"));
        var database = mongoClient.GetDatabase("BookingAppDb");

        services.AddSingleton(database);
        services.AddScoped<IBookingRepository, MongoBookingRepository>();

        return services;
    }
}
