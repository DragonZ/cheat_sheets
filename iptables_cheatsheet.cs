** Root privilege is NEEDED **
sudo iptables
	listing
	- -S ==> list all rules with specification
	- -S <chain-name> ==> list rules for one specific chain
	- -L <--line-numbers> ==> list all rules in table, --line-numbers, with line number column 
	- -L <chain-name> ==> list rules for one specific chain in table

	deleting
	- -D <specification> ==> delete one rule with specification (all string after -LETTER in -S)
	- -D <chain-name> <line-number> ==> delete one rule with chain & line info
	- -F <chain-name> ==> flush one chain but not delete chain
	- -F ==> flush all chains
	- -X <chain-name> ==> delete chain with no link



<< sample redis firewall script >>
#!/bin/bash

ALLOW_IP_ADDRESS=localhost
REDIS_PORT=6379
# create a new chain
iptables -N redis-protection
# allow your IP
iptables -A redis-protection --src $ALLOW_IP_ADDRESS -j ACCEPT
# allow Redsmin IP if you want to connect from Redsmin
iptables -A redis-protection --src 62.210.240.77 -j ACCEPT
# drop everyone else
iptables -A redis-protection -j DROP
# use chain xxx for packets coming to TCP port $REDIS_PORT
iptables -I INPUT -m tcp -p tcp --dport $REDIS_PORT -j redis-protection

<< ============================ >>