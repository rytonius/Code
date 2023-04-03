class MyClass:
    variable = "Ryan Rules"
    
    def function(self):
        print("this is msg in class.")
        
myobjectx = MyClass()
myobjecty = MyClass()

myobjecty.variable = "yeah man"

# Then print out both values
print(myobjectx.variable)
print(myobjecty.variable)
        