# Working with REST API
# GET and POST methods

import requests

url1 = "https://jsonplaceholder.typicode.com/todos"

response = requests.get(url1)
print(response.json())
input("Continue? .... ")

# POST 

task1 = {                                        # data in the json format
    "userId":102,
    "title":"Submit CA-1",
    "completed":False
} 

response = requests.post(url1, json=task1)       # creating a data on the server
print(response.status_code)                     # 201= success, request served successfully
input("Continue?....")
print(response.json())                          # data posted on the server
