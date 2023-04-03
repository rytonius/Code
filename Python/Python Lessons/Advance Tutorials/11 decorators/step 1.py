#@decorator
#def functions(arg):
#    return "value"
# is equivalent to
#def function(arg):
#    return "value"
#function = decorator(function) #this passes the function to
# the decorator, and reassigns it to the function

def repeater(old function):
    def new_function(*args, **kwds):
        old_function(*args, **kwds) #we run the old function
        old_function(*args, **kwds) #we do it twice
    return new_function #we have to return the new_function
                        # or it wouldn't reassign it to the value
                        