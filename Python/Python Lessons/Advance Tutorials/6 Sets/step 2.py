a = set(["Jake", "John", "Eric"])
print(a)
b = set(["John", "Jill"])
print(b)
print("and")

print(a.intersection(b))
print(b.intersection(a))
print("also")
print(a.symmetric_difference(b))
print(b.symmetric_difference(a))
print("difference")
print(a.difference(b))
print(b.difference(a))
print("union")
print(b.union(a))