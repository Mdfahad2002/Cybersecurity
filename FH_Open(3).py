#Searching through the file
#Show the lines that start with "Path"

fname="C:/Users/91887/OneDrive/Documents/Visual Studio 2022/Python/trail1.txt"
cnt=0
try:
    with open(fname,"r") as fhand:
        print("Lines starting with PATH : ")
        for line in fhand:
            if line.startswith('Path'):
                print(line)
except FileNotFoundError:
    print("File not Found")


#Find the lines containing text @dbs.ie
#find the frequency of words in a file(Use data structure )
