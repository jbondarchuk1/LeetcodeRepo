"""
~1    means NOT 1, all bits in the number are flipped
12&13 means 12 AND 13, all 32 bits in each number are AND together
12|13 means 12 OR 13, all 32 bits in each number are OR together
12^13 means 12 XOR 13, all 32 bits in each number are XOR together
"""

"""
NOT - 0 becomes 1, 1 becomes 0
AND - only a 1 and 1 == 1
OR  - always a 1 except for 0 or 0
XOR - only 1 if the two bits are opposite (one is a 1 and one is a 0)
"""
"""
Bit shifting
num << x spaces
num >> y spaces

1<<1 == 2
1 >> 1 == 0

cannot shift negatively
"""
print(-1<<2)
print(1>>0)

"""
python does not include a sign bit so all shifting is done with arithmetic shifting
java has logical shifting (<<< or >>>)
in python this means that shifting the bit does not impact where the negative sign is (always arithmetic)

logical shifting moves the sign bit too
"""

"""
Integer to binary conversion
"""
print(f"{421:b}")
print(bin(32))
print(0b101010+1)


# im getting tired but bit masking is setting, getting, clearing bits and stuff, i have it on an index card and in
# cracking the coding interview