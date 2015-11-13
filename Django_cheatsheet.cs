Check django installation
	- python -c "import django; print(django.get_version())"

Create project
	- django-admin startproject <project-name>
	- manage.py startapp <new-app-name>, then add <new-app-name> to <settings.py, INSTALLED_APPS>

Directory structure
	- project_dir
	    - manage.py ==> management script that can do anything 
	    - <project-name>
	        - __init__.py
	        - settings.py ==> all settings including database
	        - urls.py
	        - wsgi.py
	    - <new-app-name>
	    	- __init__.py
		    - admin.py ==> add admin page settings
		    - migrations/
		        - __init__.py
		    - models.py ==> ORM classes
		    - tests.py
		    - views.py

Database operations 
	- manage.py migrate ==> create databases/apply changes
	- manage.py makemigrations <new-app-name> ==> generate sql migrations for models
	- manage.py sqlmigrate <new-app-name> <migrate-num> ==> check generated sql

Server operations 
	- manage.py runserver <ip>:<port> ==> start the server, default port 8000
	- manage.py shell ==> interactive environment

Useful APIs
	- def __str__(self):/__unicode__(self) ==> Python 3/2 return name for the model object

Admin app
	- url/admin
	- <new-app-name>/admin.py: from .models import <new-app-name>/admin.site.register(<new-app-name>) ==> add admin page settings for the app
	- manage.py createsuperuser ==> create superuser for the site