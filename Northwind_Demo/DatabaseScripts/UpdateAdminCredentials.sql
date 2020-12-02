/*****************  Update Admin account credentials  ******************************/
SET NOCOUNT ON;

--Set admin account name = 'admin' and password = 'cc'
UPDATE [CCSystem].[Users] 
SET AccountName = N'admin', PasswordHash = 0x66C43EFE5ECFA533D3097BD9FF7C1148E7309E5A 
WHERE Id = 1