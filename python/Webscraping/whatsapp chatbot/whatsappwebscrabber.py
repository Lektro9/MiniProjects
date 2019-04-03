from selenium import webdriver
import time
from KeyGen import KeyGen

driver = webdriver.Chrome()
driver.get('https://web.whatsapp.com/')

name = "GeheimerChat" #input('Enter the name of user or group: ')
msg = "Hey, ich bins Bill McGates!\nnutze den Begriff 'win11k' um keys zu erhalten"#input('Enter your message: ')
#count = int(input('Enter the count: '))

input('Enter anything after scanning QR code')

user = driver.find_element_by_xpath('//span[@title = "{}"]'.format(name))
user.click()

msg_box = driver.find_element_by_class_name('_2S1VP')

recv_obj = driver.find_elements_by_xpath('//span[@class = "{}"]'.format("selectable-text invisible-space copyable-text"))
#anfang = len(recv_obj) #diese Methode funktioniert nur bis zu 32 Stellen, danach werden alte Nachrichten nicht mehr angezeigt


while True:
    letzteNachricht = recv_obj[len(recv_obj) - 1].text
    #time.sleep(2) #zur Sicherheit
    recv_obj = driver.find_elements_by_xpath('//span[@class = "{}"]'.format("selectable-text invisible-space copyable-text"))
    if recv_obj[len(recv_obj) - 1].text != letzteNachricht: # vergleiche listeninhalt um festzustellen ob eine neue Nachricht geschickt wurde
        if recv_obj[len(recv_obj) - 1].text == "win11k":
            msg_box.send_keys("Hier hast du sofort 3!: ")
            button = driver.find_element_by_class_name('_35EW6')
            button.click()
            msg_box.send_keys(KeyGen())
            button = driver.find_element_by_class_name('_35EW6')
            button.click()
            msg_box.send_keys(KeyGen())
            button = driver.find_element_by_class_name('_35EW6')
            button.click()
            msg_box.send_keys(KeyGen())
            button = driver.find_element_by_class_name('_35EW6')
            button.click()
            recv_obj = driver.find_elements_by_xpath('//span[@class = "{}"]'.format("selectable-text invisible-space copyable-text"))
            
        else:
            msg_box.send_keys(msg)
            button = driver.find_element_by_class_name('_35EW6')
            button.click()
            recv_obj = driver.find_elements_by_xpath('//span[@class = "{}"]'.format("selectable-text invisible-space copyable-text"))


##for i in range(count):
##    msg_box.send_keys(msg)
##    button = driver.find_element_by_class_name('_35EW6')
##    button.click()
