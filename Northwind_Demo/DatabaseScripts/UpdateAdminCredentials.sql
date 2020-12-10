/*****************  Update Admin account credentials  ******************************/
SET NOCOUNT ON;

--Set admin account name = 'admin' and password = 'admin'
UPDATE [CCSystem].[Users] 
SET AccountName = N'admin', PasswordHash = 0x7C87541FD3F3EF5016E12D411900C87A6046A8E8 
WHERE Id = 1