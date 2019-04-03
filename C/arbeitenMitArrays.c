#include <stdio.h>

int main()
{
	int werte[10];
	int ein;
	int i, min, max;
	printf("Bitte zehn Werte zwischen 1 und 100 eingeben!\n");
	for (i = 0; i < 10; i++)
	{
		printf("%d. Wert: ", i + 1);
		scanf("%d", &ein);
		werte[i] = ein;
	}
	min = werte[0];
	max = werte[0];
	printf("Ihre Werte: ");
	for (i = 0; i < 10; i++)
	{
		printf("%d ", werte[i]);
		if (werte[i] > max)
		{
			max = werte[i];
		}
		if (werte[i] < min)
		{
			min = werte[i];
		}
	}
	printf("\n");
	printf("Kleinster Wert: %d\n", min);
	printf("Größter Wert: %d\n", max);
	return 0;
}