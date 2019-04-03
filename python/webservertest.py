import socket

serversocket = socket.socket (socket.AF_INET, socket.SOCK_STREAM)
serversocket.bind(("", 8000))
serversocket.listen(5)
while True:
    (clientsocket, address) = serversocket.accept()
    print("Anfrage von ", address)
    data = clientsocket.recv(10000)
    response = b"HTTP/1.1 200 OK\n"
    response += b"Content-type: text/plain\n"
    response += b"Content-length: 49\n"
    response += b"Connection: close\n\n"
    response += b"Bill Gates hier Ich uebernehme jetzt\n"
    response += b"testing this"
    clientsocket.send(response)
    clientsocket.close()
    
