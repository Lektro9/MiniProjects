import bs4 as bs
import urllib.request
import time

url = "www.google.de" #hier link einfuegen zum testen des SSLs
list_valdate = []
list_check = [] 
website_url = urllib.request.urlopen("https://www.ssllabs.com/ssltest/analyze.html?d=" + url).read()
soup = bs.BeautifulSoup(website_url,"lxml")
table_list = soup.findAll('table')
#print(table_list[1])
table_work = [table_list[0], table_list[1]]
table = table_list[1]

table_rows = table.find_all("tr")

for tr in table_rows:
    td = tr.find_all("td")
    row = [i.text for i in td]
    list_check.append(row)

print(list_check[2])

    
