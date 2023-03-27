import json
import pandas as pd
import os
import pprint
# https://docs.python.org/3/library/pprint.html


with open('./directory/data.json', 'r') as f:
    loadJson = json.load(f)
    pprint.pprint(loadJson)
    # for keys, values in loadJson.items():
    #     print("{0}: {1}".format(keys, values))
