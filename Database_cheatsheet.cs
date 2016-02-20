SQLite
External commands
	- sqlite3 <filename> ==> start command line with file as database

Internal commands ==> start with . without ;-ending
	- tables ==> show all tables
	- schema <tab-name> ==> show all schema or one table schema (in format of create)
	- exit/quit ==> exit command line
	- help

Query ==> SQL, end with ;



MySQL
External commands
	- mysql --host=localhost --user=myname --password=mypass mydb
	- mysql -h localhost -u myname -pmypass mydb
		- there must be no space in flag
		- avoid mentioning password in command

Internal commands ==> end with ;
	- show [databases|tables] ==> list all databases or tables
	- use [db-name] ==> select one database
	- quit/exit ==> no ; needed

Query ==> SQL, end with ;

Mac Notes
	- after installation, need to set path for commands (see my .bash_profile)
	- first login, use (SET PASSWORD = PASSWORD('your_new_password');) to set password