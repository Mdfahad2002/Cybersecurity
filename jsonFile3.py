# Parsing a json file using pandas library
# Using Pandas 

import pandas as pd 

df = pd.read_json("/Users/sadongre/Documents/APT-Sep2024/Python Code/weatherData.json")
                                            # storing the data in dataframe

print(df)

for data in df['forecasts']:
    print(data)
