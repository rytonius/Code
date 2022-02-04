# https://docs.python.org/3/library/csv.html
# https://realpython.com/python-csv/
import csv
f = open("csv_stuff.txt")

f.readlines() #we can see it's name, phone, role
f.seak(0) #start at beginning of file again
csv_f = csv.reader(f)

#next(csv_f) would skip a line next()

for row in csv_f:
    name, phone, role = row
    print("Name: {Name}, Phone: {Phone}, Role: {Role}".format(Name = name, Phone = phone, Role = role))
    #just different way to format, it's just to make spots clearer and easier for someone to read vs {}

hosts = [["router","192.168.0.1"],["gaming.local", "192.168.0.3"],["server.local","192.168.0.2"]]
with open("hosts.txt","w") as hosts_csv:
    writer = csv.writer(hosts_csv)
    writer.writerows(hosts)
###############################
import os
import csv

# DictReader is better since it'll put it in a dictionary for easier handling
# Create a file with data in it
def create_file(filename):
    with open(filename, "w") as file:
        file.write("name,color,type\n")
        file.write("carnation,pink,annual\n")
        file.write("daffodil,yellow,perennial\n")
        file.write("iris,blue,perennial\n")
        file.write("poinsettia,red,perennial\n")
        file.write("sunflower,yellow,annual\n")


# Read the file contents and format the information about each row
def contents_of_file(filename):
    return_string = ""

    # Call the function to create the file
    create_file(filename)

    # Open the file
    with open(filename) as file:
        # Read the rows of the file into a dictionary
        csv_r = csv.DictReader(file, delimiter=",")

        # Process each item of the dictionary
        for row in csv_r:
            return_string += "a {} {} is {}\n".format(row["color"], row["name"], row["type"])
    return return_string


# Call the function
print(contents_of_file("flowers.csv"))



'''
import os
import csv

# Create a file with data in it
def create_file(filename):
  with open(filename, "w") as file:
    file.write("name,color,type\n")
    file.write("carnation,pink,annual\n")
    file.write("daffodil,yellow,perennial\n")
    file.write("iris,blue,perennial\n")
    file.write("poinsettia,red,perennial\n")
    file.write("sunflower,yellow,annual\n")

# Read the file contents and format the information about each row
def contents_of_file(filename):
  return_string = ""

  # Call the function to create the file 
  create_file(filename)

  # Open the file
  with open(filename) as file:
    # Read the rows of the file into a dictionary
    csv_r = csv.DictReader(file)
    
    # Process each item of the dictionary
    for row in csv_r:
      return_string += "a {} {} is {}\n".format(row["color"], row["name"], row["type"])
  return return_string

#Call the function
print(contents_of_file("flowers.csv"))
'''

'''
 # Call the function to create the file 
  create_file(filename)

  # Open the file
  with open(filename) as file:
    # Read the rows of the file
    next(file)
    csv_rows = csv.reader(file)
    # Process each row
    for row in csv_rows:
      name, color, type = row
      # Format the return string for data rows only
      
      return_string += "a {} {} is {}\n".format(name, color, type)
  return return_string

#Call the function
print(contents_of_file("flowers.csv"))
'''