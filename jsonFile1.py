# Working with json 

# loads() method parses a json string and returns list as a Python dictionary 

import json 

input= '''
[
    {"id": "1", "Name": "Charles Severance", "Book":"Python for Informatics"} , 
    {"id":"2", "Name": "Henry Korth", "Book":"Database System Principles"},
    {"id":"3", "Name": "Roger Pressman", "Book":"Software Engineering: A Practitioner's Approach"},
    {"id":"4", "Name" : "Christian Nagel", "Book":"Professional C# and .NET"}
]
'''
info = json.loads(input)
print("No. of authors: ",len(info))

for val in info:
    print(val)

for val in info:
    print("\n Id: ",val['id'])
    print("Name: ",val['Name'])
    print("Book: ",val['Book'])
