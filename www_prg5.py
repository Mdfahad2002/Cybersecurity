# Working with web
# Library: requests, BeautifulSoup

import requests
from bs4 import BeautifulSoup

url = "https://docs.python.org/3/"

response = requests.get(url)                # REST API, get() method
print(response.status_code)                 # Success code = 200

header_data = response.headers

print(header_data)

soup = BeautifulSoup(response.content,'html.parser')
print(soup)

ans = input("Please press enter to continue......")

print("Title of the web page ",soup.title)

ans = input("Please press enter to continue......")
print("Tag = ",soup.title.name)

ans = input("Please press enter to continue......")
print("Title = ",soup.title.contents)

ans = input("Please press enter to continue......")
print("Title attributes = ")

print("Parent tag ")

print("Parent Name ")
