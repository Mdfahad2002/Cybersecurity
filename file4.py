"""
Write a Python code to convert temprature. (from Fahrenheit to Celsius)

temp_c = (temp_f -32.0)*5.0/9.0

"""
import math

try:
    inp = input("Enter temperature in Farh: ")
    temp_f = float(inp);
    temp_c = (temp_f -32.0)*5.0/9.0
    temp_c = round(temp_c,2)                            # use of math function
    print("Temperature in Celsius = ", temp_c)
except:
    print("Invalid Data......")
