# Working with web 
# Library : urllib

from urllib.request import urlopen

url = "https://docs.python.org/3/"
page = urlopen(url)

print(page)

for line in page:
    print(line)
