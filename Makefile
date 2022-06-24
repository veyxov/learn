run:
	cd api && dotnet watch run -v d

dbclean:
	rm -rf api/todo.db

dbcreate: 
	sqlite3 -batch api/todo.db "create table Todos (Id uniqueidentifier PRIMARY KEY, Title NVARCHAR(50));"

dbgen: dbclean dbcreate
