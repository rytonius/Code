def chek(old_function):
    def new_function(arg):
        if arg < 0: raise (ValueError, "Negative Arguement") # This causes an error,
                            # which is better than it doing the wrong thing
        old_functino(arg)
    return new_function