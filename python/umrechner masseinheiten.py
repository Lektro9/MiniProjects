import re

einlesen = input("<Zahl Maßeinheite NeueMaßeinheit>: ")

def einheitenUmrechnen(statement):
    regex = re.compile("^(\d+(\.\d+)?)\s?([mcdk]?m)\s+([mcdk]?m)")
    gefunden = regex.match(statement)

    if gefunden:
        Zahl = float(gefunden.group(1))
        jEinheit = gefunden.group(3)
        nEinheit = gefunden.group(4)

        einheiten = {
            "mm" : 1,
            "cm" : 10,
            "dm" : 100,
            "m" : 1000,
            "km" : 1000000
        }

        return Zahl * einheiten[jEinheit] / einheiten[nEinheit]
    else:
        raise ValueError ("Falsche Eingabe gemacht.")
print(einheitenUmrechnen(einlesen))