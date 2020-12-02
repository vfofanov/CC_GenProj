/*
This script create or update Code Cruiser system objects on schema CCSystem
All objects, except tables, always recreate in Initialization region
Existed tables changes are in Table migrations region
*/
SET NOCOUNT ON;
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
SET NOEXEC OFF;
GO
/*
--For recreate system tables run script bellow
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Info') AND type ='U'))
	DROP TABLE CCSystem.Info

*/
GO
--region *****************************  Remove old structure ****************************
GO

--region Procedures
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.WriteStringToFile') AND type IN ('P')))
	DROP PROCEDURE CCSystem.WriteStringToFile
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.CreateGenericCursor') AND type IN ('P')))
	DROP PROCEDURE CCSystem.CreateGenericCursor

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetLogPropertyChanges') AND type IN ('P', 'RF', 'PC')))
	DROP PROCEDURE CCSystem.GetLogPropertyChanges
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetLogEntries') AND type IN ('P', 'RF', 'PC')))
	DROP PROCEDURE CCSystem.GetLogEntries
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetDataAnalyseProcedures') AND type IN ('P', 'RF', 'PC')))
	DROP PROCEDURE CCSystem.GetDataAnalyseProcedures
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetActionLogEntries') AND type IN ('P', 'RF', 'PC')))
	DROP PROCEDURE CCSystem.GetActionLogEntries
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.AddLogPropertyChange') AND type IN ('P', 'RF', 'PC')))
	DROP PROCEDURE CCSystem.AddLogPropertyChange
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.AddLogEntry') AND type IN ('P', 'RF', 'PC')))
	DROP PROCEDURE CCSystem.AddLogEntry
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.AddActionLogEntry') AND type IN ('P', 'RF', 'PC')))
	DROP PROCEDURE CCSystem.AddActionLogEntry

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.UpdatePermissions') AND type IN ('P', 'RF', 'PC')))
	DROP PROCEDURE CCSystem.UpdatePermissions
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.UpdateSysObjects') AND type IN ('P', 'RF', 'PC')))
	DROP PROCEDURE CCSystem.UpdateSysObjects

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetSyncSecurity') AND type IN ('P')))
	DROP PROCEDURE CCSystem.GetSyncSecurity
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[CCSystem].[GrantPermission]') AND type IN ('P')))
	DROP PROCEDURE [CCSystem].[GrantPermission]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[CCSystem].[RevokePermission]') AND type IN ('P')))
	DROP PROCEDURE [CCSystem].[RevokePermission]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.AddUserToRole') AND type IN ('P')))
	DROP PROCEDURE CCSystem.AddUserToRole
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.RemoveUserFromRole') AND type IN ('P')))
	DROP PROCEDURE CCSystem.RemoveUserFromRole
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SyncRoles') AND type IN ('P')))
	DROP PROCEDURE CCSystem.SyncRoles
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SyncUsers') AND type IN ('P')))
	DROP PROCEDURE CCSystem.SyncUsers
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SyncUserRoles') AND type IN ('P')))
	DROP PROCEDURE CCSystem.SyncUserRoles
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SyncRolePermissions') AND type IN ('P')))
	DROP PROCEDURE CCSystem.SyncRolePermissions
--endregion
GO

--region Functions
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetSysObjectId') AND type IN (N'FN', N'FS', N'FT', N'TF', N'IF'))
    DROP FUNCTION CCSystem.GetSysObjectId;

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetSysFieldId') AND type IN (N'FN', N'FS', N'FT', N'TF', N'IF'))
    DROP FUNCTION CCSystem.GetSysFieldId;

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.HasPermission') AND type IN (N'FN', N'FS', N'FT', N'TF', N'IF'))
    DROP FUNCTION CCSystem.HasPermission;
--endregion
GO

--region Views
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.PermissionsView') AND type ='V'))
    DROP VIEW CCSystem.PermissionsView
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.UserPermissions') AND type ='V'))
    DROP VIEW CCSystem.UserPermissions
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.UserPermissionsView') AND type ='V'))
    DROP VIEW CCSystem.UserPermissionsView
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.UserPermissionsDisplayView') AND type ='V'))
    DROP VIEW CCSystem.UserPermissionsDisplayView
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.UsersDisplayView') AND type ='V'))
    DROP VIEW CCSystem.UsersDisplayView    
--endregion
GO

--region Tables
IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Info') AND type ='U'))
BEGIN	

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Files') AND type in (N'U'))
	DROP TABLE CCSystem.Files

IF (EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Operation') AND type = 'U'))
  DROP TABLE CCSystem.Operation

IF (EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.OperationResult') AND type = 'U'))
  DROP TABLE CCSystem.OperationResult

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.UserRoles') AND type ='U'))
	DROP TABLE CCSystem.UserRoles

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Settings') AND type ='U'))
	DROP TABLE CCSystem.Settings

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SettingProperties') AND type ='U'))
	DROP TABLE CCSystem.SettingProperties

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.RolePermissions') AND type ='U'))
	DROP TABLE CCSystem.RolePermissions

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.ResetPasswordToken') AND type ='U'))
	DROP TABLE CCSystem.ResetPasswordToken
  
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.RefreshToken') AND type ='U'))
	DROP TABLE CCSystem.RefreshToken

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Permissions') AND type ='U'))
	DROP TABLE CCSystem.Permissions

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.PermissionTypes') AND type ='U'))
	DROP TABLE CCSystem.PermissionTypes

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SysObjects') AND type ='U'))
	DROP TABLE CCSystem.SysObjects

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SysObjectTypes') AND type ='U'))
	DROP TABLE CCSystem.SysObjectTypes
  
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SysObjectClasses') AND type ='U'))
	DROP TABLE CCSystem.SysObjectClasses

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.OperationLocks') AND type ='U'))
	DROP TABLE CCSystem.OperationLocks

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.LogPropertyChanges') AND type ='U'))
	DROP TABLE CCSystem.LogPropertyChanges

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.LogProperties') AND type ='U'))
	DROP TABLE CCSystem.LogProperties

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.LogEntries') AND type ='U'))
	DROP TABLE CCSystem.LogEntries

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GridFilters') AND type ='U'))
	DROP TABLE CCSystem.GridFilters

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.DataAnalysers') AND type ='U'))
	DROP TABLE CCSystem.DataAnalysers

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.ActionLogEntries') AND type ='U'))
	DROP TABLE CCSystem.ActionLogEntries

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.ObjectTypes') AND type ='U'))
	DROP TABLE CCSystem.ObjectTypes

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.LogActionTypes') AND type ='U'))
	DROP TABLE CCSystem.LogActionTypes

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Roles') AND type ='U'))
	DROP TABLE CCSystem.Roles

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Users') AND type ='U'))
	DROP TABLE CCSystem.Users

IF (EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.FileRepository') AND type = 'U'))
  DROP TABLE CCSystem.FileRepository

END
--endregion

--region UDT
IF (EXISTS(SELECT * FROM sys.types WHERE user_type_id = TYPE_ID(N'CCSystem.PermissionsUDT')))
	DROP TYPE CCSystem.PermissionsUDT

IF (EXISTS(SELECT * FROM sys.types WHERE user_type_id = TYPE_ID(N'CCSystem.SysObjectsUDT')))
	DROP TYPE CCSystem.SysObjectsUDT

IF (EXISTS(SELECT * FROM sys.types WHERE user_type_id = TYPE_ID(N'CCSystem.SysObjectsUpdateUDT')))
	DROP TYPE CCSystem.SysObjectsUpdateUDT
--endregion
--endregion
GO
-- region ******************* Schema ***************************8
GO
IF (EXISTS(SELECT * FROM sys.schemas WHERE name = N'CCSystem'))
SET NOEXEC ON
GO
CREATE SCHEMA CCSystem
GO
SET NOEXEC OFF
GO
--endregion

--region ****************************** Tables *******************************
IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Info') AND type ='U'))
BEGIN
  CREATE TABLE CCSystem.Info(
  	SystemVersion varchar(20) NOT NULL,
  	DomainVersion varchar(20) NOT NULL,
  	LastInitialization datetime2(3) NOT NULL,
    CONSTRAINT PK_SystemInfo PRIMARY KEY CLUSTERED (SystemVersion, DomainVersion, LastInitialization)
  ) ON [PRIMARY]
  
  INSERT INTO CCSystem.Info VALUES ('1.0.0.10', '0.0.0.0', getdate())
END  
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SysObjectClasses') AND type ='U'))
BEGIN  
  CREATE TABLE CCSystem.SysObjectClasses(
  	Id tinyint NOT NULL,
  	CodeName varchar(256) NOT NULL,
  	DisplayName nvarchar(256) NOT NULL,
  	Description nvarchar(256) NULL,
  	CONSTRAINT PK_SystemObjectClasses PRIMARY KEY CLUSTERED (Id)
  ) ON [PRIMARY]

INSERT INTO CCSystem.SysObjectClasses
VALUES
 (0, 'None', N'None', N'None type for null object')
,(1, 'Entity', N'Entity', N'Entity')
,(2, 'Query', N'Query', N'Query')
,(3, 'EntityField', N'EntityField', N'EntityField')
,(4, 'QueryField', N'QueryField', N'QueryField')
,(5, 'Action', N'Action', N'Action')
,(6, 'CreateAction', N'CreateAction', N'Create object''s action') 
,(7, 'UpdateAction', N'UpdateAction', N'Update object''s action') 
,(8, 'DeleteAction', N'DeleteAction', N'Delete object''s action')
END
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SysObjects') AND type ='U'))
BEGIN
  CREATE TABLE CCSystem.SysObjects(
  	ObjectId int NOT NULL,
  	FieldId int NOT NULL CONSTRAINT DF_SysObjects_FieldId DEFAULT (0),
  	ClassId tinyint NOT NULL,
  	CodeName varchar(256) NOT NULL,
  	DisplayName nvarchar(256) NOT NULL,
  	Description nvarchar(256) NULL,
  
  	Guid uniqueidentifier NOT NULL,
  	DbObjectId int NULL,
  	DbFieldId int NULL,
  
    CONSTRAINT PK_SysObjects PRIMARY KEY CLUSTERED (ObjectId, FieldId),
  	CONSTRAINT UK_SysObjects_Guid UNIQUE NONCLUSTERED ([Guid]),
  	CONSTRAINT FK_SysObjects_SysObjectClasses FOREIGN KEY(ClassId)
       REFERENCES CCSystem.SysObjectClasses (Id) 
  ) ON [PRIMARY]

  CREATE INDEX [idx_Nonclustered_SysObjects_CodeName] ON [CCSystem].[SysObjects] ([CodeName])
    ON [PRIMARY]

  INSERT INTO CCSystem.SysObjects
  VALUES
  (0, 0, 0, 'null',N'null',
   N'This is a null object for make strong reference to Premissions table, used for mat to system and global permissions',
   '00000000-0000-0000-0000-000000000000', null, null)
END
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Users') AND type ='U'))
BEGIN
   CREATE TABLE CCSystem.Users(
   	Id int IDENTITY(1,1) NOT NULL,
   	AccountName nvarchar(100) NOT NULL,
   	DisplayName nvarchar(100) NOT NULL,
   	IsDeleted bit NOT NULL CONSTRAINT [DF_Users_IsDeleted] DEFAULT (0),
   	IsSystemUser bit NOT NULL CONSTRAINT [DF_Users_IsSystemUser] DEFAULT (0),
   	EMail nvarchar(100) NULL,
   	FullAccess bit NOT NULL CONSTRAINT DF_Users_FullAccess DEFAULT(0),
   	TerminationDate datetime NULL,
   	Description nvarchar(500) NULL,
   	PasswordHash varbinary (50) NULL,
   	IsEmailConfirmed bit NOT NULL CONSTRAINT DF_Users_IsEmailConfirmed DEFAULT(0),
    EmailToken varchar(50) NULL,
    CONSTRAINT PK_CcUsers PRIMARY KEY CLUSTERED(Id),
    CONSTRAINT UK_CcUsers_AccountName UNIQUE(AccountName)
   ) ON [PRIMARY]
  --Leave  Id = 1 for Admin account. See generated DomainInitialization.sql
  DBCC CHECKIDENT ('CCSystem.Users', RESEED, 2) WITH NO_INFOMSGS

END
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Roles') AND type ='U'))
   CREATE TABLE CCSystem.Roles(
   	Id int IDENTITY(1,1) NOT NULL,
   	Name nvarchar(400) NOT NULL,
   	Description nvarchar(500) NULL,
   
    CONSTRAINT PK_Role PRIMARY KEY CLUSTERED (Id),
    CONSTRAINT UK_Role_Name UNIQUE NONCLUSTERED (Name)
   ) ON [PRIMARY]
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.UserRoles') AND type ='U'))
   CREATE TABLE CCSystem.UserRoles(
   	Id int IDENTITY(1,1) NOT NULL,
   	UserId int NOT NULL,
   	RoleId int NOT NULL,
   
    CONSTRAINT PK_RoleUser PRIMARY KEY CLUSTERED(Id),
    CONSTRAINT UQ_RoleUser UNIQUE NONCLUSTERED(RoleId,	UserId),
    CONSTRAINT FK_RoleUser_Roles FOREIGN KEY(RoleId)
       REFERENCES CCSystem.Roles(Id)
       ON DELETE CASCADE,
    CONSTRAINT FK_RoleUser_Users FOREIGN KEY(UserId)
       REFERENCES CCSystem.Users(Id)
       ON DELETE CASCADE
   ) ON [PRIMARY]
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.PermissionTypes') AND type ='U'))
BEGIN
   CREATE TABLE CCSystem.PermissionTypes(
   	Id tinyint NOT NULL,
   	CodeName varchar(256) NOT NULL,
   	DisplayName nvarchar(256) NOT NULL,
   	Description nvarchar(256) NULL,
   	CONSTRAINT PK_PermissionTypes PRIMARY KEY CLUSTERED (Id)
   ) ON [PRIMARY]

  INSERT INTO CCSystem.PermissionTypes
  VALUES
   (1, 'System' , N'System', N'System permission')
  ,(2, 'Global' , N'Global', N'Global permission')
  ,(3, 'Create' , N'Create', N'Create entity permission')
  ,(4, 'Read'   , N'Read', N'Read entity\field permission')
  ,(5, 'Update' , N'Update', N'Update entity\field permission')
  ,(6, 'Delete' , N'Delete', N'Delete entity permission')
  ,(7, 'Execute', N'Execute', N'Execute action permission')
END
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.[Permissions]') AND type ='U'))
  CREATE TABLE CCSystem.[Permissions](
  	Id int NOT NULL,
  	Type tinyint NOT NULL,
  	CodeName varchar(256) NOT NULL,
    DisplayName nvarchar(256) NULL, --not null only for system and global
  	Description nvarchar(500) NULL, --not null only for system and global
  	ObjectId int NOT NULL,
  	FieldId int NOT NULL,
  	Guid uniqueidentifier NOT NULL,
    CONSTRAINT PK_Permissions PRIMARY KEY CLUSTERED (Id),
  	CONSTRAINT UK_Permissions_CodeName UNIQUE NONCLUSTERED (CodeName),
  	CONSTRAINT UK_Permissions_Guid UNIQUE NONCLUSTERED ([Guid]),
  	CONSTRAINT FK_Permissions_PermissionsTypes FOREIGN KEY(Type)
       REFERENCES CCSystem.PermissionTypes (Id),
  	CONSTRAINT FK_Permissions_Objects FOREIGN KEY(ObjectId, FieldId)
       REFERENCES CCSystem.SysObjects (ObjectId, FieldId) 
       ON UPDATE CASCADE 
       ON DELETE CASCADE
  ) ON [PRIMARY]
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.RolePermissions') AND type ='U'))
  CREATE TABLE CCSystem.RolePermissions(
  	Id int IDENTITY(1,1) NOT NULL,
  	RoleId int NOT NULL,
  	PermissionId int NOT NULL,
    CONSTRAINT PK_RolePermission PRIMARY KEY CLUSTERED (Id),
  	CONSTRAINT FK_RolePermission_Roles FOREIGN KEY(RoleId) 
       REFERENCES CCSystem.Roles (Id)
       ON DELETE CASCADE,
  	CONSTRAINT FK_RolePermission_Permissions FOREIGN KEY(PermissionId) 
  	   REFERENCES CCSystem.Permissions (Id) 
  		 ON UPDATE CASCADE
  		 ON DELETE CASCADE
  ) ON [PRIMARY]
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.ResetPasswordToken') AND type ='U'))
   CREATE TABLE [CCSystem].[ResetPasswordToken] (
   	[Id] int IDENTITY(1,1) not null,
   	[UserId] int not null,
   	[Token] varchar(50) not null,
   	[ValidFrom] datetimeoffset(7) not null,
   	[IsExecuted] bit not null CONSTRAINT DF_ResetPasswordToken_IsExecuted DEFAULT ((0)),
   	CONSTRAINT [PK_ResetPasswordToken] PRIMARY KEY CLUSTERED ([Id]),
   	CONSTRAINT [FK_ResetPasswordToken_Users] FOREIGN KEY([UserId])
   	   REFERENCES [CCSystem].[Users] ([Id])
   		 ON UPDATE CASCADE
   		 ON DELETE CASCADE
   ) ON [PRIMARY]
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.RefreshToken') AND type ='U'))
   CREATE TABLE [CCSystem].[RefreshToken] (
   	[UserId] int NOT NULL,
    [ClientId] varchar(255) NOT NULL,
   	[Token]  varchar(255) NOT NULL,
   	[ExpiresUtc] datetimeoffset(7) NOT NULL,
   	CONSTRAINT [PK_RefreshToken] PRIMARY KEY CLUSTERED (UserId, ClientId),
   	CONSTRAINT [FK_RefreshToken_Users] FOREIGN KEY([UserId])
   	   REFERENCES [CCSystem].[Users] ([Id])
   		 ON UPDATE CASCADE
   		 ON DELETE CASCADE
   ) ON [PRIMARY]
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.ObjectTypes') AND type ='U'))
   CREATE TABLE CCSystem.ObjectTypes(
   	Id int IDENTITY(1,1) NOT NULL,
   	Name nvarchar(50) NOT NULL,
    CONSTRAINT PK_ObjectTypes PRIMARY KEY CLUSTERED (Id)
   ) ON [PRIMARY]
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Files') AND type ='U'))
  CREATE TABLE CCSystem.Files(
    Id int IDENTITY(1, 1)
   ,FileName nvarchar(256) NOT NULL
   ,Length bigint NOT NULL
   ,CreateDate datetimeoffset NOT NULL CONSTRAINT [DF_CCSystem_Files_CreateDate] DEFAULT (getdate())
   ,StorageName varchar(25) NOT NULL
   ,StorageLink nvarchar(500) NOT NULL
   ,ObjectId int
   ,FieldId int
   ,SysUserId int NULL
   ,CONSTRAINT [PK_CCSystem_Files] PRIMARY KEY (ID)
   ,CONSTRAINT FK_CCSystem_Files_Objects FOREIGN KEY(ObjectId, FieldId) 
          REFERENCES CCSystem.SysObjects (ObjectId, FieldId) 
          ON UPDATE CASCADE 
          ON DELETE SET NULL
  ) ON [PRIMARY]
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.OperationLocks') AND type ='U'))
   CREATE TABLE CCSystem.OperationLocks(
   	OperationName nvarchar(200) NOT NULL,
   	OperationContext nvarchar(200) NOT NULL,
   	UserId int NOT NULL,
   	MachineName nvarchar(200) NULL,
   	ProcessId int NULL,
   	AquiredTime datetime NOT NULL,
   	ExpirationTime datetime NOT NULL,
    CONSTRAINT PK_OperationLock PRIMARY KEY CLUSTERED (OperationName, OperationContext),
    CONSTRAINT FK_OperationLocks_Users FOREIGN KEY(UserId)
       REFERENCES CCSystem.Users (Id)
   ) ON [PRIMARY]
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SettingProperties') AND type ='U'))
BEGIN
  CREATE TABLE CCSystem.SettingProperties(
  	Id int IDENTITY(1,1) NOT NULL,
  	Name varchar(50) NOT NULL,
  	IsManaged bit NOT NULL,
  	Description nvarchar(256) NULL,
  	UIEditorType nvarchar(256) NULL,
  	GroupName nvarchar(256) NULL,
  	IsOverridable bit NOT NULL  CONSTRAINT DF_SettingProperties_IsOverridable DEFAULT (1),
  	DefaultType nvarchar(256) NULL,
   CONSTRAINT PK_SettingProperties PRIMARY KEY CLUSTERED (Id),
   CONSTRAINT UK_SettingProperties_Group_Name UNIQUE NONCLUSTERED (GroupName, Name)
  ) ON [PRIMARY]
  
  INSERT CCSystem.SettingProperties (Name, IsManaged, Description, UIEditorType, GroupName, IsOverridable, DefaultType) 
  VALUES 
 (N'IntegratedSecurity', 0,  NULL, NULL, NULL, 0, N'System.Boolean')
,(N'ExplorerBarStyle', 1, N'Select navigation bar style', 'BusinessFramework.Client.Controls.PropertyGridEx.UIEnumEditor, BusinessFramework.Client', 'Appearance', 1, 'BusinessFramework.Client.Explorer.ExplorerBarStyles, BusinessFramework.Client')
,(N'ExplorerBarConfiguration', 0,  NULL, NULL, NULL, 1, NULL)
,(N'AutoRefreshPeriodInHours', 1, N'Period of time in hours in witch application refreshes the data.', NULL, N'System', 1, N'System.Int32')
,(N'NotifyBeforeRefresh', 1, N'Show notification before auto refresh the data.', NULL, N'System', 1, N'System.Boolean')
,(N'ApplicationStyle', 1, N'Select a visual style of application.', N'BusinessFramework.Client.Controls.PropertyGridEx.UIAppStyleEditor, BusinessFramework.Client', N'Appearance', 1, N'System.String')
,(N'RequiredFieldColor', 1, N'Please select control color for required field.', NULL, N'Appearance', 1, N'System.Drawing.Color, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a')
,(N'RequiredTabColor', 0, N'Please select tab color if required fields are present on the tab.', NULL, N'Appearance', 1, N'System.Drawing.Color, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a')
,(N'InvalidTabColor', 0, N'Please select tab color if invalid fields are present.', NULL, N'Appearance', 1, N'System.Drawing.Color, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a')
,(N'LastView', 0, NULL, NULL, NULL, 1, N'System.String')
,(N'GridSettingsCollection', 0, N'', NULL, N'', 1, NULL)
,(N'SmtpHost', 0, N'Contains the name or IP address of the host used for SMTP transactions.', NULL, N'E-mail Notifier', 1, N'System.String')
,(N'SmtpUserName', 0, NULL, NULL, N'E-mail Notifier', 1, N'System.String')
,(N'SmtpUserPassword', 0, NULL, NULL, N'E-mail Notifier', 1, N'System.String')
,(N'SmtpNotificationsEnabled', 0, N'Indicates whether SMTP e-mail notifier is enabled. If SMTP nitifier is disabled then default email client is used to send mail.', NULL, N'E-mail Notifier', 1, N'System.Boolean')
,(N'CurrencyFormat', 1, N'Please select currency format to represent currency fields.', N'BusinessFramework.Client.Controls.PropertyGridEx.UICurrencyFormatEditor, BusinessFramework.Client', N'System', 0, N'System.String')
,(N'HierarchicalColumnChooser', 0, N'Show hierarchical column chooser tab in column chooser dialog.', NULL, N'Appearance', 1, N'System.Boolean')
,(N'MailRecipients', 0, N'Address collection that contains the recipients of e-mail notifications.', NULL, N'E-mail Notifier', 0, N'System.String')
,(N'SmtpPort', 0, N'Contains the port to be used on host. Zero indicates that port is ignored.', NULL, N'E-mail Notifier', 0, N'System.Int32')
,(N'SmtpSenderAddress', 0, N'Smtp Sender Address', NULL, N'E-mail Notifier', 0, N'System.String')
,(N'NotifyBeforeClose', 1, N'Show notification before close application', NULL, N'System', 1, N'System.Boolean')
--Reporting
,(N'ReportsPath', 1, N'Please select path to reports. Application would automatically cache reports from this folder. If blank installed reports would be used.', N'System.Windows.Forms.Design.FolderNameEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a', N'Reporting', 1, N'System.String')
,(N'FakeReportData', 0, N'Fake Report Data', NULL, N'Reporting', 1, N'System.Boolean')
,(N'ReportSystemReadOnly', 1, N'Can change reporting system 2.0 reports', NULL, N'Reporting', 1, N'System.Boolean')
,(N'ReportSystemDestinationDirectory', 1, N'Application would save reports result to this folder. If blank reports results would be saved to %USER_DOCUMENTS%\Reports folder.', N'System.Windows.Forms.Design.FolderNameEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a', N'Reporting', 1, N'System.String')
,(N'ReportOutputDirectory', 0, N'Recent report output directory', NULL, N'Reporting', 1, N'System.String')
,(N'ReportOutputFile', 0, N'Recent report output ????', NULL, N'Reporting', 1, N'System.String')
,(N'ReportBookOutputDirectory', 0, NULL, NULL, N'Reporting', 1, N'System.String')
,(N'ReportBookOutputFile', 0, NULL, NULL, N'Reporting', 1, N'System.String')
,(N'BookSeparatedReportOutputDirectory', 0, NULL, NULL, N'Reporting', 1, N'System.String')
,(N'BookSeparatedReportOutputFile', 0, NULL, NULL, N'Reporting', 1, N'System.String')
,(N'WatermarkReport', 0, N'Watermark for reports.', NULL, N'Reporting', 1, N'System.String')
,(N'ReportUseCommonFolderForAllModules', 0, N'One common folder for all modules otherwise each module has own sub folder', NULL, N'Reporting', 0, N'System.Boolean')
END
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.Settings') AND type ='U'))
BEGIN   
   CREATE TABLE CCSystem.Settings(
   	Id int IDENTITY(1,1) NOT NULL,
   	SettingPropertyId int NOT NULL,
   	UserId int NULL,
   	Value nvarchar(max) NULL,
    CONSTRAINT PK_Settings PRIMARY KEY CLUSTERED (Id),
    CONSTRAINT UK_Settings_User_Property UNIQUE NONCLUSTERED (UserId, SettingPropertyId),
    CONSTRAINT FK_Settings_SettingProperties FOREIGN KEY(SettingPropertyId)
       REFERENCES CCSystem.SettingProperties (Id)
       ON UPDATE CASCADE
       ON DELETE CASCADE,
    CONSTRAINT FK_Settings_Users FOREIGN KEY(UserId)
       REFERENCES CCSystem.Users (Id)
   	   ON DELETE CASCADE
   ) ON [PRIMARY]
   
  INSERT CCSystem.Settings (SettingPropertyId, Value) 
  SELECT Id, N'False' FROM CCSystem.SettingProperties WHERE Name = 'IntegratedSecurity'
  UNION ALL
  SELECT Id, N'DefaultStyle' FROM CCSystem.SettingProperties WHERE Name = 'ExplorerBarStyle'
  UNION ALL
  SELECT Id, N'10' FROM CCSystem.SettingProperties WHERE Name = 'ObjectEditLockUpdateTime'
  UNION ALL
  SELECT Id, N'LightBlue' FROM CCSystem.SettingProperties WHERE Name = 'RequiredFieldColor'
  UNION ALL
  SELECT Id, N'########0.00' FROM CCSystem.SettingProperties WHERE Name = 'CurrencyFormat'
  UNION ALL
  SELECT Id, N'True' FROM CCSystem.SettingProperties WHERE Name = 'ReportSystemReadOnly'
  UNION ALL
  SELECT Id, N'True' FROM CCSystem.SettingProperties WHERE Name = 'ReportUseCommonFolderForAllModules'
END
GO
--endregion

--region Table migrations

--region Migration 1.0.0.9 -> 1.0.0.10
GO
IF (EXISTS(SELECT * FROM CCSystem.Info WHERE SystemVersion = '1.0.0.9'))
BEGIN
	SET NOEXEC OFF
	PRINT 'Run CCSystem migration from 1.0.0.9 to 1.0.0.10'
END
ELSE
	SET NOEXEC ON
GO
GO
ALTER TABLE CCSystem.Info
 ADD CONSTRAINT PK_SystemInfo PRIMARY KEY CLUSTERED (SystemVersion, DomainVersion, LastInitialization)
GO
--End migration
UPDATE CCSystem.Info SET SystemVersion = '1.0.0.10', LastInitialization = getdate()
GO
SET NOEXEC OFF
GO
--endregion
GO
--region Migration 1.0.0.10 -> 1.0.0.11
IF (EXISTS(SELECT * FROM CCSystem.Info WHERE SystemVersion = '1.0.0.10'))
BEGIN
	SET NOEXEC OFF
	PRINT 'Run CCSystem migration from 1.0.0.10 to 1.0.0.11'
END
ELSE
	SET NOEXEC ON
GO

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.AddActionLogEntry') AND type IN ('P')))
 DROP PROCEDURE [CCSystem].[AddActionLogEntry]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.AddLogEntry') AND type IN ('P')))
 DROP PROCEDURE [CCSystem].[AddLogEntry]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.AddLogPropertyChange') AND type IN ('P')))
 DROP PROCEDURE [CCSystem].[AddLogPropertyChange]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetActionLogEntries') AND type IN ('P')))
 DROP PROCEDURE [CCSystem].[GetActionLogEntries]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetDataAnalyseProcedures') AND type IN ('P')))
 DROP PROCEDURE [CCSystem].[GetDataAnalyseProcedures]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetLogEntries') AND type IN ('P')))
 DROP PROCEDURE [CCSystem].[GetLogEntries]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GetLogPropertyChanges') AND type IN ('P')))
 DROP PROCEDURE [CCSystem].[GetLogPropertyChanges]

IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.ActionLogEntries') AND type IN ('U')))
 DROP TABLE [CCSystem].[ActionLogEntries]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.ActionLog') AND type IN ('U')))
 DROP TABLE [CCSystem].[ActionLog]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.DataAnalysers') AND type IN ('U')))
 DROP TABLE [CCSystem].[DataAnalysers]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.GridFilters') AND type IN ('U')))
 DROP TABLE [CCSystem].[GridFilters]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.LogPropertyChanges') AND type IN ('U')))
 DROP TABLE [CCSystem].[LogPropertyChanges]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.LogEntries') AND type IN ('U')))
 DROP TABLE [CCSystem].[LogEntries]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.LogProperties') AND type IN ('U')))
 DROP TABLE [CCSystem].[LogProperties]
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.LogActionTypes') AND type IN ('U')))
 DROP TABLE [CCSystem].[LogActionTypes]
GO
ALTER TABLE [CCSystem].[Users] 
ADD [IsAnonymous] bit NOT NULL CONSTRAINT [DF_Users_IsAnonymous] DEFAULT 0
GO
-- Create anonymous user
SET IDENTITY_INSERT CCSystem.Users ON
INSERT [CCSystem].[Users] ([Id], [AccountName], [DisplayName], [IsSystemUser], 
[PasswordHash], [FullAccess],[IsAnonymous])
VALUES 
(-1, N'Anonymous', N'Anonymous', 1, null, 0, 1)
SET IDENTITY_INSERT CCSystem.Users OFF
GO
ALTER TABLE [CCSystem].[Roles] 
ADD [IsSystem] bit NOT NULL CONSTRAINT [DF_Roles_IsSystem] DEFAULT 0
GO
ALTER TABLE CCSystem.Roles
ADD [OwnerUserID] int NULL, IsOwnByUser bit NOT NULL CONSTRAINT [DF_Roles_IsOwnByUser] DEFAULT (0) 
GO
ALTER TABLE [CCSystem].[Roles] DROP CONSTRAINT [UK_Role_Name]
GO
ALTER TABLE [CCSystem].[Roles] 
ADD CONSTRAINT [UK_Role_Name_IsOwnByUser] UNIQUE ([Name], [IsOwnByUser])
GO
ALTER TABLE CCSystem.Roles
ADD CONSTRAINT [FK_Roles_Users_Owner] 
 FOREIGN KEY (OwnerUserID) REFERENCES CCSystem.Users(Id)
GO
--Rename existed role with Public name 
IF(EXISTS(SELECT * FROM CCSystem.Roles WHERE Name = 'Public'))
UPDATE CCSystem.Roles
SET Name = 'Public(Old)'
WHERE Name = 'Public'
SET IDENTITY_INSERT CCSystem.Roles ON
-- Insert Public role
INSERT INTO CCSystem.Roles
(Id, [Name], [Description], [IsSystem]) 
VALUES (-1, 'Registered', 'This role would be automatically assigned for each newly created user', 1)
--Insert anonymous user owned role
INSERT INTO CCSystem.Roles
(Id, [Name], [Description], [IsSystem], OwnerUserID, IsOwnByUser) 
VALUES (-2, 'Anonymous', 'This role would be used for non-authenticated users', 1, -1, 1)
SET IDENTITY_INSERT CCSystem.Roles OFF
GO
--Rename conflict roles
UPDATE  r
SET Name = Name + '(Old)'
FROM CCSystem.Roles r
INNER JOIN CCSystem.Users u ON u.AccountName = r.Name
WHERE u.IsSystemUser = 0
GO
--Insert user owned roles
INSERT INTO CCSystem.Roles
([Name], [Description], [IsSystem], OwnerUserID, IsOwnByUser) 
SELECT  u.AccountName, null, u.IsSystemUser, u.Id, 1
FROM CCSystem.Users u WHERE u.Id > 0 --exclude anonymous
GO
--Put users to user's roles
INSERT INTO CCSystem.UserRoles
(UserId, RoleId)
SELECT r.OwnerUserID, r.Id
FROM CCSystem.Roles r WHERE r.IsOwnByUser = 1
GO
--Put users to Public role
INSERT INTO CCSystem.UserRoles
(UserId, RoleId)
SELECT u.Id, -1
FROM CCSystem.Users u WHERE u.IsSystemUser = 0
GO
IF (EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.SysObjectTypes') AND type ='U'))
BEGIN
  ALTER TABLE CCSystem.SysObjects
   DROP FK_SysObjects_ObjectTypes

  EXECUTE sys.sp_rename @objname = N'CCSystem.SysObjects.Type', @newname = N'ClassId', @objtype = 'COLUMN' 
 
  ALTER TABLE CCSystem.SysObjects
  ADD CONSTRAINT FK_SysObjects_SysObjectClasses FOREIGN KEY(ClassId)
       REFERENCES CCSystem.SysObjectClasses (Id)

 DROP TABLE CCSystem.SysObjectTypes 
END
GO
---------------------------------------------
EXEC('DECLARE @MaxObjId int
SELECT @MaxObjId = MAX(ObjectId) FROM CCSystem.SysObjects
UPDATE CCSystem.SysObjects
SET FieldId = FieldId + @MaxObjId
WHERE FieldId != 0

SELECT fk.Name AS FKName,
       SCHEMA_NAME(so.schema_id) AS TableSchema,
       so.name AS TableName,
       SCHEMA_NAME(so_ref.schema_id) AS RefTableSchema,
       so.name AS RefTableName
INTO CCSystem.RefSysObjects
FROM sys.foreign_keys fk
INNER JOIN sys.objects so ON fk.parent_object_id = so.object_id
INNER JOIN sys.objects so_ref ON fk.referenced_object_id = so_ref.object_id
WHERE fk.referenced_object_id = OBJECT_ID(''CCSystem.SysObjects'')')
GO
DECLARE @SQL varchar(max) = ''
SELECT @SQL = @SQL + 'ALTER TABLE [' + TableSchema + '].[' + TableName + '] DROP CONSTRAINT [' + RTRIM(FKName) +']' + CHAR(10) + CHAR(13)
FROM CCSystem.RefSysObjects
ORDER BY TableSchema, TableName, FKName
EXEC (@SQL)
GO
DELETE FROM CCSystem.RefSysObjects WHERE TableSchema = N'CCSystem'
GO
DECLARE @SQL varchar(max) = ''
SELECT @SQL = @SQL +
'UPDATE t SET ObjectId = CASE WHEN t.FieldId = 0 THEN t.ObjectId ELSE t.FieldId END FROM [' + TableSchema + '].[' + TableName + '] t' + CHAR(10) + CHAR(13)
FROM CCSystem.RefSysObjects
ORDER BY TableSchema, TableName
EXEC (@SQL)
GO
DECLARE @SQL varchar(max) = ''
SELECT @SQL=@SQL + 'ALTER TABLE [' + TableSchema + '].[' + TableName + '] DROP COLUMN FieldId ' + CHAR(10) + CHAR(13)
FROM CCSystem.RefSysObjects
ORDER BY TableSchema, TableName
EXEC (@SQL)
GO
EXEC('UPDATE t
SET FieldId = CASE WHEN t.FieldId = 0 THEN t.ObjectId ELSE t.FieldId END
FROM [CCSystem].[Files] t')
GO
EXEC('ALTER TABLE [CCSystem].[Files] DROP COLUMN ObjectId')
GO
EXEC('UPDATE t
SET ObjectId = CASE WHEN t.FieldId = 0 THEN t.ObjectId ELSE t.FieldId END
FROM [CCSystem].[Permissions] t')
GO
EXEC('ALTER TABLE [CCSystem].[Permissions] DROP COLUMN FieldId')
GO
---
ALTER TABLE [CCSystem].[SysObjects] 
DROP CONSTRAINT [PK_SysObjects]
GO
ALTER TABLE [CCSystem].[SysObjects] 
DROP CONSTRAINT [DF_SysObjects_FieldId]
GO
ALTER TABLE [CCSystem].[SysObjects] 
DROP CONSTRAINT [UK_SysObjects_Guid]
GO
ALTER TABLE [CCSystem].[SysObjects] 
DROP CONSTRAINT [FK_SysObjects_SysObjectClasses]
GO
EXEC sys.sp_rename @objname = N'[CCSystem].[SysObjects]', @newname = [SysObjects_old], @objtype = N'OBJECT';
GO
--
CREATE TABLE [CCSystem].[SysObjects] (
[Id] int NOT NULL,
[ParentId] int NOT NULL,
[ClassId] tinyint NOT NULL,
[CodeName] varchar(256) NOT NULL,
[DisplayName] nvarchar(256) NOT NULL,
[Description] nvarchar(256) NULL,
[Guid] uniqueidentifier NOT NULL,
[DbObjectId] int NULL,
[DbFieldId] int NULL,
CONSTRAINT [PK_SysObjects] PRIMARY KEY CLUSTERED ([Id]),
CONSTRAINT [UK_SysObjects_Guid] UNIQUE NONCLUSTERED ([Guid]),
CONSTRAINT [FK_SysObjects_SysObjectClasses] FOREIGN KEY (ClassId)
  REFERENCES CCSystem.SysObjectClasses (Id)
--,CONSTRAINT [FK_CCSystem_SysObjects_Objects_Parent] FOREIGN KEY (ParentId)
--  REFERENCES CCSystem.SysObjects(Id)
) ON [PRIMARY]
GO
INSERT INTO CCSystem.SysObjects
      (Id, ParentId, t.ClassId, t.CodeName, t.DisplayName, t.[Description], t.Guid, t.DbObjectId, t.DbFieldId)
SELECT CASE WHEN t.FieldId = 0 THEN t.ObjectId ELSE t.FieldId END Id,
  CASE WHEN t.FieldId = 0 THEN 0 ELSE t.ObjectId END ParentId, 
  t.ClassId, t.CodeName, t.DisplayName, t.[Description], t.Guid, t.DbObjectId, t.DbFieldId 
FROM CCSystem.SysObjects_old t
GO
DROP TABLE CCSystem.SysObjects_old
GO
ALTER TABLE CCSystem.Files 
ADD CONSTRAINT [FK_CCSystem_Files_Objects]
FOREIGN KEY ([FieldId])
REFERENCES [CCSystem].[SysObjects] (Id)
ON DELETE SET NULL
ON UPDATE CASCADE
GO
ALTER TABLE CCSystem.Permissions 
ADD CONSTRAINT [FK_CCSystem_Permissions_Objects]
FOREIGN KEY ([ObjectId])
REFERENCES [CCSystem].[SysObjects] (Id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO
DECLARE @SQL varchar(max) = ''
SELECT @SQL = @SQL + 'ALTER TABLE [' + TableSchema + '].[' + TableName + '] ADD CONSTRAINT [' + RTRIM(FKName) +']' + 
' FOREIGN KEY ([ObjectId]) REFERENCES [CCSystem].[SysObjects] (Id) ON DELETE CASCADE ON UPDATE CASCADE'
+ CHAR(10) + CHAR(13)
FROM CCSystem.RefSysObjects
WHERE RefTableSchema != 'CCSystem'
ORDER BY TableSchema, TableName, FKName
EXEC (@SQL)
GO
DROP TABLE CCSystem.RefSysObjects
GO
GO
CREATE TABLE [CCSystem].[OperationResult](
   [Id] tinyint NOT NULL,
   [Name] sysname NOT NULL,
   CONSTRAINT PK_CCSystem_OperationResult PRIMARY KEY CLUSTERED (Id))
GO
INSERT INTO [CCSystem].[OperationResult]
VALUES
 (1, 'Success'),
 (2, 'Failed'),
 (3, 'Unauthorized')
GO
CREATE TABLE [CCSystem].[Operation](
   [Id] bigint IDENTITY(1, 1) NOT NULL,
   [UserID] int NOT NULL,
   [Date] datetime NOT NULL,
   [ActionId] int NOT NULL,
   [Request] nvarchar(4000) NULL,
   [RequestContent] nvarchar(4000) NULL,
   [OperationResultId] tinyint NOT NULL,
   [OperationDetails] nvarchar(4000) NULL,
   CONSTRAINT PK_CCSystem_Operation PRIMARY KEY CLUSTERED (Id),
   CONSTRAINT FK_CCSystem_Operation_Users FOREIGN KEY(UserId) 
    REFERENCES CCSystem.Users (Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
   CONSTRAINT FK_CCSystem_Operation_SysObjects FOREIGN KEY(ActionId) 
    REFERENCES CCSystem.SysObjects(Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
    CONSTRAINT FK_CCSystem_Operation_OperationResult FOREIGN KEY(OperationResultId) 
    REFERENCES CCSystem.OperationResult (Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
    )
GO
--End migration
UPDATE CCSystem.Info SET SystemVersion = '1.0.0.11', LastInitialization = getdate()
GO
SET NOEXEC OFF
GO
--endregion
GO
--region Migration 1.0.0.11 -> 1.0.0.12
IF (EXISTS(SELECT * FROM CCSystem.Info WHERE SystemVersion = '1.0.0.11'))
BEGIN
	SET NOEXEC OFF
	PRINT 'Run CCSystem migration from 1.0.0.11 to 1.0.0.12'
END
ELSE
	SET NOEXEC ON
GO

IF (NOT EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CCSystem.RefreshToken') AND type ='U'))
   CREATE TABLE [CCSystem].[RefreshToken] (
   	[UserId] int NOT NULL,
    [ClientId] varchar(255) NOT NULL,
   	[Token]  varchar(255) NOT NULL,
   	[ExpiresUtc] datetimeoffset(7) NOT NULL,
   	CONSTRAINT [PK_RefreshToken] PRIMARY KEY CLUSTERED (UserId, ClientId),
   	CONSTRAINT [FK_RefreshToken_Users] FOREIGN KEY([UserId])
   	   REFERENCES [CCSystem].[Users] ([Id])
   		 ON UPDATE CASCADE
   		 ON DELETE CASCADE
   ) ON [PRIMARY]
GO
--End migration
UPDATE CCSystem.Info SET SystemVersion = '1.0.0.12', LastInitialization = getdate()
GO
SET NOEXEC OFF
GO
--endregion
GO
--region Migration 1.0.0.12 -> 1.0.0.13
IF (EXISTS(SELECT * FROM CCSystem.Info WHERE SystemVersion = '1.0.0.12'))
BEGIN
	SET NOEXEC OFF
	PRINT 'Run CCSystem migration from 1.0.0.12 to 1.0.0.13'
END
ELSE
	SET NOEXEC ON
GO
ALTER TABLE CCSystem.Users
ADD CreateDate datetime2 NOT NULL CONSTRAINT [DF_CCSystem_Users_CreateDate] DEFAULT (getdate())
GO
--End migration
UPDATE CCSystem.Info SET SystemVersion = '1.0.0.13', LastInitialization = getdate()
GO
SET NOEXEC OFF
GO
--endregion
GO
--region Migration 1.0.0.13 -> 1.0.0.14
IF (EXISTS(SELECT * FROM CCSystem.Info WHERE SystemVersion = '1.0.0.13'))
BEGIN
	SET NOEXEC OFF
	PRINT 'Run CCSystem migration from 1.0.0.13 to 1.0.0.14'
END
ELSE
	SET NOEXEC ON
GO
ALTER TABLE CCSystem.Users
ADD    TerminationAccountName nvarchar(100) NULL,
   	   TerminationDisplayName nvarchar(100) NULL,
   	   TerminationEMail nvarchar(100) NULL
GO
--End migration
UPDATE CCSystem.Info SET SystemVersion = '1.0.0.14', LastInitialization = getdate()
GO
SET NOEXEC OFF
GO
--endregion
GO
--region Migration 1.0.0.14 -> 1.0.0.15
IF (EXISTS(SELECT * FROM CCSystem.Info WHERE SystemVersion = '1.0.0.14'))
BEGIN
	SET NOEXEC OFF
	PRINT 'Run CCSystem migration from 1.0.0.14 to 1.0.0.15'
END
ELSE
	SET NOEXEC ON
GO
--Rename predefined users and roles
UPDATE [CCSystem].[Users]
SET [AccountName] = N'Anonymous', [DisplayName] = N'Anonymous'
WHERE [Id] = -1
GO
UPDATE [CCSystem].[Roles]
SET [Name] = N'Registered', [Description] = N'This role would be automatically assigned for each newly created user'
WHERE [Id] = -1
GO
UPDATE [CCSystem].[Roles]
SET [Name] = N'Anonymous', [Description] = N'This role would be used for non-authenticated users'
WHERE [Id] = -2
GO
--End migration
UPDATE CCSystem.Info SET SystemVersion = '1.0.0.15', LastInitialization = getdate()
GO
SET NOEXEC OFF
GO
--endregion
GO
--region Migration 1.0.0.15 -> 1.0.0.16
IF (EXISTS(SELECT * FROM CCSystem.Info WHERE SystemVersion = '1.0.0.15'))
BEGIN
	SET NOEXEC OFF
	PRINT 'Run CCSystem migration from 1.0.0.15 to 1.0.0.16'
END
ELSE
	SET NOEXEC ON
GO
ALTER TABLE CCSystem.Users
DROP COLUMN  TerminationAccountName, TerminationDisplayName, TerminationEMail
GO
EXECUTE sys.sp_rename @objname = N'[CCSystem].[Users].[TerminationDate]', @newname = N'DeactivationDate', @objtype = 'COLUMN'
GO
EXECUTE sys.sp_rename @objname = N'[CCSystem].[Users].[IsDeleted]', @newname = N'IsDeactivated', @objtype = 'COLUMN'
GO
IF (OBJECT_ID('[CCSystem].[DF_Users_IsDeleted]') IS NOT NULL)
  ALTER TABLE [CCSystem].[Users] 
    DROP CONSTRAINT [DF_Users_IsDeleted];
GO
ALTER TABLE [CCSystem].[Users] ADD CONSTRAINT [DF_CCSystem_Users_IsDeactivated] DEFAULT (0) FOR [IsDeactivated]
GO

--End migration
UPDATE CCSystem.Info SET SystemVersion = '1.0.0.16', LastInitialization = getdate()
GO
SET NOEXEC OFF
GO
--endregion

--region Migration 1.0.0.16 -> 1.0.0.17
IF (EXISTS(SELECT * FROM CCSystem.Info WHERE SystemVersion = '1.0.0.16'))
BEGIN
	SET NOEXEC OFF
	PRINT 'Run CCSystem migration from 1.0.0.16 to 1.0.0.17'
END
ELSE
	SET NOEXEC ON
GO

ALTER TABLE [CCSystem].[Roles]
DROP CONSTRAINT [UK_Role_Name_IsOwnByUser]
GO

ALTER TABLE CCSystem.Roles
ALTER COLUMN Name nvarchar(400) NOT NULL
GO

ALTER TABLE CCSystem.Roles
ALTER COLUMN Description nvarchar(500) NULL
GO

ALTER TABLE [CCSystem].[Roles]
ADD CONSTRAINT [UK_Role_Name_IsOwnByUser] UNIQUE ([Name], [IsOwnByUser])
GO

ALTER TABLE CCSystem.Users
ALTER COLUMN Description nvarchar(500) NULL
GO

--End migration
UPDATE CCSystem.Info SET SystemVersion = '1.0.0.17', LastInitialization = getdate()
GO
SET NOEXEC OFF
GO
--endregion

--region **********************************    UDT     *************************************
GO
CREATE TYPE CCSystem.PermissionsUDT AS TABLE (
	Id int NOT NULL,
	Type tinyint NOT NULL,
	CodeName varchar(256) NOT NULL,
  DisplayName nvarchar(256) NULL, --not null only for system and global
	Description nvarchar(500) NULL, --not null only for system and global
	ObjectId int NOT NULL,
	Guid uniqueidentifier NOT NULL,
  PRIMARY KEY (Id),
	UNIQUE ([Guid])
)
GO

GO
CREATE TYPE CCSystem.SysObjectsUDT AS TABLE (
	Id int NOT NULL,
	ParentId int NOT NULL DEFAULT (0),
	ClassId tinyint NOT NULL,
	CodeName varchar(256) NOT NULL,
	DisplayName nvarchar(256) NOT NULL,
	Description nvarchar(256) NULL,

	Guid uniqueidentifier NOT NULL,

	DbObjectId int NULL,
	DbFieldId int NULL,

  PRIMARY KEY (Id),
	UNIQUE([Guid])
)
GO


GO
CREATE TYPE CCSystem.SysObjectsUpdateUDT AS TABLE (
	Id int NOT NULL,
	ParentId int NOT NULL DEFAULT (0),
	ClassId tinyint NOT NULL,
	CodeName varchar(256) NOT NULL,
	DisplayName nvarchar(256) NOT NULL,
	Description nvarchar(256) NULL,

	Guid uniqueidentifier NOT NULL,

	DbObjectSchemaName sysname NULL,
	DbObjectName sysname NULL,
	DbFieldName sysname NULL,

    PRIMARY KEY (Id),
	UNIQUE([Guid])
)
GO
--endregion

--region**************************       Views     *******************************
GO
CREATE VIEW CCSystem.UserPermissionsDisplayView
AS
SELECT
t.UserId,
t.PermissionId,
t.PermissionName,
STUFF((SELECT ', ' + r.Name  AS [text()]
            FROM CCSystem.UserRoles ur
            INNER JOIN CCSystem.Roles r ON r.Id = ur.RoleId
            INNER JOIN CCSystem.RolePermissions rp ON rp.RoleId = r.Id
            WHERE ur.UserId = t.UserId AND rp.PermissionId = t.PermissionId
            ORDER BY r.IsOwnByUser DESC, r.Name
            For XML PATH ('')
        ), 1, 2, '') [Roles]
FROM
(SELECT DISTINCT
  ur.UserId,
  rp.PermissionId,
  p.DisplayName AS PermissionName
FROM CCSystem.UserRoles ur
INNER JOIN CCSystem.Roles r ON r.Id = ur.RoleId
INNER JOIN CCSystem.RolePermissions rp ON rp.RoleId = r.Id
INNER JOIN CCSystem.Permissions p ON p.Id = rp.PermissionId) t
GO
CREATE VIEW CCSystem.UsersDisplayView
AS
SELECT 
 u.Id, 
 r.Id AS UserRoleId  
FROM CCSystem.Users u
LEFT JOIN CCSystem.Roles r ON u.Id = r.OwnerUserID
GO
--endregion

--region ****************************** Functions *******************************

GO
CREATE FUNCTION CCSystem.GetSysObjectId(@ObjectCodeName sysname)
RETURNS int
    BEGIN 
        DECLARE @ObjectId int

        SELECT @ObjectId = o.Id
        FROM CCSystem.SysObjects o WHERE o.CodeName = @ObjectCodeName AND o.ClassId IN (1, 2)
        RETURN @ObjectId
    END
GO
CREATE FUNCTION CCSystem.GetSysFieldId(@ObjectCodeName sysname, @FieldCodeName sysname)
RETURNS int
    BEGIN 
        DECLARE @FieldId int

        SELECT @FieldId = f.Id 
        FROM CCSystem.SysObjects o 
        INNER JOIN CCSystem.SysObjects f ON o.Id = f.ParentId  
        WHERE o.CodeName = @ObjectCodeName AND f.CodeName = @FieldCodeName 

        RETURN @FieldId
    END
GO
CREATE FUNCTION CCSystem.HasPermission(@userId int, @permissionName varchar(256))
RETURNS bit
AS
BEGIN
IF(EXISTS(SELECT su.Id  
          FROM CCSystem.Users su
          INNER JOIN CCSystem.UserRoles sur ON su.Id = sur.UserId
          INNER JOIN CCSystem.RolePermissions srp ON sur.RoleId = srp.RoleId
          INNER JOIN CCSystem.Permissions sp ON srp.PermissionId = sp.Id
          WHERE su.Id = @userId AND (su.FullAccess = 1 OR sp.CodeName = @permissionName)))
  RETURN 1
RETURN 0
END
GO
--endregion

--region ****************************** Procedures *******************************

GO
--Based on http://www.codeproject.com/Articles/489617/CreateplusaplusCursorplususingplusDynamicplusSQLpl
CREATE PROCEDURE CCSystem.CreateGenericCursor(@vQuery nvarchar(MAX),@Cursor cursor varying OUTPUT)
AS
BEGIN
    SET NOCOUNT ON
    
    DECLARE 
        @vSQL AS nvarchar(max)
    
    SET @vSQL = 'SET @Cursor = CURSOR FORWARD_ONLY STATIC FOR ' + @vQuery + ' OPEN @Cursor;'
    
   
    EXEC sp_executesql
         @vSQL
         ,N'@Cursor cursor output'  
         ,@Cursor OUTPUT;
END 
GO


GO
--Copied from https://www.simple-talk.com/sql/t-sql-programming/reading-and-writing-files-in-sql-server-using-t-sql/
CREATE PROCEDURE CCSystem.WriteStringToFile (@path varchar(500), @string nvarchar(max))
AS
BEGIN
DECLARE  @objFileSystem int
        ,@objTextStream int,
		@objErrorObject int,
		@strErrorMessage varchar(1000),
	    @Command varchar(1000),
	    @hr int

set nocount on

select @strErrorMessage='opening the File System Object'
EXECUTE @hr = sp_OACreate  'Scripting.FileSystemObject', @objFileSystem OUT

if @HR=0 Select @objErrorObject=@objFileSystem , @strErrorMessage='Creating file "'+@Path+'"'
if @HR=0 execute @hr = sp_OAMethod @objFileSystem, 'CreateTextFile', @objTextStream OUT, @Path, 2, True

if @HR=0 Select @objErrorObject=@objTextStream, 
	@strErrorMessage='writing to the file "'+@Path+'"'
if @HR=0 execute @hr = sp_OAMethod  @objTextStream, 'Write', Null, @string

if @HR=0 Select @objErrorObject=@objTextStream, @strErrorMessage='closing the file "'+@Path+'"'
if @HR=0 execute @hr = sp_OAMethod  @objTextStream, 'Close'

if @hr<>0
	begin
	DECLARE @Source varchar(255), @Description Varchar(255), @Helpfile Varchar(255),	@HelpID int
	
	EXECUTE sp_OAGetErrorInfo  @objErrorObject, 
		@source output,@Description output,@Helpfile output,@HelpID output
	Select @strErrorMessage='Error whilst '+coalesce(@strErrorMessage,'doing something')+', '+coalesce(@Description,'')
	raiserror (@strErrorMessage,16,1)
	end
EXECUTE  sp_OADestroy @objTextStream
EXECUTE sp_OADestroy @objFileSystem
END
GO


GO
CREATE PROCEDURE CCSystem.UpdateSysObjects
@ObjectsUpdate CCSystem.SysObjectsUpdateUDT READONLY
AS
BEGIN
DECLARE @Objects CCSystem.SysObjectsUDT

INSERT INTO @Objects
SELECT 
  Id,
	ParentId,
	ClassId,
	CodeName,
	DisplayName,
	Description,
	Guid,
  CONVERT(int, CASE WHEN ClassId IN (1, 3)
    THEN OBJECT_ID(DbObjectSchemaName + '.' + DbObjectName) 
    ELSE NULL 
  END)  AS DbObjectId,
  CONVERT(int, CASE WHEN ClassId IN (3)
    THEN COLUMNPROPERTY(OBJECT_ID(DbObjectSchemaName + '.' + DbObjectName), DbFieldName, 'ColumnId') 
    ELSE NULL 
  END)  AS DbFieldId
FROM @ObjectsUpdate

--Check configuration and database integrity
IF (EXISTS(SELECT * FROM @Objects WHERE (ClassId IN (1, 3) AND DbObjectId IS NULL) OR 
                                        (ClassId IN (3) AND DbFieldId IS NULL)))
BEGIN
  PRINT 'Code Cruiser: Integrity between configuration and database is broken. See message(s) below:';

DECLARE message_cursor CURSOR FOR 

WITH Objects_CTE(Id, ParentId, ClassId,
   ObjectCodeName, PropertyCodeName,
   ObjectDisplayName,PropertyDisplayName,
   DbObjectSchemaName, DbObjectName, DbFieldName)
AS
(
  SELECT 
  o.Id,
  o.ParentId,
  o.ClassId,
  parent_o.CodeName AS ObjectCodeName,
  CASE WHEN o.ClassId = 3
    THEN o.CodeName 
    ELSE NULL 
  END AS PropertyCodeName,
  parent_o.DisplayName AS ObjectDisplayName,
  CASE WHEN o.ClassId = 3
    THEN o.DisplayName 
    ELSE NULL 
  END AS PropertyDisplayName,
	o.DbObjectSchemaName,
  o.DbObjectName, 
  o.DbFieldName
  FROM @ObjectsUpdate o
  INNER JOIN @Objects oo  ON oo.Id = o.Id
  INNER JOIN @ObjectsUpdate parent_o ON parent_o.Id = o.Id AND parent_o.ClassId = 1
  WHERE (o.ClassId IN (1, 3) AND oo.DbObjectId IS NULL) OR (o.ClassId IN (3) AND oo.DbFieldId IS NULL)
)
SELECT 'Can''t create metadata for ' +
CASE WHEN ClassId = 1  
  THEN 'Entity '''+ ObjectCodeName +'''' 
  ELSE 'Field '''+ ObjectCodeName + '.' + PropertyCodeName + '''' 
END
+ ' to ' +
CASE WHEN ClassId = 1  
  THEN 'table '''+ DbObjectSchemaName +'.' + DbObjectName +'''' 
  ELSE 'column '''+ DbObjectSchemaName +'.' + DbObjectName + '.' + DbFieldName + '''' 
END
+ '. Check object for existing and object name is correct.'
FROM Objects_CTE

--SELECT * FROM Objects_CTE

--print to output
DECLARE @message varchar(500)


OPEN message_cursor   
FETCH NEXT FROM message_cursor INTO @message

WHILE @@FETCH_STATUS = 0   
BEGIN   
       PRINT @message
       FETCH NEXT FROM message_cursor INTO @message
END   

CLOSE message_cursor   
DEALLOCATE message_cursor
    
  RAISERROR ('Code Cruiser: Integrity between configuration and database is broken. Please run ''Merge'' from Code Cruiser application and run export again', 16, 1);
END

--remove old
DELETE dest
  FROM CCSystem.SysObjects AS dest
  WHERE ClassId <> 0 
     AND NOT(Id < 0) --Ignore depricated
     AND NOT dest.Guid IN (SELECT source.Guid FROM @Objects AS source)
--TODO: Move to depricated if exists in entry log

--update existed objects
UPDATE dest
  SET dest.Id = source.Id,
      dest.ParentId = source.ParentId,
      dest.ClassId = source.ClassId,
      dest.CodeName = source.CodeName,
      dest.DisplayName = source.DisplayName,
      dest.Description = source.Description,
      dest.DbObjectId = source.DbObjectId,
      dest.DbFieldId = source.DbFieldId
  FROM CCSystem.SysObjects AS dest
  INNER JOIN @Objects AS source
  ON dest.Guid = source.Guid

--add new
INSERT INTO CCSystem.SysObjects
SELECT * FROM @Objects AS source
  WHERE NOT source.Guid IN (SELECT dest.Guid FROM CCSystem.SysObjects AS dest)
END
GO


GO
CREATE PROCEDURE CCSystem.UpdatePermissions
@Permissions CCSystem.PermissionsUDT READONLY
AS
BEGIN
--remove old
DELETE dest
  FROM CCSystem.Permissions AS dest
  WHERE NOT dest.Guid IN (SELECT source.Guid FROM @Permissions AS source)

--update existed permissions
UPDATE dest
  SET dest.Id = source.Id,
      dest.Type = source.Type,
      dest.CodeName = source.CodeName,
      dest.DisplayName = source.DisplayName,
      dest.Description = source.Description,
      dest.ObjectId = source.ObjectId
  FROM CCSystem.Permissions AS dest
  INNER JOIN @Permissions AS source
  ON dest.Guid = source.Guid

--add new
INSERT INTO CCSystem.Permissions
SELECT * FROM @Permissions AS source
  WHERE NOT source.Guid IN (SELECT dest.Guid FROM CCSystem.Permissions AS dest)
END
GO


GO
CREATE PROCEDURE CCSystem.GrantPermission (@RoleName         sysname,
                                           @PermissionName   sysname,
                                           @SkipInfoMsg      BIT= 1)
AS
BEGIN
   DECLARE
      @PermissionId   INT,
      @RoleId         INT,
      @Checked        BIT
   SET @Checked = 1
   SELECT @PermissionId = Id
   FROM CCSystem.Permissions
   WHERE CodeName = @PermissionName
   SELECT @RoleId = Id
   FROM CCSystem.Roles
   WHERE Name = @RoleName

   IF (@PermissionId IS NULL)
      BEGIN
         PRINT 'Can''t find permission ''' + @PermissionName + ''''
         SET @Checked = 0
      END

   IF (@RoleId IS NULL)
      BEGIN
         PRINT 'Can''t find role ''' + @RoleName + ''''
         SET @Checked = 0
      END

   IF (@Checked = 1)
      IF (EXISTS
             (SELECT *
              FROM CCSystem.RolePermissions
              WHERE PermissionId = @PermissionId AND RoleId = @RoleId))
         PRINT   'Already granted: Permission '''
               + @PermissionName
               + ''' to role '''
               + @RoleName
               + ''''
      ELSE
         BEGIN
            INSERT INTO CCSystem.RolePermissions (RoleId, PermissionId)
            VALUES (@RoleId, @PermissionId)

            IF (@SkipInfoMsg = 0)
               PRINT   'Granted: Permission '''
                     + @PermissionName
                     + ''' to role '''
                     + @RoleName
                     + ''''
         END
   ELSE
      PRINT   'Failed: Grant permission '''
            + @PermissionName
            + ''' to role '''
            + @RoleName
            + ''''
END
GO


GO
CREATE PROCEDURE CCSystem.RevokePermission(@RoleName sysname, @PermissionName sysname)
AS
BEGIN

DECLARE @PermissionId int, @RoleId int, @Checked bit
SET @Checked = 1
SELECT @PermissionId = Id FROM CCSystem.Permissions WHERE CodeName = @PermissionName
SELECT @RoleId = Id FROM CCSystem.Roles WHERE Name = @RoleName

IF  (@PermissionId IS NULL)
BEGIN
  PRINT 'Can''t find permission '''+@PermissionName+''''
  SET @Checked = 0
END

IF  (@RoleId IS NULL)
BEGIN
  PRINT 'Can''t find role '''+@RoleName+''''
  SET @Checked = 0
END

IF (@Checked = 1)
  IF (NOT EXISTS(SELECT * FROM CCSystem.RolePermissions WHERE PermissionId = @PermissionId AND RoleId = @RoleId))
    PRINT 'Already revoked: Permission '''+@PermissionName+''' to role '''+@RoleName+''''
  ELSE
   BEGIN
     DELETE FROM CCSystem.RolePermissions WHERe RoleId = @RoleId AND PermissionId = @PermissionId
     PRINT 'Revoked: Permission '''+@PermissionName+''' to role '''+@RoleName+''''
   END
ELSE
  PRINT 'Failed: Revoke permission '''+@PermissionName+''' to role '''+@RoleName+''''
END
GO


GO
CREATE PROCEDURE CCSystem.AddUserToRole(@RoleName sysname, @AccountName sysname)
AS
BEGIN

DECLARE @UserId int, @RoleId int, @Checked bit
SET @Checked = 1
SELECT @UserId = Id FROM CCSystem.Users WHERE AccountName = @AccountName
SELECT @RoleId = Id FROM CCSystem.Roles WHERE Name = @RoleName

IF  (@UserId IS NULL)
BEGIN
  PRINT 'Can''t find user '''+@AccountName+''''
  SET @Checked = 0
END

IF  (@RoleId IS NULL)
BEGIN
  PRINT 'Can''t find role '''+@RoleName+''''
  SET @Checked = 0
END

IF (@Checked = 1)
  IF (EXISTS(SELECT * FROM CCSystem.UserRoles WHERE UserId = @UserId AND RoleId = @RoleId))
    PRINT 'Already added: User '''+@AccountName+''' to role '''+@RoleName+''''
  ELSE
   BEGIN
     INSERT INTO CCSystem.UserRoles (RoleId, UserId) VALUES(@RoleId, @UserId)
     PRINT 'Added: user '''+@AccountName+''' to role '''+@RoleName+''''
   END
ELSE
  PRINT 'Failed: Add user '''+@AccountName+''' to role '''+@RoleName+''''
END
GO


GO
CREATE PROCEDURE CCSystem.RemoveUserFromRole (@RoleName      sysname,
                                              @AccountName   sysname)
AS
BEGIN
   DECLARE
      @UserId    INT,
      @RoleId    INT,
      @Checked   BIT
   SET @Checked = 1
   SELECT @UserId = Id
   FROM CCSystem.Users
   WHERE AccountName = @AccountName
   SELECT @RoleId = Id
   FROM CCSystem.Roles
   WHERE Name = @RoleName

   IF (@UserId IS NULL)
      BEGIN
         PRINT 'Can''t find user ''' + @AccountName + ''''
         SET @Checked = 0
      END

   IF (@RoleId IS NULL)
      BEGIN
         PRINT 'Can''t find role ''' + @RoleName + ''''
         SET @Checked = 0
      END

   IF (@Checked = 1)
      IF (NOT EXISTS
             (SELECT *
              FROM CCSystem.UserRoles
              WHERE UserId = @UserId AND RoleId = @RoleId))
         PRINT   'Already removed: User '''
               + @AccountName
               + ''' to role '''
               + @RoleName
               + ''''
      ELSE
         BEGIN
            DELETE FROM CCSystem.UserRoles
            WHERE RoleId = @RoleId AND UserId = @UserId

            PRINT   'Removed: User '''
                  + @AccountName
                  + ''' from role '''
                  + @RoleName
                  + ''''
         END
   ELSE
      PRINT   'Failed: Remove user '''
            + @AccountName
            + ''' from role '''
            + @RoleName
            + ''''
END
GO


GO
CREATE PROCEDURE CCSystem.SyncRoles(@source_db VARCHAR(1000), @target_db VARCHAR(1000), @include_update BIT = 1, @query_insert NVARCHAR(MAX) OUTPUT, @query_delete NVARCHAR(MAX) OUTPUT)
AS
BEGIN

DECLARE @query NVARCHAR(MAX)
DECLARE @compare_cursor CURSOR

SET @query = 'SELECT * FROM
(SELECT ISNULL(s.Name, t.Name) AS Name, s.Description,
       CASE WHEN t.Id IS NULL THEN ''Added''
            WHEN s.Id IS NULL THEN ''Removed''
            WHEN s.Name != t.Name OR s.Description != t.Description THEN ''NonEqual''
            ELSE ''Equal''
       END AS Status
FROM '+ @source_db + '.CCSystem.Roles s
FULL OUTER JOIN '+ @target_db + '.CCSystem.Roles t ON s.Name = t.Name) t
WHERE Status != ''Equal'''

IF(@include_update = 1)
 SET @query = @query + ' AND Status != ''NonEqual'''
SET @query = @query + ' ORDER BY Name'

EXEC [CCSystem].[CreateGenericCursor] @vQuery = @query, @Cursor = @compare_cursor OUTPUT
DECLARE @Name VARCHAR(400), @Description VARCHAR(500), @Status VARCHAR(15)
FETCH NEXT FROM @compare_cursor INTO @Name, @Description, @Status

DECLARE @delScript VARCHAR(MAX), @updateScript VARCHAR(MAX), @insertScript VARCHAR(MAX)
SELECT @delScript = '', @updateScript = '', @insertScript = ''

WHILE @@FETCH_STATUS = 0
BEGIN

  IF (@Status = 'Removed')
    BEGIN
      IF (LEN(@delScript) != 0) SET @delScript = @delScript + ' ,' ELSE SET @delScript = @delScript + '  '
      SET @delScript = @delScript + '''' + ISNULL(@Name,'') +'''' + CHAR(13) + CHAR(10)
    END
  ELSE IF (@Status = 'Added')
    BEGIN
      IF (LEN(@insertScript) != 0) SET @insertScript = @insertScript + ' ,' ELSE SET @insertScript = @insertScript + '  '
      SET @insertScript = @insertScript +'(' + N'''' + ISNULL(@Name,'') +''', N'''+ ISNULL(@Description,'') +''')' + CHAR(13)+CHAR(10)
    END
  ELSE IF (@Status = 'NonEqual')
    BEGIN
      SET @updateScript = @updateScript + 'UPDATE CCSystem.Roles SET Description=N'''+ ISNULL(@Description,'') +''' WHERE Name =''' + ISNULL(@Name,'') +'''' + CHAR(13)+CHAR(10)
    END
  FETCH NEXT FROM @compare_cursor INTO @Name, @Description, @Status
END

CLOSE @compare_cursor
DEALLOCATE @compare_cursor

SELECT @query_delete = '', @query_insert = ''
IF (LEN(@delScript) != 0)
BEGIN

SET @query_delete = CHAR(13) + CHAR(10) + 'GO'  + CHAR(13)+CHAR(10) + '-- Delete roles
DELETE FROM CCSystem.Roles
WHERE Name IN ('+ @delScript +')'

END

IF (LEN(@updateScript) != 0)
BEGIN

SET @query_insert = @query_insert + CHAR(13)+CHAR(10) + 'GO'  + CHAR(13)+CHAR(10)+ '-- Update roles
'+ @updateScript

END

IF (LEN(@insertScript) != 0)
BEGIN

SET @query_insert = @query_insert + CHAR(13)+CHAR(10) + 'GO'  + CHAR(13)+CHAR(10)+ '-- Insert roles
INSERT INTO CCSystem.Roles(Name, Description)
VALUES
'+ @insertScript

END

IF (@query_insert = '') SET @query_insert = NULL
IF (@query_delete = '') SET @query_delete = NULL

END
GO


GO
CREATE PROCEDURE CCSystem.SyncUsers(@source_db VARCHAR(1000), @target_db VARCHAR(1000), @include_update BIT = 1, @query_insert NVARCHAR(MAX) OUTPUT, @query_delete NVARCHAR(MAX) OUTPUT)
AS
BEGIN

DECLARE @query NVARCHAR(MAX)
DECLARE @compare_cursor CURSOR

SET @query = 'SELECT * FROM
(SELECT ISNULL(s.AccountName, t.AccountName) AS AccountName 
        ,s.DisplayName, s.IsDeactivated, s.IsSystemUser, s.EMail, s.FullAccess
        ,s.DeactivationDate, s.Description, s.PasswordHash,
       CASE WHEN t.Id IS NULL THEN ''Added''
            WHEN s.Id IS NULL THEN ''Removed''
            WHEN (s.AccountName != t.AccountName 
              OR s.DisplayName != t.DisplayName
              OR s.IsDeactivated != t.IsDeactivated
              OR s.IsSystemUser != t.IsSystemUser
              OR s.EMail != t.EMail
              OR s.FullAccess != t.FullAccess
              OR s.DeactivationDate != t.DeactivationDate
              OR s.Description != t.Description
              OR s.PasswordHash != t.PasswordHash) THEN ''NonEqual''
            ELSE ''Equal''
       END AS Status
FROM '+ @source_db + '.CCSystem.Users s
FULL OUTER JOIN '+ @target_db + '.CCSystem.Users t ON s.AccountName = t.AccountName) t
WHERE Status != ''Equal'''

IF(@include_update = 1)
 SET @query = @query + ' AND Status != ''NonEqual'''

SET @query = @query + ' ORDER BY AccountName'

--EXEC sys.sp_executesql @query
EXEC [CCSystem].[CreateGenericCursor] @vQuery = @query, @Cursor = @compare_cursor OUTPUT

DECLARE @AccountName NVARCHAR(100), @DisplayName NVARCHAR(100)
, @IsDeactivated BIT, @IsSystemUser BIT
, @EMail NVARCHAR(100), @FullAccess BIT, @DeactivationDate DATETIME
, @Description VARCHAR(500), @PasswordHash VARBINARY(50)
, @Status VARCHAR(15)

FETCH NEXT FROM @compare_cursor INTO @AccountName, @DisplayName, @IsDeactivated, @IsSystemUser,
                @EMail, @FullAccess, @DeactivationDate, @Description, @PasswordHash, @Status

DECLARE @delScript VARCHAR(MAX), @updateScript VARCHAR(MAX), @insertScript VARCHAR(MAX)
SELECT @delScript = '', @updateScript = '', @insertScript = ''

WHILE @@FETCH_STATUS = 0
BEGIN

  IF (@Status = 'Removed')
    BEGIN
      IF (LEN(@delScript) != 0) SET @delScript = @delScript + ' ,' ELSE SET @delScript = @delScript + '  '
      SET @delScript = @delScript + 'N''' + @AccountName +'''' + CHAR(13)+CHAR(10)
    END
  ELSE IF (@Status = 'Added')
    BEGIN
      IF (LEN(@insertScript) != 0) SET @insertScript = @insertScript + ' ,' ELSE SET @insertScript = @insertScript + '  '
      SET @insertScript = @insertScript +'(' +
      '  N''' + @AccountName +'''' +
      ', N''' + @DisplayName +'''' +
      ', ' + CONVERT(VARCHAR(1), @IsDeactivated) +
      ', ' + CONVERT(VARCHAR(1), @IsSystemUser) +
      ', N''' + @EMail +'''' +
      ', ' + CONVERT(VARCHAR(1), @FullAccess) +
      ', '+ ISNULL(''''+CONVERT(VARCHAR(20), @DeactivationDate, 126) ++'''', 'NULL') +
      ', '+ ISNULL(''''+@Description+'''', 'NULL') +
      ', '+ ISNULL('0x'+CONVERT(VARCHAR(MAX), @PasswordHash, 2), 'NULL') +
      ')' + CHAR(13)+CHAR(10)

    END
  ELSE IF (@Status = 'NonEqual')
    BEGIN
      SET @updateScript = @updateScript + 'UPDATE CCSystem.Users SET ' +
      'DisplayName= N'''+ @DisplayName +'''' +
      ', IsDeactivated=' + CONVERT(VARCHAR(1), @IsDeactivated) +
      ', IsSystemUser=' + CONVERT(VARCHAR(1), @IsSystemUser) +
      ', EMail=N''' + @EMail +'''' +
      ', FullAccess=' + CONVERT(VARCHAR(1), @FullAccess) +
      ', DeactivationDate='+ ISNULL(''''+CONVERT(VARCHAR(20), @DeactivationDate, 126) ++'''', 'NULL') +
      ', Description='+ ISNULL(''''+@Description+'''', 'NULL') +
      ', PasswordHash=0x'+ CONVERT(VARCHAR(MAX), @PasswordHash, 2)
      +'
WHERE AccountName=N'''+ @AccountName +'''' + CHAR(13)+ CHAR(10)
    END
  FETCH NEXT FROM @compare_cursor INTO @AccountName, @DisplayName, @IsDeactivated, @IsSystemUser,
                @EMail, @FullAccess, @DeactivationDate, @Description, @PasswordHash, @Status
END

CLOSE @compare_cursor
DEALLOCATE @compare_cursor

SELECT @query_insert = '', @query_delete = ''
IF (LEN(@delScript) != 0)
BEGIN

SET @query_delete = CHAR(13)+CHAR(10) + 'GO'  + CHAR(13)+CHAR(10)+ '-- Delete users
DELETE FROM CCSystem.Users
WHERE AccountName IN ('+ @delScript +')'

END

IF (LEN(@updateScript) != 0)
BEGIN

SET @query_insert = @query_insert + CHAR(13)+CHAR(10) + 'GO'  + CHAR(13)+CHAR(10)+ '-- Update users
'+ @updateScript

END

IF (LEN(@insertScript) != 0)
BEGIN

SET @query_insert = @query_insert + CHAR(13)+CHAR(10) + 'GO'  + CHAR(13)+CHAR(10)+ '-- Insert users
INSERT INTO CCSystem.Users (AccountName, DisplayName, IsDeactivated, IsSystemUser, EMail, FullAccess, DeactivationDate, Description, PasswordHash)
VALUES
'+ @insertScript

END

IF (@query_insert = '') SET @query_insert = NULL
IF (@query_delete = '') SET @query_delete = NULL

END
GO


GO
CREATE PROCEDURE CCSystem.SyncUserRoles(@source_db varchar(1000), @target_db varchar(1000), @query nvarchar(max) OUTPUT)
AS
BEGIN

DECLARE @compare_cursor CURSOR
 
SET @query = 'SELECT * FROM
(SELECT ISNULL(s.AccountName, t.AccountName) AS AccountName, ISNULL(s.RoleName, t.RoleName) AS RoleName,
       CASE WHEN t.RoleName IS NULL THEN ''Added''
            WHEN s.RoleName IS NULL THEN ''Removed''
            ELSE ''Equal''
       END AS Status
FROM (SELECT u.AccountName, r.Name AS RoleName FROM 
' + @source_db +'.CCSystem.UserRoles ur 
INNER JOIN ' + @source_db +'.CCSystem.Roles r ON ur.RoleId = r.Id
INNER JOIN ' + @source_db +'.CCSystem.Users u ON ur.UserId = u.Id) s
 FULL OUTER JOIN 
 (SELECT u.AccountName, r.Name AS RoleName FROM 
' + @target_db +'.CCSystem.UserRoles ur 
INNER JOIN ' + @target_db +'.CCSystem.Roles r ON ur.RoleId = r.Id
INNER JOIN ' + @target_db +'.CCSystem.Users u ON ur.UserId = u.Id) t 
  ON s.AccountName = t.AccountName AND s.RoleName = t.RoleName
) t
WHERE Status != ''Equal'' ORDER BY RoleName, AccountName'

--EXEC sys.sp_sqlexec @query
EXEC [CCSystem].[CreateGenericCursor] @vQuery = @query, @Cursor = @compare_cursor OUTPUT
DECLARE @AccountName nvarchar(100), @RoleName varchar(400), @Status varchar(15)
FETCH NEXT FROM @compare_cursor INTO @AccountName, @RoleName, @Status

DECLARE @delScript varchar(MAX), @updateScript varchar(MAX), @insertScript varchar(MAX)
SELECT @delScript = '', @insertScript = ''

WHILE @@FETCH_STATUS = 0   
BEGIN 

  IF (@Status = 'Removed')
    BEGIN
      SET @delScript = @delScript + 'EXEC CCSystem.RemoveUserFromRole N''' + @RoleName + ''', ''' + @AccountName + '''' + CHAR(13) + CHAR(10)
    END
  ELSE IF (@Status = 'Added')
    BEGIN
      SET @insertScript = @insertScript + 'EXEC CCSystem.AddUserToRole N''' + @RoleName + ''', ''' + @AccountName + '''' + CHAR(13) + CHAR(10)
    END
  FETCH NEXT FROM @compare_cursor INTO @AccountName, @RoleName, @Status
END   

CLOSE @compare_cursor   
DEALLOCATE @compare_cursor

SET @query = ''
IF (LEN(@delScript) != 0)
BEGIN

SET @query = @query + CHAR(13)+CHAR(10) + 'GO'  + CHAR(13)+CHAR(10)+ '-- Remove users from roles
' + @delScript

END

IF (LEN(@insertScript) != 0)
BEGIN

SET @query = @query + CHAR(13)+CHAR(10) + 'GO'  + CHAR(13)+CHAR(10)+ '-- Add users to roles
' + @insertScript

END

--PRINT @query

END
GO


GO
CREATE PROCEDURE CCSystem.SyncRolePermissions(@source_db VARCHAR(1000), @target_db VARCHAR(1000),
    @include_permissions_revoke BIT, @include_permissions_grant BIT,
    @query NVARCHAR(MAX) OUTPUT)
AS
BEGIN

DECLARE @compare_cursor CURSOR

SET @query = 'SELECT * FROM
(SELECT ISNULL(s.CodeName, t.CodeName) AS CodeName, ISNULL(s.RoleName, t.RoleName) AS RoleName,
       CASE WHEN t.RoleName IS NULL THEN ''Added''
            WHEN s.RoleName IS NULL THEN ''Removed''
            ELSE ''Equal''
       END AS Status
FROM (SELECT p.Guid, p.CodeName, r.Name AS RoleName FROM 
'+ @source_db +'.CCSystem.RolePermissions rp
INNER JOIN '+ @source_db +'.CCSystem.Roles r ON rp.RoleId = r.Id
INNER JOIN '+ @source_db +'.CCSystem.Permissions p ON rp.PermissionId = p.Id) s
 FULL OUTER JOIN 
 (SELECT p.Guid, p.CodeName, r.Name AS RoleName FROM 
'+ @target_db +'.CCSystem.RolePermissions rp
INNER JOIN '+ @target_db +'.CCSystem.Roles r ON rp.RoleId = r.Id
INNER JOIN '+ @target_db +'.CCSystem.Permissions p ON rp.PermissionId = p.Id) t 
  ON s.Guid = t.Guid AND s.RoleName = t.RoleName
) t
WHERE Status != ''Equal'' ORDER BY RoleName, CodeName'

--EXEC sys.sp_sqlexec @query
EXEC [CCSystem].[CreateGenericCursor] @vQuery = @query, @Cursor = @compare_cursor OUTPUT
DECLARE @CodeName sysname, @RoleName VARCHAR(400), @Status VARCHAR(15)
FETCH NEXT FROM @compare_cursor INTO @CodeName, @RoleName, @Status

DECLARE @delScript VARCHAR(MAX), @updateScript VARCHAR(MAX), @insertScript VARCHAR(MAX)
SELECT @delScript = '', @insertScript = ''

WHILE @@FETCH_STATUS = 0
BEGIN

  IF (@Status = 'Removed')
    BEGIN
      SET @delScript = @delScript + 'EXEC CCSystem.RevokePermission ''' + @RoleName + ''', ''' + @CodeName + '''' + CHAR(13) + CHAR(10)
    END
  ELSE IF (@Status = 'Added')
    BEGIN
      SET @insertScript = @insertScript + 'EXEC CCSystem.GrantPermission ''' + @RoleName + ''', ''' + @CodeName + '''' + CHAR(13) + CHAR(10)
    END
  FETCH NEXT FROM @compare_cursor INTO @CodeName, @RoleName, @Status
END

CLOSE @compare_cursor
DEALLOCATE @compare_cursor

SET @query = ''
IF (LEN(@delScript) != 0 AND @include_permissions_revoke = 1)
BEGIN

SET @query = @query + CHAR(13)+CHAR(10) + 'GO'  + CHAR(13)+CHAR(10)+ '-- Revoke permissions
'+ @delScript

END

IF (LEN(@insertScript) != 0 AND @include_permissions_grant = 1)
BEGIN

SET @query = @query + CHAR(13)+CHAR(10) + 'GO'  + CHAR(13)+CHAR(10)+ '-- Grant  permissions
'+ @insertScript

END

--PRINT @query

END
GO


GO
CREATE PROCEDURE CCSystem.GetSyncSecurity (
   @source_db                    VARCHAR (1000),
   @target_db                    VARCHAR (1000),
   @include_update_roles         BIT= 1,
   @include_update_users         BIT= 1,
   @include_permissions_revoke   BIT= 1,
   @include_permissions_grant    BIT= 1,
   @filePath                     VARCHAR (500)= NULL)
AS
BEGIN
   DECLARE
      @query          NVARCHAR (MAX),
      @part           NVARCHAR (MAX),
      @delete_roles   NVARCHAR (MAX),
      @delete_users   NVARCHAR (MAX)

   SET @query = ''

   EXEC
      CCSystem.SyncRoles @source_db,
      @target_db,
      @include_update_roles,
      @part OUTPUT,
      @delete_roles OUTPUT

   IF (LEN (@part) > 0)
      SET @query =
               @query
             + ISNULL
               (
                    '-------Sync roles-------'
                  + CHAR (13)
                  + CHAR (10)
                  + @part
                  + CHAR (13)
                  + CHAR (10)
                  + CHAR (13)
                  + CHAR (10),
                  '')

   EXEC
      CCSystem.SyncUsers @source_db,
      @target_db,
      @include_update_users,
      @part OUTPUT,
      @delete_users OUTPUT

   IF (LEN (@part) > 0)
      SET @query =
               @query
             + ISNULL
               (
                    '-------Sync users-------'
                  + CHAR (13)
                  + CHAR (10)
                  + @part
                  + CHAR (13)
                  + CHAR (10)
                  + CHAR (13)
                  + CHAR (10),
                  '')

   EXEC CCSystem.SyncUserRoles @source_db, @target_db, @part OUTPUT

   IF (LEN (@part) > 0)
      SET @query =
               @query
             + ISNULL
               (
                    '-------Sync user-role mapping-------'
                  + CHAR (13)
                  + CHAR (10)
                  + @part
                  + CHAR (13)
                  + CHAR (10)
                  + CHAR (13)
                  + CHAR (10),
                  '')

   EXEC
      CCSystem.SyncRolePermissions @source_db,
      @target_db,
      @include_permissions_revoke,
      @include_permissions_grant,
      @part OUTPUT

   IF (LEN (@part) > 0)
      SET @query =
               @query
             + ISNULL
               (
                    '-------Sync role-permission mapping-------'
                  + CHAR (13)
                  + CHAR (10)
                  + @part
                  + CHAR (13)
                  + CHAR (10)
                  + CHAR (13)
                  + CHAR (10),
                  '')

   IF (LEN (@delete_roles) > 0)
      SET @query =
               @query
             + ISNULL
               (
                    '-------Delete roles-------'
                  + CHAR (13)
                  + CHAR (10)
                  + @delete_roles
                  + CHAR (13)
                  + CHAR (10)
                  + CHAR (13)
                  + CHAR (10),
                  '')

   IF (LEN (@delete_users) > 0)
      SET @query =
               @query
             + ISNULL
               (
                    '-------Delete users-------'
                  + CHAR (13)
                  + CHAR (10)
                  + @delete_users
                  + CHAR (13)
                  + CHAR (10)
                  + CHAR (13)
                  + CHAR (10),
                  '')

   IF (LEN (@query) > 0)
      SET @query =
               '-- Sync security from '
             + @source_db
             + ' to '
             + @target_db
             + CHAR (13)
             + CHAR (10)
             + 'SET NOCOUNT ON;'
             + CHAR (13)
             + CHAR (10)
             + @query
   ELSE
      SET @query =
               '-- Security between '
             + @source_db
             + ' and '
             + @target_db
             + ' is equal'


   SELECT @query

   IF (NOT @filePath IS NULL)
      EXEC CCSystem.WriteStringToFile @filePath, @query
END
GO
--endregion