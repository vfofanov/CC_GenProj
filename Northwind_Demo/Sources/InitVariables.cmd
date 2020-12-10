:: This file contains settings for remote deploy logic.
:: You can create multi configuration adding postfix to variable name. For example, "SET DeployFTPProtocol_production".
:: With multi configuration you can use any configuration with deploy cmd files. For example, "Deploy.Full.cmd _production".
:: Ftp protocol options: Sftp = 0, Scp = 1, Ftp = 2, Webdav = 3

:: DEFAULT CONFIGURATION
:: FTP Settings
SET ServerHostName=31.31.196.89
SET ServerPortNumber=21
SET ServerProtocol=2
SET ServerUserName=u1015027
SET ServerPassword=S!6g9x!P
SET ServerRemoteFolder=api.northwind.code-cruiser.com
SET ClientHostName=31.31.196.89
SET ClientPortNumber=21
SET ClientProtocol=2
SET ClientUserName=u1015027
SET ClientPassword=S!6g9x!P
SET ClientRemoteFolder=northwind.code-cruiser.com
:: Database
SET DBServer=wpl26.hosting.reg.ru
SET DBName=u1015027_northwind
SET DBUserName=u1015027_northwind
SET DBPassword=fa8m5$7U