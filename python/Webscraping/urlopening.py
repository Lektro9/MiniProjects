import bs4 as bs
import urllib.request
import time

testlinks = ["www.google.de", "www.heise.de"] # hier die links einfügen, die geprüft werden sollen


def justOpenLinks(urls):                # damit der Server Zeit hat javascript auszufuehren bevor getValidationDate auf den neu generierten HTML text zugreifen kann, sonst gibt es keine Tabellen
    for url in urls:
        website_url = urllib.request.urlopen("https://www.ssllabs.com/ssltest/analyze.html?d=" + url).read()
        time.sleep(3)
        print(url + " wurde geöffnet")
def getValidationDate(urls):
    for url in urls:
        list_val = []
        list_check = []
        website_url = urllib.request.urlopen("https://www.ssllabs.com/ssltest/analyze.html?d=" + url).read()
        soup = bs.BeautifulSoup(website_url,"lxml")
        table_list = soup.findAll('table')      #finde alle Tabellen und speicher sie in eine Liste
        table0 = table_list[0]                  #table0 ist fuer das Datum wichtig
        table1 = table_list[1]                  #table1 ist fuer Chain issues wichtig

        table_rows0 = table0.find_all("tr")     #fuer erste Tabelle
        table_rows1 = table1.find_all("tr")     #fuer zweite Tabelle (weil erst die zweite Tabelle "chain issues" enthaelt

        for tr in table_rows0:
            td = tr.find_all("td")
            row = [i.text for i in td]
            list_val.append(row)
            
        for tr in table_rows1:
            td = tr.find_all("td")
            row = [i.text for i in td]
            list_check.append(row)
            

        print("{}: {:>8} {}".format(url, str(list_val[6]), str(list_check[2]))) #list_val[6] ist der Validate Eintrag
        f = open("log.txt", "a+")
        f.write("{:<35s} \t\t {:<50s} {}\n".format(url, str(list_val[6]), str(list_check[2]))) #list_check[2] ist der chain issues Eintrag
        f.close()
        
justOpenLinks(testlinks)                #hier Liste mit Links in die Funktionen einfuegen
getValidationDate(testlinks)

