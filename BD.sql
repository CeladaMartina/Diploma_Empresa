USE [master]
GO
/****** Object:  Database [Diploma_Empresa]    Script Date: 2022-10-13 7:20:19 PM ******/
CREATE DATABASE [Diploma_Empresa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Diploma_Empresa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Diploma_Empresa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Diploma_Empresa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Diploma_Empresa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Diploma_Empresa] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Diploma_Empresa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Diploma_Empresa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET ARITHABORT OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Diploma_Empresa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Diploma_Empresa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Diploma_Empresa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Diploma_Empresa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET RECOVERY FULL 
GO
ALTER DATABASE [Diploma_Empresa] SET  MULTI_USER 
GO
ALTER DATABASE [Diploma_Empresa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Diploma_Empresa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Diploma_Empresa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Diploma_Empresa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Diploma_Empresa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Diploma_Empresa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Diploma_Empresa', N'ON'
GO
ALTER DATABASE [Diploma_Empresa] SET QUERY_STORE = OFF
GO
USE [Diploma_Empresa]
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[IdArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IdLocalidad] [int] NOT NULL,
	[CodProd] [int] NOT NULL,
	[Nombre] [nvarchar](40) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Material] [nvarchar](40) NOT NULL,
	[Talle] [int] NOT NULL,
	[Stock] [int] NOT NULL,
	[PUnit] [money] NOT NULL,
	[BajaLogica] [bit] NOT NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[IdArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[IdBitacora] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Criticidad] [nvarchar](20) NOT NULL,
	[DVH] [int] NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[IdBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](40) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[FechaNac] [datetime] NOT NULL,
	[Tel] [int] NOT NULL,
	[Mail] [nvarchar](240) NOT NULL,
	[BajaLogica] [bit] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Control_Cambios_Proveedor]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Control_Cambios_Proveedor](
	[IdCambioProveedor] [int] IDENTITY(1,1) NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[CUIT] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](40) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[FechaNac] [datetime] NOT NULL,
	[Tel] [int] NOT NULL,
	[Mail] [nvarchar](240) NOT NULL,
	[BajaLogica] [bit] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Control_Cambios_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IdCambioProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Compra]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Compra](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdCompra] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Cant] [int] NOT NULL,
	[PUnit] [money] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Detalle_Compra] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Cant] [int] NOT NULL,
	[PUnit] [money] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Detalle_Venta] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DVV]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVV](
	[IdDVV] [int] IDENTITY(1,1) NOT NULL,
	[NombreTabla] [nvarchar](50) NOT NULL,
	[DVV] [int] NOT NULL,
 CONSTRAINT [PK_DVV] PRIMARY KEY CLUSTERED 
(
	[IdDVV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[IdIdioma] [int] IDENTITY(1,1) NOT NULL,
	[NombreIdioma] [nvarchar](100) NOT NULL,
	[BajaLogica] [bit] NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[IdIdioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IdiomaOriginal]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IdiomaOriginal](
	[Id_Original] [int] IDENTITY(1,1) NOT NULL,
	[Original] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_IdiomaOriginal] PRIMARY KEY CLUSTERED 
(
	[Id_Original] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[IdLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Descripcion] [nvarchar](40) NOT NULL,
	[CodPostal] [int] NOT NULL,
	[Partido] [nvarchar](50) NOT NULL,
	[BajaLogica] [bit] NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[IdPedido] [int] IDENTITY(1,1) NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[permiso] [nvarchar](100) NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_permiso](
	[id_permiso_padre] [int] NULL,
	[id_permiso_hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[CUIT] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](40) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[FechaNac] [datetime] NOT NULL,
	[Tel] [int] NOT NULL,
	[Mail] [nvarchar](240) NOT NULL,
	[BajaLogica] [bit] NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[IdTraduccion] [int] IDENTITY(1,1) NOT NULL,
	[IdIdioma] [int] NOT NULL,
	[IdOriginal] [int] NOT NULL,
	[Traducido] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Traduccion_1] PRIMARY KEY CLUSTERED 
(
	[IdTraduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nick] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](40) NOT NULL,
	[Mail] [nvarchar](240) NOT NULL,
	[Estado] [bit] NOT NULL,
	[Contador] [int] NOT NULL,
	[IdIdioma] [int] NOT NULL,
	[BajaLogica] [bit] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios_permisos](
	[id_usuario] [int] NOT NULL,
	[id_permiso] [int] NOT NULL,
 CONSTRAINT [PK_usuarios_permisos] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_Articulo_Localidad] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidad] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_Articulo_Localidad]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Proveedor] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedor] ([IdProveedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Proveedor]
GO
ALTER TABLE [dbo].[Control_Cambios_Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Control_Cambios_Proveedor_Proveedor] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Control_Cambios_Proveedor] CHECK CONSTRAINT [FK_Control_Cambios_Proveedor_Proveedor]
GO
ALTER TABLE [dbo].[Control_Cambios_Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Control_Cambios_Proveedor_Proveedor1] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedor] ([IdProveedor])
GO
ALTER TABLE [dbo].[Control_Cambios_Proveedor] CHECK CONSTRAINT [FK_Control_Cambios_Proveedor_Proveedor1]
GO
ALTER TABLE [dbo].[Detalle_Compra]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Compra_Articulo] FOREIGN KEY([IdArticulo])
REFERENCES [dbo].[Articulo] ([IdArticulo])
GO
ALTER TABLE [dbo].[Detalle_Compra] CHECK CONSTRAINT [FK_Detalle_Compra_Articulo]
GO
ALTER TABLE [dbo].[Detalle_Compra]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Compra_Compra] FOREIGN KEY([IdCompra])
REFERENCES [dbo].[Compra] ([IdCompra])
GO
ALTER TABLE [dbo].[Detalle_Compra] CHECK CONSTRAINT [FK_Detalle_Compra_Compra]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Articulo] FOREIGN KEY([IdArticulo])
REFERENCES [dbo].[Articulo] ([IdArticulo])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Articulo]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Venta] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Venta] ([IdVenta])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Venta]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Articulo] FOREIGN KEY([IdArticulo])
REFERENCES [dbo].[Articulo] ([IdArticulo])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Articulo]
GO
ALTER TABLE [dbo].[permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_PermisoHijo] FOREIGN KEY([id_permiso_hijo])
REFERENCES [dbo].[Permiso] ([id])
GO
ALTER TABLE [dbo].[permiso_permiso] CHECK CONSTRAINT [FK_Table_1_PermisoHijo]
GO
ALTER TABLE [dbo].[permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_PermisoPadre] FOREIGN KEY([id_permiso_padre])
REFERENCES [dbo].[Permiso] ([id])
GO
ALTER TABLE [dbo].[permiso_permiso] CHECK CONSTRAINT [FK_Table_1_PermisoPadre]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma1] FOREIGN KEY([IdIdioma])
REFERENCES [dbo].[Idioma] ([IdIdioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma1]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_IdiomaOriginal] FOREIGN KEY([IdOriginal])
REFERENCES [dbo].[IdiomaOriginal] ([Id_Original])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_IdiomaOriginal]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([IdIdioma])
REFERENCES [dbo].[Idioma] ([IdIdioma])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_Permiso] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[Permiso] ([id])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_Permiso]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_Usuario]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[AltaArticulo]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AltaArticulo]
@IdArticulo int, @IdLocalidad int, @CodProd int, @Nombre nvarchar(40),
@Descripcion nvarchar(50), @Material nvarchar(40), @Talle int, 
@Stock int, @PUnit money
as
if exists (select * from Articulo where IdArticulo=@IdArticulo)
and @CodProd=(select CodProd from Articulo where IdArticulo=@IdArticulo)
	begin
		update Articulo
		set BajaLogica = 0 where CodProd = @CodProd
	end
else
	begin
		insert into Articulo (IdLocalidad,CodProd,Nombre,Descripcion,
		Material,Talle,Stock,PUnit,BajaLogica)
		values (@IdLocalidad,@CodProd,@Nombre,@Descripcion,@Material,
		@Talle,@Stock,@PUnit,0)
	end


GO
/****** Object:  StoredProcedure [dbo].[AltaCliente]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	proc [dbo].[AltaCliente]
@IdCliente int, @DNI nvarchar(50), @Nombre nvarchar(40), @Apellido nvarchar(50), @FechaNac datetime, @Tel int, @Mail nvarchar(240)
as

	if	exists(select * from Cliente where IdCliente=@IdCliente) 
	and @DNI=(select DNI from Cliente where IdCliente=@IdCliente) 
	and @Mail=(select Mail from Cliente where IdCliente=@IdCliente)
		begin 
			update Cliente 
			set BajaLogica = 0 where IdCliente=@IdCliente
		end
	else if (@Mail not in (select Mail from Cliente) and @DNI not in (select DNI from Cliente)) 
		begin
			insert into Cliente (DNI,Nombre,Apellido,FechaNac,Tel,Mail,BajaLogica)
			values (@DNI,@Nombre,@Apellido,@FechaNac,@Tel,@Mail,0)
end

GO
/****** Object:  StoredProcedure [dbo].[AltaCompra]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AltaCompra]
@IdProveedor int, @Fecha datetime
as
begin
insert into Compra(IdProveedor,Fecha)
values (@IdProveedor,@Fecha)
end


GO
/****** Object:  StoredProcedure [dbo].[AltaDetalleCompra]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AltaDetalleCompra]
@IdCompra int, @IdArticulo int, @Cant int, @PUnit money, @DVH int
as
	begin
		insert into Detalle_Compra(IdCompra,IdArticulo,Cant,PUnit,DVH) 
		values (@IdCompra,@IdArticulo,@Cant,@PUnit,@DVH)
	end 

GO
/****** Object:  StoredProcedure [dbo].[AltaDetalleVenta]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AltaDetalleVenta]
@IdVenta int, @IdArticulo int, @Cant int, @PUnit money, @DVH int
as
	begin
		insert into Detalle_Venta(IdVenta,IdArticulo,Cant,PUnit,DVH)
		values (@IdVenta,@IdArticulo,@Cant,@PUnit,@DVH)
	end

GO
/****** Object:  StoredProcedure [dbo].[AltaIdioma]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
CREATE proc [dbo].[AltaIdioma]
@IdIdioma int, @NombreIdioma nvarchar(100)
as
if EXISTS(select * from Idioma where IdIdioma = @IdIdioma)
		begin
		update Idioma
		set BajaLogica = 0 where IdIdioma = @IdIdioma
		end
else
		begin
				insert into Idioma(NombreIdioma,BajaLogica) values (@NombreIdioma,0)
		end

GO
/****** Object:  StoredProcedure [dbo].[AltaLocalidad]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AltaLocalidad]
@IdLocalidad int, @Nombre nvarchar(30), @Descripcion nvarchar(40),
@CodPostal int, @Partido nvarchar(50)
as
if exists(select * from Localidad where IdLocalidad=@IdLocalidad)
	begin
		update Localidad
		set BajaLogica = 0 where IdLocalidad=@IdLocalidad
	end
else
	begin 
		insert into Localidad(Nombre,Descripcion,CodPostal,
		Partido,BajaLogica)
		values (@Nombre,@Descripcion,@CodPostal,@Partido,0)
	end


GO
/****** Object:  StoredProcedure [dbo].[AltaPedido]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[AltaPedido]
@IdArticulo int, @Cantidad int
as
if exists (select * from Pedido where IdArticulo = @IdArticulo)
	begin
		update Pedido
		set Cantidad = @Cantidad + Cantidad where IdArticulo = @IdArticulo
	end
else
	begin
		insert into Pedido(IdArticulo,Cantidad)
		values (@IdArticulo,@Cantidad)
	end

GO
/****** Object:  StoredProcedure [dbo].[AltaProveedor]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AltaProveedor]
@IdProveedor int, @CUIT nvarchar(50),@Nombre nvarchar(40),
@Apellido nvarchar(50), @FechaNac datetime, @Tel int,
@Mail nvarchar(240)
as

if exists (select * from Proveedor where IdProveedor=@IdProveedor)
and @CUIT = (select CUIT from Proveedor where IdProveedor=@IdProveedor)
and @Mail = (select Mail from Proveedor where IdProveedor=@IdProveedor)
	begin
		update Proveedor
		set BajaLogica = 0 where IdProveedor = @IdProveedor
	end
else if(@Mail not in (select Mail from Proveedor) and @CUIT not in(select CUIT from Proveedor))
	begin
		insert into Proveedor(CUIT,Nombre,Apellido,FechaNac,
		Tel,Mail,BajaLogica)
		values (@CUIT,@Nombre,@Apellido,@FechaNac,@Tel,
		@Mail,0)
	end

GO
/****** Object:  StoredProcedure [dbo].[AltaTraduccion]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AltaTraduccion]
@NombreIdioma nvarchar(100), @Original nvarchar(250), @Traducido nvarchar(250)
as
begin
if not EXISTS (select * from Traduccion where IdIdioma = (select IdIdioma from Idioma where NombreIdioma = @NombreIdioma) and IdOriginal = (select Id_Original from IdiomaOriginal where Original = @Original))
insert into Traduccion(IdIdioma,IdOriginal,Traducido) values ((select IdIdioma from Idioma where NombreIdioma = @NombreIdioma), (select Id_Original from IdiomaOriginal where Original = @Original), @Traducido)
end

GO
/****** Object:  StoredProcedure [dbo].[AltaUsuario]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AltaUsuario]
@IdUsuario int, @Nick nvarchar(50), @Contraseña nvarchar(50),
@Nombre nvarchar(40), @Mail nvarchar(240), @Estado bit, @Contador int,
@Idioma nvarchar(25), @DVH int
as
if @Nick=(select Nick from Usuario where IdUsuario=@IdUsuario)
	begin
		update Usuario
		set BajaLogica = 0 where IdUsuario=@IdUsuario
	end
else
	begin
		insert into Usuario(Nick,Contraseña,Nombre,Mail,Estado,
		Contador,IdIdioma,BajaLogica,DVH)
		values (@Nick,@Contraseña,@Nombre,@Mail,@Estado,@Contador,
		(select IdIdioma from Idioma where NombreIdioma = @Idioma),0,@DVH)
	end
GO
/****** Object:  StoredProcedure [dbo].[AltaVenta]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AltaVenta]
@IdCliente int, @Fecha datetime
as
begin
insert into Venta(IdCliente,Fecha)
values (@IdCliente,@Fecha)
end


GO
/****** Object:  StoredProcedure [dbo].[BajaArticulo]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BajaArticulo]
@IdArticulo int
as
begin
update Articulo
set BajaLogica = 1 where IdArticulo=@IdArticulo
end


GO
/****** Object:  StoredProcedure [dbo].[BajaCliente]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BajaCliente]
@IdCliente int 
as
begin
update Cliente 
set BajaLogica = 1 where IdCliente=@IdCliente
end


GO
/****** Object:  StoredProcedure [dbo].[BajaDetalleCompra]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BajaDetalleCompra]
@IdDetalle int
as
begin
delete from Detalle_Compra where IdDetalle=@IdDetalle
end


GO
/****** Object:  StoredProcedure [dbo].[BajaDetalleVenta]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BajaDetalleVenta]
@IdDetalle int 
as
begin
delete from Detalle_Venta where IdDetalle=@IdDetalle
end


GO
/****** Object:  StoredProcedure [dbo].[BajaIdioma]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BajaIdioma]
@IdIdioma int
as
begin
		update Idioma
		set BajaLogica = 1
		where IdIdioma = @IdIdioma
end

GO
/****** Object:  StoredProcedure [dbo].[BajaLocalidad]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BajaLocalidad]
@IdLocalidad int 
as
begin
update Localidad
set BajaLogica = 1 where IdLocalidad=@IdLocalidad
end


GO
/****** Object:  StoredProcedure [dbo].[BajaPedido]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[BajaPedido]
@IdArticulo int
as
begin
delete from Pedido
where IdArticulo = @IdArticulo
end

GO
/****** Object:  StoredProcedure [dbo].[BajaProveedor]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BajaProveedor]
@IdProveedor int
as
begin 
update Proveedor
set BajaLogica = 1 where IdProveedor =@IdProveedor
end


GO
/****** Object:  StoredProcedure [dbo].[BajaTraduccion]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BajaTraduccion]
@IdTraduccion int
as
begin
delete from Traduccion where IdTraduccion = @IdTraduccion
end

GO
/****** Object:  StoredProcedure [dbo].[BajaUsuario]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc[dbo].[BajaUsuario]
@IdUsuario int, @DVH int
as
begin
update Usuario
set BajaLogica=1,DVH=@DVH where IdUsuario=@IdUsuario
end


GO
/****** Object:  StoredProcedure [dbo].[CargarBitacora]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CargarBitacora]
@IdUsuario int, @Fecha datetime, @Descripcion nvarchar(50), @Criticidad nvarchar(20), @DVH int
as
begin
insert into Bitacora(IdUsuario,Fecha,Descripcion,Criticidad,DVH)
values(@IdUsuario,CONVERT(DATETIME, CONVERT(VARCHAR(20), @Fecha, 120)),@Descripcion,@Criticidad, @DVH)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarControlCambioProveedor]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarControlCambioProveedor]
@CUIT nvarchar(50), @Nombre nvarchar(40), @Apellido nvarchar(50),
@FechaN datetime, @Tel int, @Mail nvarchar(240),@IdUsuario int, @FechaModificacion datetime
as
begin
insert into Control_Cambios_Proveedor(IdProveedor,CUIT,Nombre,Apellido,FechaNac,Tel,Mail,BajaLogica,IdUsuario,FechaModificacion)
values ((select IdProveedor from Proveedor where CUIT = @CUIT),@CUIT,@Nombre,@Apellido,@FechaN,@Tel,@Mail, (select BajaLogica from Proveedor where CUIT = @CUIT), @IdUsuario ,@FechaModificacion)
end 
GO
/****** Object:  StoredProcedure [dbo].[ListarArticulo]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarArticulo]
as
begin
select A.IdArticulo, A.CodProd, A.Nombre, A.Descripcion, A.Material, 
A.Talle,L.Nombre as 'NombreLocalidad', A.Stock, A.PUnit,A.BajaLogica from Articulo A 
inner join Localidad L on L.IdLocalidad = A.IdLocalidad
end

GO
/****** Object:  StoredProcedure [dbo].[ListarBitacora]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListarBitacora]
as
begin
select U.Nick,B.Fecha,B.Descripcion,B.Criticidad from Usuario U 
inner join Bitacora B on U.IdUsuario = B.IdUsuario
end


GO
/****** Object:  StoredProcedure [dbo].[ListarBitacoraVerificacion]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarBitacoraVerificacion]
as
begin 
select * from Bitacora
end

GO
/****** Object:  StoredProcedure [dbo].[ListarCliente]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListarCliente]
as
begin
select * from Cliente
end


GO
/****** Object:  StoredProcedure [dbo].[ListarCompra]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarCompra]
as
begin
select C.IdCompra as 'NumCompra', P.CUIT, C.Fecha,
(select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) as 'Monto' 
from Compra C inner join Proveedor P on P.IdProveedor = c.IdProveedor
end
GO
/****** Object:  StoredProcedure [dbo].[ListarCompraVerificacion]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarCompraVerificacion]
as
begin 
select * from Detalle_Compra
end

GO
/****** Object:  StoredProcedure [dbo].[ListarControlCambiosProveedor]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarControlCambiosProveedor]
as
begin
select CP.IdProveedor,CP.CUIT,CP.Nombre,CP.Apellido,CP.FechaNac,CP.Tel,CP.Mail,CP.BajaLogica,U.Nick,CP.FechaModificacion from Control_Cambios_Proveedor CP, Usuario U
where CP.IdUsuario = U.IdUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[ListarDCParametros]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListarDCParametros]
@IdCompra  int 
as
begin
select DC.IdDetalle,Ar.CodProd, DC.PUnit, DC.Cant from Detalle_Compra DC
inner join Articulo Ar on DC.IdArticulo = Ar.IdArticulo
where DC.IdCompra = @IdCompra
end


GO
/****** Object:  StoredProcedure [dbo].[ListarDVParametros]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarDVParametros]
@IdVenta int
as
begin
select DV.IdDetalle, Ar.CodProd, DV.PUnit, DV.Cant from  Detalle_Venta DV
inner join Articulo Ar on DV.IdArticulo = Ar.IdArticulo
where DV.IdVenta = @IdVenta
end

GO
/****** Object:  StoredProcedure [dbo].[ListarIdioma]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarIdioma]
as
begin
select IdIdioma, NombreIdioma, BajaLogica from Idioma
end
GO
/****** Object:  StoredProcedure [dbo].[ListarLocalidad]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListarLocalidad]
as
begin
select * from Localidad
end


GO
/****** Object:  StoredProcedure [dbo].[ListarPedido]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarPedido]
as
begin
select P.IdPedido,A.CodProd,P.Cantidad,A.Descripcion from Pedido P,Articulo A
where P.IdArticulo = A.IdArticulo
end

GO
/****** Object:  StoredProcedure [dbo].[ListarProveedor]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListarProveedor]
as
begin
select * from Proveedor
end


GO
/****** Object:  StoredProcedure [dbo].[ListarTraduccion]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarTraduccion]
@NombreIdioma nvarchar(100)
as
begin
select T.IdTraduccion,I.NombreIdioma,IOR.Original,T.Traducido from Traduccion T,IdiomaOriginal IOR,Idioma I
where I.NombreIdioma = @NombreIdioma
and I.IdIdioma = T.IdIdioma
and IOR.Id_Original = T.IdOriginal
end
GO
/****** Object:  StoredProcedure [dbo].[ListarTraduccionDiccionario]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarTraduccionDiccionario]
@NombreIdioma nvarchar(100)
as
begin
select IOR.Original,T.Traducido from IdiomaOriginal IOR, Traduccion T
where T.IdIdioma = (select IdIdioma from Idioma where NombreIdioma = @NombreIdioma)
and IOR.Id_Original = T.IdOriginal
end
GO
/****** Object:  StoredProcedure [dbo].[ListarUsuario]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarUsuario]
as
begin
select U.IdUsuario,u.Nick,U.Contraseña,U.Nombre,U.Mail,U.Estado,U.Contador,U.IdIdioma,I.NombreIdioma,U.BajaLogica,U.DVH from Usuario U,Idioma I
where U.IdIdioma = I.IdIdioma
end

GO
/****** Object:  StoredProcedure [dbo].[ListarVenta]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarVenta]
as
begin
select V.IdVenta as 'NumVenta', c.DNI as 'DNICliente',v.Fecha,
(select ISNULL(SUM(Cant * PUnit),0) from Detalle_Venta where IdVenta = V.IdVenta) as 'Monto'
from Venta V inner join Cliente C on c.IdCliente = v.IdCliente
end
GO
/****** Object:  StoredProcedure [dbo].[ListarVentaVerificacion]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarVentaVerificacion]
as
begin 
select * from Detalle_Venta
end

GO
/****** Object:  StoredProcedure [dbo].[ModificarArticulo]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ModificarArticulo]
@IdArticulo int, @IdLocalidad int, @CodProd int, @Nombre nvarchar(40),
@Descripcion nvarchar(50), @Material nvarchar(40), @Talle int, 
@PUnit money
as
begin
update Articulo
set IdLocalidad = @IdLocalidad,
	CodProd = @CodProd,
	Nombre = @Nombre,
	Descripcion = @Descripcion,
	Material = @Material,
	Talle = @Talle,
	PUnit = @PUnit
where IdArticulo = @IdArticulo
end

GO
/****** Object:  StoredProcedure [dbo].[ModificarCliente]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ModificarCliente]
@IdCliente int,@DNI nvarchar(50),@Nombre nvarchar(40),@Apellido nvarchar(50),
@FechaNac datetime,@Tel int,@Mail nvarchar(240)
as
begin
update Cliente
set DNI=@DNI,Nombre=@Nombre,Apellido=@Apellido,FechaNac=@FechaNac,Tel=@Tel,Mail=@Mail
where IdCliente=@IdCliente
end


GO
/****** Object:  StoredProcedure [dbo].[ModificarDetalleCompra]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ModificarDetalleCompra]
@IdDetalle int, @IdArticulo int, @Cant int, @PUnit money, @DVH int
as
begin
update Detalle_Compra
set IdArticulo = @IdArticulo,
	Cant = @Cant,
	PUnit = @PUnit,
	DVH = @DVH
where IdDetalle = @IdDetalle
end

GO
/****** Object:  StoredProcedure [dbo].[ModificarDetalleVenta]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ModificarDetalleVenta]
@IdDetalle int,  @IdArticulo int, @Cant int, @PUnit money, @DVH int
as
begin
update Detalle_Venta
set IdArticulo = @IdArticulo,
	Cant = @Cant,
	PUnit = @PUnit,
	DVH = @DVH
where IdDetalle = @IdDetalle
end

GO
/****** Object:  StoredProcedure [dbo].[ModificarIdioma]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ModificarIdioma]
@IdIdioma int, @NombreIdioma nvarchar(100)
as
begin
		update Idioma
		set NombreIdioma = @NombreIdioma
		where IdIdioma = @IdIdioma
End

GO
/****** Object:  StoredProcedure [dbo].[ModificarLocalidad]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ModificarLocalidad]
@IdLocalidad int, @Nombre nvarchar(30),@Descripcion nvarchar(40),@CodPostal int, @Partido nvarchar(50)
as
begin
update Localidad
set Nombre = @Nombre,
	Descripcion = @Descripcion,
	CodPostal = @CodPostal,
	Partido = @Partido
	where IdLocalidad = @IdLocalidad
end

GO
/****** Object:  StoredProcedure [dbo].[ModificarPedido]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[ModificarPedido]
@IdArticulo int, @Cantidad int
as
begin
update Pedido
set IdArticulo = @IdArticulo, 
	Cantidad = @Cantidad	
where IdArticulo = @IdArticulo
end

GO
/****** Object:  StoredProcedure [dbo].[ModificarProveedor]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ModificarProveedor]
@IdProveedor int, @CUIT nvarchar(50), @Nombre nvarchar(40), @Apellido nvarchar(50),
@FechaNac datetime, @Tel int, @Mail nvarchar(240)
as
begin
update Proveedor
set CUIT=@CUIT,Nombre=@Nombre,Apellido=@Apellido,FechaNac=@FechaNac,Tel=@Tel,Mail=@Mail
where IdProveedor=@IdProveedor
end


GO
/****** Object:  StoredProcedure [dbo].[ModificarTraduccion]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ModificarTraduccion]
@IdTraduccion int, @NombreIdioma nvarchar(100), @Original nvarchar(250), @Traducido nvarchar(250)
as
begin
update Traduccion
set IdIdioma = (select IdIdioma from Idioma where NombreIdioma = @NombreIdioma), IdOriginal = (select Id_Original from IdiomaOriginal where Original = @Original), Traducido = @Traducido
where IdTraduccion = @IdTraduccion
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuario]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ModificarUsuario]
@IdUsuario int, @Nick nvarchar(50), @Nombre nvarchar(40),
@Mail nvarchar(240), @Estado bit, @Contador int, @Idioma nvarchar(25), @DVH int
as
begin
update Usuario
set Nick=@Nick,Nombre=@Nombre,Mail=@Mail,Estado=@Estado,
Contador=@Contador,IdIdioma=(select IdIdioma from Idioma where NombreIdioma = @Idioma),DVH=@DVH
where IdUsuario=@IdUsuario
end

GO
/****** Object:  StoredProcedure [dbo].[VolverEstadoProveedor]    Script Date: 2022-10-13 7:20:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VolverEstadoProveedor]
@IdProveedor int, @CUIT nvarchar(50), @Nombre nvarchar(40),
@Apellido nvarchar(50), @FechaNac datetime, @Tel int,
@Mail nvarchar(240), @BajaLogica bit
as
begin
update Proveedor 
set CUIT = @CUIT, Nombre = @Nombre, Apellido = @Apellido,
FechaNac = @FechaNac, Tel = @Tel, Mail = @Mail, 
BajaLogica = @BajaLogica
where IdProveedor = @IdProveedor
end

GO
USE [master]
GO
ALTER DATABASE [Diploma_Empresa] SET  READ_WRITE 
GO
