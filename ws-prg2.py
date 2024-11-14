# Parsing a web page using beautifulsoup
# url = https://docs.python.org/3/

import requests
from bs4 import BeautifulSoup

url = "https://docs.python.org/3/"

response = requests.get(url)
soup = BeautifulSoup(response.content, 'html.parser')

print(soup.prettify())

input("Finding all the 'p' tags. Continue? ..... ")

p_tags = soup.find_all('p')
print(p_tags)

input("Listing all the tags in list. Continue? ..... ")
for tag in p_tags:
    print(tag)

input("Collecting all the links ")
a_tags = soup.find_all('a')
for tag in a_tags:
    print(tag)
