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
	