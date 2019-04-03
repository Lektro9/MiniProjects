
class Tier:
    def __init__(self, name, beine):
        self.name = name
        self.beine = beine

    def __str__(self):
        return "Das Tier {} hat {} Beine.\n".format(self.name, self.beine)

Mensch = Tier("Mensch", "2")
Spinne = Tier("Spinne", "8")
Maus = Tier("Maus", "4")

tierliste = [Mensch, Spinne, Maus]

tierliste = sorted(tierliste, key=lambda t: t.beine)

for s in tierliste:
    print(f"{s.name} hat {s.beine} Beine")
