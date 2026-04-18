using BookingApp.Application.Interfaces;
using BookingApp.Domain.Entities;
using MediatR;

namespace BookingApp.Application.Bookings.Commands.CreateBooking;

public record CreateBookingCommand(string CustomerName, string ServiceName, DateTime BookingDate) : IRequest<Guid>;

public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, Guid>
{
    private readonly IBookingRepository _repository;

    public CreateBookingCommandHandler(IBookingRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
    {
        var booking = new Booking(request.CustomerName, request.ServiceName, request.BookingDate);
        await _repository.AddAsync(booking);
        return booking.Id;
    }
}
