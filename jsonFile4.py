# Writing json data into a file 
# method : dump()

import json


Book1 = {
    "Name" : "Java, The Complete Reference",
    "Publication": "Oracle Press",
    "Edition":11 ,
    "Year": 2023,
    "Authors": ["Herbert Schildt", "Danny Coward"]
}

with open("data.json",'w') as fhand:            # mode is set to write
    json.dump(Book1,fhand)                      # dump() stores python object in file

with open("data.json",'r') as fhand:
    text = json.load(fhand)
    print(text)

Book2 = {
    "Name" : "Core Java Vol1: Fundamentals",
    "Publication": "O'Rielly Media",
    "Edition":12 ,
    "Year": 2007,
    "Authors": ["Cay Horstman", "Garry Cornel"]
}

with open("data.json",'a+') as fhand:
    json.dump(Book2, fhand)

