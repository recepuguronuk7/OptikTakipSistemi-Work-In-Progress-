USE master;
GO

-- Varsa eski veritabanını silip temiz bir sayfa açıyoruz
DROP DATABASE IF EXISTS OPTIKVT;
GO

CREATE DATABASE OPTIKVT;
GO

USE OPTIKVT;
GO

-- Senin Gönderdiğin Tablo ve İlişki Kodları (Buradan Aşağısı)
CREATE TABLE dbo.UTSYeniAlmaBildirimleri (
  UrunNo varchar(50) NULL,
  GonderenKurumNo bigint NULL,
  BildirimId uniqueidentifier NOT NULL,
  LotBatchNo varchar(50) NULL,
  SeriNo varchar(50) NULL,
  UrunTanimi varchar(200) NULL,
  GonderenKurumAdi varchar(100) NULL,
  Adet int NULL,
  BelgeNo varchar(50) NULL,
  BildirimDurumu varchar(50) NULL,
  BildirimZamani datetime NULL,
  VermeTarihi datetime NULL,
  UniqueNo bigint NULL,
  IslemDurumu int NOT NULL CONSTRAINT UTSYeniAlma_IslemDurumu DEFAULT (0),
  CONSTRAINT PK_UTSYeniAlmaBildirimleri_BildirimId PRIMARY KEY CLUSTERED (BildirimId)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.UTSGelenBildirimler (
  BildirimId uniqueidentifier NOT NULL,
  Adet varchar(50) NULL,
  BelgeNo varchar(50) NULL,
  BildirenKurumNo bigint NULL,
  BildirimDurumu varchar(50) NULL,
  BildirimTipi varchar(50) NULL,
  DigerKurumNo bigint NULL,
  BarkodNo varchar(100) NULL,
  LotBatchNo varchar(50) NULL,
  OlusturulmaTarihi datetime NULL,
  SeriNo varchar(50) NULL,
  UrunNo char(14) NULL,
  UrunTanimi varchar(200) NULL,
  KarsiBildirimId varchar(50) NULL,
  VermeTarihi varchar(50) NULL,
  GonderenKurumAdi varchar(200) NULL,
  IslemDurumu int NOT NULL CONSTRAINT DF_UTSGelenBildirimler_IslemDurumu DEFAULT (0),
  CONSTRAINT PK_StokUTSOnaylanan_BildirimKodu PRIMARY KEY CLUSTERED (BildirimId)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IX_UTSGelenBildirimler_BildirimKodu
  ON dbo.UTSGelenBildirimler (BildirimId)
  ON [PRIMARY]
GO

CREATE TABLE dbo.ReceteSatis (
  SatisId int IDENTITY,
  ReceteId int NOT NULL,
  UrunBarkodNo varchar(50) NULL,
  UrunSatisFiyati decimal NOT NULL,
  CONSTRAINT PK_ReceteDetay_DetayId PRIMARY KEY CLUSTERED (SatisId)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.Receteler (
  ReceteId int IDENTITY,
  MusteriId int NOT NULL,
  Tarih datetime NOT NULL,
  Aciklama nvarchar(200) NULL,
  Hastane varchar(50) NULL,
  Doktor varchar(50) NULL,
  Kurum varchar(50) NULL,
  CONSTRAINT PK_Receteler_ReceteID PRIMARY KEY CLUSTERED (ReceteId)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.Musteriler (
  MusteriId int IDENTITY,
  Ad varchar(50) NOT NULL,
  Soyad varchar(50) NOT NULL,
  TCNo char(11) NOT NULL,
  TelNo char(10) NOT NULL,
  Adres varchar(50) NULL,
  CONSTRAINT PK_Musteriler_MusteriId PRIMARY KEY CLUSTERED (MusteriId)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.KurumAdlari (
  KurumNo bigint NOT NULL,
  KurumAdi varchar(200) NULL,
  SonGuncelleme datetime NULL,
  CONSTRAINT PK_KurumAdlari_KurumNo PRIMARY KEY CLUSTERED (KurumNo)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.Hastaneler (
  Id int IDENTITY,
  HastaneAd varchar(50) NULL,
  Sehir varchar(50) NULL,
  Ilce varchar(50) NULL,
  HastaneKodu int NOT NULL,
  CONSTRAINT PK_Hastaneler_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.DukkanStok (
  UrunNo varchar(50) NULL,
  GonderenKurumNo bigint NULL,
  BildirimId uniqueidentifier NULL,
  LotBatchNo varchar(50) NULL,
  SeriNo varchar(50) NULL,
  UrunTanimi varchar(100) NULL,
  GonderenKurumAdi varchar(100) NULL,
  Adet varchar(100) NULL,
  BelgeNo varchar(100) NULL,
  BildirimDurumu varchar(100) NULL,
  BildirimZamani datetime NULL,
  VermeTarihi varchar(50) NULL,
  BarkodNo varchar(50) NOT NULL,
  Durum int NOT NULL CONSTRAINT DF_DukkanStok_SatisBilgisi DEFAULT (0),
  Maliyet decimal NULL,
  StokEklenmeTarihi datetime NULL,
  SatisTarihi datetime NULL,
  VermeBildirimiDurum int NOT NULL DEFAULT (0),
  CONSTRAINT PK_DukkanStok_StokId PRIMARY KEY CLUSTERED (BarkodNo)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.Doktorlar (
  DoktorId int IDENTITY,
  DoktorAd varchar(50) NULL,
  DoktorSoyad varchar(50) NULL,
  CONSTRAINT PK_Doktorlar_DoktorId PRIMARY KEY CLUSTERED (DoktorId)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.LensRecetesi (
  ReceteId int NOT NULL,
  U_Sag_BC decimal(5, 2) NULL,
  U_Sag_DIA decimal(5, 2) NULL,
  U_Sag_SPH decimal(5, 2) NULL,
  U_Sag_CYL decimal(5, 2) NULL,
  U_Sag_AKS decimal(5, 2) NULL,
  U_Sag_ADD decimal(5, 2) NULL,
  U_Sol_BC decimal(5, 2) NULL,
  U_Sol_DIA decimal(5, 2) NULL,
  U_Sol_SPH decimal(5, 2) NULL,
  U_Sol_CYL decimal(5, 2) NULL,
  U_Sol_AKS decimal(5, 2) NULL,
  U_Sol_ADD decimal(5, 2) NULL,
  Y_Sag_BC decimal(5, 2) NULL,
  Y_Sag_DIA decimal(5, 2) NULL,
  Y_Sag_SPH decimal(5, 2) NULL,
  Y_Sag_CYL decimal(5, 2) NULL,
  Y_Sag_AKS decimal(5, 2) NULL,
  Y_Sag_ADD decimal(5, 2) NULL,
  Y_Sol_BC decimal(5, 2) NULL,
  Y_Sol_DIA decimal(5, 2) NULL,
  Y_Sol_SPH decimal(5, 2) NULL,
  Y_Sol_CYL decimal(5, 2) NULL,
  Y_Sol_AKS decimal(5, 2) NULL,
  Y_Sol_ADD decimal(5, 2) NULL,
  CONSTRAINT PK_LensRecetesi2_ReceteId PRIMARY KEY CLUSTERED (ReceteId)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.GozlukRecetesi (
  ReceteId int NOT NULL,
  Y_Sag_SPH decimal(5, 2) NULL,
  Y_Sag_CYL decimal(5, 2) NULL,
  Y_Sag_AKS decimal(5, 2) NULL,
  Y_Sag_PUP decimal(5, 2) NULL,
  Y_Sag_YUK decimal(5, 2) NULL,
  Y_Sag_PRIZM decimal(5, 2) NULL,
  Y_Sag_TAB decimal(5, 2) NULL,
  Y_Sol_SPH decimal(5, 2) NULL,
  Y_Sol_CYL decimal(5, 2) NULL,
  Y_Sol_AKS decimal(5, 2) NULL,
  Y_Sol_PUP decimal(5, 2) NULL,
  Y_Sol_YUK decimal(5, 2) NULL,
  Y_Sol_PRIZM decimal(5, 2) NULL,
  Y_Sol_TAB decimal(5, 2) NULL,
  U_Sag_SPH decimal(5, 2) NULL,
  U_Sag_CYL decimal(5, 2) NULL,
  U_Sag_AKS decimal(5, 2) NULL,
  U_Sag_PUP decimal(5, 2) NULL,
  U_Sag_YUK decimal(5, 2) NULL,
  U_Sag_PRIZM decimal(5, 2) NULL,
  U_Sag_TAB decimal(5, 2) NULL,
  U_Sol_SPH decimal(5, 2) NULL,
  U_Sol_CYL decimal(5, 2) NULL,
  U_Sol_AKS decimal(5, 2) NULL,
  U_Sol_PUP decimal(5, 2) NULL,
  U_Sol_YUK decimal(5, 2) NULL,
  U_Sol_PRIZM decimal(5, 2) NULL,
  U_Sol_TAB decimal(5, 2) NULL,
  CONSTRAINT PK_GozlukRecetesi_ReceteId PRIMARY KEY CLUSTERED (ReceteId)
)
ON [PRIMARY]
GO

ALTER TABLE dbo.Receteler
  ADD CONSTRAINT FK_Receteler_MusteriID FOREIGN KEY (MusteriId) REFERENCES dbo.Musteriler (MusteriId)
GO

ALTER TABLE dbo.ReceteSatis
  ADD CONSTRAINT FK_ReceteSatis_ReceteId FOREIGN KEY (ReceteId) REFERENCES dbo.Receteler (ReceteId)
GO

ALTER TABLE dbo.LensRecetesi
  ADD CONSTRAINT FK_LensRecetesi_ReceteId FOREIGN KEY (ReceteId) REFERENCES dbo.Receteler (ReceteId)
GO

ALTER TABLE dbo.GozlukRecetesi
  ADD CONSTRAINT FK_GozlukRecetesi_ReceteId FOREIGN KEY (ReceteId) REFERENCES dbo.Receteler (ReceteId)
GO