#include <stdio.h>
#include <stdlib.h>

struct offeneListe {
    int wert;
    struct offeneListe *naechsterPlatz;
};

int main (int argc, char *argv[]){
    int i;
    int w;
    struct offeneListe *derJtzige = malloc(sizeof *derJtzige);
    struct offeneListe *alsErster = derJtzige;
    printf("Bitte 10 int-Werte eingeben\n");

    for (i = 0; i < 10; i++){
        scanf("%d", &w);
        derJtzige->wert = w;
        derJtzige->naechsterPlatz = malloc(sizeof *derJtzige);
        derJtzige = derJtzige->naechsterPlatz;
    }
    derJtzige = alsErster;
    printf ("\n");
    printf ("Ihre Eingaben waren:\n");
    for (i = 0; i < 10; i++){
        printf("%d\n", derJtzige->wert);
        derJtzige = derJtzige->naechsterPlatz;
    }
    return 0;
}