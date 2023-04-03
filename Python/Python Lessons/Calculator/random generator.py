import random
def gen():
    x = random.randint(0, 12)
    print(x)
    if x < 3:
        print("less than 3 (0-2)")
    elif x < 3+3:
        print("between 3-5")
    elif x in range(10):
        print("6 to 9")
    else:
        print("over 9")
    
gen()
