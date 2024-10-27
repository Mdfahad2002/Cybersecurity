
#Use of finally block in exception handling
#File handling without 'with' keyword
    
fname="C:/Users/91887/OneDrive/Documents/Visual Studio 2022/Python/trail1.txt"
try:                                    #Alternate and safe way t handle files is using 'with' keyword
    fhand=open(fname,'r')
    text=fhand.read()
    print(text)
except FileNotFoundError:               #Exception are caught 
        print("File is not found, Please check the filename/location")
finally:                                #Use of finally block ti release the resources
        fhand.close()