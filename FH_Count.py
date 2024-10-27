#Write a python code to count number of lines in the file

fname="C:/Users/91887/OneDrive/Documents/Visual Studio 2022/Python/trail1.txt"
cnt = 0
try:
    with open(fname,"r") as fhand:
        for line in fhand:
            cnt = cnt+1
        print("No of lines in the file=",cnt)
except:
        print("Exception is thrown by the code....")
        print("Program will terminate now......")
