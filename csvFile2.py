# Working with csv files
# Using python csv module 

import csv

try:
    with open("/Users/sadongre/Downloads/Dublin-Airport.csv",'r') as fhand:
        text = csv.reader(fhand, delimiter=",")
        for row in text:
            print(row)
except FileNotFoundError:
    print("File not found .... /n Program is terminating .....")
