import string
import random


def KeyGen (size = 20, zeichen = string.ascii_uppercase + string.digits):
    KeyNM = "".join(random.choice(zeichen) for char in range(size))
    return (KeyNM[:5] + "-" + KeyNM[5:10] + "-" + KeyNM[10:15] + "-" + KeyNM[15:20])
