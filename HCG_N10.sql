Use master
GO

CREATE DATABASE HCG_N10
GO

USE HCG_N10
GO
--DROP DATABASE HCG_N10
--DROP TABLE TapLuat
CREATE TABLE SuKien(
	MaSuKien varchar(10) not null PRIMARY KEY,
	MoTa nvarchar(100) not null,
	LoaiSuKien varchar(10) not null
)
GO

CREATE TABLE TapLuat(
	MaLuat varchar(10) not null PRIMARY KEY,
	NoiDung nvarchar(100) not null,
	DoUuTien int DEFAULT 0
)
GO

--Bang SuKien
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB1', N'NXB Kim Đồng',   'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB2', N'NXB Thanh Niên', 'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB3', N'NXB Lao Động',   'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB4', N'NXB Tư Pháp',    'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB5', N'NXB Quân Đội',   'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB6', N'NXB Trẻ',        'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX7', N'NXB VH-NT',      'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX8', N'NXB Đà nẵng',    'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX9', N'NXB Công thương','NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX10', N'NXB Thế Giới',  'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX11', N'NXB Tổng hợp TP.HCM','NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NBX12', N'NXB Phụ nữ',         'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB13', N'NXB Nhã Nam',        'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB14', N'NXB Sky Book',       'NhaXuatBan')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NXB15', N'NXB Trí Tuệ',        'NhaXuatBan')
GO

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL1', N'Chính trị - Pháp luật',    'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL2', N'Khoa học công nghẹ',       'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL3', N'Kinh tế',                  'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL4', N'Văn học - Nghệ thuật',     'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL5', N'Văn hóa xã hội - Lịch sử', 'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL6', N'Truyện - Tiểu thuyết',     'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL7', N'Thiếu nhi',                'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL8',N'Kỹ năng sống',    'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL9',N'Tâm lí',    'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL10',N'Du kí',    'TheLoai')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TL11', N'Phụ nữ','Sach')
Go

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT1', N'< 100 nghìn',     'GiaTien')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT2', N'100 - 200 nghìn', 'GiaTien')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT3', N'200 - 300 nghìn', 'GiaTien')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT4', N'300 - 400 nghìn', 'GiaTien')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('GT5', N'400 - 500 nghìn', 'GiaTien')

GO



INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG1', N'Nguyễn Nhật Ánh','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG2', N'Peter Frankopan','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG3', N'Dale Carnegie','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG4', N'S J Scott','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG5', N'Phan Văn Trường','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG6', N'Lieberman','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG7', N'Nguyễn Thế Quang','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG8', N'Lý thành cơ','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG9', N'Trần Trọng Kim','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG10', N'Đặng Quân','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG11', N'Hà Giang','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG12', N'Nguyễn Thủy Chung','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG13', N'Tô Hoài','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG14', N'James F. O’brien','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG15', N'Manh Chu','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG16', N'Osho','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG17', N'Haruki','TacGia')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('TG18', N'Nhật Phong','TacGia')
GO

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('MD0', N'-',   'MucDich')
GO


INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NN1', N'Kinh doanh', 'NgheNghiep')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NN2', N'Kỹ sư',      'NgheNghiep')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NN3', N'Học sinh',   'NgheNghiep')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('NN4', N'Luật sư',    'NgheNghiep')
GO

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('DT1', N'6-11 tuổi',    'DoTuoi')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('DT2', N'11-15 tuổi',   'DoTuoi')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('DT3', N'15-18 tuổi',   'DoTuoi')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('DT4', N'trên 18 tuổi', 'DoTuoi')

GO

INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S1', N'Truyện ngụ ngôn Aesop','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S2', N'Thiên đường có thật','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S3', N'Sự nghiệp là một trò chơi','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S4', N'Con đường tơ lụa','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S5', N'Con đường không tắt nắng','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S6', N'Cuộc Thập Tự Chinh Thứ Nhất - Tiếng Gọi Từ Phương Đông','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S7', N'Con Đường Tơ Lụa Mới - Hiện Tại Và Tương lai Của Thế Giới Mới','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S8', N'Cuốn theo chiều gió','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S9', N'Cha giàu cha nghèo','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S10', N'Đắc nhân tâm',             'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S11', N'Luật kinh tế',              'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S12', N'Internet vạn vật',			'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S13', N'Trở về từ cõi sáng',		'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S14', N'Mắt biếc',					'Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S15', N'Truyện cổ tích',			'Sach')
GO
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S16', N'Đừng Để Mục Tiêu Như Diều Không Gió','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S17', N'Một đời như kẻ tìm đường','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S18', N'Đọc vị Bất kì ai','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S19', N'Thông reo ngàn hống','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S20', N'Mộ,t đời quản trị','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S21', N'Nguyễn Du','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S22', N'Chuyện những người An nam ở Paris Hay sự thật về đông dương','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S23', N'Chuỗi thói quen','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S24', N'Tuổi Trẻ Trong Ví, Bạn Mua Được Gì?','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S25', N'Thế Giới Rộng Lớn Đừng Đi Một Mình','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S26', N'Cho Tôi Xin Một Vé Đi Tuổi Thơ','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S27', N'Đừng Lựa Chọn An Nhàn Khi Còn Trẻ','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S28', N'Nóng Giận Là Bản Năng , Tĩnh Lặng Là Bản Lĩnh','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S29', N'Quẳng Gánh Lo Đi Và Vui Sống','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S30', N'Việt Nam Sử Lược (Bản Đặc Biệt)','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S31', N'Tôi thấy hoa vàng trên cỏ xanh','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S32', N'Quê Nhà','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S33', N'Dế Mèn Phiêu Lưu Ký','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S34', N'TRÍ TUỆ SHERLOCK HOLMES','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S35', N'Kafa','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S36', N'Tiếng chim hót trong bụi','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S37', N'Giải mã bí ẩn phái đẹp','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S38', N'Truyện Grim','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S39', N'Saitama','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S40', N'Quy tắc 4 giờ','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S41', N'Ngày hôm qua','Sach')
INSERT INTO SuKien(MaSuKien, MoTa, LoaiSuKien) VALUES ('S42', N'Khi người lớn cô đơn','Sach')
GO
--Bang TapLuat
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R1', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R2', N'', 6);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R3', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R4', N'', 10);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R5', N'', 9);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R6', N'', 5);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R7', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R8', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R9', N'', 5);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R10', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R11', N'', 6);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R12', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R13', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R14', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R15', N'', 3);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R16', N'', 2);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R17', N'', 6);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R18', N'', 3);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R19', N'', 6);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R20', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R21', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R22', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R23', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R24', N'', 1);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R25', N'', 9);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R26', N'', 6);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R27', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R28', N'', 5);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R29', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R30', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R31', N'', 10);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R32', N'', 6);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R33', N'', 2);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R34', N'', 6);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R35', N'', 10);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R36', N'', 3);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R37', N'', 1);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R38', N'', 10);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R39', N'', 10);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R40', N'', 2);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R41', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R42', N'', 5);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R43', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R44', N'', 1);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R45', N'', 9);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R46', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R47', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R48', N'', 6);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R49', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R50', N'', 2);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R51', N'', 3);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R52', N'', 3);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R53', N'', 5);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R54', N'', 1);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R55', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R56', N'', 9);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R57', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R58', N'', 9);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R59', N'', 6);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R60', N'', 10);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R61', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R62', N'', 10);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R63', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R64', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R65', N'', 1);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R66', N'', 10);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R67', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R68', N'', 9);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R69', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R70', N'', 2);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R71', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R72', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R73', N'', 10);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R74', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R75', N'', 2);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R76', N'', 5);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R77', N'', 2);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R78', N'', 9);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R79', N'', 5);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R80', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R81', N'', 9);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R82', N'', 7);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R83', N'', 4);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R84', N'', 3);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R85', N'', 2);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R86', N'', 1);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R87', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R88', N'', 1);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R89', N'', 8);
INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES ('R90', N'', 7);
GO

select * from SuKien
select * from TapLuat