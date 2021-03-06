USE [master]
GO
/****** Object:  Database [sistema_ventas]    Script Date: 10/05/2021 18:02:37 ******/
CREATE DATABASE [sistema_ventas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sistema_ventas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\sistema_ventas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sistema_ventas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\sistema_ventas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [sistema_ventas] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sistema_ventas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sistema_ventas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sistema_ventas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sistema_ventas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sistema_ventas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sistema_ventas] SET ARITHABORT OFF 
GO
ALTER DATABASE [sistema_ventas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sistema_ventas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sistema_ventas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sistema_ventas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sistema_ventas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sistema_ventas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sistema_ventas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sistema_ventas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sistema_ventas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sistema_ventas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [sistema_ventas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sistema_ventas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sistema_ventas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sistema_ventas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sistema_ventas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sistema_ventas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sistema_ventas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sistema_ventas] SET RECOVERY FULL 
GO
ALTER DATABASE [sistema_ventas] SET  MULTI_USER 
GO
ALTER DATABASE [sistema_ventas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sistema_ventas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sistema_ventas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sistema_ventas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sistema_ventas] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'sistema_ventas', N'ON'
GO
ALTER DATABASE [sistema_ventas] SET QUERY_STORE = OFF
GO
USE [sistema_ventas]
GO
/****** Object:  Table [dbo].[tb_cliente]    Script Date: 10/05/2021 18:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_cliente](
	[iDCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombreCliente] [varchar](50) NULL,
	[direccionCliente] [varchar](50) NULL,
	[duiCliente] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[iDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_detalleVenta]    Script Date: 10/05/2021 18:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_detalleVenta](
	[iDDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[idVenta] [int] NULL,
	[idProducto] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](18, 5) NULL,
	[total] [decimal](18, 5) NULL,
PRIMARY KEY CLUSTERED 
(
	[iDDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_documento]    Script Date: 10/05/2021 18:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_documento](
	[iDDocumento] [int] IDENTITY(1,1) NOT NULL,
	[nombreDocumento] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[iDDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_producto]    Script Date: 10/05/2021 18:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombreProducto] [varchar](50) NULL,
	[precioProducto] [varchar](50) NULL,
	[estadoProducto] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_usuario]    Script Date: 10/05/2021 18:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_usuario](
	[iDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NULL,
	[contrasena] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[iDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_venta]    Script Date: 10/05/2021 18:02:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_venta](
	[iDVenta] [int] IDENTITY(1,1) NOT NULL,
	[iDDocumento] [int] NULL,
	[iDCliente] [int] NULL,
	[iDUsuario] [int] NULL,
	[iDProducto] [int] NULL,
	[totalVenta] [decimal](18, 5) NULL,
	[fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[iDVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_detalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_tb_detalleVenta_tb_producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[tb_producto] ([idProducto])
GO
ALTER TABLE [dbo].[tb_detalleVenta] CHECK CONSTRAINT [FK_tb_detalleVenta_tb_producto]
GO
ALTER TABLE [dbo].[tb_detalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_tb_detalleVenta_tb_venta] FOREIGN KEY([idVenta])
REFERENCES [dbo].[tb_venta] ([iDVenta])
GO
ALTER TABLE [dbo].[tb_detalleVenta] CHECK CONSTRAINT [FK_tb_detalleVenta_tb_venta]
GO
ALTER TABLE [dbo].[tb_venta]  WITH CHECK ADD  CONSTRAINT [FK_tb_venta_tb_cliente] FOREIGN KEY([iDCliente])
REFERENCES [dbo].[tb_cliente] ([iDCliente])
GO
ALTER TABLE [dbo].[tb_venta] CHECK CONSTRAINT [FK_tb_venta_tb_cliente]
GO
ALTER TABLE [dbo].[tb_venta]  WITH CHECK ADD  CONSTRAINT [FK_tb_venta_tb_documento] FOREIGN KEY([iDDocumento])
REFERENCES [dbo].[tb_documento] ([iDDocumento])
GO
ALTER TABLE [dbo].[tb_venta] CHECK CONSTRAINT [FK_tb_venta_tb_documento]
GO
ALTER TABLE [dbo].[tb_venta]  WITH CHECK ADD  CONSTRAINT [FK_tb_venta_tb_usuario] FOREIGN KEY([iDUsuario])
REFERENCES [dbo].[tb_usuario] ([iDUsuario])
GO
ALTER TABLE [dbo].[tb_venta] CHECK CONSTRAINT [FK_tb_venta_tb_usuario]
GO
USE [master]
GO
ALTER DATABASE [sistema_ventas] SET  READ_WRITE 
GO
