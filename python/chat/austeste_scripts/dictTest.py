import tkinter


def send(event=None):
    msg = sendM.get()
    recvWindow.insert(tkinter.END, msg)
    sendM.set("")


root = tkinter.Tk()
root.title("Test")

msgFrame = tkinter.Frame(root)
sendM = tkinter.StringVar()
sendM.set("Normal text")
scrollBar = tkinter.Scrollbar(msgFrame)
recvWindow = tkinter.Listbox(msgFrame, height = 5, width = 50, yscrollcommand = scrollBar.set)
scrollBar.pack(side = tkinter.RIGHT, fill = tkinter.Y)
recvWindow.pack(side = tkinter.RIGHT, fill = tkinter.BOTH)
msgFrame.pack()

entry = tkinter.Entry(root, width = 50, textvariable = sendM)
entry.bind("<Return>", send)
entry.pack()
sendButton = tkinter.Button(root, text = "SENDEN!", command = send)
sendButton.pack(side = tkinter.RIGHT)

tkinter.mainloop()
