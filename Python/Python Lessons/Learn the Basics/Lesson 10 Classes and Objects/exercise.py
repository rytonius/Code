# Define the Vehicle Class
class Vehicle:
    def description(self):
        desc_str = "%s is a %s %s worth $%.2f" % (self.name, self.color, self.kind, self.value)
        return desc_str

# your code goes here
car1 = Vehicle()
car1.name = "Fer"
car1.color = "Red"
car1.kind = "Convertible"
car1.value = 60000.00

car2 = Vehicle()
car2.name = "Jump"
car2.color = "Blue"
car2.kind = "Van"
car2.value = 10000.00
# test code
print(car1.description())
print(car2.description())