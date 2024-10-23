# Write a Python code to find division of two integers
# Program should accept integer values from user

print("Number 1 :")
inp = input()                       # the input will be treated as a string data    
num1 = int(inp)                     # Type conversion

inp = input("Number 2: ")
num2 = int(inp)
try:                                    # Exception handling block 
    result = num1/num2
    print("Division of two numbers = ",result)
except:
    print("Invalid input")
