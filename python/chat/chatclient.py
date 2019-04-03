import socket
import sys
import threading
import tkinter

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
host = input(str("IP eingeben: "))
port = 8080
server.connect((host, port))
print("mit dem Server verbunden")
BillyGates = ['.=====================================================.',
'||                                                   ||',
'||   _       _--""--_                                ||',
'||     " --""   |    |   .--.           |    ||      ||',
'||   " . _|     |    |  |    |          |    ||      ||',
'||   _    |  _--""--_|  |----| |.-  .-i |.-. ||      ||',
'||     " --""   |    |  |    | |   |  | |  |         ||',
'||   " . _|     |    |  |    | |    `-( |  | ()      ||',
'||   _    |  _--""--_|             |  |              ||',
'||     " --""                      `--               ||',
'||                                                   ||',
'`=====================================================`']

def send(event = None):
        msg = sendM.get()
        sendM.set("")
        server.send(msg.encode())

def recv():
    while True:
        try:
            rMsg = server.recv(2048).decode()
            if rMsg == "BillyGates":
                for Bill in BillyGates:
                    recvWindow.insert(tkinter.END, Bill)
            else:
                recvWindow.insert(tkinter.END, rMsg)
                recvWindow.see("end")
        except OSError:
            break
        
root = tkinter.Tk()
root.title("Test")

msgFrame = tkinter.Frame(root)
sendM = tkinter.StringVar()
sendM.set("Nachricht hier rein")
scrollBar = tkinter.Scrollbar(msgFrame)
recvWindow = tkinter.Listbox(msgFrame, yscrollcommand = scrollBar.set)
scrollBar.pack(side = tkinter.RIGHT, fill = tkinter.Y)
recvWindow.pack(side = tkinter.RIGHT, fill = tkinter.BOTH, expand = True)
msgFrame.pack(fill = tkinter.BOTH, expand = True)

entry = tkinter.Entry(root, width = 50, textvariable = sendM)
entry.bind("<Return>", send)
entry.pack(fill = tkinter.BOTH, expand = True)
sendButton = tkinter.Button(root, text = "SENDEN!", command = send)
sendButton.pack(side = tkinter.RIGHT)


recvThread = threading.Thread(target = recv)
recvThread.start()

tkinter.mainloop()
