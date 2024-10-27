#Creating a text file using Python

fname="C:/Users/91887/OneDrive/Documents/Visual Studio 2022/Python/trail1.txt"
with open(fname,"r")as fhand:                   #opening a text file in reading mode
    text=fhand.read()                           #fetching data from 
    print(text)


        