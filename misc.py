ranks = "2 3 4 5 6 7 8 9 10 A J Q K".split(" ")
suits = "clubs hearts diamonds spades".split(" ")

deck = []
for r in ranks:
    for s in suits:
        deck.append(f"{r} {s}") #[r,s])

# print(len(deck))



def combo(arr, max = -1):
    if len(arr) == 0: return [[]]
    
    
    perms = []
    # for each value in the array
    for i in range(len(arr)):
        first = arr[i]
        rest = arr[:i] + arr[i+1:]

        permutations = combo(rest,max)
        for element in permutations:
            if len(element) < max:
                # add a permutation with each value in front omg this kinda deep
                perms.append([first]+element)
            else: perms.append(element)

    return perms


print(combo(ranks, 1))