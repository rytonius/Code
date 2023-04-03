# Create 2 new lists height and weight
height = [1.87, 1.87, 1.82, 1.91, 1.90, 1.85]
weight = [81.65, 97.52, 95.25, 92.98, 86.18, 88.45]

# Import the numpy package as np
import numpy as np
#create 2 numpy arrasy from height and weight
np_height = np.array(height)
np_weight = np.array(weight)
# Print type of height
print(type(np_height))

# Calculate bmi example 81.65/1.87^2
bmi = np_weight / np_height ** 2

# Print the result
print(bmi)

# For a boolean response
bmi > 23

# Print out those observations above 23
print(bmi[bmi > 24])