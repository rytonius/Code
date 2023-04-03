def do_stuff_with_number(n):
        print(n)
        
the_list = (1, 2, 3, 4, 5)

for i in range(10):
    try:
        do_stuff_with_number(the_list[i])
    except IndexError: # raised when accessing a non-exisintg index list
        do_stuff_with_number(0)