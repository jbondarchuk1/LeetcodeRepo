vertices = "a b c d e f g h i j k l m n o p q r s t"

edges = [
    "a b 5", "a g 2", "a f 4",
    "b c 4", "b h 1", "b g 3",
    "c d 3", "c i 7", "c h 5",
    "d e 2", "d j 5", "d i 7",
    "e j 2",
    "f g 2", "f k 3",
    "g h 4", "g l 4", "g k 2",
    "h l 3", "h m 2", "h i 3",
    "i j 5", "i n 2", "i m 3",
    "j n 5", "j o 2",
    "k l 3", "k q 4", "k p 2", 
    "l m 4", "l r 4", "l q 1",
    "m n 3", "m s 3", "m r 2",
    "n o 1", "n t 1", "n s 2",
    "p q 2", "q r 4", "r s 1", "s t 2"
     ]

newEdges = []
for edge in edges:
    newEdge = edge.split(" ")
    newEdge[2] = int(newEdge[2])
    newEdges.append(newEdge)

g = sorted(newEdges, key=lambda newEdge: newEdge[2])
print(len(g))
out = ''
for i in g:
    out += str(i) + "\n"

f = open("out.txt", "w")
f.write(out)
f.close()
# kruskal 45 prim 36
print(2 + 2 + 2 + 2 + 3 + 1 + 1 + 3 + 2 + 2+ 3 + 1 + 2 + 2 + 2 + 1 + 1 + 2 + 2)