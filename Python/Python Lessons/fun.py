from random import randint
import math
a = randint(0, 5) - randint(0, 1)
b = randint(0, 20)
c = b + a
d = c * 1.5
e = math.ceil(d)

print(a, b, c, d, e)

x = randint(0, 10)
Z = x - (a - b)

if Z <= 5:
    print("yes", x, Z)
else:
    print("no", x, Z)