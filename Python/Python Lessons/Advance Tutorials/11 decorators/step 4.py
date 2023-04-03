def doulbe_Ii(old_function):
    def new_function(arg): # only works if the old funtion has one arguement
        return old_function(arg * 2) # modify the arguement passed
    return new_function