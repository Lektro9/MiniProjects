import socket
import sys
import threading
import string
import random

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
host = socket.gethostbyname(input("gebe die Host-IP ein: "))
print(host)
port = 8080
server.bind((host, port))
clientsDic = {}

def KeyGen (size = 20, zeichen = string.ascii_uppercase + string.digits):
    KeyNM = "".join(random.choice(zeichen) for char in range(size))
    return (KeyNM[:5] + "-" + KeyNM[5:10] + "-" + KeyNM[10:15] + "-" + KeyNM[15:20])

def accepting_clients():
    while True:
        print("waiting for connection")
        clientsocket, addr = server.accept()
        print(addr, " is connected")
        threading.Thread(target=handle_message, args = (clientsocket, addr,)).start()

def handle_message(clientsocket, addr):
    clientsocket.send(bytes("Gebe deinen Nickname ein: ", "utf8"))
    nick = clientsocket.recv(2048).decode()
    clientsDic[clientsocket] = nick
    while True:
        msg = clientsocket.recv(2048).decode()
        if msg:
            print(addr, ": " + msg)
            broadcast(msg, nick)
        else:
            clientsocket.close()
            del clientsDic[clientsocket]

def broadcast(bMsg, nick):
    for client in clientsDic:
        if bMsg == "BillyGates":
            try:
                client.send(bytes("BillyGates", "utf8"))
            except ConnectionResetError:
                pass
        if bMsg == "W11K":
            try:
                client.send(bytes(KeyGen(), "utf8"))
            except ConnectionResetError:
                pass
        else:
            try:
                client.send(bytes(nick + "> " + bMsg, "utf8"))
            except ConnectionResetError:
                pass
    
if __name__ == "__main__":
    server.listen(5)            
    thread = threading.Thread(target=accepting_clients)
    thread.start()
    thread.join()
