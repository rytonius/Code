print("I am Artificial Intelligence, I am going to ask you questions about you.")
def profile():
    name = input("What is your name? ")
    print("Well that's a dumb name.")
    age = input("age? ")
        # if number:
        #    print("wow your that old")
        # else letter:
        #    print("that's not a number! stupid!")
    print("Wow your that old? Ha ha...")
    sex = input("are you boy or girl? ")
    eyes = input("what color eyes? ")
    pet = input("do you have a cat or dog or bird? ")
    return (name, age, sex, eyes, pet)

profile_name, profile_age, profile_sex, profile_eyes, profile_pet = profile()
print("Name: ", profile_name)
print("Age: ", profile_age)
print("Sex: ", profile_sex)
print("Eye Color: ", profile_eyes)
print("Pet Choice: ", profile_pet)
                 
                
