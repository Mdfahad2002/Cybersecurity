# Python Program to get a Google map image of specified location using Google Static Maps API

import requests
import urllib.request

api_key = 'my-api-key'
url = "https://www.google.com/maps/@19.082502,72.7163714,11z?entry=ttu"
center = "London"
zoom =10 
r = requests.get(url+'center= '+'&zoom'+str(zoom)+ '&size=400x400&key='+api_key+'sensor=false')

img = urllib.request.urlopen('https://www.google.com/maps/@19.082502,72.7163714,11z?entry=ttu').read()

fhand = open('London.jpeg','wb')
fhand.write(str(img))
fhand.close()
