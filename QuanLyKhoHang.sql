create database QuanLyKhoHang;
create table tblChucVu (
MaCV nvarchar(50) primary key,
TenCV nvarchar(50)
);

create table tblNhanVien (
MaNV nvarchar(50) primary key,
MaCV nvarchar(50),
HoTen nvarchar(50),
NamSinh date,
SDT nvarchar(20),
GioiTinh nvarchar(10),
QueQuan nvarchar(100)
foreign key (MaCV) references tblChucVu
);

create table tblCuaHang (
MaCH nvarchar(50) primary key,
TenCH nvarchar(100),
DiaChi nvarchar(100),
SDT nvarchar(20)
);

create table tblTaiKhoan(
Id nvarchar(20) primary key,
TenDangNhap nvarchar(100),
MatKhau nvarchar(100)
);
drop table tblTaiKhoan;
create table tblNhaCungCap (
MaNCC nvarchar(50) primary key,
TenNCC nvarchar(100),
DiaChi nvarchar(100),
SDT nvarchar(20),
Email nvarchar(100)
);

create table tblSanPham(
MaSP nvarchar(50) primary key,
MaNCC nvarchar(50),
TenSP nvarchar (50),
SoLuong int,
DonGia nvarchar(20),
DonVi nvarchar(30),
foreign key (MaNCC) references tblNhaCungCap
);

create table tblPhieuXuatKho(
MaXK nvarchar(50) primary key,
MaCH nvarchar(50),
MaNV nvarchar(50),
NgayXuat date,
TongTien float,
foreign key (MaCH) references tblCuaHang,
foreign key (MaNV) references tblNhanVien
);

create table tblChiTietXuatKho(
MaXK nvarchar(50),
MaSP nvarchar(50),
SoLuong int,
ThanhTien float,
foreign key (MaXK) references tblPhieuXuatKho,
foreign key (MaSP) references tblSanPham
);

create table tblPhieuNhapKho(
MaNK nvarchar(50) primary key,
MaNCC nvarchar(50),
MaNV nvarchar(50),
NgayNhap date,
TongTien float,
foreign key (MaNCC) references tblNhaCungCap,
foreign key (MaNV) references tblNhanVien
);

create table tblChiTietNhapKho(
MaNK nvarchar(50),
MaSP nvarchar(50),
SoLuong int,
DonGia nvarchar(20),
DonVi nvarchar(30),
ThanhTien float,
foreign key (MaNK) references tblPhieuNhapKho,
foreign key (MaSP) references tblSanPham
);

create table tblPhieuDatHang(
MaPDH nvarchar(50) primary key,
MaNV nvarchar(50),
NgayThang date,
foreign key(MaNV) references tblNhanVien,
);
select *from tblPhieuDatHang;

create table tblChiTietPDH(
MaPDH nvarchar(50),
MaSP nvarchar(50),
SoLuong int,
primary key(MaPDH,MaSP)
);
select *from tblChiTietPDH;
drop table tblChitietPDH;

insert into tblTaiKhoan(Id,TenDangNhap,MatKhau)
values ('01','admin','123456');
insert into tblTaiKhoan(Id,TenDangNhap,MatKhau)
values ('02','Hoa','12345');

insert into tblChucVu (MaCV,TenCV) 
values ('CV01',N'Quản lý');
insert into tblChucVu (MaCV,TenCV) 
values ('CV02',N'Thủ kho');
insert into tblChucVu (MaCV,TenCV) 
values ('CV03',N'Kế toán kho');

insert into tblNhanVien( MaNV, MaCV,HoTen, NamSinh, SDT,GioiTinh, QueQuan)
values ('NV01', 'CV01', N'Đinh Thị Thúy', '02/26/1982','0822694857',N'Nữ',N'Hà Nội');
insert into tblNhanVien( MaNV, MaCV,HoTen, NamSinh, SDT,GioiTinh, QueQuan)
values ('NV02', 'CV02', N'Nguyễn Văn Chính', '08/02/1996','0831694875',N'Nam',N'Thái Nguyên');
insert into tblNhanVien( MaNV, MaCV,HoTen, NamSinh, SDT,GioiTinh, QueQuan)
values ('NV03', 'CV02', N'Trinh Thị Mơ', '12/15/1995','0934614782',N'Nữ',N'Ninh Bình');
insert into tblNhanVien( MaNV, MaCV,HoTen, NamSinh, SDT,GioiTinh, QueQuan)
values ('NV04', 'CV03', N'Trần Minh Khai', '01/02/1992','0736954128',N'Nam',N'Hưng Yên');

insert into tblCuaHang (MaCH, TenCH,DiaChi, SDT)
values ('CH01', N'Mixue Thái Nguyên 01',N'Số 278 Lương Ngọc Quyến,P.Hoàng Văn thụ, TP.Thái Nguyên','0814614681');
insert into tblCuaHang (MaCH, TenCH,DiaChi, SDT)
values ('CH02', N'Mixue Thái Nguyên 02',N'Số 245 Quang Trung,P.Tân Thịnh, TP.Thái Nguyên','0815642389');
insert into tblCuaHang (MaCH, TenCH,DiaChi, SDT)
values ('CH03', N'Mixue Ninh Bình',N'89 Lê Hồng Phong, Đông Thành, Ninh Bình','0911217900');
insert into tblCuaHang (MaCH, TenCH,DiaChi, SDT)
values ('CH04', N'Mixue Bắc Ninh',N'77 Đỗ Ngọc Vỹ, P.Ninh Xá, Bắc Ninh','0364215368');

insert into tblNhaCungCap(MaNCC, TenNCC, DiaChi, SDT, Email)
values ('NCC01', N'Bao bì thực phẩm Lan Hùng',N'Thành Công, Ba Đình, Hà Nội', '0348626626',N'baobithucphamlanhung@gmail.com');
insert into tblNhaCungCap(MaNCC, TenNCC, DiaChi, SDT, Email)
values ('NCC02', N'Công ty TNHH DV TM SX Trí Đức',N'Nguyễn Huy Tưởng, P.6, Q.Bình Thạnh, TP.HCM', '0238430020',N'infotriducfood@gmail.com');
insert into tblNhaCungCap(MaNCC, TenNCC, DiaChi, SDT, Email)
values ('NCC03', N'Công ty TNHH Vua An Toàn',N'Số 08 Đường Lê Tấn Quốc, P.13,Quận Tân Bình, TP.HCM', '0987013502',N'nguyenlieuantoan@gmail.com');

insert into tblSanPham(MaSP,MaNCC, TenSP, SoLuong, DonGia, DonVi)
values ('SP01','NCC01',N'Cốc 700ml',10,'1600000',N'Thùng');
insert into tblSanPham(MaSP,MaNCC, TenSP, SoLuong, DonGia, DonVi)
values ('SP02','NCC01',N'Cốc 500ml',30,'954000',N'Thùng');
insert into tblSanPham(MaSP,MaNCC, TenSP, SoLuong, DonGia, DonVi)
values ('SP03','NCC02',N'Thạch lô hội 18 gói-2kg',60,'727000',N'Thùng');
insert into tblSanPham(MaSP,MaNCC, TenSP, SoLuong, DonGia, DonVi)
values ('SP04','NCC03',N'Bột kem nguyên vị 8 hộp -3kg',50,'727206',N'Thùng');
insert into tblSanPham(MaSP,MaNCC, TenSP, SoLuong, DonGia, DonVi)
values ('SP05','NCC02',N'Syrup thạch dừa',40,'527272',N'Thùng');
insert into tblSanPham(MaSP,MaNCC, TenSP, SoLuong, DonGia, DonVi)
values ('SP06','NCC02',N'Syrup xoài 20 hộp -850g',45,'1436363',N'Thùng');
insert into tblSanPham(MaSP,MaNCC, TenSP, SoLuong, DonGia, DonVi)
values ('SP07','NCC02',N'Syrup dâu tây 8 hộp- 2kg',45,'709000',N'Thùng');
insert into tblSanPham(MaSP,MaNCC, TenSP, SoLuong, DonGia, DonVi)
values ('SP08','NCC03',N'Chân trâu đen 16 túi-1kg',105,'664000',N'Thùng');

insert into tblPhieuXuatKho(MaXK, MaCH, MaNV, NgayXuat, TongTien)
values ('XK01','CH01','NV04','01/16/2021',3081272);

insert into tblChiTietXuatKho(MaXK, MaSP,SoLuong, ThanhTien)
values ('XK01','SP01',1,1600000);
insert into tblChiTietXuatKho(MaXK, MaSP,SoLuong, ThanhTien)
values ('XK01','SP02',1,954000);
insert into tblChiTietXuatKho(MaXK, MaSP,SoLuong, ThanhTien)
values ('XK01','SP05',1,527272);

insert into tblPhieuNhapKho(MaNK, MaNCC, MaNV, NgayNhap, TongTien)
values ('NK01','NCC01','NV04','05/16/2021',26170000);

insert into tblChiTietNhapKho(MaNK, MaSP,SoLuong,DonGia, DonVi, ThanhTien)
values ('NK01','SP02',20,954000,N'Thùng',19080000);
insert into tblChiTietNhapKho(MaNK, MaSP,SoLuong,DonGia, DonVi, ThanhTien)
values ('NK01','SP07',10,709000,N'Thùng',7090000);
drop table tblChiTietXuatKho;
drop table tblChiTietNhapKho;
drop table tblPhieuNhapKho;
drop table tblPhieuXuatKho;
drop table tblSanPham;
drop table tblNhaCungCap;
drop table tblChucVu;
drop table tblNhanVien;
drop table tblCuaHang;
select *from tblChiTietXuatKho;
select *from tblPhieuXuatKho;