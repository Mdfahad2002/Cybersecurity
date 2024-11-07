# Parsing a json file : /Users/sadongre/Documents/APT-Sep2024/Python Code/weatherData.json
# method: load()

import json 

with open("/Users/sadongre/Documents/APT-Sep2024/Python Code/weatherData.json", 'r') as fhand:
    Data = json.load(fhand)
   
   # print(Data)
    
    for data in Data['forecasts']:
        print(data)
