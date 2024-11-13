# Working with web
# Library: BeautifulSoup

from urllib.request import urlopen
from bs4 import BeautifulSoup

try:
    url = "https://docs.python.org/3/"
    page = urlopen(url)
    soup = BeautifulSoup(page,"html.parser")
    print(soup)
except ModuleNotFoundError as e:
    print("Module not found")