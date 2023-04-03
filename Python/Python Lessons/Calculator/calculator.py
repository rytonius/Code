
while True:
    print("Options:")
    print("Enter 'add' to add two numbers")
    print("Enter 'subtract' to subtract two numbers")
    print("Enter 'multilply' to multiply two numbers")
    print("Enter 'division' to divide two numbers")
    print("Enter 'quit' to end the program")
    user_input = input("Choose your destiny: ")
    
    if user_input == "quit":
        break
    elif user_input == "add":
        print("num1 + num2")
        num1 = float(input("Enter a number 1: "))
        num2 = float(input("Enter another number 2: "))
        print("answer is = ", num1+num2)
        input ("press Enter to continue")
    elif user_input == "subtract":
        print("num1 '-' num2")
        num1 = float(input("enter first number 1: "))
        num2 = float(input("Now enter second number 2: "))
        print("answer is = ", num1-num2)
        input ("press Enter to die")
    elif user_input == "multiply":
        print("num1 * num2")
        num1 = float(input("enter number 1: "))
        num2 = float(input("enter num 2: "))
        answer = num1*num2
        print("answer is =", answer)
    elif user_input == "division":
        print("num1 / num2")
        num1 = float(input("Enter first number: "))
        num2 = float(input("Enter second number: "))
        if num2 == 0:
            print(" You can't divide by 0")
        else:
            result = str(num1/num2)
            print("Answer is = ", result)
            input ("press Enter to continue")
    else:
        print("Unknown input")
        break
    print("num1 was = %s, and num2 was = %s" % (num1, num2))  