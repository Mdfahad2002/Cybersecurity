# Parsing a web page using beautifulsoup
# url = https://docs.python.org/3/

import requests
from bs4 import BeautifulSoup

url = "https://docs.python.org/3/"

response = requests.get(url)
soup = BeautifulSoup(response.content, 'html.parser')

print(soup)

print(soup.prettify())
