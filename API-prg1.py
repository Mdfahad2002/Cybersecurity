# Working with REST API
# GET and POST methods

import requests

url1 = "https://jsonplaceholder.typicode.com/posts"

response = requests.get(url1)
print(response.json())
input("Continue? .... ")

# POST 

data = {                                        # data in the json format
    "userId":101,
    "title": "Making a POST request",
    "body":"For the APT students"
} 

response = requests.post(url1, json=data)       # creating a data on the server
print(response.status_code)                     # 201= success, request served successfully
input("Continue?....")
print(response.json())                          # data posted on the server

# url2 = https://jsonplaceholder.typicode.com/todos
# task1 = {
# "userId":102,
# "title":"Submit CA-1",
# "completed":False
# } 