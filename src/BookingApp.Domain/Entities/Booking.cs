using BookingApp.Domain.Enums;

namespace BookingApp.Domain.Entities;

public class Booking
{
    public Guid Id { get; private set; }
    public string CustomerName { get; private set; }
    public string ServiceName { get; private set; }
    public DateTime BookingDate { get; private set; }
    public BookingStatus Status { get; private set; }

    // Constructor cho việc tạo mới
    public Booking(string customerName, string serviceName, DateTime bookingDate)
    {
        Id = Guid.NewGuid();
        CustomerName = customerName;
        ServiceName = serviceName;
        BookingDate = bookingDate;
        Status = BookingStatus.Pending;
    }

    // Logic nghiệp vụ: Chỉ cho phép xác nhận nếu đang ở trạng thái Pending
    public void Confirm()
    {
        if (Status != BookingStatus.Pending)
            throw new InvalidOperationException("Chỉ có thể xác nhận đơn đặt chỗ đang chờ.");
        
        Status = BookingStatus.Confirmed;
    }

    public void Cancel()
    {
        if (Status == BookingStatus.Completed)
            throw new InvalidOperationException("Không thể hủy đơn đã hoàn thành.");
            
        Status = BookingStatus.Cancelled;
    }
}
