#!/usr/bin/env python3

import csv

file=open("Telefonbuch.vcf", "w+")
file.seek(0)

with open('Telefonbuch.csv') as csv_file:
    csv_reader = csv.reader(csv_file, delimiter=';')
    line_count = 0
    for row in csv_reader:
        if line_count == 0:
            print(f'Column names are {", ".join(row)}')
            line_count += 1
        else:
            if row[1] != "":
                print(f'\t{row[0]}  {row[1]} {row[2]}.')
                file.write("BEGIN:VCARD\nVERSION:2.1\nN:" + row[2] + ";\nTEL;HOME: " + row[1] +" \nEND:VCARD\n\n")
                line_count += 1
    print(f'Processed {line_count} lines.')

