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
