# https://www.jetbrains.com/help/objc/regular-expression-syntax-reference.html
# https://regexr.com/
# https://docs.python.org/3/howto/regex.html
# https://docs.python.org/3/library/re.html
# https://docs.python.org/3/howto/regex.html#greedy-versus-non-greedy
import re

result = re.search(r"aza", "plaza")
print(result)
print(re.search(r"^x", "xenon"))  # search begin with ^
print(re.search(r"p.ng", "penguin"))  # wild card .
print(re.search(r"p.ng", "SPoNge", re.IGNORECASE))
print(re.search(r"[Pp]ython", "Python is cool"))
print(re.search(r"[a-z]way", "We should go on the highway tomorrow"))
print(re.search(r"[a-z]way", "We should go on this way"))
print(re.search("cloud[a-zA-Z0-9]", "cloudy"))
print(re.search("cloud[a-zA-Z0-9]", "cloud9"))
print(re.search("[^a-zA-Z]", "This is a sentence with spaces."))
print(re.search("[^a-zA-Z ]","This is a sentence with spaces."))  # anything between brackets is including or ^not included
print(re.search(r"cat|dog", "I like cats"))  # | lets you do a or
print(re.findall(r"cat|dog", "I like both dogs and cats"))

print(re.search(r"Py.*n", "Pygmalion"))  # matches whole word as it's wildcard and the * is any letter until n
print(re.search(r"Py.*n", "Python Programming is cool"))  # matches until the last n is in string
print(re.search(r"Py[a-z]*n", "Python Programming"))
print(re.search(r"Py[a-z]*n", "Pyn"))
print(re.search(r"o+l+", "goldfish"))  # matches preceding character one or more times
print(re.search(r"o+l+", "woolly"))
print(re.search(r"o+l+", "doyle"))


def repeating_letter_a(text):
    result = re.search(r"[aA].*[aA]", text)  # looks for the first aA, then wildcard . any length * end at aA
    return result != None


print(repeating_letter_a("banana"))  # True
print(repeating_letter_a("pineapple"))  # False
print(repeating_letter_a("Animal Kingdom"))  # True
print(repeating_letter_a("A is for apple"))  # True

print(re.search(r"p?each", "To each their own"))  # ? if p is there or not it'll match
print(re.search(r"p?each", "I like peaches"))
print(re.search(r"\.com", "welcome"))  # \ is escape character, so false since .com doesn't exist
print(re.search(r"\.com", "welcome.com"))
print(re.search(r"\w*", "This is an example"))  # \w matches letters, numbers, and underscores
print(re.search(r"\w*", "This_is_an_example"))
print(re.search(r"\d", "hey 244"))  # matches digits


# , \s for matching whitespace characters like space, tab or new line, \b for word boundaries and a few others.

def check_character_groups(text):
    result = re.search(r"\w \w", text)
    return result != None


print(check_character_groups("One"))  # False
print(check_character_groups("123  Ready Set GO"))  # True
print(check_character_groups("username user_01"))  # True
print(check_character_groups("shopping_list: milk, bread, eggs."))  # False

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


print(check_sentence("Is this is a sentence?"))  # True
print(check_sentence("is this is a sentence?"))  # False
print(check_sentence("Hello"))  # False
print(check_sentence("1-2-3-GO!"))  # False
print(check_sentence("A star is born."))  # True


def check_time(text):
    pattern = r"^1[0-2]|[1-9]:[0-5][0-9] ?[pA][mM]"
    result = re.search(pattern, text)
    return result != None


print(check_time("12:45pm"))  # True
print(check_time("9:59 AM"))  # True
print(check_time("6:60am"))  # False
print(check_time("five o'clock"))  # False


def check_zip_code(text):
    result = re.search(r" \d{5}(?:-\d{4})?", text)
    return result != None


print(check_zip_code("The zip codes for New York are 10001 thru 11104."))  # True
print(check_zip_code("90210 is a TV show"))  # False
print(check_zip_code("Their address is: 123 Main Street, Anytown, AZ 85258-0001."))  # True
print(check_zip_code("The Parliament of Canada is at 111 Wellington St, Ottawa, ON K1A0A9."))  # False


def contains_acronym(text):
    pattern = r"\(\w.*\w\)"
    result = re.search(pattern, text)
    return result != None


print(contains_acronym("Instant messaging (IM) is a set of communication technologies used for text-based communication"))  # True
print(contains_acronym("American Standard Code for Information Interchange (ASCII) is a character encoding standard for electronic communication"))  # True
print(contains_acronym("Please do NOT enter without permission!"))  # False
print(contains_acronym("PostScript is a fourth-generation programming language (4GL)"))  # True
print(contains_acronym("Have fun using a self-contained underwater breathing apparatus (Scuba)!"))  # True


def check_web_address(text):
    pattern = r"\.[a-zA-Z]*$"
    result = re.search(pattern, text)
    return result != None


print(check_web_address("gmail.com"))  # True
print(check_web_address("www@google"))  # False
print(check_web_address("www.Coursera.org"))  # True
print(check_web_address("web-address.com/homepage"))  # False
print(check_web_address("My_Favorite-Blog.US"))  # True

result = re.search(r"^(\w*), (\w*)$", "Ada, Lovelace")
print(result)
print(result.groups())
print(result[0])
print(result[1])
print(result[2])
"{0} first and {1} last".format(result[1], result[2])


def rearrange_name(name):
    result = re.search(r"^(\w*), (\w*)$", name)
    if result is None:
        return name
    return "{} {}".format(result[2], result[1])


print(re.findall(r"\b[a-zA-Z]{5}\b", "a scary ghost came and found everyone"))  # find only 5 letter words
print(re.findall(r"\w{5,10}", "I really like Starwars and Strawberries"))
print(re.findall(r"\w{5,}", "I really like Starwars and Strawberries"))
print(re.findall(r"[sS]\w{,20}", "I really like Starwars and Strawberries"))


def extract_pid(log_line):
    regex = r"\[(\d+)\]\: ([A-Z]+)"
    result = re.search(regex, log_line)
    if result is None:
        return None
    return "{} ({})".format(result[1], result[2])


print(extract_pid("July 31 07:51:48 mycomputer bad_process[12345]: ERROR Performing package upgrade")) # 12345 (ERROR)
print(extract_pid("99 elephants in a [cage]")) # None
print(extract_pid("A string that also has numbers [34567] but no uppercase message"))  # None


def transform_record(record):
    new_record = re.sub(r",(?=\d)", r",+1-", record)
    return new_record


print(transform_record("Sabrina Green,802-867-5309,System Administrator"))
# Sabrina Green,+1-802-867-5309,System Administrator
print(transform_record("Eli Jones,684-3481127,IT specialist"))
# Eli Jones,+1-684-3481127,IT specialist
print(transform_record("Melody Daniels,846-687-7436,Programmer"))
# Melody Daniels,+1-846-687-7436,Programmer
print(transform_record("Charlie Rivera,698-746-3357,Web Developer"))
# Charlie Rivera,+1-698-746-3357,Web Developer

#  The multi_vowel_words function returns all words with 3 or more consecutive vowels (a, e, i, o, u). Fill in the regular expression to do that.
def multi_vowel_words(text):
    pattern = r"\w*[aeiou]{3,}\w*"
    result = re.findall(pattern, text)
    return result


print(multi_vowel_words("Life is beautiful"))
# ['beautiful']

print(multi_vowel_words("Obviously, the queen is courageous and gracious."))
# ['Obviously', 'queen', 'courageous', 'gracious']

print(multi_vowel_words("The rambunctious children had to sit quietly and await their delicious dinner."))
# ['rambunctious', 'quietly', 'delicious']

print(multi_vowel_words("The order of a data queue is First In First Out (FIFO)"))
# ['queue']

print(multi_vowel_words("Hello world!"))
# []


def transform_comments(line_of_code):
    result = re.sub(r"#+",r"//",line_of_code)
    return result

print(transform_comments("### Start of program"))
# Should be "// Start of program"
print(transform_comments("  number = 0   ## Initialize the variable"))
# Should be "  number = 0   // Initialize the variable"
print(transform_comments("  number += 1   # Increment the variable"))
# Should be "  number += 1   // Increment the variable"
print(transform_comments("  return(number)"))
# Should be "  return(number)"


def convert_phone_number(phone):
  result = re.sub(r'(?<!\S)(\d{3})-', r'(\1) ', phone)
  return result

print(convert_phone_number("My number is 212-345-9999.")) # My number is (212) 345-9999.
print(convert_phone_number("Please call 888-555-1234")) # Please call (888) 555-1234
print(convert_phone_number("123-123-12345")) # 123-123-12345
print(convert_phone_number("Phone number of Buckingham Palace is +44 303 123 7300")) # Phone number of Buckingham Palace is +44 303 123 7300