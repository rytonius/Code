from functools import partial
def func(u,v,w,x):
    return u*4 + v*3 + w*2 + x

par = partial(func,5,10,4) 
print(par(2))