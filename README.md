# Hệ Chuyên Gia Tư Vấn Chọn Sách - HCG_N10

## 🧠 Mô tả
Đây là một hệ chuyên gia được xây dựng bằng WinForms (C#) và SQL Server để tư vấn chọn sách phù hợp dựa trên thông tin người dùng cung cấp như:
- Nhà xuất bản
- Thể loại
- Tác giả
- Giá tiền
- Nghề nghiệp
- Độ tuổi

Hệ thống sử dụng 2 cơ chế suy luận:
- ✅ **Suy diễn tiến (Forward chaining)**
- ✅ **Suy diễn lùi (Backward chaining)**

## ⚙️ Chức năng nổi bật
- Quản lý luật suy diễn (thêm, sửa, xóa, tìm kiếm)
- Giao diện chọn chế độ suy diễn: Tiến hoặc Lùi
- Hiển thị kết quả bằng `RichTextBox` và `TreeView`
- Xử lý xung đột luật bằng độ ưu tiên (`DoUuTien`)

## 📦 Dữ liệu và cấu trúc bảng

### 🔹 Bảng `SuKien`
| MaSuKien | MoTa         | LoaiSuKien    |
|----------|--------------|----------------|
| TG1      | Tác giả A    | TacGia         |
| Sach1    | Sách ABC     | Sach           |

### 🔹 Bảng `TapLuat`
| MaLuat | NoiDung                  | DoUuTien |
|--------|--------------------------|----------|
| L1     | TG1^NXB1>Sach1           | 5        |
| L2     | TG2^NXB1>Sach1           | 3        |

> ⚠️ Luật sẽ được sắp xếp theo `DoUuTien DESC` trong suy diễn tiến.

## ⚙️ Quy trình hoạt động

### ➤ Bước 1: Nhập đầu vào
Người dùng lựa chọn các đặc điểm như:
- Thể loại sách, tác giả, nhà xuất bản
- Độ tuổi, nghề nghiệp, mức giá mong muốn

### ➤ Bước 2: Chọn chế độ suy luận
- **Suy diễn tiến:** Xây dựng tập sự kiện mở rộng từ giả thiết đầu vào cho đến khi suy ra kết luận.
- **Suy diễn lùi:** Truy ngược từ mục tiêu (sách) về các giả thiết ban đầu để xác minh tính đúng đắn.

### ➤ Bước 3: Áp dụng luật
- Các luật có cấu trúc: `Giả thiết1 ^ Giả thiết2 > Kết luận1, Kết luận2`
- Nếu có xung đột, luật có `DoUuTien` cao hơn sẽ được chọn trước.

### ➤ Bước 4: Hiển thị kết quả
- Kết quả được in ra `RichTextBox`
- Toàn bộ quá trình suy luận được minh họa bằng `TreeView` dạng cây.

## 🚀 Hướng dẫn sử dụng
1. Mở project trong Visual Studio
2. Đảm bảo cấu hình chuỗi kết nối SQL Server (`ketnoi.cs`)
3. Chạy script `HCG_N10_updated.sql` để khởi tạo và thêm dữ liệu mẫu
4. Build và chạy ứng dụng
5. Chọn các tiêu chí đầu vào và nhấn `Tư vấn`

## 📁 File quan trọng

| Tên File               | Vai trò                           |
|------------------------|-----------------------------------|
| `tuvan.cs`             | Form chính tư vấn                 |
| `suydientien.cs`       | Xử lý forward chaining + xung đột |
| `suydienlui.cs`        | Xử lý backward chaining           |
| `quanlyluat.cs`        | Quản lý luật và độ ưu tiên        |
| `khaibao.cs`           | Lớp định nghĩa `luat_suy_dien`    |
| `HCG_N10_updated.sql`  | Tạo CSDL & dữ liệu mẫu            |
