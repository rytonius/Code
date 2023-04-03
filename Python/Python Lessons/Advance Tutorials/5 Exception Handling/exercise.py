# Handle all the exceptions!
#Setup
actor = {"name": "John Cleese Adam", "name2": "Maybe this Chuck", "rank": "awesome"}

#Function to modify, should return the last name of the actor
# -think back to previous lessons for how to get it
def get_last_name():
    return actor["name"].split()[-1]
def baby():
    return actor["name2"].split()[2]
def rank():
    return actor["rank"]

#test code


try:
    get_last_name()
    print("The 2 actor's last name is %s and %s, with a rank of %s" % (get_last_name(), baby(), rank()))
except KeyError:
    
    print("All exceptions caught! Good job!")