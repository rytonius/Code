# edit the functions prototype and implementation
def foo(a, b, c, *args):
    return len(args)

def bar(a, b, c, **kwargs):
    return kwargs["magicnumber"] == 7

# test code
if foo(1,2,3,4) == 1:
    print("Good, jedi.")
if foo(1,2,3,4,5) == 2:
    print("Better, nub.")
if bar(1,2,3,magicnumber = 6) == False:
    print("Great Magic.")
if bar(1,2,3,magicnumber = 7) == True:
    print("Tubular!")