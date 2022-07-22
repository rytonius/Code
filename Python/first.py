def test(args):
    print(args.title() +" "+ args.upper())
    print("hello world!")

test("hiya")    

class Person:
    def __init__(self, name, age):
        self.name = name
        self.age = age

testy = Person("heyatt", 79)

print(testy.name + "\tis my name,\n" + str(testy.age) + "\tis my age")


