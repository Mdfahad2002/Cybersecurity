# Working with REST APIs
# PUT()

import requests

url1 = "https://jsonplaceholder.typicode.com/todos/80"

# fetch the data using REST http method
response = requests.get(url1)

# Show the data 
print(response.json())

input("continue? ....")

# update data
task = {
    "userId":102,
    "title": "Submit CA-1",
    "completed": True
}

# Update the data using PUT method
response = requests.put(url1, task)

# show the response
print(response.json())

response = requests.get("https://jsonplaceholder.typicode.com/todos/80")
print(response.json())
