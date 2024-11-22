#Extract value from the JSON response using the API 
#
# API Key is available at:/ 

import urllib.parse
import requests


baseUrl = "https://v6.exchangerate-api.com/v6/0f215802f0c83392e64ee40d/pair/" 
try:
    ans = 'y'
    while (ans != 'n'):
        val1 = input('Enter first Currency value (e.g. EUR): ')             # INR, KWD, JOD, JPY, GBP
        val2 = input('Enter second currency value (e.g. USD): ')
        val = val1+"/"+val2

        url = baseUrl+val

        json_data = requests.get(url).json()
        result = json_data['conversion_rate']

        print("Conversion rate from "+val1+" to "+val2+" = ",result)
        print("1",val1,'=',result,val2)
        ans = input('Continue? ')
        
except:
    print("Exception is thrown")