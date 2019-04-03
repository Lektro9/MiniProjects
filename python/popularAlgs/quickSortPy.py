def quickSort(eliste):
    quickSortAlg(eliste, 0, len(eliste) - 1)

def quickSortAlg(eliste, anfang, ende):
    if anfang < ende:
        splitpoint = sor(eliste, anfang, ende)

        quickSortAlg(eliste, anfang, splitpoint - 1)
        quickSortAlg(eliste, splitpoint + 1, ende)

def sor(eliste, anfang, ende):

    vergleichsP = eliste[anfang]

    links = anfang + 1
    rechts = ende

    fertig = False

    while not fertig:
        while links <= rechts and eliste[links] <= vergleichsP:
            links += 1
        while rechts >= links and eliste[rechts] >= vergleichsP:
            rechts -= 1
        
        if rechts < links:
            fertig = True
        else:
            temp = eliste[links]
            eliste[links] = eliste[rechts]
            eliste[rechts] = temp

    temp = eliste[anfang]
    eliste[anfang] = eliste[rechts]
    eliste[rechts] = temp

    return rechts

testliste = [5,4,5,444,7,54,3,11,88]
quickSort(testliste)

print(testliste)

