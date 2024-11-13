# Working with Web
# Library: urllib3

import urllib3

url = "https://docs.python.org/3/"
response = urllib3.request("GET",url)   # retrieving a webpage 

print(response.status)              # success code: 200
print(response.data)                # showing the data, i.e. source code in HTML  
