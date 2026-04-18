using BookingApp.Application.Interfaces;
using BookingApp.Domain.Entities;
using MongoDB.Driver;

namespace BookingApp.Infrastructure.Repositories;

public class MongoBookingRepository : IBookingRepository
{
    private readonly IMongoCollection<Booking> _bookings;

    public MongoBookingRepository(IMongoDatabase database)
    {
        _bookings = database.GetCollection<Booking>("Bookings");
    }

    public async Task<Booking?> GetByIdAsync(Guid id)
    {
        return await _bookings.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Booking>> GetAllAsync()
    {
        return await _bookings.Find(_ => true).ToListAsync();
    }

    public async Task AddAsync(Booking booking)
    {
        await _bookings.InsertOneAsync(booking);
    }

    public async Task UpdateAsync(Booking booking)
    {
        await _bookings.ReplaceOneAsync(x => x.Id == booking.Id, booking);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _bookings.DeleteOneAsync(x => x.Id == id);
    }
}
