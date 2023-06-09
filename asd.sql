USE [master]
GO
/****** Object:  Database [RegFac]    Script Date: 11/4/2023 3:41:48 p. m. ******/
CREATE DATABASE [RegFac]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RegFac', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\RegFac.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RegFac_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\RegFac_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RegFac] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RegFac].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RegFac] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RegFac] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RegFac] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RegFac] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RegFac] SET ARITHABORT OFF 
GO
ALTER DATABASE [RegFac] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RegFac] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RegFac] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RegFac] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RegFac] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RegFac] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RegFac] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RegFac] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RegFac] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RegFac] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RegFac] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RegFac] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RegFac] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RegFac] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RegFac] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RegFac] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RegFac] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RegFac] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RegFac] SET  MULTI_USER 
GO
ALTER DATABASE [RegFac] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RegFac] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RegFac] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RegFac] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RegFac] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RegFac] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RegFac] SET QUERY_STORE = OFF
GO
USE [RegFac]
GO
/****** Object:  Table [dbo].[Cheque]    Script Date: 11/4/2023 3:41:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cheque](
	[IdCheque] [int] IDENTITY(1,1) NOT NULL,
	[NumeroCheque] [nvarchar](100) NOT NULL,
	[ConceptoPago] [nvarchar](100) NOT NULL,
	[Cedula] [nvarchar](11) NOT NULL,
	[FechaPago] [datetime] NOT NULL,
	[MontoNumero] [float] NOT NULL,
	[MontoLetra] [nvarchar](100) NOT NULL,
	[FacturaPagada] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Cheque] PRIMARY KEY CLUSTERED 
(
	[IdCheque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[EditarCheque]    Script Date: 11/4/2023 3:41:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[EditarCheque]
@NumeroCheque nvarchar (100),
@ConceptoPago nvarchar (100),
@Cedula nvarchar (13),
@FechaPago datetime,
@MontoNumero float,
@MontoLetra nvarchar(100),
@FacturaPagada nvarchar(50),
@id int
as
update Cheque set NumeroCheque=@NumeroCheque, ConceptoPago=@ConceptoPago, Cedula=@Cedula, FechaPago=@FechaPago, MontoNumero=@MontoNumero, MontoLetra=@MontoLetra, FacturaPagada=@FacturaPagada where IdCheque=@id
GO
/****** Object:  StoredProcedure [dbo].[EliminarCheque]    Script Date: 11/4/2023 3:41:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[EliminarCheque]
@idpro int
as
delete from Cheque where IdCheque=@idpro
GO
/****** Object:  StoredProcedure [dbo].[InsetarCheque]    Script Date: 11/4/2023 3:41:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsetarCheque]
@NumeroCheque nvarchar (100),
@ConceptoPago nvarchar (100),
@Cedula nvarchar (13),
@FechaPago datetime,
@MontoNumero float,
@MontoLetra nvarchar(100),
@FacturaPagada nvarchar(50)
as
insert into Cheque values (@NumeroCheque,@ConceptoPago,@Cedula,@FechaPago,@MontoNumero,@MontoLetra,@FacturaPagada)
GO
/****** Object:  StoredProcedure [dbo].[MostrarCheques]    Script Date: 11/4/2023 3:41:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarCheques]
as
select *from Cheque
GO
USE [master]
GO
ALTER DATABASE [RegFac] SET  READ_WRITE 
GO
