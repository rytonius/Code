# https://www.jetbrains.com/help/objc/regular-expression-syntax-reference.html
# https://regexr.com/
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
print(re.search(r"cat|dog", "I like cats")) # | lets you do a or
print(re.findall(r"cat|dog", "I like both dogs and cats"))

print(re.search(r"Py.*n", "Pygmalion")) #matches whole word as it's wildcard and the * is any letter until n
print(re.search(r"Py.*n", "Python Programming is cool")) # matches until the last n is in string
print(re.search(r"Py[a-z]*n", "Python Programming"))
print(re.search(r"Py[a-z]*n", "Pyn"))
print(re.search(r"o+l+", "goldfish")) #matches preceding character one or more times
print(re.search(r"o+l+", "woolly"))
print(re.search(r"o+l+", "doyle")) 

def repeating_letter_a(text):
  result = re.search(r"[aA].*[aA]", text) # looks for the first aA, then wildcard . any length * end at aA
  return result != None

print(repeating_letter_a("banana")) # True
print(repeating_letter_a("pineapple")) # False
print(repeating_letter_a("Animal Kingdom")) # True
print(repeating_letter_a("A is for apple")) # True

print(re.search(r"p?each", "To each their own")) # ? if p is there or not it'll match
print(re.search(r"p?each", "I like peaches")) 
print(re.search(r"\.com", "welcome")) # \ is escape character, so false since .com doesn't exist
print(re.search(r"\.com", "welcome.com"))
print(re.search(r"\w*", "This is an example")) # \w matches letters, numbers, and underscores
print(re.search(r"\w*", "This_is_an_example"))
print(re.search(r"\d", "hey 244") # matches digits
#, \s for matching whitespace characters like space, tab or new line, \b for word boundaries and a few others.

def check_character_groups(text):
  result = re.search(r"\w \w", text)
  return result != None

print(check_character_groups("One")) # False
print(check_character_groups("123  Ready Set GO")) # True
print(check_character_groups("username user_01")) # True
print(check_character_groups("shopping_list: milk, bread, eggs.")) # False

print(re.search(r"A.*a", "Argentina"))
print(re.search(r"A.*a", "Azerbaijan"))
print(re.search(r"^A.*a$", "Azerbaijan"))
print(re.search(r"^A.*a$", "Australia"))

pattern = r"^[a-zA-Z_][a-zA-Z0-9_]*$"
print(re.search(pattern, "_this_is_a_valid_variable_name"))
print(re.search(pattern, "this isn't a valid variable"))
print(re.search(pattern, "my_variable1"))
print(re.search(pattern, "2my_variable1"))

'''
Using regular expressions, we can also construct a pattern that would validate if the string is a valid variable name in Python. 
Do you remember what the rules were? It can contain any number of letters numbers or underscores,
but it can't start with a number. So what do you think the validating pattern would look like?
We said it needs to start with a letter. So we'll start with circumflex to indicate that we wanted to start from the beginning,
and now a character class with all lowercase and uppercase letters plus the underscore.
The rest of the variable can have as many numbers letters or underscores that we want. 
So we needed another character class this time containing numbers with a star at the end.

Okay, we're almost done. You definitely deserve a star at the end of this.
One last thing, we want this to be the end of the string that we're matching. 
Otherwise, we could match something that could be a variable, but that also contains additional stuff after it. 
So we finish up with a dollar sign.

Now, we'll apply this pattern to a few examples and check that matches correctly.
That's right, we can use underscores anywhere in the string, that's a valid variable name. 
It matches our validation pattern because we included underscores in it. Let's try something a little different.

Once we use a space, it stops being a valid variable name. 
It doesn't matter pattern because spaces aren't included in the possible characters. 
Let's check out a variable with a number.

Sure enough, we can use numbers inside the variable name. Our pattern includes all numbers as part of the variable, 
but what have we start with a number.

The variable the number at the beginning isn't a valid variable name. 
In our pattern doesn't match it because the first of two character classes doesn't include numbers. 
Awesome job. We've covered the basics of regular expressions. 
'''

def check_sentence(text):
  result = re.search(r"^[A-Z][a-z ]*[?!.]$", text)
  return result != None

print(check_sentence("Is this is a sentence?")) # True
print(check_sentence("is this is a sentence?")) # False
print(check_sentence("Hello")) # False
print(check_sentence("1-2-3-GO!")) # False
print(check_sentence("A star is born.")) # True