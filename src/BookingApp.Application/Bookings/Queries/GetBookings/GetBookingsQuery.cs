using BookingApp.Application.Interfaces;
using BookingApp.Domain.Entities;
using MediatR;

namespace BookingApp.Application.Bookings.Queries.GetBookings;

public record GetBookingsQuery() : IRequest<IEnumerable<Booking>>;

public class GetBookingsQueryHandler : IRequestHandler<GetBookingsQuery, IEnumerable<Booking>>
{
    private readonly IBookingRepository _repository;

    public GetBookingsQueryHandler(IBookingRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Booking>> Handle(GetBookingsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}
