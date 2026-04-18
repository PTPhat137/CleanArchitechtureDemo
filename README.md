# Booking App - Clean Architecture Demo

Dự án minh họa cấu trúc **Clean Architecture** sử dụng **.NET 8** và **MongoDB**. Dự án được xây dựng với mục tiêu tách biệt rõ ràng các lớp nghiệp vụ, giúp mã nguồn dễ bảo trì, mở rộng và kiểm thử.

## 🏗 Kiến trúc (Architecture)

Dự án tuân thủ sơ đồ 4 lớp của Clean Architecture:

1. **Domain (Core Layer)**: 
   - Chứa các thực thể (Entities), Enum và logic nghiệp vụ lõi.
   - Không phụ thuộc vào bất kỳ thư viện hay framework bên ngoài nào.
2. **Application (Use Case Layer)**:
   - Chứa logic xử lý nghiệp vụ cụ thể (Use Cases).
   - Sử dụng **MediatR** để triển khai mô hình **CQRS** (Command Query Responsibility Segregation).
   - Định nghĩa các Interface (Ports) cho Repository.
3. **Infrastructure (Data Layer)**:
   - Triển khai cụ thể các Interface từ lớp Application.
   - Kết nối và truy vấn dữ liệu với **MongoDB**.
4. **API (Presentation Layer)**:
   - Cung cấp các điểm cuối (Endpoints) RESTful.
   - Tiếp nhận yêu cầu từ người dùng và chuyển tiếp đến lớp Application.

## 🛠 Công nghệ sử dụng (Tech Stack)

- **Ngôn ngữ**: C# (.NET 8)
- **Database**: MongoDB
- **Thư viện**: 
  - `MediatR`: Xử lý các Command/Query.
  - `MongoDB.Driver`: Kết nối cơ sở dữ liệu.
  - `Swashbuckle.AspNetCore`: Giao diện Swagger/OpenAPI.

## 🚀 Hướng dấn chạy dự án (Getting Started)

### Điều kiện cần
- Đã cài đặt [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
- Đã cài đặt **Docker Desktop** (để chạy MongoDB).

### Các bước thực hiện
1. **Khởi động Database**:
   ```powershell
   docker-compose up -d
   ```
2. **Chạy Backend**:
   - Mở Solution trong IntelliJ hoặc Visual Studio.
   - Chạy dự án `BookingApp.API`.
3. **Truy cập Swagger**:
   - Mở trình duyệt và truy cập: `https://localhost:<port>/swagger` để test các API.

---
*Dự án được tạo bởi Commit Helper Skill Demo.*
