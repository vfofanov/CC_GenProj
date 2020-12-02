:: This file installs npm packages for web client building process.
:: Prior to run this file install node.js.

cd Sources
cd Northwind.Web.Angular
rmdir /s /q node_modules
CALL npm install webpack@5.3.2 -g
CALL npm install webpack-cli -g
CALL npm install webpack-dev-server -g
CALL npm install electron-packager -g
CALL npm install webdriver-manager -g
CALL npm install protractor -g
CALL npm install cordova -g
CALL npm install

if not "%1" == "nopause" (
pause
)