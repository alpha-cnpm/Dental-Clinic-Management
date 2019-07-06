
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLPM')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLPM') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLPM]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLPM]
GO
USE [QLPM]
GO


CREATE TABLE [dbo].[tblBenhNhan]

(	
	[MaBN] nvarchar(10) NOT NULL PRIMARY KEY,	
	[HotenBN] nvarchar(50) not null,	
	[NgayTiepNhan]  smalldatetime not null,
	[GioiTinh] nvarchar(5) not null,
	[NamSinh] smalldatetime not null,
	[DiaChi] nvarchar(100) not null
	
)
CREATE TABLE [dbo].[tblCachDung]
(	
	[IDCD] nvarchar(10) NOT NULL primary key,	
	[NoiDungCD] nvarchar(50) NULL
)


CREATE TABLE [dbo].[tblLoaiBenh]
(	
	[MaLB] nvarchar(10) NOT NULL PRIMARY KEY,
	[TenBenh] nvarchar(50) Not Null
)
CREATE TABLE [dbo].[tblThuoc]
(	
	[MaThuoc] nvarchar(10) NOT NULL PRIMARY KEY,
	[TenThuoc] nvarchar(50) not null,
	[DonViTinh] nvarchar(10)  not null,
	[DonGia] int  not null
)
CREATE TABLE [dbo].[tblTienKham]
(

	[TienKham] int not null primary key,
	[SoTienKham] int null

)

CREATE TABLE [dbo].[tblPhieuKhamBenh]
(	
	[MaPKB] nvarchar(10) NOT NULL PRIMARY KEY,	
	[MaBN] nvarchar(10) not NULL,			
	[MaLB] nvarchar(10) not null,
	[MaThuoc] nvarchar(10) not  null,
	[IDCD] nvarchar(10) not null,
	[TienTong] int null,
	[TrieuChung] nvarchar(50) null,
	[SoLuong] int null,
	[TienKham] int not  null,
	
	[NgayKham] smalldatetime not null
	foreign key (MaBN) references tblBenhNhan(MaBN),
	FOREIGN KEY (MaLB) REFERENCES tblLoaiBenh(MaLB),
	foreign key (TienKham) references tblTienKham(TienKham),
	foreign key (MaThuoc) references tblThuoc(MaThuoc),
	foreign key (IDCD) references tblCachDung(IDCD)




)


CREATE TABLE [dbo].[tblPhieuBaoCaoDoanhThu]
(
	[MaBCDT] nvarchar(10) not null primary key,
	[ThangDT] int NOT NULL,
	[MaPKB] nvarchar(10) not null
	foreign key (MaPKB) references tblPhieuKhamBenh(MaPKB),
)
CREATE TABLE [dbo].[tblPhieuBaoCaoSuDungThuoc]
(	
	[MaBCSD] nvarchar(10) NOT NULL primary key,	
	[MaPKB] nvarchar(10) NOT NULL,		
	[ThangSD] int NOT NULL,
	foreign key (MaPKB) references tblPhieuKhamBenh(MaPKB),
)
