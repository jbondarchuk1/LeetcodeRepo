import serial

g = serial.Serial('/dev/ttyS4')

g.flushInput()
g.flushOutput()

while True:
    out = serial.readline().decode()
    if out!='': 
        print(out)