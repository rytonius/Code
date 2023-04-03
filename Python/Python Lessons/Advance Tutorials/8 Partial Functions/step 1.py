from functools import partial

def multiply(x,y):
        return x * y

dbl = partial(multiply,2)
print(dbl(4))