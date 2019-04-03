import sys

if len(sys.argv) > 2:
    zahl1, zahl2 = int(sys.argv[1]), int(sys.argv[2])
else:
    zahl1, zahl2 = int(input("Erste Zahl bitte eingeben: ")), int(input("Zweite Zahl bitte eingeben: "))

print(zahl1)
print(zahl2)

if zahl1 == zahl2:
    print("GGT ist {}".format(zahl1))
else:
    groesser = zahl1 if zahl1 > zahl2 else zahl2
    kleiner = zahl1 if zahl1 < zahl2 else zahl2

def teilenBisKlappt(gr, kl):
    for i in range(gr // 2, 1, -1):         #gr//2 ist der Start, 1 das Ende, -1 wie groß die Schritte gehen sollen
        if gr % i == 0 and kl % i == 0:
            return i
    return 1

print("GGT ist {}".format(teilenBisKlappt(groesser, kleiner)))