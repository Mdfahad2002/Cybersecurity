# User defined functions in Python 

def print_lyrics():
    print("\n")
    print("Que sera sera whatever will be will be")
    print("The future is not ours to see")
    print("Que sera sera")

def repeat_lyrics():
    print_lyrics()
    print_lyrics()
    print_lyrics()

i=0
while i<3 :
    repeat_lyrics()
    i = i+1

