# Scraping a webpage to collect links from a specified area
#  url = https://docs.python.org/3/

import requests
from bs4 import BeautifulSoup

url= "https://docs.python.org/3/"
response = requests.get(url)
soup = BeautifulSoup(response.content, 'html.parser')

s = soup.find('div',class_='sphinxsidebarwrapper')
print(s)

input("Listing all the a tags. continue? ...... ")
a_tags = s.find_all('a')
for tag in a_tags:
    print(tag)

input("Listing the text. continue? ...... ")

a_tags = s.find_all('a')
for tag in a_tags:
    print(tag.text)

