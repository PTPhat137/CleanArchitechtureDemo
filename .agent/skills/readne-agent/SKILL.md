---
name: readme-agent
description: Tự động cập nhật phần cấu trúc và tính năng của file README.md dựa trên sự thay đổi thực tế của mã nguồn.
---

# 🧠 Skill: README Agent

Kỹ năng này giúp AI duy trì tài liệu của dự án luôn khớp với code thực tế.

## 📌 Khi nào sử dụng?
1. Khi có sự thay đổi lớn về cấu trúc thư mục (thêm folder, đổi tên module).
2. Khi thêm các tính năng mới vào API hoặc Application layer.
3. Trước khi thực hiện `git commit` cho các thay đổi lớn.

## 🛠 Cách hoạt động (Instructions)
Khi người dùng yêu cầu cập nhật README hoặc khi phát hiện thay đổi lớn, hãy thực hiện:

1. **Phân tích dự án (Analyze):**
   - Quét sơ đồ thư mục (ví dụ: `src/`, `backend/`, `domain/`).
   - Kiểm tra các file project ([.csproj](cci:7://file:///d:/study/Project/BookingAppCleanArchitechtureDemo/src/BookingApp.API/BookingApp.API.csproj:0:0-0:0), [package.json](cci:7://file:///d:/study/Project/BookingAppCleanArchitechtureDemo/frontend/package.json:0:0-0:0)) để xem các dependency mới.
   - Tìm các Controller hoặc Service mới.

2. **Cập nhật mục Architecture (Update Architecture):**
   - Nếu dự án theo chuẩn Clean Architecture, hãy cập nhật mô tả cho từng lớp nếu có sự thay đổi.

3. **Cập nhật Tech Stack (Update Tech Stack):**
   - Tự động thêm các thư viện mới vào danh sách công nghệ.

4. **Định dạng chuẩn (Formatting):**
   - Sử dụng Markdown chuẩn, thêm các bảng biểu hoặc sơ đồ Mermaid nếu cần để làm nổi bật kiến trúc.

## 💡 Ví dụ (Standard Prompt)
"Dựa trên các file .csproj vừa thêm trong thư mục /src, hãy cập nhật lại mục 'Project Structure' trong file README.md cho chính xác."
