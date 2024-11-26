# MyCalculator code 

def add(x, y):
    return x+y

def subtract(x, y):
    return x-y

def multiply(x, y):
    return x*y 

def divide(x, y):
    if y==0:
        raise ZeroDivisionError
    else:
        return x/y


def main():
    result = add(10,20)
    print("Addition = ",result)
    ans = input("Continue? ")
    result = subtract(10,20)
    print("Subtraction = ",result)
    ans = input("Continue? ")
    result = multiply(10,20)
    print("Multiplication = ",result)
    ans = input("Continue? ")
    result = divide(10,20)
    print("Division = ",result)
    ans = input("Continue? ")

if __name__ == "__main__":
    main()
    