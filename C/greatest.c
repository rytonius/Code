#include <stdio.h>
/*
figure out the greatest value of input
*/
int max_of_four(int a, int b, int c, int d);
int max_of_two(int e, int f);
int main() {
    int a, b, c, d;
    puts("input 4  numbers seperated by space");
    scanf("%d %d %d %d", &a, &b, &c, &d);
    int ans = max_of_four(a, b, c, d);
    printf("%d", ans);
    
    return 0;
}

int max_of_four(int a, int b, int c, int d){
    int greatest1 = max_of_two(a, b);
    int greatest2 = max_of_two(c, d);
    int greatest3 = max_of_two(greatest1, greatest2);
    
    
    return greatest3;
}

int max_of_two(int e, int f){
    int greatest;
    
    if (e > f) greatest = e;
    else greatest = f;
    
    return greatest;
}