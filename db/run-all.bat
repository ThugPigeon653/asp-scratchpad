sqlcmd -S %COMPUTERNAME%\MSSQLSERVER01 -E -i Create.sql
sqlcmd -S %COMPUTERNAME%\MSSQLSERVER01 -E -i Setup.sql
sqlcmd -S %COMPUTERNAME%\MSSQLSERVER01 -E -i Insert.sql
sqlcmd -S %COMPUTERNAME%\MSSQLSERVER01 -E -i Query.sql
sqlcmd -S %COMPUTERNAME%\MSSQLSERVER01 -E -i Drop.sql
pause