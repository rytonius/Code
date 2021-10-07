/* 
roguesee
for me to compile I'm using:
gcc main.c -o main -lSDL2
written in ubuntu and I have no idea what i'm doing.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <time.h>
#include <stdbool.h>
#include <stdint.h>

// open graphics library and Simple DirectMedia Layer

#include <SDL2/SDL.h>


//DEFINE
#define SCREEN_WIDTH    1280
#define SCREEN_HEIGHT   720
#define CREATE_WINDOW_UFLAGS 0

#define NUM_COLS        80
#define NUM_ROWS        45

#define internal static
#define local_persist static
#define global_variable static


//TypeDef
typedef uint8_t     u8;
typedef uint32_t    u32;
typedef uint64_t    u64;
typedef int32_t     i32;
typedef int64_t     i64;

//Downloaded from https://github.com/PeteyCodes/DarkCaverns/
#include "pt_console.c"

//GLOBAL VARIABLES

//Functions
void render_screen(SDL_Renderer *renderer, SDL_Texture *screen);

int main()
{
    SDL_Init(SDL_INIT_VIDEO);

    SDL_Window *window = SDL_CreateWindow("RogueSee",
                                          SDL_WINDOWPOS_UNDEFINED,
                                          SDL_WINDOWPOS_UNDEFINED,
                                          SCREEN_WIDTH, SCREEN_HEIGHT,
                                          CREATE_WINDOW_UFLAGS);

    SDL_Renderer *renderer = SDL_CreateRenderer(window, 0, SDL_RENDERER_SOFTWARE);

    SDL_SetHint(SDL_HINT_RENDER_SCALE_QUALITY, "linear");
    SDL_RenderSetLogicalSize(renderer, SCREEN_WIDTH, SCREEN_HEIGHT);
    
    // obvious is obvious, but this represents your texture for render
    SDL_Texture *screen = SDL_CreateTexture(renderer, SDL_PIXELFORMAT_ABGR8888,
                                            SDL_TEXTUREACCESS_STREAMING, SCREEN_WIDTH, SCREEN_HEIGHT);

    //Console *console =
    //SDL_LoadBMP("");

    bool done = false;
    while (!done) {
        SDL_Event event;
        while(SDL_PollEvent(&event) != false) {
            if (event.type == SDL_QUIT) done = true; break;
        
        }
        render_screen(renderer, screen);
    }

    
    SDL_DestroyTexture(screen);
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);

    SDL_Quit();

    return 0;
}

void render_screen(SDL_Renderer *renderer, SDL_Texture *screen)
{
    u32 *pixels = calloc(SCREEN_WIDTH * SCREEN_HEIGHT, sizeof(u32));

    
    SDL_UpdateTexture(screen, NULL, pixels, SCREEN_WIDTH * sizeof(u32));
    SDL_RenderClear(renderer);
    SDL_RenderCopy(renderer, screen, NULL, NULL);
    SDL_RenderPresent(renderer);

    free(pixels);
}


