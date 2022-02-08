grep w.ld /usr/share/dict/words

# If we wanted to match a string regardless of case,
# we will have to pass the -i parameter to the grep command, like this.

grep -i python /usr/share/dict/words


# We'll use grep to find all the words that end with cat by writing grep cat dollar sign into our file.
grep $wild /usr/share/dict/words

# We can use a circumflex to check if a line begins with a pattern or use a dollar sign and check if it ends with a pattern
grep ^wild /usr/share/dict/words