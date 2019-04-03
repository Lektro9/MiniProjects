import string
import random


def KeyGen (size = 20, zeichen = string.ascii_uppercase + string.digits):
    return "".join(random.choice(zeichen) for char in range(size))

print(KeyGen())