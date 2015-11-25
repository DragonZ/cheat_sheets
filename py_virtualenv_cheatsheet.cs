-- virtualenv --
Install
	- pip install virtualenv
Basic Usage
	- create & go into project directory
	- virtualenv venv ==> create virtualenv directory named venv in project directory
		- virtualenv -p /usr/bin/python2.7 venv ==> use specific interpreter
	- source venv/bin/activate ==> activate virtualenv
	- deactivate ==> stop virtualenv back to global settings
	- virtualenv --no-site-packages	==> not include packages installed globally

	- backup environment
		- pip freeze > requirements.txt ==> backup
		- pip install -r requirements.txt ==> restore 

-- virtualenvwrapper --
Install
	- pip install virtualenvwrapper
	- export WORKON_HOME=~/Envs ==> all virtualenv stored here
	- source /usr/local/bin/virtualenvwrapper.sh
Basic Usage
	- mkvirtualenv venv ==> create virtualenv in WORKON_HOME (auto use venv after creation)
	- workon venv ==> use venv virtualenv 
	- export PROJECT_HOME=... ==> used for mkproject
	- mkproject myproject ==> create project|create virtualenv <myproject>|go into project & workon
	- deactivate
	- rmvirtualenv venv ==> delete virtualenv venv
	- lsvirtualenv ==> list all virtualenv
	- cdvirtualenv ==> navigate into directory of currently activated virtualenv
	- cdsitepackages ==> like cdvirtualenv but into site-packages
	- lssitepackages ==> show site-packages

Helpful Tools
	Mac
	- brew install autoenv
	Linux
	- git clone git://github.com/kennethreitz/autoenv.git ~/.autoenv
	- echo 'source ~/.autoenv/activate.sh' >> ~/.bashrc
	autoenv ==> into a directory containing a .env, automagically activates the environment