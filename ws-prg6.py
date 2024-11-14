# Fetching an image from web

import urllib.request

url='https://bluemoji.io/emoji/double-thumbs-up'            # HTTP Error 403 - Forbidden
url1 = 'http://data.pr4e.org/cover3.jpg'

img = urllib.request.urlopen(url1).read()
try:
    fhand = open('image1.jpg','wb')
    fhand.write(img)
except:
    print("Operation failed ..... ")
finally:
    fhand.close()