# Modify this function to return a list of strings as defined above
def list_benefits():
    return "More organized code", "More readable code", "Easier code reuse", "Butt"

# Modify this function to concatenate to each benefit -
# "is a benefit of functions!"
def build_sentence(baby):
    return "%s, is a benefit of functions!" % baby

def name_the_benefits_of_functions():
    boobs = list_benefits()
    for baby in boobs:
        print(build_sentence(baby))
        
name_the_benefits_of_functions()
