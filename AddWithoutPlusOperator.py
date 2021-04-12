# learn masking thats really important, i was doing the same thing but it doesnt work without bit masking to handle the negative case
def getSum(a, b):
    xoring = a^b
    anding = (a&b)<<1
    mask = 0xffffffff
    while  anding&mask != 0:
        temp =  (xoring&anding)<<1
        xoring = xoring^anding
        anding = temp
    return xoring&mask if anding > mask else xoring


print(getSum(-1,1))