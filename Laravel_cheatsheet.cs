BASIC TASK LIST

Create project
	- composer create-project laravel/laravel <project-name> --prefer-dist

Database migrations
	- php artisan make:migration <name-in-migration-script> --create=<table-name>
	- php artisan migrate

	- php artisan migrate:rollback ==> rollback to last migration
	- php artisan migrate:reset ==> rollback all migrations
	- php artisan migrate:refresh <--seed> ==> rollback and run all again
	- migrates are managed in migrations table in Database
	- ** never try to manually delete migrations, cause data inconsist**
	- ** rollback tools *NOT* supported in sqlite, write script to remove database file and re-migrate **

ORM models(Eloquent in Laravel)
	- php artisan make:model <name-mapping-to-db>
	- model name and table name relation: YxxYxx <=> yxx_yxxs

PHPUnit Test of Laravel
	- php artisan make:test UserTest

Directory structure
	- app
		- xxx.php ==> ORM model classes
		- Http
			- routes.php ==> url management
	- database
		- migrations ==> all database migrations files
	- resources
		- views ==> all UI/html templates
			- xxx.blade.php ==> blade templating engine templates
			- layouts
				- xxx.blade.php

TODO ==> Make controller deal with instance instead of id

Useful keywords
	- @yield('content') ==> child pages injected here
	- @extends('xxx.xxx') ==> extend super layout with path from resources/views
	- @section('content') ... @endsection ==> inject to @yield('content')

Q&A
	- if symbolic linking laravel project to <www> directory, you may have to give 777 permission to <storage >directory; 
	Further experiment may be needed for more detailed permission. May not be a good way for production public site.