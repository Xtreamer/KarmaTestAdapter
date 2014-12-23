@echo off
setlocal
cd /d %~dp0

echo ===============================================================================================
echo init
echo -----------------------------------------------------------------------------------------------
call init.cmd
echo.

echo ===============================================================================================
echo clean
echo -----------------------------------------------------------------------------------------------
rmdir /s /q output
mkdir output
echo.

echo ===============================================================================================
echo args
echo -----------------------------------------------------------------------------------------------
call node_modules\.bin\karma-vs-reporter args -c karma-vs-reporter.test.json -v output\VsConfig.json
echo.

echo ===============================================================================================
echo output files
echo -----------------------------------------------------------------------------------------------
dir /b output
echo.
