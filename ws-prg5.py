# Scraping contents from https://books.toscrape.com/catalogue/category/books/mystery_3/index.html
# Storing the content in a flat file

import requests
from bs4 import BeautifulSoup

url = "https://books.toscrape.com/catalogue/category/books/mystery_3/index.html"
response = requests.get(url)
soup = BeautifulSoup(response.content,'html.parser')


obj = soup.find('div', class_="side_categories")

a_tags = obj.find_all('a')

try:
    fhand = open("Books.txt","w")
    for tag in a_tags:
        book = tag.text.strip()
        fhand.write(book+"\n")
        print(book)
except:
    print("Error.....")
finally:
    fhand.close()


