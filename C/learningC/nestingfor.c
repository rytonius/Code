/* nesting two for statements */
#include <stdio.h>

int values();
void draw_box( int, int);

int main(void)
{ 
    draw_box (values(),values());

    return 0;
}

int values()
{
    int x, y, z;

    if (z == 1) {
        z++;
        return y;
    }
    else {
        puts("write your x / y");
        scanf("%d/%d", &x,&y);
        z = 1;
        return x;
    }
    
}

void draw_box(int row, int column)
{
    printf("\nx: %d \ty: %d\n\n", row, column);
    int totalx = row * column;

    int col;
    for ( ; row > 0; row--)
    {
        for (col = column; col > 0; col--) printf("X");
        
        printf("\n");
    }

    printf("\nyou have: %d X's", totalx);
}