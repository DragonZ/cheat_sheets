COMMAND
docker
	- run <image:version> <command/application>
		- -t ==> assign pseudo-tty/terminal
		- -i ==> interactive connection
		- -d ==> put background & daemonize
		- -P ==> map container port to host
		- -p <container-port> ==> exposed container port to host high port
		- -p <host-port>:<container-port> ==> detail mapping
	- ps ==> query container
		- -l ==> details about last started container
		- -a ==> all container including stopped
	- logs <container-name> ==> container stdout
	- stop <container-name> ==> stop container
	- version ==> client & server/daemon info
	- <subcommand> --help ==> all/subcommand help info
	- port <container-id/name> <container-port> ==> port mapping info

SHORTCUT
	- docker stop $(docker ps -a -q) ==> stop all containers
	- docker rm $(docker ps -a -q) ==> remove all containers

DOCKER-MACHINE
	- set up ssh keys
	https://help.ubuntu.com/community/SSH/OpenSSH/Keys#Generating_RSA_Keys
		- if virtual machine, may need host only network 
		http://christophermaier.name/blog/2010/09/01/host-only-networking-with-virtualbox
		- need sudo without password privilege
		http://askubuntu.com/questions/147241/execute-sudo-without-password
		https://github.com/docker/machine/issues/1569
		- when use generic driver, better choose ubuntu as base OS @ this moment
	- create the docker host
	docker-machine create --driver generic \
	--generic-ip-address 192.168.99.166 \
	--generic-ssh-key /Users/lzhen/.ssh/id_rsa \
	--generic-ssh-user lzhen \
	dev