#include <stdio.h>

int main()
{
    int werte[3];
    int ein;
    int summe, mittelw, arrayL;

    printf("Bitte 3 Zahlen eingeben, es wird die Summe und der Mittelwert ausgegeben");
    for(int i = 0; i < 3; i++)
    {
        printf("\n%d. Wert: ", i + 1);
        scanf("%d", &ein);
        werte[i] = ein;
    }
    summe = werte[0] + werte[1] + werte[2];
    arrayL = sizeof(werte)/sizeof(werte[0]);
    mittelw = summe/arrayL;
    printf("\n%d ist die Summe\nund %d ist der Mittelwert", summe, mittelw);
    return 0;
    
    




}