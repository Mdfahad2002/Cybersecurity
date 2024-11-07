# Working with csv files

"""
import pandas as pd 
df = pd.read_csv(r"/Users/sadongre/Downloads/Dublin-Airport.csv")
print(df)


import csv
with open("/Users/sadongre/Downloads/Dublin-Airport.csv",'r') as fhand:
    text = csv.reader(fhand, delimiter=",")
    for row in text:
        print(row)

"""
import csv

headings = ["Player name", "Sport", "Age", "Country"]
rows = [["Sachin Tendulkar",'Cricket',50,'India'], 
        ['Roger Federer','Tennis',40,'Switzerland'], 
        ['Serena Williams','Tennis', 40, 'US'], 
        ['Evan Ferguson','Football',25,'Ireland'], 
        ['Troy Parrott','Football',29,'Ireland'] ]
fname = "Players.csv"
try:
    with open(fname,'a+') as fhand:
        csv_writer = csv.writer(fhand)
        csv_writer.writerow(headings)
        csv_writer.writerows(rows)
    print("Players.csv file is ready.")

    with open(fname,"r") as fhand:
        text = csv.reader(fhand)
        for row in text:
            print(row)

except FileExistsError:
    print("File already exists....")
except:
    print("File operation failed....")
    print("Program is terminating now...")

# Create a file Employee.csv with the following records in it:
# Emo No, EmpName, DateOfJoining Department


# Create a dictionary studentData (branch, cgpa, name, year)

authors = [{'Topic':'Databases', 'Name':'Henry Korth','BookName':'Database Management System'}, 
           {'Topic':'Programming','Name':'Charles Severence','BookName':'Python for Informatics'}, 
           {'Topic':'Programming','Name':'Nagel christian','BookName':'C# Programming'}, 
           {'Topic':'SE','Name':'Roger Pressman','BookName':'Software Engineering'} ]

fields = ['Topic','Name','BookName']

fname = "author.csv"

with open(fname, 'w') as fhand:
    writer = csv.DictWriter(fhand, fieldnames= fields)

    writer.writeheader()
    writer.writerows(authors)
print("File author.csv is ready")

with open(fname, 'r') as fhand:
    reader = csv.DictReader(fhand)
    for row in reader:
        print(row)
