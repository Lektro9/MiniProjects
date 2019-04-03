import socket

sock = socket.socket(
    socket.AF_INET,
    socket.SOCK_STREAM,
    socket.getprotobyname("tcp")
)
ip = socket.gethostbyname("www.heise.de")
port = socket.getservbyname("http", "tcp")
sock.connect((ip, port))
sock.send(b"GET / HTTP/1.1\nHost: www.heise.de\nConnection: close\n\n")
result = sock.recv(10000)
while (len(result) > 0):
    print(result)
    result = sock.recv(10000)