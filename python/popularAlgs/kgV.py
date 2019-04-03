import sys

if __name__ == "__main__":
    if len(sys.argv) > 2:
        zahl1 = int(sys.argv[1])
        zahl2 = int(sys.argv[2])
    else:
        zahl1 = int(input("Erste Zahl bitte eingeben: "))
        zahl2 = int(input("Zweite Zahl bitte eingeben: "))

    if zahl1 > zahl2:
        groesser = zahl1
        kleiner = zahl2
    else:
        groesser = zahl2
        kleiner = zahl1
    
    

def kgV(gr, kl):
    i = 1
    while i < kleiner:
        x = groesser * i
        if x % kleiner == 0:
            return x
        else:
            i += 1
    return gr * kl

if kgV(groesser, kleiner) == groesser * kleiner:
    print("teilerfremd also: {}".format(kgV(groesser, kleiner)))
else:
    print("das kleinste gemeinsame Vielfache ist: {}".format(kgV(groesser, kleiner)))