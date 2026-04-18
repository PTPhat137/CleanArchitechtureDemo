using BookingApp.Application.Bookings.Commands.ConfirmBooking;
using BookingApp.Application.Bookings.Commands.CreateBooking;
using BookingApp.Application.Bookings.Queries.GetBookings;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingsController : ControllerBase
{
    private readonly ISender _sender;

    public BookingsController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> GetBookings()
    {
        var result = await _sender.Send(new GetBookingsQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBooking(CreateBookingCommand command)
    {
        var bookingId = await _sender.Send(command);
        return Ok(new { Id = bookingId, Message = "Tạo đơn đặt chỗ thành công!" });
    }

    [HttpPatch("{id}/confirm")]
    public async Task<IActionResult> ConfirmBooking(Guid id)
    {
        await _sender.Send(new ConfirmBookingCommand(id));
        return Ok(new { Message = "Đã xác nhận đơn đặt chỗ!" });
    }
}
