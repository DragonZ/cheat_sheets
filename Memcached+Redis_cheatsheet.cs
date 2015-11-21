Great tools for speeding up query and reducing database operations 

Memcached python API
	name
		- import memcache
	initialize
		- memcache.Client([host:port], debug=0)
			- local default -> '127.0.0.1:11211'
	create/update
		- set(key, value)
	fetch 
		- get(key)
	delete
		- delete(key)
	increase/decrease
		- incr(key) / decr(key)
	database with memcache
		# key = derive_key(obj)				#
	    # obj = mc.get(key)					#
	    # if not obj:						#
	    #     obj = backend_api.get(...)	#
	    #     mc.set(key, obj)				#
	    #									#
	    # now have obj, and future passes	#
	    # through this code, will use the	#
	    # object from the cache				#
	more