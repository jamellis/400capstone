REM ONLY NEED IF DB DOES NOT EXIST
REM MUST RUN AS ADMIN _ CHANGE PATH TO MATCH WHERE YOU RUN FROM
sqlcmd -S localhost\SQLExpress -i "C:\Users\aschole\Desktop\DB Files Sample\makeDB.sql"
pause