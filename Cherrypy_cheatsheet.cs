CURL REST TEST COMMAND
	pass data in url
		- curl [--user username:password] [--request GET|POST|PUT|DELETE] [URL]
	pass data in json
		- curl [--user ..] [-H <header-info>] [-X GET|POST|PUT|DELETE] [-d <data>] [URL]
			- <header-info> ==> e.g. "Content-Type: application/json"
			- <data> ==> e.g. "{'xxx': xxx, 'yyy': yyy}"
	** IMPORTANT => curl CANNOT send DELETE request with JSON, only POST|PUT **

CHERRYPY REST
	multiple arguments in url
		- @cherrypy.popargs('xxx', 'yyy') \ def GET(self, xxx[=None], yyy[=None]): ==> xxx/num/yyy/num2 -> xxx=num, yyy=num2
	arguments in json
		- @cherrypy.expose ==> required 
		- @cherrypy.tools.json_in() ==> required for incoming communication
		- @cherrypy.tools.json_out() ==> required for outgoing communication
		- cherrypy.request.json ==> access json data, dictionary type		 

CHERRYPY TUTORIAL
