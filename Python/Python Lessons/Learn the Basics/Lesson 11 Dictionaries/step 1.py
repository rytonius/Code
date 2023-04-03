phonebook = {
    "Ryan" : 9077412075,
    "Billy" : 7872224444,
    "Sandy" : 1239075555
    }
del phonebook["Ryan"]
phonebook.pop("Billy")
print(phonebook)

teet = {}
teet["John"] = 938477566
teet["Jack"] = 938377264
teet["Jill"] = 947662781
print(teet)

bonebook = {"Moby" : 1112223333, "Brody" : 9990003333, "Lisa" : 5559804210}
for name, number in bonebook.items():
    print("Phone number of %s is %d" % (name, number))