#Groeßter Gemeinsamer Teiler GGT

import sys

if len(sys.argv) > 2:
    zahl1 = int(sys.argv[1])
    zahl2 = int(sys.argv[2])
else:
    zahl1 = int(input("Erste Zahl bitte eingeben: "))
    zahl2 = int(input("Zweite Zahl bitte eingeben: "))

print(zahl1)
print(zahl2)

if zahl1 == zahl2:
    print("GGT ist {}".format(zahl1))
else:
    if zahl1 > zahl2:
        groesser = zahl1
        kleiner = zahl2
    else:
        groesser = zahl2s
        kleiner = zahl1

i = int(groesser/2)

def teilenBisKlappt(gr, kl, j):
    while i >= 2:
        if groesser % j == 0 and kleiner % j == 0:
            return j
        else:
            j = j - 1
    return j

print("GGT ist {}".format(teilenBisKlappt(groesser, kleiner, i)))