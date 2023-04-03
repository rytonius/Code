phonebook = {
    "John" : 2626180,
    "Jack" : 5551111,
    "Jill" : 2229991
}

# write your code here
phonebook["Jake"] = 3984829
del phonebook["Jill"]

# Testing Code
if "Jake" in phonebook:
    print("Jake is listed in the phonebook.")
if "Jill" not in phonebook:
    print("Jill is not listed in phonebook.")