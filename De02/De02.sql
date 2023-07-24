use QLSanpham
go

create table LoaiSP
(
MaLoai char(2) primary key,
TenLoai nvarchar (30),
)
Go

create table Sanpham
(
MaSP char(6) primary key,
TenSP nvarchar(30),
Ngaynhap Datetime,
MaLoai char(2),
constraint Sanpham_pk foreign key(MaLoai) references LoaiSP(MaLoai)
)
Go
