import re
result = re.search(r"aza","plaza")
print(result)
print(re.search(r"^x","xenon")) #search begin with ^
print(re.search(r"p.ng","penguin")) #wild card .
print(re.search(r"p.ng","SPoNge",re.IGNORECASE))
print(re.search(r"[Pp]ython", "Python is cool"))
print(re.search(r"[a-z]way","We should go on the highway tomorrow"))
print(re.search(r"[a-z]way","We should go on this way"))
print(re.search("cloud[a-zA-Z0-9]","cloudy"))
print(re.search("cloud[a-zA-Z0-9]","cloud9"))
print(re.search("[^a-zA-Z]","This is a sentence with spaces."))
print(re.search("[^a-zA-Z ]","This is a sentence with spaces.")) #anything between brackets is including or ^not included
print(re.search(r"cat|dog", "I like cats"))
print(re.findall(r"cat|dog", "I like both dogs and cats"))