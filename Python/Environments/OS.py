# https://docs.python.org/3/library/functions.html#open
# https://www.pythontutorial.net/python-basics/python-create-text-file/
# https://docs.python.org/3/library/os.html
# https://docs.python.org/3/library/os.path.html
# https://en.wikipedia.org/wiki/Unix_time
'''
Character
Meaning
'r'
open for reading (default)
'w'
open for writing, truncating the file first
'x'
open for exclusive creation, failing if the file already exists
'a'
open for writing, appending to the end of file if it exists
'b'
binary mode
't'
text mode (default)
'+'
open for updating (reading and writing)
'''
import os
help(os)
help('modules')
dir() #list imported modules
os.getcwd() #is a string type
print(os.getcwd()) #looks prettier, will cut out the extra \, class: nonetype
os.mkdir('testdir') #makes a directory
os.chdir("testdir") #change directory
os.mkdir("dead_dir")
os.rmdir("dead_dir")

os.listdir() #list all files, is growss recommend for file in os.listdir(): print(file)
os.path.listdir() #list directories

dir = "directory"
os.mkdir(dir)
open("directory/test.txt", "w")
for name in os.listdir(dir): #list all files or directories in a path
    fullname = os.path.join(dir, name) # By using os.path.join we can concatenate directories in a way that can be used with other os.path() functions.
    if os.path.isdir(fullname):
        print("{} is directory".format(fullname))
    else:
        print("{} is a file".format(fullname))


os.chdir(path) # change directory
os.remote(path) # remove a file
open("filetorename.txt",'w')
os.rename("filetorename.txt","nameitthis.txt")
os.path.exist("nameitthis.txt")
os.path.getsize("nameitthis.txt")
os.path.getmtime("nameitthis.txt") # last modified time
import datetime
timestamp = os.path.getmtime("nameitthis.txt")
converted_date = datetime.datetime.fromtimestamp(timestamp).date() #convert to a readable time
print("{}".format(converted_date))
os.path.abspath("nameitthis.txt") #absolute path
os.pardir() # list parent directory same as os.listdir("..")

for o in os.listdir():
    print(o)

with open('some file') as file:
    print(file)

file = open('some file')

file.readline()
file.read()

file.close()

with open("spider.txt") as file:
    for line in file:
        print(line.strip().upper())

file = open("spider.txt")
lines = file.readlines()
file.close()

print(lines)

with open("novel.txt", "w") as file: #w = write, will over-write or create new file; r = read only; a = append, use this to add to an existing file
    write("It was a dark and stormy night")