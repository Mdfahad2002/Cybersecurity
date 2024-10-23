# Write a Python code to find division of two integers
# Program should accept integer values from user

try:
    inp = input("Number 1 :")                       # the input will be treated as a string data    
    num1 = int(inp)                     # Type conversion

    inp = input("Number 2: ")
    num2 = int(inp)                                 
    
    result = num1/num2
    print("Division of two numbers = ",result)
except ZeroDivisionError:
    print("Can not divide a number by zero.....")
    print("Program is terminating.......")
except ValueError:
    print("Invalid date .... enter integer numbers only ")
    print("Program is terminating.....")

