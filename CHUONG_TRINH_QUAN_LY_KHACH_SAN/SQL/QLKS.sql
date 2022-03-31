	create database QUANLYKHACHSAN
go
use QUANLYKHACHSAN
go
create table khachhang
(
	makhach NVARCHAR(20) NOT NULL,
	tenkhach NVARCHAR(100) NOT NULL,
	diachi NVARCHAR(50) NOT NULL,
	dienthoai NVARCHAR(15) NOT NULL,
	CONSTRAINT pk_khachhang PRIMARY KEY(makhach)
);
CREATE TABLE phong
(
	maphong NVARCHAR(20) NOT NULL,
	loaiphong NVARCHAR(30) NOT NULL,
	giaphong FLOAT NOT NULL,
	sogiuong TINYINT NOT NULL,
	CONSTRAINT pk_phong PRIMARY KEY(maphong)
);
CREATE TABLE datphong
(
	maphong NVARCHAR(20) NOT NULL,
	makhach NVARCHAR(20) NOT NULL,
	ngayden DATETIME NOT NULL,
	ngaydi DATETIME NOT NULL,
	soluong NVARCHAR(10) NOT NULL,
	CONSTRAINT pk_datphong PRIMARY KEY(maphong,makhach),
	CONSTRAINT fk_maphong FOREIGN KEY (maphong) REFERENCES phong (maphong)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	CONSTRAINT fk_makhach FOREIGN KEY (makhach) REFERENCES khachhang (makhach)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
-- create proc xemkhachhang
go
create proc sp_xemkhachhang
as
begin
 select * from KHACHHANG
end
-- create proc int khachhang
go
create proc sp_nhapkhachhang
(
	@makhach NVARCHAR(20),
	@tenkhach NVARCHAR(100),
	@diachi NVARCHAR(50),
	@dienthoai NVARCHAR(15)
)
as
begin
	insert into khachhang(makhach,tenkhach,diachi,dienthoai)
	values(@makhach,@tenkhach,@diachi,@dienthoai)
end
-- create proc search khachhang
go
create proc sp_timkiemkhachhang
(
	@makhach NVARCHAR(20),
	@tenkhach NVARCHAR(100),
	@diachi NVARCHAR(50),
	@dienthoai NVARCHAR(15)
)
as
begin
	select *
	from khachhang
	where makhach=@makhach or tenkhach=@tenkhach or diachi=@diachi or dienthoai=@dienthoai
end
-- create proc delete khachhang
go
create procedure sp_xoakhachhang
(	
	@makhach NVARCHAR(20),
	@tenkhach NVARCHAR(100),
	@diachi NVARCHAR(50),
	@dienthoai NVARCHAR(15)
)
as
begin
	delete from khachhang
	where makhach=@makhach or tenkhach=@tenkhach or diachi=@diachi or dienthoai=@dienthoai
end
-- create proc edit khachhang
go
CREATE procedure sp_capnhatkhachhang
(
@makhachcu nvarchar(20), @tenkhachcu nvarchar(100), @diachicu NVARCHAR(50),
@dienthoaicu nvarchar(15),
@makhachmoi nvarchar(20), @tenkhachmoi nvarchar(100), @diachimoi NVARCHAR(50),
@dienthoaimoi nvarchar(15)
)
as
begin
 IF @makhachmoi <>''and @tenkhachmoi <>'' and @diachicu <>'' and
@dienthoaimoi <>''
 update khachhang
 set makhach=@makhachmoi, tenkhach=@tenkhachmoi, diachi=@diachimoi,
dienthoai=@dienthoaimoi
 where makhach=@makhachcu and tenkhach=@tenkhachcu and diachi=@diachicu and
dienthoai=@dienthoaimoi
end
-- create proc xemphong
go
create proc sp_xemphong
as
begin
 select * from phong
end
-- create proc int phong
go
create proc sp_nhapphong
(
	@maphong NVARCHAR(20),
	@loaiphong NVARCHAR(30),
	@giaphong FLOAT,
	@sogiuong TINYINT
)
as
begin
	insert into phong(maphong,loaiphong,giaphong,sogiuong)
	values(@maphong,@loaiphong,@giaphong,@sogiuong)
end
-- create proc search khachhang
go
create proc sp_timkiemphong
(
	@maphong NVARCHAR(20),
	@loaiphong NVARCHAR(30),
	@giaphong FLOAT,
	@sogiuong TINYINT
)
as
begin
	select *
	from phong
	where maphong=@maphong or loaiphong=@loaiphong or giaphong=@giaphong or sogiuong=@sogiuong
end
-- create proc delete khachhang
go
create procedure sp_xoaphong
(	
	@maphong NVARCHAR(20),
	@loaiphong NVARCHAR(30),
	@giaphong FLOAT,
	@sogiuong TINYINT
)
as
begin
	delete from phong
	where maphong=@maphong or loaiphong=@loaiphong or giaphong=@giaphong or sogiuong=@sogiuong
end
-- create proc edit phong
go
CREATE procedure sp_capnhatphong
(
@maphongcu nvarchar(20), @loaiphongcu nvarchar(100), @giaphongcu NVARCHAR(50),
@sogiuongcu nvarchar(15),
@maphongmoi nvarchar(20), @loaiphongmoi nvarchar(100), @giaphongmoi NVARCHAR(50),
@sogiuongmoi nvarchar(15)
)
as
begin
 IF @maphongmoi <>''and @loaiphongmoi <>'' and @giaphongmoi <>'' and
@sogiuongmoi <>''
 update phong
 set maphong=@maphongmoi, loaiphong=@loaiphongmoi, giaphong=@giaphongmoi,
sogiuong=@sogiuongmoi
 where maphong=@maphongcu and loaiphong=@loaiphongcu and giaphong=@giaphongcu and
sogiuong=@sogiuongcu
end
-- create int datphong
go
create proc sp_nhapdatphong
(
	@maphong NVARCHAR(20),
	@makhach NVARCHAR(20),
	@ngayden DATETIME,
	@ngaydi DATETIME,
	@soluong NVARCHAR(10) 
)
as
begin
	insert into datphong(maphong,makhach,ngayden,ngaydi)
	values(@maphong,@makhach,@ngayden,@ngaydi)
end
-- create view datphong
go
create proc sp_xemdatphong
as
begin 
	select * from datphong
end
--create delete datphong
go
create proc sp_xoadatphong
(	
	@maphong NVARCHAR(20),
	@makhach NVARCHAR(20),
	@ngayden DATETIME,
	@ngaydi DATETIME,
	@soluong NVARCHAR(10) 
)
as
begin
	delete from datphong
	where maphong=@maphong or makhach=@makhach or ngayden=@ngayden or ngaydi=@ngaydi or soluong=@soluong
end
-- create update datphong
go
CREATE procedure sp_capnhatdatphong
(
@maphongcu nvarchar(20), @makhachcu nvarchar(100), @ngaydencu NVARCHAR(50),
@ngaydicu nvarchar(15),
@maphongmoi nvarchar(20), @makhachmoi nvarchar(100), @ngaydenmoi NVARCHAR(50),
@ngaydimoi nvarchar(15)
)
as
begin
 IF @maphongmoi <>''and @makhachmoi <>'' and @ngaydenmoi <>'' and
@ngaydimoi <>''
 update datphong
 set maphong=@maphongmoi, makhach=@makhachmoi, ngayden=@ngaydenmoi,
ngaydi=@ngaydimoi
 where maphong=@maphongcu and makhach=@makhachcu and ngayden=@ngaydencu and
ngaydi=@ngaydicu
end