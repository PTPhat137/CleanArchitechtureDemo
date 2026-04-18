using BookingApp.Application.Interfaces;
using MediatR;

namespace BookingApp.Application.Bookings.Commands.ConfirmBooking;

public record ConfirmBookingCommand(Guid Id) : IRequest;

public class ConfirmBookingCommandHandler : IRequestHandler<ConfirmBookingCommand>
{
    private readonly IBookingRepository _repository;

    public ConfirmBookingCommandHandler(IBookingRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(ConfirmBookingCommand request, CancellationToken cancellationToken)
    {
        var booking = await _repository.GetByIdAsync(request.Id);
        if (booking == null) throw new Exception("Không tìm thấy đơn đặt chỗ.");

        booking.Confirm(); // Gọi logic của Domain
        await _repository.UpdateAsync(booking);
    }
}
