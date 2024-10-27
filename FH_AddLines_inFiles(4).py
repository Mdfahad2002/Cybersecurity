#Creating a file using Python code

line1="When I was just a little girl, I asked my mother who will I Be"
line2="Will I be pretty? will I be rich?"
line3="Here's what she said to me....."

line4="Que sera sera whatever will be will be"
line5="The future is not ours to see"
line6="Que sera sera"
fname="lyrics.txt"
try:                                                #file is opened in reading mode only
    with open(fname,'w') as fhand:
        fhand.write(line1)
        fhand.write(line2)
        fhand.write(line3)
        print("lyrics.txt is created")
#open the file to show the contents of the file
    with open(fname,'r')as fhand:                       #file is opened in append + mode
        text=fhand.read()
        print(text)

#add lines 4,5,6 to the file
    with open(fname,'a+') as fhand:
        fhand.write(line4)
        fhand.write(line5)
        fhand.write(line6)
except FileExistsError:
    print("File already exist,please give a different file name")


#create a file poem first para 3 sub question add four in the file and read entire file 