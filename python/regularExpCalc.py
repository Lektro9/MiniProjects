import re

def Calc(eingabe):
    pattern = re.compile("^(\-?\d+(\.\d+)?)\s*([+*/-])\s*(\-?\d+(\.\d+)?)$")
    gefunden = pattern.match(eingabe)
    if gefunden:
        ersteZ = float(gefunden.group(1))
        rechenZ = gefunden.group(3)
        zweiteZ = float(gefunden.group(4))
        if rechenZ == "+":
            return ersteZ + zweiteZ
        if rechenZ == "-":
            return ersteZ - zweiteZ
        if rechenZ == "/":
            if zweiteZ == 0:
                print("durch Null ist nicht erlaubt")
            else:
                return ersteZ / zweiteZ
        if rechenZ == "*":
            return ersteZ * zweiteZ

print("Rechenaufgabe eingeben:")
eingabe = input("> ")
print(Calc(eingabe))