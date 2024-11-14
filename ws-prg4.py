# Scraping contents from https://books.toscrape.com/catalogue/category/books/mystery_3/index.html

import requests
from bs4 import BeautifulSoup

url = "https://books.toscrape.com/catalogue/category/books/mystery_3/index.html"
response = requests.get(url)
soup = BeautifulSoup(response.content,'html.parser')

obj = soup.find('div', class_="side_categories")

print(obj)

input("Listing all the anchor tags. Continue? .....")
a_tags = obj.find_all('a')
for tag in a_tags:
    print(tag)

input("Listing the categories. Continue? .....")
for tag in a_tags:
    print(tag.text.strip())
    

