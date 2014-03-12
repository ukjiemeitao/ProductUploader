/*
   25 January 201410:23:36
   User: 
   Server: STMA-MAC1\SQLEXPRESS
   Database: Catalog
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
EXECUTE sp_rename N'dbo.TB_Product.IsUpdated', N'Tmp_IsUploaded', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.TB_Product.Tmp_IsUploaded', N'IsUploaded', 'COLUMN' 
GO
ALTER TABLE dbo.TB_Product SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
