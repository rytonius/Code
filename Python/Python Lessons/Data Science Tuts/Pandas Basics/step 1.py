dict = {"country": ["Brazil", "Russia", "India", "China", "South Africa"],
        "capital": ["Brasilia", "Moscow", "New Dehli", "Beijing", "Pretoria"],
        "area": [8.516, 17.10, 3.286, 9.597, 1.221],
        "population": [200.4, 143.5, 1252, 1357, 52.98] }
# imports pandas and defines as brics
import pandas as pd
brics = pd.DataFrame(dict)

# Set the index for brics
brics.index = ["BR", "RU", "IN", "CH", "SA"]

# print
print(brics)

# Import the cars.csv data: cars
cars = pd.read_csv('cars.csv')

#print out cars
print(cars)