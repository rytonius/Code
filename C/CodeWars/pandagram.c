#include <stdbool.h>
#include <stdio.h>
#include <string.h>

/*   We create a mark[] array of Boolean type. We iterate through all
    the characters of our string and whenever we see a character we mark it.
    Lowercase and Uppercase are considered the same. So ‘A’ and ‘a’ are marked in index 0
    and similarly ‘Z’ and ‘z’ are marked in index 25.
*/

bool is_pangram(const char *str_in) {

    //  can't be a pangram if it's not at least 26 chars long
    if (strlen(str_in) <= 26) {
        return false;
    }
    // create a hash table to mark the characters as we check
    bool mark[26]={0};
    //for (int i = 0; i < 26; i++) mark[i] = false;

    //index the mark
    int index;

    // traverse all the characters in the string
    size_t size = strlen(str_in);
    for (int i = 0; i < size; i++) {
        printf("%c\n", str_in[i]);

        // check uppercase chars
        if ('A' <= str_in[i] && str_in[i] <= 'Z') 
            index = str_in[i] - 'A';

        // check lowercase chars
        else if ('a' <= str_in[i] && str_in[i] <= 'z') 
            index = str_in[i] - 'a';

        // for anything else that's not english aA-zZ
        else continue;

        mark[index] = true;
    }

    // Return false if any character is unmarked
    for (int i = 0; i <= 25; i++)
        if (mark[i] == false)
            return (false);

    // return true otherwise
    return (true);
}

int main () {
    
    char str[] = "The quick brown fox jumps over the lazy dog";
    if (is_pangram(str) == true) 
        printf("%s is pangram\n\n", str);
    else 
        printf("%s is not a pangram\n\n", str);

    return 0;
}