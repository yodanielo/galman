/****** Object:  Database Galman    Script Date: 05/06/2008 07:13:25 p.m. ******/
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Galman')
	DROP DATABASE [Galman]
GO

CREATE DATABASE [Galman]  ON (NAME = N'Galman_Data', FILENAME = N'G:\bases de datos\trabajos\galman db\Galman_Data.MDF' , SIZE = 2, FILEGROWTH = 10%) LOG ON (NAME = N'Galman_Log', FILENAME = N'G:\bases de datos\trabajos\galman db\Galman_Log.LDF' , SIZE = 1, FILEGROWTH = 10%)
 COLLATE Traditional_Spanish_CI_AS
GO
ALTER DATABASE [Galman] ADD FILEGROUP [lowupdate] 
GO
ALTER DATABASE [Galman] ADD FILE(NAME = N'lowupdate_Data', FILENAME = N'G:\bases de datos\trabajos\galman db\Galman3_Data.NDF' , SIZE = 1, FILEGROWTH = 10%) TO FILEGROUP [lowupdate]
GO
ALTER DATABASE [Galman] ADD FILEGROUP [mediumupdate] 
GO
ALTER DATABASE [Galman] ADD FILE(NAME = N'mediumupdate_Data', FILENAME = N'G:\bases de datos\trabajos\galman db\Galman2_Data.NDF' , SIZE = 1, FILEGROWTH = 10%) TO FILEGROUP [mediumupdate]
GO
ALTER DATABASE [Galman] ADD FILEGROUP [hardupdate] 
GO
ALTER DATABASE [Galman] ADD FILE(NAME = N'hardupdate_Data', FILENAME = N'G:\bases de datos\trabajos\galman db\Galman1_Data.NDF' , SIZE = 1, FILEGROWTH = 10%) TO FILEGROUP [hardupdate]
GO

exec sp_dboption N'Galman', N'autoclose', N'false'
GO

exec sp_dboption N'Galman', N'bulkcopy', N'false'
GO

exec sp_dboption N'Galman', N'trunc. log', N'true'
GO

exec sp_dboption N'Galman', N'torn page detection', N'true'
GO

exec sp_dboption N'Galman', N'read only', N'false'
GO

exec sp_dboption N'Galman', N'dbo use', N'false'
GO

exec sp_dboption N'Galman', N'single', N'false'
GO

exec sp_dboption N'Galman', N'autoshrink', N'true'
GO

exec sp_dboption N'Galman', N'ANSI null default', N'false'
GO

exec sp_dboption N'Galman', N'recursive triggers', N'false'
GO

exec sp_dboption N'Galman', N'ANSI nulls', N'false'
GO

exec sp_dboption N'Galman', N'concat null yields null', N'false'
GO

exec sp_dboption N'Galman', N'cursor close on commit', N'false'
GO

exec sp_dboption N'Galman', N'default to local cursor', N'false'
GO

exec sp_dboption N'Galman', N'quoted identifier', N'false'
GO

exec sp_dboption N'Galman', N'ANSI warnings', N'false'
GO

exec sp_dboption N'Galman', N'auto create statistics', N'true'
GO

exec sp_dboption N'Galman', N'auto update statistics', N'true'
GO

if( (@@microsoftversion / power(2, 24) = 8) and (@@microsoftversion & 0xffff >= 724) )
	exec sp_dboption N'Galman', N'db chaining', N'false'
GO

use [Galman]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tconarrendatario_tconarrendamiento]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tconarrendatario] DROP CONSTRAINT FK_tconarrendatario_tconarrendamiento
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tconrescindido_tconarrendamiento]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tconrescindido] DROP CONSTRAINT FK_tconrescindido_tconarrendamiento
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tloccontrato_tconarrendamiento]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tloccontrato] DROP CONSTRAINT FK_tloccontrato_tconarrendamiento
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tmantenimiento_tconarrendamiento]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tmantenimiento] DROP CONSTRAINT FK_tmantenimiento_tconarrendamiento
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tmerconductiva_tconarrendamiento]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tmerconductiva] DROP CONSTRAINT FK_tmerconductiva_tconarrendamiento
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tarbitrio_tlocal]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tarbitrio] DROP CONSTRAINT FK_tarbitrio_tlocal
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tloccontrato_tlocal]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tloccontrato] DROP CONSTRAINT FK_tloccontrato_tlocal
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tluz_tlocal]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tluz] DROP CONSTRAINT FK_tluz_tlocal
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tconarrendatario_tperjuridica]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tconarrendatario] DROP CONSTRAINT FK_tconarrendatario_tperjuridica
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpagcontratista_tperjuridica]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpagcontratista] DROP CONSTRAINT FK_tpagcontratista_tperjuridica
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpernatjuridica_tperjuridica]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpernatjuridica] DROP CONSTRAINT FK_tpernatjuridica_tperjuridica
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tteljuridico_tperjuridica]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tteljuridico] DROP CONSTRAINT FK_tteljuridico_tperjuridica
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ttipo_tperjuridica]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ttipo] DROP CONSTRAINT FK_ttipo_tperjuridica
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ttippernatural_tperjuridica]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ttippersona] DROP CONSTRAINT FK_ttippernatural_tperjuridica
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tconarrendatario_tpernatural]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tconarrendatario] DROP CONSTRAINT FK_tconarrendatario_tpernatural
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_templeado_tpernatural]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[templeado] DROP CONSTRAINT FK_templeado_tpernatural
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpagcontratista_tpernatural]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpagcontratista] DROP CONSTRAINT FK_tpagcontratista_tpernatural
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpagopersonal_tpernatural]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpagopersonal] DROP CONSTRAINT FK_tpagopersonal_tpernatural
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpernatjuridica_tpernatural]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpernatjuridica] DROP CONSTRAINT FK_tpernatjuridica_tpernatural
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_trucnatural_tpernatural]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[trucnatural] DROP CONSTRAINT FK_trucnatural_tpernatural
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ttelnatural_tpernatural]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ttelnatural] DROP CONSTRAINT FK_ttelnatural_tpernatural
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ttippersona_tpernatural]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ttippersona] DROP CONSTRAINT FK_ttippersona_tpernatural
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpagcompra_treport]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpagcompra] DROP CONSTRAINT FK_tpagcompra_treport
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpagcontratista_treport]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpagcontratista] DROP CONSTRAINT FK_tpagcontratista_treport
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpagopersonal_treport]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpagopersonal] DROP CONSTRAINT FK_tpagopersonal_treport
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpagoservicio_treport]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpagoservicio] DROP CONSTRAINT FK_tpagoservicio_treport
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpagotributo_treport]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpagotributo] DROP CONSTRAINT FK_tpagotributo_treport
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tpagotro_treport]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tpagotro] DROP CONSTRAINT FK_tpagotro_treport
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_tcuomesarbitrio_tmesarbitrio]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tcuomesarbitrio] DROP CONSTRAINT FK_tcuomesarbitrio_tmesarbitrio
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_cuomantenimiento_tmantenimiento]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tcuomantenimiento] DROP CONSTRAINT FK_cuomantenimiento_tmantenimiento
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_cuomerconductiva_tmerconductiva]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[tcuomerconductiva] DROP CONSTRAINT FK_cuomerconductiva_tmerconductiva
GO

/****** Object:  Trigger dbo.espagado_mantenimiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[espagado_mantenimiento]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[espagado_mantenimiento]
GO

/****** Object:  User Defined Function dbo.arrendatarios_contrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[arrendatarios_contrato]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[arrendatarios_contrato]
GO

/****** Object:  User Defined Function dbo.locales_contrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[locales_contrato]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[locales_contrato]
GO

/****** Object:  User Defined Function dbo.mora_merconductiva    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[mora_merconductiva]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[mora_merconductiva]
GO

/****** Object:  Stored Procedure dbo.get_cuomerconductiva    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_cuomerconductiva]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_cuomerconductiva]
GO

/****** Object:  Stored Procedure dbo.get_mantenimiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_mantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_mantenimiento]
GO

/****** Object:  Stored Procedure dbo.get_merconductiva    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_merconductiva]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_merconductiva]
GO

/****** Object:  Stored Procedure dbo.rpt_facturacion    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[rpt_facturacion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[rpt_facturacion]
GO

/****** Object:  Stored Procedure dbo.rpt_report_codigo    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[rpt_report_codigo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[rpt_report_codigo]
GO

/****** Object:  Stored Procedure dbo.rpt_report_fecha    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[rpt_report_fecha]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[rpt_report_fecha]
GO

/****** Object:  Stored Procedure dbo.update_cuomantenimiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_cuomantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_cuomantenimiento]
GO

/****** Object:  Stored Procedure dbo.update_cuomerconductiva    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_cuomerconductiva]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_cuomerconductiva]
GO

/****** Object:  Stored Procedure dbo.get_convencidos    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_convencidos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_convencidos]
GO

/****** Object:  Stored Procedure dbo.update_pernatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_pernatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_pernatural]
GO

/****** Object:  Stored Procedure dbo.list_conarrendamientos    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_conarrendamientos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_conarrendamientos]
GO

/****** Object:  Stored Procedure dbo.update_conarrendamiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_conarrendamiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_conarrendamiento]
GO

/****** Object:  Stored Procedure dbo.List_PerNatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[List_PerNatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[List_PerNatural]
GO

/****** Object:  Stored Procedure dbo.List_PerNatural2    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[List_PerNatural2]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[List_PerNatural2]
GO

/****** Object:  Stored Procedure dbo.Load_Param    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Load_Param]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Load_Param]
GO

/****** Object:  Stored Procedure dbo.delete_conarrendatario    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[delete_conarrendatario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[delete_conarrendatario]
GO

/****** Object:  Stored Procedure dbo.delete_loccontrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[delete_loccontrato]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[delete_loccontrato]
GO

/****** Object:  Stored Procedure dbo.delete_pernatjuridica    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[delete_pernatjuridica]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[delete_pernatjuridica]
GO

/****** Object:  Stored Procedure dbo.delete_teljuridico    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[delete_teljuridico]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[delete_teljuridico]
GO

/****** Object:  Stored Procedure dbo.delete_telnatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[delete_telnatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[delete_telnatural]
GO

/****** Object:  Stored Procedure dbo.get_arbitrio    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_arbitrio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_arbitrio]
GO

/****** Object:  Stored Procedure dbo.get_conarrendamiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_conarrendamiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_conarrendamiento]
GO

/****** Object:  Stored Procedure dbo.get_conarrendatario    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_conarrendatario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_conarrendatario]
GO

/****** Object:  Stored Procedure dbo.get_conrescindido    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_conrescindido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_conrescindido]
GO

/****** Object:  Stored Procedure dbo.get_contrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_contrato]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_contrato]
GO

/****** Object:  Stored Procedure dbo.get_cuomantenimiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_cuomantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_cuomantenimiento]
GO

/****** Object:  Stored Procedure dbo.get_cuomesarbitrio    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_cuomesarbitrio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_cuomesarbitrio]
GO

/****** Object:  Stored Procedure dbo.get_empleado    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_empleado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_empleado]
GO

/****** Object:  Stored Procedure dbo.get_local    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_local]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_local]
GO

/****** Object:  Stored Procedure dbo.get_loccontrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_loccontrato]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_loccontrato]
GO

/****** Object:  Stored Procedure dbo.get_luz    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_luz]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_luz]
GO

/****** Object:  Stored Procedure dbo.get_morpagmantenimiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_morpagmantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_morpagmantenimiento]
GO

/****** Object:  Stored Procedure dbo.get_morpagmerced    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_morpagmerced]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_morpagmerced]
GO

/****** Object:  Stored Procedure dbo.get_otrcobro    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_otrcobro]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_otrcobro]
GO

/****** Object:  Stored Procedure dbo.get_pagcompra    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_pagcompra]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_pagcompra]
GO

/****** Object:  Stored Procedure dbo.get_pagcontratista    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_pagcontratista]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_pagcontratista]
GO

/****** Object:  Stored Procedure dbo.get_pagopersonal    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_pagopersonal]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_pagopersonal]
GO

/****** Object:  Stored Procedure dbo.get_pagoservicio    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_pagoservicio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_pagoservicio]
GO

/****** Object:  Stored Procedure dbo.get_pagotributo    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_pagotributo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_pagotributo]
GO

/****** Object:  Stored Procedure dbo.get_pagotro    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_pagotro]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_pagotro]
GO

/****** Object:  Stored Procedure dbo.get_perjurcontrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_perjurcontrato]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_perjurcontrato]
GO

/****** Object:  Stored Procedure dbo.get_perjuridica    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_perjuridica]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_perjuridica]
GO

/****** Object:  Stored Procedure dbo.get_pernatcontrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_pernatcontrato]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_pernatcontrato]
GO

/****** Object:  Stored Procedure dbo.get_pernatjuridica    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_pernatjuridica]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_pernatjuridica]
GO

/****** Object:  Stored Procedure dbo.get_pernatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_pernatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_pernatural]
GO

/****** Object:  Stored Procedure dbo.get_report    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_report]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_report]
GO

/****** Object:  Stored Procedure dbo.get_rucnatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_rucnatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_rucnatural]
GO

/****** Object:  Stored Procedure dbo.get_teljuridico    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_teljuridico]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_teljuridico]
GO

/****** Object:  Stored Procedure dbo.get_telnatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_telnatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_telnatural]
GO

/****** Object:  Stored Procedure dbo.get_tipo    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_tipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_tipo]
GO

/****** Object:  Stored Procedure dbo.get_tippersona    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[get_tippersona]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[get_tippersona]
GO

/****** Object:  Stored Procedure dbo.list_arbitrio    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_arbitrio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_arbitrio]
GO

/****** Object:  Stored Procedure dbo.list_conarrendamiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_conarrendamiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_conarrendamiento]
GO

/****** Object:  Stored Procedure dbo.list_conarrendatario    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_conarrendatario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_conarrendatario]
GO

/****** Object:  Stored Procedure dbo.list_conrescindido    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_conrescindido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_conrescindido]
GO

/****** Object:  Stored Procedure dbo.list_cuomantenimiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_cuomantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_cuomantenimiento]
GO

/****** Object:  Stored Procedure dbo.list_cuomerconductiva    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_cuomerconductiva]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_cuomerconductiva]
GO

/****** Object:  Stored Procedure dbo.list_cuomesarbitrio    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_cuomesarbitrio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_cuomesarbitrio]
GO

/****** Object:  Stored Procedure dbo.list_empleado    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_empleado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_empleado]
GO

/****** Object:  Stored Procedure dbo.list_local    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_local]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_local]
GO

/****** Object:  Stored Procedure dbo.list_local2    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_local2]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_local2]
GO

/****** Object:  Stored Procedure dbo.list_loccontrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_loccontrato]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_loccontrato]
GO

/****** Object:  Stored Procedure dbo.list_luz    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_luz]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_luz]
GO

/****** Object:  Stored Procedure dbo.list_mantenimiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_mantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_mantenimiento]
GO

/****** Object:  Stored Procedure dbo.list_merconductiva    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_merconductiva]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_merconductiva]
GO

/****** Object:  Stored Procedure dbo.list_otrcobro    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_otrcobro]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_otrcobro]
GO

/****** Object:  Stored Procedure dbo.list_pagcompra    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_pagcompra]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_pagcompra]
GO

/****** Object:  Stored Procedure dbo.list_pagcontratista    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_pagcontratista]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_pagcontratista]
GO

/****** Object:  Stored Procedure dbo.list_pagopersonal    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_pagopersonal]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_pagopersonal]
GO

/****** Object:  Stored Procedure dbo.list_pagoservicio    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_pagoservicio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_pagoservicio]
GO

/****** Object:  Stored Procedure dbo.list_pagotributo    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_pagotributo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_pagotributo]
GO

/****** Object:  Stored Procedure dbo.list_pagotro    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_pagotro]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_pagotro]
GO

/****** Object:  Stored Procedure dbo.list_perjuridica    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_perjuridica]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_perjuridica]
GO

/****** Object:  Stored Procedure dbo.list_perjuridica2    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_perjuridica2]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_perjuridica2]
GO

/****** Object:  Stored Procedure dbo.list_pernatjuridica    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_pernatjuridica]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_pernatjuridica]
GO

/****** Object:  Stored Procedure dbo.list_report    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_report]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_report]
GO

/****** Object:  Stored Procedure dbo.list_rucnatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_rucnatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_rucnatural]
GO

/****** Object:  Stored Procedure dbo.list_teljuridico    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_teljuridico]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_teljuridico]
GO

/****** Object:  Stored Procedure dbo.list_telnatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_telnatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_telnatural]
GO

/****** Object:  Stored Procedure dbo.list_tipo    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_tipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_tipo]
GO

/****** Object:  Stored Procedure dbo.list_tippersona    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[list_tippersona]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[list_tippersona]
GO

/****** Object:  Stored Procedure dbo.rescindir_contrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[rescindir_contrato]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[rescindir_contrato]
GO

/****** Object:  Stored Procedure dbo.update_arbitrio    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_arbitrio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_arbitrio]
GO

/****** Object:  Stored Procedure dbo.update_conarrendatario    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_conarrendatario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_conarrendatario]
GO

/****** Object:  Stored Procedure dbo.update_conrescindido    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_conrescindido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_conrescindido]
GO

/****** Object:  Stored Procedure dbo.update_cuomesarbitrio    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_cuomesarbitrio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_cuomesarbitrio]
GO

/****** Object:  Stored Procedure dbo.update_empleado    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_empleado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_empleado]
GO

/****** Object:  Stored Procedure dbo.update_local    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_local]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_local]
GO

/****** Object:  Stored Procedure dbo.update_loccontrato    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_loccontrato]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_loccontrato]
GO

/****** Object:  Stored Procedure dbo.update_luz    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_luz]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_luz]
GO

/****** Object:  Stored Procedure dbo.update_mantenimiento    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_mantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_mantenimiento]
GO

/****** Object:  Stored Procedure dbo.update_merconductiva    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_merconductiva]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_merconductiva]
GO

/****** Object:  Stored Procedure dbo.update_otrcobro    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_otrcobro]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_otrcobro]
GO

/****** Object:  Stored Procedure dbo.update_pagcompra    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_pagcompra]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_pagcompra]
GO

/****** Object:  Stored Procedure dbo.update_pagcontratista    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_pagcontratista]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_pagcontratista]
GO

/****** Object:  Stored Procedure dbo.update_pagopersonal    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_pagopersonal]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_pagopersonal]
GO

/****** Object:  Stored Procedure dbo.update_pagoservicio    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_pagoservicio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_pagoservicio]
GO

/****** Object:  Stored Procedure dbo.update_pagotributo    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_pagotributo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_pagotributo]
GO

/****** Object:  Stored Procedure dbo.update_pagotro    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_pagotro]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_pagotro]
GO

/****** Object:  Stored Procedure dbo.update_perjuridica    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_perjuridica]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_perjuridica]
GO

/****** Object:  Stored Procedure dbo.update_pernatjuridica    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_pernatjuridica]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_pernatjuridica]
GO

/****** Object:  Stored Procedure dbo.update_report    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_report]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_report]
GO

/****** Object:  Stored Procedure dbo.update_rucnatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_rucnatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_rucnatural]
GO

/****** Object:  Stored Procedure dbo.update_teljuridico    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_teljuridico]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_teljuridico]
GO

/****** Object:  Stored Procedure dbo.update_telnatural    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_telnatural]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_telnatural]
GO

/****** Object:  Stored Procedure dbo.update_tipo    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_tipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_tipo]
GO

/****** Object:  Stored Procedure dbo.update_tippersona    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[update_tippersona]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[update_tippersona]
GO

/****** Object:  Table [dbo].[tcuomantenimiento]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tcuomantenimiento]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tcuomantenimiento]
GO

/****** Object:  Table [dbo].[tcuomerconductiva]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tcuomerconductiva]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tcuomerconductiva]
GO

/****** Object:  Table [dbo].[tcuomesarbitrio]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tcuomesarbitrio]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tcuomesarbitrio]
GO

/****** Object:  Table [dbo].[tarbitrio]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tarbitrio]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tarbitrio]
GO

/****** Object:  Table [dbo].[tconarrendatario]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tconarrendatario]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tconarrendatario]
GO

/****** Object:  Table [dbo].[tconrescindido]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tconrescindido]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tconrescindido]
GO

/****** Object:  Table [dbo].[templeado]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[templeado]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[templeado]
GO

/****** Object:  Table [dbo].[tloccontrato]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tloccontrato]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tloccontrato]
GO

/****** Object:  Table [dbo].[tluz]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tluz]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tluz]
GO

/****** Object:  Table [dbo].[tmantenimiento]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tmantenimiento]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tmantenimiento]
GO

/****** Object:  Table [dbo].[tmerconductiva]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tmerconductiva]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tmerconductiva]
GO

/****** Object:  Table [dbo].[tpagcompra]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tpagcompra]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tpagcompra]
GO

/****** Object:  Table [dbo].[tpagcontratista]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tpagcontratista]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tpagcontratista]
GO

/****** Object:  Table [dbo].[tpagopersonal]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tpagopersonal]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tpagopersonal]
GO

/****** Object:  Table [dbo].[tpagoservicio]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tpagoservicio]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tpagoservicio]
GO

/****** Object:  Table [dbo].[tpagotributo]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tpagotributo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tpagotributo]
GO

/****** Object:  Table [dbo].[tpagotro]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tpagotro]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tpagotro]
GO

/****** Object:  Table [dbo].[tpernatjuridica]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tpernatjuridica]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tpernatjuridica]
GO

/****** Object:  Table [dbo].[trucnatural]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[trucnatural]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[trucnatural]
GO

/****** Object:  Table [dbo].[tteljuridico]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tteljuridico]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tteljuridico]
GO

/****** Object:  Table [dbo].[ttelnatural]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ttelnatural]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ttelnatural]
GO

/****** Object:  Table [dbo].[ttipo]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ttipo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ttipo]
GO

/****** Object:  Table [dbo].[ttippersona]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ttippersona]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ttippersona]
GO

/****** Object:  Table [dbo].[tconarrendamiento]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tconarrendamiento]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tconarrendamiento]
GO

/****** Object:  Table [dbo].[tindice]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tindice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tindice]
GO

/****** Object:  Table [dbo].[tlocal]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tlocal]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tlocal]
GO

/****** Object:  Table [dbo].[totrcobro]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[totrcobro]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[totrcobro]
GO

/****** Object:  Table [dbo].[tperjuridica]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tperjuridica]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tperjuridica]
GO

/****** Object:  Table [dbo].[tpernatural]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tpernatural]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[tpernatural]
GO

/****** Object:  Table [dbo].[treport]    Script Date: 05/06/2008 07:13:29 p.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[treport]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[treport]
GO

/****** Object:  Login donlucho    Script Date: 05/06/2008 07:13:26 p.m. ******/
if not exists (select * from master.dbo.syslogins where loginname = N'donlucho')
BEGIN
	declare @logindb nvarchar(132), @loginlang nvarchar(132) select @logindb = N'Galman', @loginlang = N'us_english'
	if @logindb is null or not exists (select * from master.dbo.sysdatabases where name = @logindb)
		select @logindb = N'master'
	if @loginlang is null or (not exists (select * from master.dbo.syslanguages where name = @loginlang) and @loginlang <> N'us_english')
		select @loginlang = @@language
	exec sp_addlogin N'donlucho', null, @logindb, @loginlang
END
GO

/****** Object:  Login BUILTIN\Administradores    Script Date: 05/06/2008 07:13:26 p.m. ******/
exec sp_addsrvrolemember N'BUILTIN\Administradores', sysadmin
GO

/****** Object:  User dbo    Script Date: 05/06/2008 07:13:26 p.m. ******/
/****** Object:  User guest    Script Date: 05/06/2008 07:13:26 p.m. ******/
if not exists (select * from dbo.sysusers where name = N'guest' and hasdbaccess = 1)
	EXEC sp_grantdbaccess N'guest'
GO

/****** Object:  DatabaseRole autenticacion    Script Date: 05/06/2008 07:13:26 p.m. ******/
if not exists (select * from dbo.sysusers where name = N'autenticacion')
	EXEC sp_addrole N'autenticacion'
GO

/****** Object:  DatabaseRole galman    Script Date: 05/06/2008 07:13:26 p.m. ******/
if not exists (select * from dbo.sysusers where name = N'galman')
	EXEC sp_addrole N'galman'
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  User Defined Function dbo.arrendatarios_contrato    Script Date: 05/06/2008 07:13:38 p.m. ******/
CREATE FUNCTION arrendatarios_contrato
	(@idcontrato int)
RETURNS varchar(255) 
AS
begin
	declare @cadena varchar(254)
	select @cadena=(tpernatural.nombres + ' ' + tpernatural.apellidos)
	from tpernatural inner join tconarrendatario
	on tconarrendatario.idpersona=tpernatural.idpersona
	where tconarrendatario.tipo=0 and tconarrendatario.idconarrendamiento=@idcontrato
	if(@cadena is null)
	begin
		select @cadena=tperjuridica.razsocial 
		from tperjuridica inner join tconarrendatario
		on tconarrendatario.idpersona=tperjuridica.idperjuridica
		where tconarrendatario.tipo=1 and tconarrendatario.idconarrendamiento=@idcontrato
	end
	return @cadena
end

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  User Defined Function dbo.locales_contrato    Script Date: 05/06/2008 07:13:38 p.m. ******/
CREATE  FUNCTION locales_contrato 
	(@idcontrato int)
RETURNS varchar(255)
AS
BEGIN
	declare @numloc int
	declare @maxloc int
	declare @minloc int
	declare @cadena varchar(255)
	select @cadena=''
	select @maxloc=max(idloccontrato),@minloc=min(idloccontrato) from tloccontrato where idcontrato=@idcontrato
	while @minloc<=@maxloc
	begin
		select @cadena=@cadena + ',' + (select nombre from tloccontrato where idloccontrato=@minloc)
		select @minloc=@minloc+1
	end
	if(len(@cadena)>0)
	begin
		select @cadena=right(@cadena,len(@cadena)-1)
	end
	return @cadena
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  REFERENCES ,  EXECUTE  ON [dbo].[locales_contrato]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  User Defined Function dbo.mora_merconductiva    Script Date: 05/06/2008 07:13:38 p.m. ******/



CREATE    FUNCTION mora_merconductiva 
	(@idcontrato int,@fecha1 datetime,@fecha2 datetime)
RETURNS int
AS
BEGIN
	declare @dias int
--	declare @mora money
	select @dias=datediff(day,@fecha1,@fecha2)
--	select @mora=sum(mormerconductiva) from tloccontrato where idcontrato=@idcontrato
	if(@dias<0)
	begin
		select @dias=0
	end
	return @dias
END




GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Table [dbo].[tconarrendamiento]    Script Date: 05/06/2008 07:13:31 p.m. ******/
CREATE TABLE [dbo].[tconarrendamiento] (
	[idconarrendamiento] [int] IDENTITY (1, 1) NOT NULL ,
	[garantia] [money] NULL ,
	[fecha] [datetime] NULL ,
	[inicio] [datetime] NULL ,
	[fin] [datetime] NULL ,
	[meses] [int] NULL ,
	[dias] [int] NULL ,
	[tipcomprobante] [int] NULL ,
	[rutcontrato] [varchar] (255) COLLATE Traditional_Spanish_CI_AS NULL ,
	[estado] [int] NULL ,
	[quiregistra] [int] NULL 
) ON [hardupdate]
GO

/****** Object:  Table [dbo].[tindice]    Script Date: 05/06/2008 07:13:32 p.m. ******/
CREATE TABLE [dbo].[tindice] (
	[idindice] [int] IDENTITY (1, 1) NOT NULL ,
	[objeto] [varchar] (100) COLLATE Traditional_Spanish_CI_AS NULL ,
	[valor] [int] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[tlocal]    Script Date: 05/06/2008 07:13:32 p.m. ******/
CREATE TABLE [dbo].[tlocal] (
	[idlocal] [int] IDENTITY (1, 1) NOT NULL ,
	[nombre] [varchar] (10) COLLATE Traditional_Spanish_CI_AS NULL ,
	[estado] [int] NULL ,
	[area] [decimal](18, 0) NULL ,
	[piso] [int] NULL ,
	[descripcion] [varchar] (250) COLLATE Traditional_Spanish_CI_AS NULL ,
	[medidor] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[telinterno] [varchar] (13) COLLATE Traditional_Spanish_CI_AS NULL ,
	[merconductiva] [money] NULL ,
	[mormerconductiva] [money] NULL ,
	[mantenimiento] [money] NULL ,
	[mormantenimiento] [money] NULL ,
	[arbitrio] [money] NULL ,
	[morarbitrio] [money] NULL ,
	[tipo] [int] NULL ,
	[imagen] [image] NULL 
) ON [lowupdate] TEXTIMAGE_ON [lowupdate]
GO

/****** Object:  Table [dbo].[totrcobro]    Script Date: 05/06/2008 07:13:32 p.m. ******/
CREATE TABLE [dbo].[totrcobro] (
	[idotrcobro] [bigint] IDENTITY (1, 1) NOT NULL ,
	[destinatario] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[monto] [money] NULL ,
	[fecha] [datetime] NULL ,
	[concepto] [text] COLLATE Traditional_Spanish_CI_AS NULL ,
	[idreport] [int] NULL 
) ON [mediumupdate] TEXTIMAGE_ON [mediumupdate]
GO

/****** Object:  Table [dbo].[tperjuridica]    Script Date: 05/06/2008 07:13:32 p.m. ******/
CREATE TABLE [dbo].[tperjuridica] (
	[idperjuridica] [int] IDENTITY (1, 1) NOT NULL ,
	[razsocial] [varchar] (150) COLLATE Traditional_Spanish_CI_AS NULL ,
	[ruc] [varchar] (11) COLLATE Traditional_Spanish_CI_AS NULL ,
	[giro] [varchar] (150) COLLATE Traditional_Spanish_CI_AS NULL ,
	[direccion] [varchar] (200) COLLATE Traditional_Spanish_CI_AS NULL 
) ON [hardupdate]
GO

/****** Object:  Table [dbo].[tpernatural]    Script Date: 05/06/2008 07:13:32 p.m. ******/
CREATE TABLE [dbo].[tpernatural] (
	[idpersona] [int] IDENTITY (1, 1) NOT NULL ,
	[nombres] [varchar] (100) COLLATE Traditional_Spanish_CI_AS NULL ,
	[apellidos] [varchar] (200) COLLATE Traditional_Spanish_CI_AS NULL ,
	[tipdocumento] [int] NULL ,
	[numdocumento] [varchar] (10) COLLATE Traditional_Spanish_CI_AS NULL ,
	[pasaporte] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[fecnacimiento] [datetime] NULL 
) ON [hardupdate]
GO

/****** Object:  Table [dbo].[treport]    Script Date: 05/06/2008 07:13:32 p.m. ******/
CREATE TABLE [dbo].[treport] (
	[idreport] [bigint] IDENTITY (1, 1) NOT NULL ,
	[codigo] [bigint] NULL ,
	[origen] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[tipo] [bit] NULL ,
	[fecha] [datetime] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[tarbitrio]    Script Date: 05/06/2008 07:13:32 p.m. ******/
CREATE TABLE [dbo].[tarbitrio] (
	[idmesarbitrio] [int] NOT NULL ,
	[idlocal] [int] IDENTITY (1, 1) NOT NULL ,
	[monto] [money] NULL ,
	[mes] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[numdias] [int] NULL ,
	[año] [int] NULL ,
	[espagado] [bit] NULL ,
	[esincobrable] [bit] NULL ,
	[cuota] [int] NULL ,
	[fecfin] [datetime] NULL 
) ON [mediumupdate]
GO

/****** Object:  Table [dbo].[tconarrendatario]    Script Date: 05/06/2008 07:13:32 p.m. ******/
CREATE TABLE [dbo].[tconarrendatario] (
	[idconarrendatario] [int] IDENTITY (1, 1) NOT NULL ,
	[idconarrendamiento] [int] NULL ,
	[idpersona] [int] NULL ,
	[tipo] [bit] NULL 
) ON [hardupdate]
GO

/****** Object:  Table [dbo].[tconrescindido]    Script Date: 05/06/2008 07:13:33 p.m. ******/
CREATE TABLE [dbo].[tconrescindido] (
	[idconarrendamiento] [int] NOT NULL ,
	[fecrescincion] [datetime] NULL ,
	[motivo] [varchar] (250) COLLATE Traditional_Spanish_CI_AS NULL 
) ON [lowupdate]
GO

/****** Object:  Table [dbo].[templeado]    Script Date: 05/06/2008 07:13:33 p.m. ******/
CREATE TABLE [dbo].[templeado] (
	[idconempleado] [int] IDENTITY (1, 1) NOT NULL ,
	[fecinicio] [datetime] NULL ,
	[fecfin] [datetime] NULL ,
	[fecsalida] [datetime] NULL ,
	[estado] [bit] NULL ,
	[idpersona] [int] NULL 
) ON [lowupdate]
GO

/****** Object:  Table [dbo].[tloccontrato]    Script Date: 05/06/2008 07:13:33 p.m. ******/
CREATE TABLE [dbo].[tloccontrato] (
	[idloccontrato] [int] IDENTITY (1, 1) NOT NULL ,
	[idlocal] [int] NULL ,
	[idcontrato] [int] NULL ,
	[nombre] [varchar] (10) COLLATE Traditional_Spanish_CI_AS NULL ,
	[estado] [int] NULL ,
	[area] [int] NULL ,
	[piso] [int] NULL ,
	[descripcion] [varchar] (200) COLLATE Traditional_Spanish_CI_AS NULL ,
	[medidor] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[telinterno] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[merconductiva] [money] NULL ,
	[mormerconductiva] [money] NULL ,
	[mantenimiento] [money] NULL ,
	[mormantenimiento] [money] NULL ,
	[arbitrio] [money] NULL ,
	[morarbitrio] [money] NULL ,
	[uso] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL 
) ON [mediumupdate]
GO

/****** Object:  Table [dbo].[tluz]    Script Date: 05/06/2008 07:13:33 p.m. ******/
CREATE TABLE [dbo].[tluz] (
	[idmesluz] [int] IDENTITY (1, 1) NOT NULL ,
	[idlocal] [int] NULL ,
	[cuota] [tinyint] NULL ,
	[lecanterior] [decimal](18, 0) NULL ,
	[lecactual] [decimal](18, 0) NULL ,
	[tarifa] [money] NULL ,
	[consumo] [decimal](18, 0) NULL ,
	[total] [money] NULL ,
	[fecvencimiento] [datetime] NULL ,
	[esincobrable] [bit] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[tmantenimiento]    Script Date: 05/06/2008 07:13:33 p.m. ******/
CREATE TABLE [dbo].[tmantenimiento] (
	[idmantenimiento] [int] IDENTITY (1, 1) NOT NULL ,
	[idconarrendamiento] [int] NULL ,
	[monto] [money] NULL ,
	[semana] [tinyint] NULL ,
	[rangodias] [varchar] (29) COLLATE Traditional_Spanish_CI_AS NULL ,
	[numdias] [int] NULL ,
	[fecfin] [datetime] NULL ,
	[mora] [money] NULL ,
	[conmora] [money] NULL ,
	[total] AS ([monto] + [mora] * [conmora]) ,
	[espagado] [bit] NULL ,
	[esincobrable] [bit] NULL 
) ON [hardupdate]
GO

/****** Object:  Table [dbo].[tmerconductiva]    Script Date: 05/06/2008 07:13:33 p.m. ******/
CREATE TABLE [dbo].[tmerconductiva] (
	[idmerconductiva] [int] IDENTITY (1, 1) NOT NULL ,
	[idconarrendamiento] [int] NULL ,
	[cuota] [int] NULL ,
	[mes] [varchar] (30) COLLATE Traditional_Spanish_CI_AS NULL ,
	[fecfin] [datetime] NULL ,
	[monto] [money] NULL ,
	[numcomprobante] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[mora] [money] NULL ,
	[conmora] [bit] NULL ,
	[total] AS ([monto] + [mora] * [conmora]) ,
	[espagado] [bit] NULL ,
	[esincobrable] [bit] NULL 
) ON [mediumupdate]
GO

/****** Object:  Table [dbo].[tpagcompra]    Script Date: 05/06/2008 07:13:33 p.m. ******/
CREATE TABLE [dbo].[tpagcompra] (
	[idpagcompra] [int] IDENTITY (1, 1) NOT NULL ,
	[idordcompra] [int] NULL ,
	[idreport] [bigint] NULL ,
	[ruc] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[tipcomprobante] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[serie] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[numero] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[razsocual] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[fecha] [datetime] NULL ,
	[monto] [money] NULL 
) ON [lowupdate]
GO

/****** Object:  Table [dbo].[tpagcontratista]    Script Date: 05/06/2008 07:13:34 p.m. ******/
CREATE TABLE [dbo].[tpagcontratista] (
	[idpagcontratista] [int] IDENTITY (1, 1) NOT NULL ,
	[idreport] [bigint] NULL ,
	[idpersona] [int] NULL ,
	[tippersona] [int] NULL ,
	[idordpago] [int] NULL ,
	[concepto] [varchar] (200) COLLATE Traditional_Spanish_CI_AS NULL ,
	[fecpago] [datetime] NULL 
) ON [mediumupdate]
GO

/****** Object:  Table [dbo].[tpagopersonal]    Script Date: 05/06/2008 07:13:34 p.m. ******/
CREATE TABLE [dbo].[tpagopersonal] (
	[idpagpersonal] [int] IDENTITY (1, 1) NOT NULL ,
	[idreport] [bigint] NULL ,
	[idpersonal] [int] NULL ,
	[idordpago] [int] NULL ,
	[mes] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[semana] [int] NULL ,
	[monto] [money] NULL ,
	[fecpago] [datetime] NULL 
) ON [lowupdate]
GO

/****** Object:  Table [dbo].[tpagoservicio]    Script Date: 05/06/2008 07:13:34 p.m. ******/
CREATE TABLE [dbo].[tpagoservicio] (
	[idpagservicio] [int] IDENTITY (1, 1) NOT NULL ,
	[idreport] [bigint] NULL ,
	[idordpago] [int] NULL ,
	[tipo] [int] NULL ,
	[mes] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[año] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[monto] [money] NULL ,
	[fecpago] [datetime] NULL 
) ON [lowupdate]
GO

/****** Object:  Table [dbo].[tpagotributo]    Script Date: 05/06/2008 07:13:34 p.m. ******/
CREATE TABLE [dbo].[tpagotributo] (
	[idpagtributo] [int] IDENTITY (1, 1) NOT NULL ,
	[idreport] [bigint] NULL ,
	[idordpago] [int] NULL ,
	[mes] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[año] [int] NULL ,
	[monto] [money] NULL ,
	[fecpago] [datetime] NULL 
) ON [lowupdate]
GO

/****** Object:  Table [dbo].[tpagotro]    Script Date: 05/06/2008 07:13:34 p.m. ******/
CREATE TABLE [dbo].[tpagotro] (
	[idpagotro] [int] IDENTITY (1, 1) NOT NULL ,
	[idreport] [bigint] NULL ,
	[idordpago] [int] NULL ,
	[concepto] [varchar] (200) COLLATE Traditional_Spanish_CI_AS NULL ,
	[fecpago] [datetime] NULL ,
	[monto] [money] NULL 
) ON [mediumupdate]
GO

/****** Object:  Table [dbo].[tpernatjuridica]    Script Date: 05/06/2008 07:13:34 p.m. ******/
CREATE TABLE [dbo].[tpernatjuridica] (
	[idpernatjuridica] [int] IDENTITY (1, 1) NOT NULL ,
	[idpernatural] [int] NOT NULL ,
	[idperjuridica] [int] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[trucnatural]    Script Date: 05/06/2008 07:13:34 p.m. ******/
CREATE TABLE [dbo].[trucnatural] (
	[idpersona] [int] NOT NULL ,
	[ruc] [varchar] (11) COLLATE Traditional_Spanish_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[tteljuridico]    Script Date: 05/06/2008 07:13:35 p.m. ******/
CREATE TABLE [dbo].[tteljuridico] (
	[idtelefono] [int] IDENTITY (1, 1) NOT NULL ,
	[idpersona] [int] NULL ,
	[tipo] [int] NULL ,
	[numero] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ttelnatural]    Script Date: 05/06/2008 07:13:35 p.m. ******/
CREATE TABLE [dbo].[ttelnatural] (
	[idtelefono] [int] IDENTITY (1, 1) NOT NULL ,
	[idpersona] [int] NULL ,
	[tipo] [int] NULL ,
	[numero] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL 
) ON [mediumupdate]
GO

/****** Object:  Table [dbo].[ttipo]    Script Date: 05/06/2008 07:13:35 p.m. ******/
CREATE TABLE [dbo].[ttipo] (
	[idtipo] [int] IDENTITY (1, 1) NOT NULL ,
	[idpersona] [int] NULL ,
	[nombre] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL ,
	[nombrebreve] [varchar] (15) COLLATE Traditional_Spanish_CI_AS NULL ,
	[tippersona] [int] NULL 
) ON [mediumupdate]
GO

/****** Object:  Table [dbo].[ttippersona]    Script Date: 05/06/2008 07:13:35 p.m. ******/
CREATE TABLE [dbo].[ttippersona] (
	[idpersona] [int] NOT NULL ,
	[tippersona] [bit] NULL ,
	[arrendatario] [bit] NULL ,
	[empleado] [bit] NULL ,
	[contratista] [bit] NULL 
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[tcuomantenimiento]    Script Date: 05/06/2008 07:13:35 p.m. ******/
CREATE TABLE [dbo].[tcuomantenimiento] (
	[idcuomantenimiento] [int] IDENTITY (1, 1) NOT NULL ,
	[idmantenimiento] [int] NULL ,
	[fecha] [datetime] NULL ,
	[monto] [money] NULL ,
	[idreport] [bigint] NOT NULL 
) ON [hardupdate]
GO

/****** Object:  Table [dbo].[tcuomerconductiva]    Script Date: 05/06/2008 07:13:35 p.m. ******/
CREATE TABLE [dbo].[tcuomerconductiva] (
	[idcuomerconductiva] [bigint] IDENTITY (1, 1) NOT NULL ,
	[idmerconductiva] [int] NULL ,
	[monto] [money] NULL ,
	[idreport] [int] NULL ,
	[fechacobro] [datetime] NULL 
) ON [hardupdate]
GO

/****** Object:  Table [dbo].[tcuomesarbitrio]    Script Date: 05/06/2008 07:13:35 p.m. ******/
CREATE TABLE [dbo].[tcuomesarbitrio] (
	[idcuomesarbitrio] [int] IDENTITY (1, 1) NOT NULL ,
	[idmesarbitrio] [int] NULL ,
	[fecha] [datetime] NULL ,
	[idreport] [bigint] NULL ,
	[monto] [money] NULL 
) ON [mediumupdate]
GO

ALTER TABLE [dbo].[tconarrendamiento] WITH NOCHECK ADD 
	CONSTRAINT [PK_conarrendamiento] PRIMARY KEY  CLUSTERED 
	(
		[idconarrendamiento]
	)  ON [hardupdate] 
GO

ALTER TABLE [dbo].[tindice] WITH NOCHECK ADD 
	CONSTRAINT [PK_tindice] PRIMARY KEY  CLUSTERED 
	(
		[idindice]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tlocal] WITH NOCHECK ADD 
	CONSTRAINT [PK_local] PRIMARY KEY  CLUSTERED 
	(
		[idlocal]
	)  ON [lowupdate] 
GO

ALTER TABLE [dbo].[totrcobro] WITH NOCHECK ADD 
	CONSTRAINT [PK_totrcobro] PRIMARY KEY  CLUSTERED 
	(
		[idotrcobro]
	)  ON [mediumupdate] 
GO

ALTER TABLE [dbo].[tperjuridica] WITH NOCHECK ADD 
	CONSTRAINT [PK_razonsocial] PRIMARY KEY  CLUSTERED 
	(
		[idperjuridica]
	)  ON [hardupdate] 
GO

ALTER TABLE [dbo].[tpernatural] WITH NOCHECK ADD 
	CONSTRAINT [PK_persona] PRIMARY KEY  CLUSTERED 
	(
		[idpersona]
	)  ON [hardupdate] 
GO

ALTER TABLE [dbo].[treport] WITH NOCHECK ADD 
	CONSTRAINT [PK_treport] PRIMARY KEY  CLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tarbitrio] WITH NOCHECK ADD 
	CONSTRAINT [PK_tmesarbitrio] PRIMARY KEY  CLUSTERED 
	(
		[idmesarbitrio]
	)  ON [mediumupdate] 
GO

ALTER TABLE [dbo].[tconarrendatario] WITH NOCHECK ADD 
	CONSTRAINT [PK_tconarrendatario] PRIMARY KEY  CLUSTERED 
	(
		[idconarrendatario]
	)  ON [hardupdate] 
GO

ALTER TABLE [dbo].[tconrescindido] WITH NOCHECK ADD 
	CONSTRAINT [PK_tconrescindido] PRIMARY KEY  CLUSTERED 
	(
		[idconarrendamiento]
	)  ON [lowupdate] 
GO

ALTER TABLE [dbo].[templeado] WITH NOCHECK ADD 
	CONSTRAINT [PK_conempleado] PRIMARY KEY  CLUSTERED 
	(
		[idconempleado]
	)  ON [lowupdate] 
GO

ALTER TABLE [dbo].[tloccontrato] WITH NOCHECK ADD 
	CONSTRAINT [PK_tloccontrato] PRIMARY KEY  CLUSTERED 
	(
		[idloccontrato]
	)  ON [mediumupdate] 
GO

ALTER TABLE [dbo].[tluz] WITH NOCHECK ADD 
	CONSTRAINT [PK_tluz] PRIMARY KEY  CLUSTERED 
	(
		[idmesluz]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tmantenimiento] WITH NOCHECK ADD 
	CONSTRAINT [PK_tmantenimiento] PRIMARY KEY  CLUSTERED 
	(
		[idmantenimiento]
	)  ON [hardupdate] 
GO

ALTER TABLE [dbo].[tmerconductiva] WITH NOCHECK ADD 
	CONSTRAINT [PK_tmerconductiva] PRIMARY KEY  CLUSTERED 
	(
		[idmerconductiva]
	)  ON [mediumupdate] 
GO

ALTER TABLE [dbo].[tpagcompra] WITH NOCHECK ADD 
	CONSTRAINT [PK_tpagcompra] PRIMARY KEY  CLUSTERED 
	(
		[idpagcompra]
	)  ON [lowupdate] 
GO

ALTER TABLE [dbo].[tpagcontratista] WITH NOCHECK ADD 
	CONSTRAINT [PK_tpagcontratista] PRIMARY KEY  CLUSTERED 
	(
		[idpagcontratista]
	)  ON [mediumupdate] 
GO

ALTER TABLE [dbo].[tpagopersonal] WITH NOCHECK ADD 
	CONSTRAINT [PK_tpagopersonal] PRIMARY KEY  CLUSTERED 
	(
		[idpagpersonal]
	)  ON [lowupdate] 
GO

ALTER TABLE [dbo].[tpagoservicio] WITH NOCHECK ADD 
	CONSTRAINT [PK_tpagoservicio] PRIMARY KEY  CLUSTERED 
	(
		[idpagservicio]
	)  ON [lowupdate] 
GO

ALTER TABLE [dbo].[tpagotributo] WITH NOCHECK ADD 
	CONSTRAINT [PK_tpagotributo] PRIMARY KEY  CLUSTERED 
	(
		[idpagtributo]
	)  ON [lowupdate] 
GO

ALTER TABLE [dbo].[tpagotro] WITH NOCHECK ADD 
	CONSTRAINT [PK_tpagotro] PRIMARY KEY  CLUSTERED 
	(
		[idpagotro]
	)  ON [mediumupdate] 
GO

ALTER TABLE [dbo].[tpernatjuridica] WITH NOCHECK ADD 
	CONSTRAINT [PK_tpernatjuridica] PRIMARY KEY  CLUSTERED 
	(
		[idpernatjuridica]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[trucnatural] WITH NOCHECK ADD 
	CONSTRAINT [PK_trucnatural] PRIMARY KEY  CLUSTERED 
	(
		[idpersona]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tteljuridico] WITH NOCHECK ADD 
	CONSTRAINT [PK_tteljuridico] PRIMARY KEY  CLUSTERED 
	(
		[idtelefono]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ttelnatural] WITH NOCHECK ADD 
	CONSTRAINT [PK_telefono] PRIMARY KEY  CLUSTERED 
	(
		[idtelefono]
	)  ON [mediumupdate] 
GO

ALTER TABLE [dbo].[ttipo] WITH NOCHECK ADD 
	CONSTRAINT [PK_ttipo] PRIMARY KEY  CLUSTERED 
	(
		[idtipo]
	)  ON [mediumupdate] 
GO

ALTER TABLE [dbo].[tcuomantenimiento] WITH NOCHECK ADD 
	CONSTRAINT [PK_cuomantenimiento] PRIMARY KEY  CLUSTERED 
	(
		[idcuomantenimiento]
	)  ON [hardupdate] 
GO

ALTER TABLE [dbo].[tcuomerconductiva] WITH NOCHECK ADD 
	CONSTRAINT [PK_cuomerconductiva] PRIMARY KEY  CLUSTERED 
	(
		[idcuomerconductiva]
	)  ON [hardupdate] 
GO

ALTER TABLE [dbo].[tcuomesarbitrio] WITH NOCHECK ADD 
	CONSTRAINT [PK_tcuomesarbitrio] PRIMARY KEY  CLUSTERED 
	(
		[idcuomesarbitrio]
	)  ON [mediumupdate] 
GO

ALTER TABLE [dbo].[tindice] ADD 
	CONSTRAINT [DF_tindice_valor] DEFAULT (0) FOR [valor]
GO

ALTER TABLE [dbo].[totrcobro] ADD 
	CONSTRAINT [IX_totrcobro] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tmantenimiento] ADD 
	CONSTRAINT [DF_tmantenimiento_mora] DEFAULT (0) FOR [mora],
	CONSTRAINT [DF_tmantenimiento_conmora] DEFAULT (1) FOR [conmora],
	CONSTRAINT [DF_tmantenimiento_espagado] DEFAULT (0) FOR [espagado],
	CONSTRAINT [DF_tmantenimiento_esincobrable] DEFAULT (0) FOR [esincobrable]
GO

ALTER TABLE [dbo].[tmerconductiva] ADD 
	CONSTRAINT [DF_tmerconductiva_mora] DEFAULT (0) FOR [mora],
	CONSTRAINT [DF_tmerconductiva_conmora] DEFAULT (1) FOR [conmora]
GO

ALTER TABLE [dbo].[tpagcompra] ADD 
	CONSTRAINT [IX_tpagcompra] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tpagcontratista] ADD 
	CONSTRAINT [IX_tpagcontratista] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tpagopersonal] ADD 
	CONSTRAINT [IX_tpagopersonal] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tpagoservicio] ADD 
	CONSTRAINT [IX_tpagoservicio] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tpagotributo] ADD 
	CONSTRAINT [IX_tpagotributo] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tpagotro] ADD 
	CONSTRAINT [IX_tpagotro] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tcuomantenimiento] ADD 
	CONSTRAINT [IX_tcuomantenimiento] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tcuomerconductiva] ADD 
	CONSTRAINT [IX_tcuomerconductiva] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tcuomesarbitrio] ADD 
	CONSTRAINT [IX_tcuomesarbitrio] UNIQUE  NONCLUSTERED 
	(
		[idreport]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[tarbitrio] ADD 
	CONSTRAINT [FK_tarbitrio_tlocal] FOREIGN KEY 
	(
		[idlocal]
	) REFERENCES [dbo].[tlocal] (
		[idlocal]
	) NOT FOR REPLICATION 
GO

alter table [dbo].[tarbitrio] nocheck constraint [FK_tarbitrio_tlocal]
GO

ALTER TABLE [dbo].[tconarrendatario] ADD 
	CONSTRAINT [FK_tconarrendatario_tconarrendamiento] FOREIGN KEY 
	(
		[idconarrendamiento]
	) REFERENCES [dbo].[tconarrendamiento] (
		[idconarrendamiento]
	),
	CONSTRAINT [FK_tconarrendatario_tperjuridica] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tperjuridica] (
		[idperjuridica]
	) NOT FOR REPLICATION ,
	CONSTRAINT [FK_tconarrendatario_tpernatural] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tpernatural] (
		[idpersona]
	) NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[tconrescindido] ADD 
	CONSTRAINT [FK_tconrescindido_tconarrendamiento] FOREIGN KEY 
	(
		[idconarrendamiento]
	) REFERENCES [dbo].[tconarrendamiento] (
		[idconarrendamiento]
	)
GO

ALTER TABLE [dbo].[templeado] ADD 
	CONSTRAINT [FK_templeado_tpernatural] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tpernatural] (
		[idpersona]
	)
GO

ALTER TABLE [dbo].[tloccontrato] ADD 
	CONSTRAINT [FK_tloccontrato_tconarrendamiento] FOREIGN KEY 
	(
		[idcontrato]
	) REFERENCES [dbo].[tconarrendamiento] (
		[idconarrendamiento]
	),
	CONSTRAINT [FK_tloccontrato_tlocal] FOREIGN KEY 
	(
		[idlocal]
	) REFERENCES [dbo].[tlocal] (
		[idlocal]
	)
GO

ALTER TABLE [dbo].[tluz] ADD 
	CONSTRAINT [FK_tluz_tlocal] FOREIGN KEY 
	(
		[idlocal]
	) REFERENCES [dbo].[tlocal] (
		[idlocal]
	)
GO

ALTER TABLE [dbo].[tmantenimiento] ADD 
	CONSTRAINT [FK_tmantenimiento_tconarrendamiento] FOREIGN KEY 
	(
		[idconarrendamiento]
	) REFERENCES [dbo].[tconarrendamiento] (
		[idconarrendamiento]
	)
GO

ALTER TABLE [dbo].[tmerconductiva] ADD 
	CONSTRAINT [FK_tmerconductiva_tconarrendamiento] FOREIGN KEY 
	(
		[idconarrendamiento]
	) REFERENCES [dbo].[tconarrendamiento] (
		[idconarrendamiento]
	)
GO

ALTER TABLE [dbo].[tpagcompra] ADD 
	CONSTRAINT [FK_tpagcompra_treport] FOREIGN KEY 
	(
		[idreport]
	) REFERENCES [dbo].[treport] (
		[idreport]
	)
GO

ALTER TABLE [dbo].[tpagcontratista] ADD 
	CONSTRAINT [FK_tpagcontratista_tperjuridica] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tperjuridica] (
		[idperjuridica]
	),
	CONSTRAINT [FK_tpagcontratista_tpernatural] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tpernatural] (
		[idpersona]
	),
	CONSTRAINT [FK_tpagcontratista_treport] FOREIGN KEY 
	(
		[idreport]
	) REFERENCES [dbo].[treport] (
		[idreport]
	)
GO

ALTER TABLE [dbo].[tpagopersonal] ADD 
	CONSTRAINT [FK_tpagopersonal_tpernatural] FOREIGN KEY 
	(
		[idpersonal]
	) REFERENCES [dbo].[tpernatural] (
		[idpersona]
	),
	CONSTRAINT [FK_tpagopersonal_treport] FOREIGN KEY 
	(
		[idreport]
	) REFERENCES [dbo].[treport] (
		[idreport]
	)
GO

ALTER TABLE [dbo].[tpagoservicio] ADD 
	CONSTRAINT [FK_tpagoservicio_treport] FOREIGN KEY 
	(
		[idreport]
	) REFERENCES [dbo].[treport] (
		[idreport]
	)
GO

ALTER TABLE [dbo].[tpagotributo] ADD 
	CONSTRAINT [FK_tpagotributo_treport] FOREIGN KEY 
	(
		[idreport]
	) REFERENCES [dbo].[treport] (
		[idreport]
	)
GO

ALTER TABLE [dbo].[tpagotro] ADD 
	CONSTRAINT [FK_tpagotro_treport] FOREIGN KEY 
	(
		[idreport]
	) REFERENCES [dbo].[treport] (
		[idreport]
	)
GO

ALTER TABLE [dbo].[tpernatjuridica] ADD 
	CONSTRAINT [FK_tpernatjuridica_tperjuridica] FOREIGN KEY 
	(
		[idperjuridica]
	) REFERENCES [dbo].[tperjuridica] (
		[idperjuridica]
	),
	CONSTRAINT [FK_tpernatjuridica_tpernatural] FOREIGN KEY 
	(
		[idpernatural]
	) REFERENCES [dbo].[tpernatural] (
		[idpersona]
	)
GO

ALTER TABLE [dbo].[trucnatural] ADD 
	CONSTRAINT [FK_trucnatural_tpernatural] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tpernatural] (
		[idpersona]
	) ON DELETE CASCADE  ON UPDATE CASCADE 
GO

ALTER TABLE [dbo].[tteljuridico] ADD 
	CONSTRAINT [FK_tteljuridico_tperjuridica] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tperjuridica] (
		[idperjuridica]
	)
GO

ALTER TABLE [dbo].[ttelnatural] ADD 
	CONSTRAINT [FK_ttelnatural_tpernatural] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tpernatural] (
		[idpersona]
	)
GO

ALTER TABLE [dbo].[ttipo] ADD 
	CONSTRAINT [FK_ttipo_tperjuridica] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tperjuridica] (
		[idperjuridica]
	) NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[ttippersona] ADD 
	CONSTRAINT [FK_ttippernatural_tperjuridica] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tperjuridica] (
		[idperjuridica]
	) NOT FOR REPLICATION ,
	CONSTRAINT [FK_ttippersona_tpernatural] FOREIGN KEY 
	(
		[idpersona]
	) REFERENCES [dbo].[tpernatural] (
		[idpersona]
	) NOT FOR REPLICATION 
GO

alter table [dbo].[ttippersona] nocheck constraint [FK_ttippernatural_tperjuridica]
GO

alter table [dbo].[ttippersona] nocheck constraint [FK_ttippersona_tpernatural]
GO

ALTER TABLE [dbo].[tcuomantenimiento] ADD 
	CONSTRAINT [FK_cuomantenimiento_tmantenimiento] FOREIGN KEY 
	(
		[idmantenimiento]
	) REFERENCES [dbo].[tmantenimiento] (
		[idmantenimiento]
	)
GO

ALTER TABLE [dbo].[tcuomerconductiva] ADD 
	CONSTRAINT [FK_cuomerconductiva_tmerconductiva] FOREIGN KEY 
	(
		[idmerconductiva]
	) REFERENCES [dbo].[tmerconductiva] (
		[idmerconductiva]
	)
GO

ALTER TABLE [dbo].[tcuomesarbitrio] ADD 
	CONSTRAINT [FK_tcuomesarbitrio_tmesarbitrio] FOREIGN KEY 
	(
		[idmesarbitrio]
	) REFERENCES [dbo].[tarbitrio] (
		[idmesarbitrio]
	)
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.List_PerNatural    Script Date: 05/06/2008 07:13:36 p.m. ******/
CREATE PROCEDURE List_PerNatural AS
SELECT     
tpernatural.idpersona AS Código, 
tpernatural.nombres AS Nombres, 
tpernatural.apellidos AS Apellidos, 
tpernatural.numdocumento AS Documento, 
ttippersona.arrendatario, ttippersona.empleado, ttippersona.contratista
FROM         tpernatural full JOIN
                      ttippersona ON tpernatural.idpersona = ttippersona.idpersona
WHERE     (ttippersona.tippersona = 0)
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[List_PerNatural]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.List_PerNatural2    Script Date: 05/06/2008 07:13:36 p.m. ******/
CREATE  PROCEDURE List_PerNatural2 
@arrendatario bit=0,
@contratista bit=0,
@empleado bit=0
as
declare @v1 table(codigo int,nombres varchar(50),apellidos varchar(50),documento varchar(10),arrendatario bit,empleado bit,contratista bit)

if(@empleado=0 and @contratista=0 and @arrendatario=0)
begin
	insert into @v1 SELECT   tpernatural.idpersona AS Código, tpernatural.nombres AS Nombres, tpernatural.apellidos AS Apellidos, tpernatural.numdocumento AS Documento, 
	                      ttippersona.arrendatario, ttippersona.empleado, ttippersona.contratista
	FROM         tpernatural FULL OUTER JOIN
	                      ttippersona ON tpernatural.idpersona = ttippersona.idpersona
	WHERE     (ttippersona.tippersona = 0)
end
else
begin
	if(@empleado=1)
	begin
		insert into @v1 SELECT   tpernatural.idpersona AS Código, tpernatural.nombres AS Nombres, tpernatural.apellidos AS Apellidos, tpernatural.numdocumento AS Documento, 
		                      ttippersona.arrendatario, ttippersona.empleado, ttippersona.contratista
		FROM         tpernatural FULL OUTER JOIN
		                      ttippersona ON tpernatural.idpersona = ttippersona.idpersona
		WHERE     (ttippersona.tippersona = 0) AND (ttippersona.empleado = @empleado)
	end
	if(@contratista=1)
	begin
		insert into @v1 SELECT   tpernatural.idpersona AS Código, tpernatural.nombres AS Nombres, tpernatural.apellidos AS Apellidos, tpernatural.numdocumento AS Documento, 
		                      ttippersona.arrendatario, ttippersona.empleado, ttippersona.contratista
		FROM         tpernatural FULL OUTER JOIN
		                      ttippersona ON tpernatural.idpersona = ttippersona.idpersona
		WHERE     (ttippersona.tippersona = 0) AND (ttippersona.contratista = @contratista)
	end
	if(@arrendatario=1)
	begin
		insert into @v1 SELECT   tpernatural.idpersona AS Código, tpernatural.nombres AS Nombres, tpernatural.apellidos AS Apellidos, tpernatural.numdocumento AS Documento, 
		                      ttippersona.arrendatario, ttippersona.empleado, ttippersona.contratista
		FROM         tpernatural FULL OUTER JOIN
		                      ttippersona ON tpernatural.idpersona = ttippersona.idpersona
		WHERE     (ttippersona.tippersona = 0) AND (ttippersona.arrendatario=@arrendatario)
	end
end
select distinct * from @v1

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.Load_Param    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE  PROCEDURE Load_Param 
@objeto varchar(200)
AS

SELECT     sysobjects.name AS tabla, syscolumns.name AS columna, systypes.name AS paramtype, syscolumns.length
FROM         sysobjects INNER JOIN
                      syscolumns ON sysobjects.id = syscolumns.id INNER JOIN
                      systypes ON syscolumns.xtype = systypes.xtype
where sysobjects.name=@objeto
order by sysobjects.id

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[Load_Param]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.delete_conarrendatario    Script Date: 05/06/2008 07:13:36 p.m. ******/
CREATE PROCEDURE dbo.delete_conarrendatario
	@idcontrato int
AS
	delete from tconarrendatario where idconarrendamiento=@idcontrato
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.delete_loccontrato    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE  PROCEDURE dbo.delete_loccontrato
	@idcontrato int
AS
	delete from tloccontrato where idcontrato=@idcontrato

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.delete_pernatjuridica    Script Date: 05/06/2008 07:13:36 p.m. ******/
CREATE PROCEDURE delete_pernatjuridica
	@idperjuridica int
AS
	delete from tpernatjuridica where idperjuridica=@idperjuridica
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.delete_teljuridico    Script Date: 05/06/2008 07:13:36 p.m. ******/

create procedure delete_teljuridico
@idperjuridica int
as
delete tteljuridico where idpersona=@idperjuridica

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[delete_teljuridico]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.delete_telnatural    Script Date: 05/06/2008 07:13:36 p.m. ******/
CREATE  procedure delete_telnatural
@idpersona int
as
delete ttelnatural where idpersona=@idpersona



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[delete_telnatural]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_arbitrio    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_arbitrio
@idmesarbitrio int
as
select idmesarbitrio,idlocal,monto,mes,numdias,año,espagado,esincobrable,cuota,fecfin from tarbitrio where idmesarbitrio=@idmesarbitrio

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_conarrendamiento    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_conarrendamiento
@idconarrendamiento int
as
select idconarrendamiento,garantia,fecha,inicio,fin,meses,dias,tipcomprobante,rutcontrato,estado,quiregistra from tconarrendamiento where idconarrendamiento=@idconarrendamiento

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_conarrendatario    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_conarrendatario
@idconarrendatario int
as
select idconarrendatario,idconarrendamiento,idpersona,tipo from tconarrendatario where idconarrendatario=@idconarrendatario

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_conrescindido    Script Date: 05/06/2008 07:13:36 p.m. ******/


CREATE  procedure get_conrescindido
@idconarrendamiento int
as
select idconarrendamiento,fecrescincion,motivo from tconrescindido where idconarrendamiento=@idconarrendamiento


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_contrato    Script Date: 05/06/2008 07:13:36 p.m. ******/


CREATE   procedure get_contrato @idcontrato int as
declare @es_rescindido int
if(exists(select idconarrendamiento from tconrescindido where idconarrendamiento=@idcontrato))
	select @es_rescindido=1
else
	select @es_rescindido=0

SELECT     
tconarrendamiento.idconarrendamiento, --0
tconarrendamiento.garantia, --1
tconarrendamiento.fecha, --2
tconarrendamiento.meses, --3
tconarrendamiento.dias, --4
tconarrendamiento.tipcomprobante, --5
tconarrendamiento.rutcontrato, --6
tconarrendamiento.estado, --7
SUM(tloccontrato.mantenimiento) AS mantenimiento, --8
SUM(tloccontrato.mormantenimiento) AS mormantenimiento, --9
SUM(tloccontrato.mormerconductiva) AS mormerconductiva, --10
tconrescindido.fecrescincion, --11
tconrescindido.motivo, --12
tconarrendamiento.inicio, --13
@es_rescindido--14
FROM         tconarrendamiento FULL OUTER JOIN
                      tloccontrato ON tconarrendamiento.idconarrendamiento = tloccontrato.idcontrato FULL OUTER JOIN
                      tconrescindido ON tconarrendamiento.idconarrendamiento = tconrescindido.idconarrendamiento
where tconarrendamiento.idconarrendamiento=@idcontrato
GROUP BY tconarrendamiento.idconarrendamiento, tconarrendamiento.garantia, tconarrendamiento.fecha, tconarrendamiento.meses, tconarrendamiento.dias, 
                      tconarrendamiento.tipcomprobante, tconarrendamiento.rutcontrato, tconarrendamiento.estado, tconrescindido.fecrescincion, tconrescindido.motivo, 
                      tconarrendamiento.inicio, tconarrendamiento.fin



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_cuomantenimiento    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_cuomantenimiento
@idcontrato int
as
select 
tcuomantenimiento.idcuomantenimiento as [Código de cuota],
tcuomantenimiento.idmantenimiento as [Nº de Mantenimiento],
tcuomantenimiento.fecha,
tcuomantenimiento.monto,
tcuomantenimiento.idreport as [Nº de Report]
from tcuomantenimiento full join tmantenimiento 
on tcuomantenimiento.idmantenimiento=tmantenimiento.idmantenimiento
where tmantenimiento.idconarrendamiento=@idcontrato
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_cuomesarbitrio    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_cuomesarbitrio
@idcuomesarbitrio int
as
select idcuomesarbitrio,idmesarbitrio,fecha,idreport,monto from tcuomesarbitrio where idcuomesarbitrio=@idcuomesarbitrio

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_empleado    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_empleado
@idconempleado int
as
select idconempleado,fecinicio,fecfin,fecsalida,estado from templeado where idconempleado=@idconempleado

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_local    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_local
@idlocal int
as
select idlocal,nombre,estado,area,piso,descripcion,medidor,telinterno,merconductiva,mormerconductiva,mantenimiento,mormantenimiento,arbitrio,morarbitrio,tipo,imagen from tlocal where idlocal=@idlocal

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_loccontrato    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_loccontrato
@idloccontrato int
as
select idloccontrato,idlocal,idcontrato,nombre,estado,area,piso,descripcion,medidor,telinterno,merconductiva,mormerconductiva,mantenimiento,mormantenimiento,arbitrio,morarbitrio,uso from tloccontrato where idloccontrato=@idloccontrato

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_luz    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_luz
@idmesluz int
as
select idmesluz,idlocal,cuota,lecanterior,lecactual,tarifa,consumo,total,fecvencimiento,esincobrable from tluz where idmesluz=@idmesluz

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_morpagmantenimiento    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE  procedure get_morpagmantenimiento
@idmantenimiento int
as
select isnull(sum(monto),0) from totrcobro where destinatario='mant' + cast(@idmantenimiento as varchar(50))


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_morpagmerced    Script Date: 05/06/2008 07:13:36 p.m. ******/

create procedure get_morpagmerced
@idmerced int
as
select isnull(sum(monto),0) from totrcobro where destinatario='mer' + cast(@idmerced as varchar(50))


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_otrcobro    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_otrcobro
@idotrcobro int
as
select idotrcobro,destinatario,monto,fecha,concepto,idreport from totrcobro where idotrcobro=@idotrcobro

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_pagcompra    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_pagcompra
@idpagcompra int
as
select idpagcompra,idordcompra,idreport,ruc,tipcomprobante,serie,numero,razsocual,fecha,monto from tpagcompra where idpagcompra=@idpagcompra

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_pagcontratista    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_pagcontratista
@idpagcontratista int
as
select idpagcontratista,idreport,idpersona,tippersona,idordpago,concepto,fecpago from tpagcontratista where idpagcontratista=@idpagcontratista

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_pagopersonal    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_pagopersonal
@idpagpersonal int
as
select idpagpersonal,idreport,idpersonal,idordpago,mes,semana,monto,fecpago from tpagopersonal where idpagpersonal=@idpagpersonal

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_pagoservicio    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_pagoservicio
@idpagservicio int
as
select idpagservicio,idreport,idordpago,tipo,mes,año,monto,fecpago from tpagoservicio where idpagservicio=@idpagservicio

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_pagotributo    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_pagotributo
@idpagtributo int
as
select idpagtributo,idreport,idordpago,mes,año,monto,fecpago from tpagotributo where idpagtributo=@idpagtributo

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_pagotro    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_pagotro
@idpagotro int
as
select idpagotro,idreport,idordpago,concepto,fecpago,monto from tpagotro where idpagotro=@idpagotro

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_perjurcontrato    Script Date: 05/06/2008 07:13:36 p.m. ******/
create procedure get_perjurcontrato
@idcontrato int
as
SELECT     idpersona
FROM         tconarrendatario
WHERE     (tipo = 1) and idconarrendamiento=@idcontrato

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_perjuridica    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_perjuridica
@idperjuridica int
as
select idperjuridica,razsocial,ruc,giro,direccion from tperjuridica where idperjuridica=@idperjuridica

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_pernatcontrato    Script Date: 05/06/2008 07:13:36 p.m. ******/
create procedure get_pernatcontrato
@idcontrato int
as
SELECT     idpersona
FROM         tconarrendatario
WHERE     (tipo = 0) and idconarrendamiento=@idcontrato

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_pernatjuridica    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_pernatjuridica
@idperjuridica int
as
select idpernatjuridica,idpernatural,idperjuridica from tpernatjuridica where idperjuridica=@idperjuridica

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_pernatural    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE  procedure get_pernatural
@idpersona int
as

select 
tpernatural.idpersona,
nombres,
apellidos,
tipdocumento,
numdocumento,
pasaporte,
fecnacimiento,
ruc 
from tpernatural full join trucnatural on tpernatural.idpersona = trucnatural.idpersona
where tpernatural.idpersona=@idpersona

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[get_pernatural]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_report    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_report
@idreport int
as
select idreport,codigo,origen,tipo,fecha from treport where idreport=@idreport

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_rucnatural    Script Date: 05/06/2008 07:13:36 p.m. ******/

create procedure get_rucnatural
@idpersona int
as
select ruc from trucnatural where idpersona=@idpersona

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_teljuridico    Script Date: 05/06/2008 07:13:36 p.m. ******/


CREATE  procedure get_teljuridico
@idpersona int
as
select idtelefono,idpersona,tipo,numero from tteljuridico where idpersona=@idpersona


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_telnatural    Script Date: 05/06/2008 07:13:36 p.m. ******/


CREATE  procedure get_telnatural
@idpersona int
as
select idtelefono,idpersona,tipo,numero from ttelnatural where idpersona=@idpersona


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[get_telnatural]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_tipo    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_tipo
@idtipo int
as
select idtipo,idpersona,nombre,nombrebreve,tippersona from ttipo where idtipo=@idtipo

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_tippersona    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure get_tippersona
@idpersona int
as
select idpersona,tippersona,arrendatario,empleado,contratista from ttippersona where idpersona=@idpersona

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_arbitrio    Script Date: 05/06/2008 07:13:36 p.m. ******/
CREATE procedure list_arbitrio
as
select idmesarbitrio,idlocal,monto,mes,numdias,año,espagado,esincobrable,cuota,fecfin from tarbitrio

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_conarrendamiento    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure list_conarrendamiento
as
select idconarrendamiento,garantia,fecha,inicio,fin,meses,dias,tipcomprobante,rutcontrato,estado,quiregistra from tconarrendamiento

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_conarrendatario    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure list_conarrendatario
as
select idconarrendatario,idconarrendamiento,idpersona,tipo from tconarrendatario

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_conrescindido    Script Date: 05/06/2008 07:13:36 p.m. ******/


CREATE  procedure list_conrescindido
as
select idconarrendamiento,fecrescincion,motivo from tconrescindido


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_cuomantenimiento    Script Date: 05/06/2008 07:13:36 p.m. ******/

CREATE procedure list_cuomantenimiento
as
select idcuomantenimiento,idmantenimiento,fecha,monto,idreport from tcuomantenimiento

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_cuomerconductiva    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_cuomerconductiva
as
select idcuomerconductiva,idmerconductiva,monto,idreport,fechacobro from tcuomerconductiva

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_cuomesarbitrio    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_cuomesarbitrio
as
select idcuomesarbitrio,idmesarbitrio,fecha,idreport,monto from tcuomesarbitrio

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_empleado    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_empleado
as
select idconempleado,fecinicio,fecfin,fecsalida,estado from templeado

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_local    Script Date: 05/06/2008 07:13:37 p.m. ******/
CREATE procedure list_local
as
select idlocal as codigo,nombre,estado,piso,merconductiva as [merced contiva],tipo as [tipo de local] from tlocal

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_local2    Script Date: 05/06/2008 07:13:37 p.m. ******/
CREATE procedure list_local2
@tienda int=1,
@taller int=1,
@almacen int=1,
@vitrina int=1,
@oficina int=1,
@otro int=1
as
declare @tb1 table(idlocal int,nombre varchar(10),estado int,piso int,merconductiva money,tipo int)
if @tienda=1
	insert into @tb1 select idlocal,Nombre,Estado,Piso,merconductiva as [Merced Conductiva],tipo from tlocal
	where tipo=0
if @taller=1
	insert into @tb1 select idlocal,Nombre,Estado,Piso,merconductiva as [Merced Conductiva],tipo from tlocal
	where tipo=1
if @almacen=1
	insert into @tb1 select idlocal,Nombre,Estado,Piso,merconductiva as [Merced Conductiva],tipo from tlocal
	where tipo=2
if @vitrina=1
	insert into @tb1 select idlocal,Nombre,Estado,Piso,merconductiva as [Merced Conductiva],tipo from tlocal
	where tipo=3
if @oficina=1
	insert into @tb1 select idlocal,Nombre,Estado,Piso,merconductiva as [Merced Conductiva],tipo from tlocal
	where tipo=4
if @otro=1
	insert into @tb1 select idlocal,Nombre,Estado,Piso,merconductiva as [Merced Conductiva],tipo from tlocal
	where tipo=5
select idlocal as codigo,nombre,estado,piso,merconductiva as [merced contiva],tipo as [tipo de local] from @tb1

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_loccontrato    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_loccontrato
as
select idloccontrato,idlocal,idcontrato,nombre,estado,area,piso,descripcion,medidor,telinterno,merconductiva,mormerconductiva,mantenimiento,mormantenimiento,arbitrio,morarbitrio,uso from tloccontrato

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_luz    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_luz
as
select idmesluz,idlocal,cuota,lecanterior,lecactual,tarifa,consumo,total,fecvencimiento,esincobrable from tluz

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_mantenimiento    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_mantenimiento
as
select idmantenimiento,idconarrendamiento,monto,semana,rangodias,numdias,fecfin,espagado,esincobrable from tmantenimiento

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_merconductiva    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_merconductiva
as
select idmerconductiva,idconarrendamiento,cuota,mes,fecfin,monto,numcomprobante,espagado,esincobrable from tmerconductiva

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_otrcobro    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_otrcobro
as
select idotrcobro,destinatario,monto,fecha,concepto,idreport from totrcobro

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_pagcompra    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_pagcompra
as
select idpagcompra,idordcompra,idreport,ruc,tipcomprobante,serie,numero,razsocual,fecha,monto from tpagcompra

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_pagcontratista    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_pagcontratista
as
select idpagcontratista,idreport,idpersona,tippersona,idordpago,concepto,fecpago from tpagcontratista

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_pagopersonal    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_pagopersonal
as
select idpagpersonal,idreport,idpersonal,idordpago,mes,semana,monto,fecpago from tpagopersonal

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_pagoservicio    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_pagoservicio
as
select idpagservicio,idreport,idordpago,tipo,mes,año,monto,fecpago from tpagoservicio

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_pagotributo    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_pagotributo
as
select idpagtributo,idreport,idordpago,mes,año,monto,fecpago from tpagotributo

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_pagotro    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_pagotro
as
select idpagotro,idreport,idordpago,concepto,fecpago,monto from tpagotro

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.list_perjuridica    Script Date: 05/06/2008 07:13:37 p.m. ******/
CREATE PROCEDURE lis_perjuridica AS
SELECT     tperjuridica.idperjuridica AS Código, tperjuridica.ruc AS RUC, tperjuridica.razsocial AS [Razón Social], tperjuridica.giro AS Giro, ttippersona.tippersona, 
                      ttippersona.arrendatario, ttippersona.empleado, ttippersona.contratista
FROM         tperjuridica INNER JOIN
                      ttippersona ON tperjuridica.idperjuridica = ttippersona.idpersona
WHERE     (ttippersona.tippersona = 1)
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[list_perjuridica]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_perjuridica2    Script Date: 05/06/2008 07:13:37 p.m. ******/
CREATE PROCEDURE list_perjuridica2 
@arrendatario bit=0,
@contratista bit=0
as
declare @tv1 table(idpersona int,ruc varchar(11),razsocial varchar(150),giro varchar(150),tippersona bit,arrendatario bit,contratista bit)

if(@arrendatario=0 and @contratista=0)
begin
	insert into @tv1 SELECT tperjuridica.idperjuridica AS Código, tperjuridica.ruc AS RUC, tperjuridica.razsocial AS [Razón Social], tperjuridica.giro AS Giro, ttippersona.tippersona, 
        ttippersona.arrendatario, ttippersona.contratista
	FROM tperjuridica INNER JOIN ttippersona ON tperjuridica.idperjuridica = ttippersona.idpersona
	WHERE (ttippersona.tippersona = 1)
end

else
begin
	if(@arrendatario=1)
		insert into @tv1 SELECT tperjuridica.idperjuridica AS Código, tperjuridica.ruc AS RUC, tperjuridica.razsocial AS [Razón Social], tperjuridica.giro AS Giro, ttippersona.tippersona, 
	        ttippersona.arrendatario, ttippersona.contratista
		FROM tperjuridica INNER JOIN ttippersona ON tperjuridica.idperjuridica = ttippersona.idpersona
		WHERE ttippersona.tippersona = 1 and arrendatario=1
	if(@contratista=1)
		insert into @tv1 SELECT tperjuridica.idperjuridica AS Código, tperjuridica.ruc AS RUC, tperjuridica.razsocial AS [Razón Social], tperjuridica.giro AS Giro, ttippersona.tippersona, 
	        ttippersona.arrendatario, ttippersona.contratista
		FROM tperjuridica INNER JOIN ttippersona ON tperjuridica.idperjuridica = ttippersona.idpersona
		WHERE ttippersona.tippersona = 1 and contratista=1
end

select distinct * from @tv1 

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

/****** Object:  Stored Procedure dbo.list_pernatjuridica    Script Date: 05/06/2008 07:13:37 p.m. ******/
CREATE PROCEDURE list_pernatjuridica AS
SELECT     tpernatjuridica.idpernatjuridica AS [Código Empresa], tpernatural.idpersona AS Código, tpernatural.nombres AS Nombres, 
                      tpernatural.apellidos AS Apellidos, tpernatural.numdocumento AS documento
FROM         tpernatjuridica INNER JOIN
                      tpernatural ON tpernatjuridica.idpernatural = tpernatural.idpersona
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[list_pernatjuridica]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_report    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_report
as
select idreport,codigo,origen,tipo,fecha from treport

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_rucnatural    Script Date: 05/06/2008 07:13:37 p.m. ******/

create procedure list_rucnatural
as
select ruc from trucnatural

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_teljuridico    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_teljuridico
as
select idtelefono,idpersona,tipo,numero from tteljuridico

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_telnatural    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_telnatural
as
select idtelefono,idpersona,tipo,numero from ttelnatural

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_tipo    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_tipo
as
select idtipo,idpersona,nombre,nombrebreve,tippersona from ttipo

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_tippersona    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure list_tippersona
as
select idpersona,tippersona,arrendatario,empleado,contratista from ttippersona

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.rescindir_contrato    Script Date: 05/06/2008 07:13:37 p.m. ******/
CREATE   PROCEDURE rescindir_contrato
	@idcontrato int,
	@fecrescincion datetime,
	@motivo varchar(250)
AS
	if(not exists(select * from tconrescindido where idconarrendamiento=@idcontrato))
	begin
		declare @fecfin datetime
		select @fecfin=fin from tconarrendamiento where idconarrendamiento=@idcontrato
		if(@fecfin>=getdate())
		begin
			update tarbitrio set esincobrable=1 where fecfin=getdate()
			update tmerconductiva set esincobrable=1 where fecfin=getdate()
			update tmantenimiento set esincobrable=1 where fecfin=getdate()
			insert into tconrescindido values(@idcontrato,@fecrescincion,@motivo)
			update tlocal set tlocal.estado=0 from tlocal inner join tloccontrato on tlocal.idlocal=tloccontrato.idlocal  where idcontrato=@idcontrato
			--nose si se debe poner tluz en esta lista
		end
	end
	else
	begin
		update tconrescindido set motivo=@motivo where idconarrendamiento=@idcontrato
	end



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_arbitrio    Script Date: 05/06/2008 07:13:37 p.m. ******/
create procedure update_arbitrio
@idmesarbitrio int,
@idlocal int,
@monto money,
@mes varchar(50),
@numdias int,
@año int,
@espagado bit,
@esincobrable bit,
@cuota int,
@fecfin datetime
as
if(@idmesarbitrio=-1)
begin
 --se inserta un registro
 insert into tarbitrio(
 idlocal, monto, mes, numdias, año, espagado, esincobrable, cuota, fecfin) values(@idlocal,@monto,@mes,@numdias,@año,@espagado,@esincobrable,@cuota,@fecfin)
update tindice set valor=valor+1 where objeto='tarbitrio'
select valor from tindice where objeto='tarbitrio'
end
else
begin
--se actualiza el registro
update tarbitrio set 
idlocal=@idlocal,
monto=@monto,
mes=@mes,
numdias=@numdias,
año=@año,
espagado=@espagado,
esincobrable=@esincobrable,
cuota=@cuota,
fecfin=@fecfin
where idmesarbitrio = @idmesarbitrio
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_conarrendatario    Script Date: 05/06/2008 07:13:37 p.m. ******/

create procedure update_conarrendatario
@idconarrendatario int,
@idconarrendamiento int,
@idpersona int,
@tipo bit
as
if(@idconarrendatario=-1)
begin
 --se inserta un registro
 insert into tconarrendatario(
 idconarrendamiento, idpersona, tipo) values(@idconarrendamiento,@idpersona,@tipo)
update tindice set valor=valor+1 where objeto='tconarrendatario'
select valor from tindice where objeto='tconarrendatario'
end
else
begin
--se actualiza el registro
update tconarrendatario set 
idconarrendamiento=@idconarrendamiento,
idpersona=@idpersona,
tipo=@tipo
where idconarrendatario = @idconarrendatario
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_conrescindido    Script Date: 05/06/2008 07:13:37 p.m. ******/


CREATE  procedure update_conrescindido
@idconarrendamiento int,
@fecrescincion datetime,
@motivo varchar(250),
@incobrable bit
as
if(not exists(select idconarrendamiento from tconrescindido where idconarrendamiento=@idconarrendamiento))
begin
	--se inserta un registro
	insert into tconrescindido(
	idconarrendamiento,fecrescincion, motivo) 
	values(@idconarrendamiento,@fecrescincion,@motivo)
	update tindice set valor=valor+1 where objeto='tconrescindido'
	select valor from tindice where objeto='tconrescindido'
end
else
begin
	--se actualiza el registro
	update tconrescindido set
	fecrescincion=@fecrescincion,
	motivo=@motivo
	where idconarrendamiento = @idconarrendamiento
END


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_cuomesarbitrio    Script Date: 05/06/2008 07:13:37 p.m. ******/

create procedure update_cuomesarbitrio
@idcuomesarbitrio int,
@idmesarbitrio int,
@fecha datetime,
@idreport bigint,
@monto money
as
if(@idcuomesarbitrio=-1)
begin
 --se inserta un registro
 insert into tcuomesarbitrio(
 idmesarbitrio, fecha, idreport, monto) values(@idmesarbitrio,@fecha,@idreport,@monto)
update tindice set valor=valor+1 where objeto='tcuomesarbitrio'
select valor from tindice where objeto='tcuomesarbitrio'
end
else
begin
--se actualiza el registro
update tcuomesarbitrio set 
idmesarbitrio=@idmesarbitrio,
fecha=@fecha,
idreport=@idreport,
monto=@monto
where idcuomesarbitrio = @idcuomesarbitrio
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_empleado    Script Date: 05/06/2008 07:13:37 p.m. ******/

create procedure update_empleado
@idconempleado int,
@fecinicio datetime,
@fecfin datetime,
@fecsalida datetime,
@estado bit
as
if(@idconempleado=-1)
begin
 --se inserta un registro
 insert into templeado(
 fecinicio, fecfin, fecsalida, estado) values(@fecinicio,@fecfin,@fecsalida,@estado)
update tindice set valor=valor+1 where objeto='templeado'
select valor from tindice where objeto='templeado'
end
else
begin
--se actualiza el registro
update templeado set 
fecinicio=@fecinicio,
fecfin=@fecfin,
fecsalida=@fecsalida,
estado=@estado
where idconempleado = @idconempleado
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_local    Script Date: 05/06/2008 07:13:37 p.m. ******/
CREATE procedure update_local
@idlocal int,
@nombre varchar(10)=null,
@estado int=0,
@area decimal=0,
@piso int=0,
@descripcion varchar(250)='ninguno',
@medidor varchar(50)='',
@telinterno varchar(13)='',
@merconductiva money=0,
@mormerconductiva money=0,
@mantenimiento money=0,
@mormantenimiento money=0,
@arbitrio money=0,
@morarbitrio money=0,
@tipo int=0
as
if(@idlocal=-1)
begin
 --se inserta un registro
 insert into tlocal(
 nombre, estado, area, piso, descripcion, medidor, telinterno, merconductiva, mormerconductiva, mantenimiento, mormantenimiento, arbitrio, morarbitrio, tipo) values(@nombre,@estado,@area,@piso,@descripcion,@medidor,@telinterno,@merconductiva,@mormerconductiva,@mantenimiento,@mormantenimiento,@arbitrio,@morarbitrio,@tipo)
update tindice set valor=valor+1 where objeto='tlocal'
select valor from tindice where objeto='tlocal'
end
else
begin
--se actualiza el registro
update tlocal set 
nombre=@nombre,
estado=@estado,
area=@area,
piso=@piso,
descripcion=@descripcion,
medidor=@medidor,
telinterno=@telinterno,
merconductiva=@merconductiva,
mormerconductiva=@mormerconductiva,
mantenimiento=@mantenimiento,
mormantenimiento=@mormantenimiento,
arbitrio=@arbitrio,
morarbitrio=@morarbitrio,
tipo=@tipo
where idlocal = @idlocal
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_loccontrato    Script Date: 05/06/2008 07:13:37 p.m. ******/


CREATE  procedure update_loccontrato
@idloccontrato int,
@idcontrato int,
@idlocal int,
@nombre varchar(10)=null,
@estado int=0,
@area int=0,
@piso int=0,
@descripcion varchar(200)='ninguno',
@medidor varchar(50)='',
@telinterno varchar(50)='',
@merconductiva money=0,
@mormerconductiva money=0,
@mantenimiento money=0,
@mormantenimiento money=0,
@arbitrio money=0,
@morarbitrio money=0,
@tipo int=0,
@uso varchar(50)
as
if(@idloccontrato=-1)
begin
 --se inserta un registro
 insert into tloccontrato(
 idlocal, idcontrato, nombre, estado, area, piso, descripcion, medidor, telinterno, merconductiva, mormerconductiva, mantenimiento, mormantenimiento, arbitrio, morarbitrio, uso) values(@idlocal,@idcontrato,@nombre,@estado,@area,@piso,@descripcion,@medidor,@telinterno,@merconductiva,@mormerconductiva,@mantenimiento,@mormantenimiento,@arbitrio,@morarbitrio,@uso)
update tindice set valor=valor+1 where objeto='tloccontrato'
select valor from tindice where objeto='tloccontrato'
end
else
begin
--se actualiza el registro
update tloccontrato set 
idlocal=@idlocal,
idcontrato=@idcontrato,
nombre=@nombre,
estado=@estado,
area=@area,
piso=@piso,
descripcion=@descripcion,
medidor=@medidor,
telinterno=@telinterno,
merconductiva=@merconductiva,
mormerconductiva=@mormerconductiva,
mantenimiento=@mantenimiento,
mormantenimiento=@mormantenimiento,
arbitrio=@arbitrio,
morarbitrio=@morarbitrio,
uso=@uso
where idloccontrato = @idloccontrato
END


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_luz    Script Date: 05/06/2008 07:13:37 p.m. ******/

create procedure update_luz
@idmesluz int,
@idlocal int,
@cuota tinyint,
@lecanterior decimal,
@lecactual decimal,
@tarifa money,
@consumo decimal,
@total money,
@fecvencimiento datetime,
@esincobrable bit
as
if(@idmesluz=-1)
begin
 --se inserta un registro
 insert into tluz(
 idlocal, cuota, lecanterior, lecactual, tarifa, consumo, total, fecvencimiento, esincobrable) values(@idlocal,@cuota,@lecanterior,@lecactual,@tarifa,@consumo,@total,@fecvencimiento,@esincobrable)
update tindice set valor=valor+1 where objeto='tluz'
select valor from tindice where objeto='tluz'
end
else
begin
--se actualiza el registro
update tluz set 
idlocal=@idlocal,
cuota=@cuota,
lecanterior=@lecanterior,
lecactual=@lecactual,
tarifa=@tarifa,
consumo=@consumo,
total=@total,
fecvencimiento=@fecvencimiento,
esincobrable=@esincobrable
where idmesluz = @idmesluz
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_mantenimiento    Script Date: 05/06/2008 07:13:37 p.m. ******/


CREATE  procedure update_mantenimiento
@idmantenimiento int,
@idconarrendamiento int,
@monto money,
@semana tinyint,
@rangodias varchar(29),
@numdias int,
@fecfin datetime,
@espagado bit,
@esincobrable bit
as
if(@idmantenimiento=-1)
begin
 --se inserta un registro
 insert into tmantenimiento(
 idconarrendamiento, monto, semana, rangodias, numdias, fecfin, espagado, esincobrable) values(@idconarrendamiento,@monto,@semana,@rangodias,@numdias,@fecfin,@espagado,@esincobrable)
update tindice set valor=valor+1 where objeto='tmantenimiento'
select valor from tindice where objeto='tmantenimiento'
end
else
begin
--se actualiza el registro
update tmantenimiento set 
idconarrendamiento=@idconarrendamiento,
monto=@monto,
semana=@semana,
rangodias=@rangodias,
numdias=@numdias,
fecfin=@fecfin,
espagado=@espagado,
esincobrable=@esincobrable
where idmantenimiento = @idmantenimiento
END


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_merconductiva    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_merconductiva
@idmerconductiva int,
@idconarrendamiento int,
@cuota int,
@mes varchar(30),
@fecfin datetime,
@monto money,
@numcomprobante varchar(50),
@espagado bit,
@esincobrable bit
as
if(@idmerconductiva=-1)
begin
 --se inserta un registro
 insert into tmerconductiva(
 idconarrendamiento, cuota, mes, fecfin, monto, numcomprobante, espagado, esincobrable) values(@idconarrendamiento,@cuota,@mes,@fecfin,@monto,@numcomprobante,@espagado,@esincobrable)
update tindice set valor=valor+1 where objeto='tmerconductiva'
select valor from tindice where objeto='tmerconductiva'
end
else
begin
--se actualiza el registro
update tmerconductiva set 
idconarrendamiento=@idconarrendamiento,
cuota=@cuota,
mes=@mes,
fecfin=@fecfin,
monto=@monto,
numcomprobante=@numcomprobante,
espagado=@espagado,
esincobrable=@esincobrable
where idmerconductiva = @idmerconductiva
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_otrcobro    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_otrcobro
@idotrcobro bigint,
@destinatario varchar(50),
@monto money,
@fecha datetime,
@concepto text,
@idreport int
as
if(@idotrcobro=-1)
begin
 --se inserta un registro
 insert into totrcobro(
 destinatario, monto, fecha, concepto, idreport) values(@destinatario,@monto,@fecha,@concepto,@idreport)
update tindice set valor=valor+1 where objeto='totrcobro'
select valor from tindice where objeto='totrcobro'
end
else
begin
--se actualiza el registro
update totrcobro set 
destinatario=@destinatario,
monto=@monto,
fecha=@fecha,
concepto=@concepto,
idreport=@idreport
where idotrcobro = @idotrcobro
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_pagcompra    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_pagcompra
@idpagcompra int,
@idordcompra int,
@idreport bigint,
@ruc varchar(50),
@tipcomprobante varchar(50),
@serie varchar(50),
@numero varchar(50),
@razsocual varchar(50),
@fecha datetime,
@monto money
as
if(@idpagcompra=-1)
begin
 --se inserta un registro
 insert into tpagcompra(
 idordcompra, idreport, ruc, tipcomprobante, serie, numero, razsocual, fecha, monto) values(@idordcompra,@idreport,@ruc,@tipcomprobante,@serie,@numero,@razsocual,@fecha,@monto)
update tindice set valor=valor+1 where objeto='tpagcompra'
select valor from tindice where objeto='tpagcompra'
end
else
begin
--se actualiza el registro
update tpagcompra set 
idordcompra=@idordcompra,
idreport=@idreport,
ruc=@ruc,
tipcomprobante=@tipcomprobante,
serie=@serie,
numero=@numero,
razsocual=@razsocual,
fecha=@fecha,
monto=@monto
where idpagcompra = @idpagcompra
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_pagcontratista    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_pagcontratista
@idpagcontratista int,
@idreport bigint,
@idpersona int,
@tippersona int,
@idordpago int,
@concepto varchar(200),
@fecpago datetime
as
if(@idpagcontratista=-1)
begin
 --se inserta un registro
 insert into tpagcontratista(
 idreport, idpersona, tippersona, idordpago, concepto, fecpago) values(@idreport,@idpersona,@tippersona,@idordpago,@concepto,@fecpago)
update tindice set valor=valor+1 where objeto='tpagcontratista'
select valor from tindice where objeto='tpagcontratista'
end
else
begin
--se actualiza el registro
update tpagcontratista set 
idreport=@idreport,
idpersona=@idpersona,
tippersona=@tippersona,
idordpago=@idordpago,
concepto=@concepto,
fecpago=@fecpago
where idpagcontratista = @idpagcontratista
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_pagopersonal    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_pagopersonal
@idpagpersonal int,
@idreport bigint,
@idpersonal int,
@idordpago int,
@mes varchar(50),
@semana int,
@monto money,
@fecpago datetime
as
if(@idpagpersonal=-1)
begin
 --se inserta un registro
 insert into tpagopersonal(
 idreport, idpersonal, idordpago, mes, semana, monto, fecpago) values(@idreport,@idpersonal,@idordpago,@mes,@semana,@monto,@fecpago)
update tindice set valor=valor+1 where objeto='tpagopersonal'
select valor from tindice where objeto='tpagopersonal'
end
else
begin
--se actualiza el registro
update tpagopersonal set 
idreport=@idreport,
idpersonal=@idpersonal,
idordpago=@idordpago,
mes=@mes,
semana=@semana,
monto=@monto,
fecpago=@fecpago
where idpagpersonal = @idpagpersonal
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_pagoservicio    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_pagoservicio
@idpagservicio int,
@idreport bigint,
@idordpago int,
@tipo int,
@mes varchar(50),
@año varchar(50),
@monto money,
@fecpago datetime
as
if(@idpagservicio=-1)
begin
 --se inserta un registro
 insert into tpagoservicio(
 idreport, idordpago, tipo, mes, año, monto, fecpago) values(@idreport,@idordpago,@tipo,@mes,@año,@monto,@fecpago)
update tindice set valor=valor+1 where objeto='tpagoservicio'
select valor from tindice where objeto='tpagoservicio'
end
else
begin
--se actualiza el registro
update tpagoservicio set 
idreport=@idreport,
idordpago=@idordpago,
tipo=@tipo,
mes=@mes,
año=@año,
monto=@monto,
fecpago=@fecpago
where idpagservicio = @idpagservicio
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_pagotributo    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_pagotributo
@idpagtributo int,
@idreport bigint,
@idordpago int,
@mes varchar(50),
@año int,
@monto money,
@fecpago datetime
as
if(@idpagtributo=-1)
begin
 --se inserta un registro
 insert into tpagotributo(
 idreport, idordpago, mes, año, monto, fecpago) values(@idreport,@idordpago,@mes,@año,@monto,@fecpago)
update tindice set valor=valor+1 where objeto='tpagotributo'
select valor from tindice where objeto='tpagotributo'
end
else
begin
--se actualiza el registro
update tpagotributo set 
idreport=@idreport,
idordpago=@idordpago,
mes=@mes,
año=@año,
monto=@monto,
fecpago=@fecpago
where idpagtributo = @idpagtributo
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_pagotro    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_pagotro
@idpagotro int,
@idreport bigint,
@idordpago int,
@concepto varchar(200),
@fecpago datetime,
@monto money
as
if(@idpagotro=-1)
begin
 --se inserta un registro
 insert into tpagotro(
 idreport, idordpago, concepto, fecpago, monto) values(@idreport,@idordpago,@concepto,@fecpago,@monto)
update tindice set valor=valor+1 where objeto='tpagotro'
select valor from tindice where objeto='tpagotro'
end
else
begin
--se actualiza el registro
update tpagotro set 
idreport=@idreport,
idordpago=@idordpago,
concepto=@concepto,
fecpago=@fecpago,
monto=@monto
where idpagotro = @idpagotro
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_perjuridica    Script Date: 05/06/2008 07:13:37 p.m. ******/
CREATE procedure update_perjuridica
@idperjuridica int,
@razsocial varchar(150),
@ruc varchar(11),
@giro varchar(150),
@direccion varchar(200)
as
if(@idperjuridica=-1)
begin
	insert into tperjuridica(razsocial,ruc,giro,direccion)
	values(@razsocial,@ruc,@giro,@direccion)
	update tindice set valor=valor+1 where objeto='tperjuridica'
	select @idperjuridica =valor from tindice where objeto='tperjuridica'
end
else
	update tperjuridica set
	razsocial=@razsocial,
	ruc=@ruc,
	giro=@giro,
	direccion=@direccion
	where idperjuridica=@idperjuridica
select @idperjuridica
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[update_perjuridica]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_pernatjuridica    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_pernatjuridica
@idpernatjuridica int,
@idpernatural int,
@idperjuridica int
as
if(@idpernatjuridica=-1)
begin
 --se inserta un registro
 insert into tpernatjuridica(
 idpernatural, idperjuridica) values(@idpernatural,@idperjuridica)
update tindice set valor=valor+1 where objeto='tpernatjuridica'
select valor from tindice where objeto='tpernatjuridica'
end
else
begin
--se actualiza el registro
update tpernatjuridica set 
idpernatural=@idpernatural,
idperjuridica=@idperjuridica
where idpernatjuridica = @idpernatjuridica
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_report    Script Date: 05/06/2008 07:13:37 p.m. ******/


CREATE    procedure update_report
@idreport bigint,
@origen varchar(50),
@tipo bit,
@fecha datetime
as
if(@idreport=-1)
begin
	--se inserta un registro
	declare @codigo bigint
	if(@tipo=1)
	begin
		select @codigo=valor+1 from tindice where objeto='ingreso'
		update tindice set valor=valor+1 where objeto='ingreso'
	end
	else
	begin
		select @codigo=valor+1 from tindice where objeto='egreso'
		update tindice set valor=valor+1 where objeto='engreso'
	end
	insert into treport(
	codigo, origen, tipo, fecha) values(@codigo,@origen,@tipo,@fecha)	
	update tindice set valor=valor+1 where objeto='treport'
	select valor from tindice where objeto='treport'
end
else
begin
	--se actualiza el registro
	update treport set 
	codigo=@codigo,
	origen=@origen,
	tipo=@tipo,
	fecha=@fecha
	where idreport = @idreport
END



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_rucnatural    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_rucnatural
@idpersona int,
@ruc varchar(11)
as
if(@idpersona=-1)
begin
 --se inserta un registro
 insert into trucnatural(
 ruc) values(@ruc)
update tindice set valor=valor+1 where objeto='trucnatural'
select valor from tindice where objeto='trucnatural'
end
else
begin
--se actualiza el registro
update trucnatural set 
ruc=@ruc
where idpersona = @idpersona
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_teljuridico    Script Date: 05/06/2008 07:13:37 p.m. ******/

create procedure update_teljuridico
@idtelefono int,
@idpersona int,
@tipo int,
@numero varchar(50)
as
if(@idtelefono=-1)
	insert into tteljuridico(idpersona,tipo,numero)
	values(@idpersona,@tipo,@numero)
else
	update tteljuridico set

	idpersona=@idpersona,
	tipo=@tipo,
	numero=@numero
	where idtelefono=@idtelefono


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[update_teljuridico]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_telnatural    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_telnatural
@idtelefono int,
@idpersona int,
@tipo int,
@numero varchar(50)
as
if(@idtelefono=-1)
begin
 --se inserta un registro
 insert into ttelnatural(
 idpersona, tipo, numero) values(@idpersona,@tipo,@numero)
update tindice set valor=valor+1 where objeto='ttelnatural'
select valor from tindice where objeto='ttelnatural'
end
else
begin
--se actualiza el registro
update ttelnatural set 
idpersona=@idpersona,
tipo=@tipo,
numero=@numero
where idtelefono = @idtelefono
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[update_telnatural]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_tipo    Script Date: 05/06/2008 07:13:37 p.m. ******/

CREATE procedure update_tipo
@idtipo int,
@idpersona int,
@nombre varchar(50),
@nombrebreve varchar(15),
@tippersona int
as
if(@idtipo=-1)
begin
 --se inserta un registro
 insert into ttipo(
 idpersona, nombre, nombrebreve, tippersona) values(@idpersona,@nombre,@nombrebreve,@tippersona)
update tindice set valor=valor+1 where objeto='ttipo'
select valor from tindice where objeto='ttipo'
end
else
begin
--se actualiza el registro
update ttipo set 
idpersona=@idpersona,
nombre=@nombre,
nombrebreve=@nombrebreve,
tippersona=@tippersona
where idtipo = @idtipo
END

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_tippersona    Script Date: 05/06/2008 07:13:38 p.m. ******/


CREATE  procedure update_tippersona
@quehago int,
@idpersona int,
@tippersona bit,
@arrendatario bit,
@empleado bit,
@contratista bit
as
if(@quehago=-1)
begin
 --se inserta un registro
 insert into ttippersona(
 idpersona,tippersona, arrendatario, empleado, contratista) 
 values(@idpersona,@tippersona,@arrendatario,@empleado,@contratista)
update tindice set valor=valor+1 where objeto='ttippersona'
select valor from tindice where objeto='ttippersona'
end
else
begin
--se actualiza el registro
update ttippersona set 
arrendatario=@arrendatario,
empleado=@empleado,
contratista=@contratista
where idpersona = @idpersona and tippersona=@tippersona
END


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.list_conarrendamientos    Script Date: 05/06/2008 07:13:38 p.m. ******/

CREATE  procedure list_conarrendamientos as
SELECT     
idconarrendamiento as Código, 
Inicio, 
Fin,
convert(varchar(10),meses) + ' meses y ' + convert(varchar(10),dias) + ' dias' as Duracion,
dbo.locales_contrato(idconarrendamiento) as Locales
FROM         tconarrendamiento

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[list_conarrendamientos]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_conarrendamiento    Script Date: 05/06/2008 07:13:38 p.m. ******/


CREATE    procedure update_conarrendamiento
@idconarrendamiento int,
@garantia money,
@fecha datetime,
@meses int,
@dias int,
@tipcomprobante int,
@rutcontrato varchar(255),
@estado int,
@inicio datetime
as
if(@idconarrendamiento=-1)
begin
	--se inserta un registro
	insert into tconarrendamiento(
	garantia, fecha, meses, dias, tipcomprobante, rutcontrato, estado, inicio,fin) 
	values(@garantia,@fecha,@meses,@dias,@tipcomprobante,@rutcontrato,@estado,@inicio,dateadd(day,@dias-1,dateadd(month,@meses,@inicio)))
	update tindice set valor=valor+1 where objeto='tconarrendamiento'
	select @idconarrendamiento=valor from tindice where objeto='tconarrendamiento'
end
else
begin
	--se actualiza el registro
	update tconarrendamiento set 
	garantia=@garantia,
	fecha=@fecha,
	inicio=@inicio,
	fin=dateadd(day,@dias-1,dateadd(month,@meses,@inicio)),
	meses=@meses,
	dias=@dias,
	tipcomprobante=@tipcomprobante,
	rutcontrato=@rutcontrato,
	estado=@estado
	where idconarrendamiento = @idconarrendamiento
END
select @idconarrendamiento
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_convencidos    Script Date: 05/06/2008 07:13:38 p.m. ******/
CREATE PROCEDURE get_convencidos AS
update dbo.tconarrendamiento set estado=1 where fin<=getdate()
update tlocal set estado=0 where exists(select idloccontrato 
from tloccontrato inner join tconarrendamiento on
tloccontrato.idcontrato=tconarrendamiento.idconarrendamiento 
where tconarrendamiento.fin<=getdate() and tloccontrato.idlocal=tlocal.idlocal)
select idconarrendamiento as Nº,fecha as [fecha de firma],dbo.arrendatarios_contrato(idconarrendamiento) as [arrendatarios], dbo.locales_contrato(idconarrendamiento) as [locales] from tconarrendamiento
where fin=getdate()
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_pernatural    Script Date: 05/06/2008 07:13:38 p.m. ******/





CREATE           procedure update_pernatural
@idpersona int,
@nombres varchar(100),
@apellidos varchar(200),
@tipdocumento int,
@numdocumento varchar(10),
@pasaporte varchar(50)=null,
@fecnacimiento datetime,
@ruc varchar(11)=''
as
if(@idpersona=-1)
begin
	declare @id int
	insert into tpernatural(nombres,apellidos,tipdocumento,numdocumento,pasaporte,fecnacimiento)
	values(@nombres,@apellidos,@tipdocumento,@numdocumento,@pasaporte,@fecnacimiento)
	update tindice set valor=valor+1 where objeto='tpernatural'
	select valor from tindice where objeto='tpernatural'
end
else
begin	
	update tpernatural set
	nombres=@nombres,
	apellidos=@apellidos,
	tipdocumento=@tipdocumento,
	numdocumento=@numdocumento,
	pasaporte=@pasaporte,
	fecnacimiento=@fecnacimiento
	where idpersona=@idpersona
	select @id=@idpersona
end
delete trucnatural where idpersona=@idpersona
if(@ruc is null or @ruc='' or @ruc=null)
begin
	delete from trucnatural where idpersona=@id
end
else
begin
	insert into trucnatural values(@id,@ruc)
end







GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[update_pernatural]  TO [galman]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_cuomerconductiva    Script Date: 05/06/2008 07:13:38 p.m. ******/


CREATE  procedure get_cuomerconductiva
@idcuomerconductiva int
as
select 
idcuomerconductiva as Código,
idmerconductiva as [Merced_Conductiva],
monto,
idreport as Report,
fechacobro as Fecha
from tcuomerconductiva 
where idcuomerconductiva=@idcuomerconductiva


GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_mantenimiento    Script Date: 05/06/2008 07:13:38 p.m. ******/


CREATE      procedure get_mantenimiento
@idcontrato int
as
select 
tmantenimiento.idmantenimiento as [Nº],--0
tmantenimiento.Semana,--1
tmantenimiento.fecfin as fecha,--2
tmantenimiento.rangodias as [Rando de Días],
tmantenimiento.monto,--3
isnull(sum(tcuomantenimiento.monto),0) as pagados,--4
tmantenimiento.total - isnull(sum(tcuomantenimiento.monto),0) as debe,--5
DBO.mora_merconductiva(@idcontrato,fecfin,getdate()) as [dias de demora],--6
tmantenimiento.numdias,--7
conmora as [perdon de mora],--8
espagado as [es pagado]--9
from tmantenimiento full join tcuomantenimiento
on tmantenimiento.idmantenimiento=tcuomantenimiento.idmantenimiento
where idconarrendamiento=@idcontrato and esincobrable=0
group by 
tmantenimiento.idmantenimiento,tmantenimiento.Semana,
tmantenimiento.fecfin,tmantenimiento.monto,
tmantenimiento.total,tmantenimiento.numdias,
conmora,espagado,tmantenimiento.rangodias



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.get_merconductiva    Script Date: 05/06/2008 07:13:38 p.m. ******/



CREATE   procedure get_merconductiva
@idcontrato int
as
select 
tmerconductiva.idmerconductiva as Nº,--0
tmerconductiva.cuota,--1
tmerconductiva.mes,--2
tmerconductiva.fecfin as Fecha,--3
tmerconductiva.monto,--4
isnull(sum(tcuomerconductiva.monto),0) as pagados,--5
tmerconductiva.total-isnull(sum(tcuomerconductiva.monto),0) as debe,--6
DBO.mora_merconductiva(@idcontrato,fecfin,getdate()) as [dias de demora],--7
conmora as [perdon de mora],--8
espagado as [es pagado]--9
from tmerconductiva full join tcuomerconductiva
on tmerconductiva.idmerconductiva= tcuomerconductiva.idmerconductiva
where idconarrendamiento=@idcontrato
group by tmerconductiva.idmerconductiva,
tmerconductiva.cuota,
tmerconductiva.mes,
tmerconductiva.fecfin,
tmerconductiva.total,
tmerconductiva.conmora,
tmerconductiva.espagado,
tmerconductiva.monto

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.rpt_facturacion    Script Date: 05/06/2008 07:13:38 p.m. ******/
CREATE procedure rpt_facturacion
@fecha1 datetime,@fecha2 datetime
as
	SELECT     'Arbitrios' AS concepto, monto,fecha,month(fecha) as mes,year(fecha) año,datename(month,fecha)as mesnombre
	FROM         dbo.tcuomesarbitrio
	where fecha between @fecha1 and @fecha2 
	union
	SELECT     'Mantenimiento', monto, fecha,month(fecha) as mes,year(fecha) año,datename(month,fecha)
	FROM         dbo.tcuomantenimiento
	where fecha between @fecha1 and @fecha2
	union
	SELECT     'Merced Conductiva', monto, fechacobro,month(fechacobro) as mes,year(fechacobro) año,datename(month,fechacobro)
	FROM         dbo.tcuomerconductiva
	where fechacobro between @fecha1 and @fecha2

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.rpt_report_codigo    Script Date: 05/06/2008 07:13:38 p.m. ******/
CREATE procedure rpt_report_codigo
@codinicio bigint,
@codfin bigint
as
SELECT     treport.codigo AS Nº, 'Mantenimiento' AS Descripción, tcuomantenimiento.monto AS Total, treport.fecha AS Fecha,'Ingreso' as Tipo
FROM         treport INNER JOIN
                      tcuomantenimiento ON treport.idreport = tcuomantenimiento.idreport
where treport.codigo between @codinicio and @codfin
union 
SELECT     treport.codigo, 'Merced Conductiva', tcuomerconductiva.monto, treport.fecha,'Ingreso'
FROM         treport INNER JOIN
                      tcuomerconductiva ON treport.idreport = tcuomerconductiva.idreport
where treport.codigo between @codinicio and @codfin
union
SELECT     treport.codigo, 'Merced Conductiva', tcuomesarbitrio.monto, treport.fecha,'Ingreso'
FROM         treport INNER JOIN
                      tcuomesarbitrio ON treport.idreport = tcuomesarbitrio.idreport
where treport.codigo between @codinicio and @codfin

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.rpt_report_fecha    Script Date: 05/06/2008 07:13:38 p.m. ******/
create procedure rpt_report_fecha
@fecha1 datetime,
@fecha2 datetime
as
SELECT     treport.codigo AS Nº, 'Mantenimiento' AS Descripción, tcuomantenimiento.monto AS Total, treport.fecha AS Fecha,'Ingreso' as Tipo
FROM         treport INNER JOIN
                      tcuomantenimiento ON treport.idreport = tcuomantenimiento.idreport
where treport.fecha between @fecha1 and @fecha2
union 
SELECT     treport.codigo, 'Merced Conductiva', tcuomerconductiva.monto, treport.fecha,'Ingreso'
FROM         treport INNER JOIN
                      tcuomerconductiva ON treport.idreport = tcuomerconductiva.idreport
where treport.fecha between @fecha1 and @fecha2
union
SELECT     treport.codigo, 'Merced Conductiva', tcuomesarbitrio.monto, treport.fecha,'Ingreso'
FROM         treport INNER JOIN
                      tcuomesarbitrio ON treport.idreport = tcuomesarbitrio.idreport
where treport.fecha between @fecha1 and @fecha2

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_cuomantenimiento    Script Date: 05/06/2008 07:13:38 p.m. ******/
CREATE    procedure update_cuomantenimiento
@idcuomantenimiento int,
@idmantenimiento int,
@monto money,
@mora money,
@conmora bit
as
	--se inserta un registro

	--se inserta en treport
	declare @fecha datetime
	select @fecha=getdate()
	declare @idreport bigint
	declare @valor money
	declare @total money
	exec update_report -1,'tcuomantenimiento',1,@fecha
	select @idreport=valor from tindice where objeto='treport'

	--se inserta en tcuomantenimiento
	 insert into tcuomantenimiento(
	 idmantenimiento, fecha, monto, idreport) 
	values(@idmantenimiento,getdate(),@monto,@idreport)
	update tindice set valor=valor+1 where objeto='tcuomantenimiento'

	--conmora
	if(@conmora=1)
		update tmantenimiento set mora=@mora,conmora=@conmora where idmantenimiento=@idmantenimiento
	else
		update tmantenimiento set mora=0,conmora=@conmora where idmantenimiento=@idmantenimiento

	select @valor=sum(monto) from tcuomantenimiento where idmantenimiento=@idmantenimiento
	select @total=monto from tmantenimiento where idmantenimiento=@idmantenimiento
	if @valor>=@total
		update tmantenimiento set espagado=1 where idmantenimiento=@idmantenimiento

	select @idreport

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Stored Procedure dbo.update_cuomerconductiva    Script Date: 05/06/2008 07:13:38 p.m. ******/
CREATE   procedure update_cuomerconductiva
@idcuomerconductiva bigint,
@idmerconductiva int,
@monto money,
@idreport int,
@fechacobro datetime,
@mora money,
@conmora bit
as
 --se inserta un registro
declare @valor money,@total money
insert into tcuomerconductiva(
idmerconductiva, monto, idreport, fechacobro) values(@idmerconductiva,@monto,@idreport,@fechacobro)
update tindice set valor=valor+1 where objeto='tcuomerconductiva'

if(@conmora=1)
	update tmerconductiva set mora=@mora,conmora=@conmora where idmerconductiva=@idmerconductiva
else
	update tmerconductiva set mora=0 where idmerconductiva=@idmerconductiva

select @valor=sum(monto) from tcuomerconductiva where idmerconductiva=@idmerconductiva
select @total=total from tmerconductiva where idmerconductiva=@idmerconductiva
if @valor>=@total
	update tmerconductiva set espagado=1 where idmerconductiva=@idmerconductiva

GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

/****** Object:  Trigger dbo.espagado_mantenimiento    Script Date: 05/06/2008 07:13:38 p.m. ******/

-- =============================================
-- Create trigger contained If UPDATE(column)
-- =============================================
CREATE TRIGGER espagado_mantenimiento
ON tcuomantenimiento
after INSERT, UPDATE 
AS 
declare @idmantenimiento int
select @idmantenimiento=idmantenimiento from inserted

update tmantenimiento set tmantenimiento.espagado=1 where 
tmantenimiento.monto=(select sum(a.monto) from tcuomantenimiento as a where a.idmantenimiento=tmantenimiento.idmantenimiento)
and tmantenimiento.idmantenimiento=@idmantenimiento



GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

-------------------------------------------------
--rear los indices
-------------------------------------------------
insert into tindice(objeto,valor) select name,0 from sysobjects where xtype='u'