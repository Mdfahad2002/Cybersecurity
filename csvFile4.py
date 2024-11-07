# working with csv files
# method: DictWriter()

import csv

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
