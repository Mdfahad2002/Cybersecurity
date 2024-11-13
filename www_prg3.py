# Parsing an URL , for components

from urllib.parse import urlparse

url = "https://docs.python.org/3/"

result = urlparse(url)
print(result)





"""
The result should be as follows: 
ParseResult(scheme='https', netloc='docs.python.org', path='/3/', params='', query='', fragment='')
"""