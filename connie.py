# x: 15fabric 10assembly, 2pack $4
# y: 10fabric 15 assembly, 3pack $5
# z: 7fabric, 20 assembly, 4pack $6
# fabric: 2800
# assembly: 2500 
# pack: 500
# output >=30z, find max profit

profit = 0
fabric = 2800
assembly = 2500
pack = 500

fabric-=7*30
assembly-=20*30
pack-= 4*30
profit+=6*30

maxx = min(fabric//15,assembly//10,pack//2)
maxy = min(fabric//10,assembly//15,pack//3)
maxz = min(fabric//7,assembly//20,pack//4)

nums = []
for x in range(maxx):
    for y in range(maxy):
        for z in range(maxz):
            if x*15 + y*10 + z*7 <= fabric and x*10+y*15+z*20 <=assembly and x*2+y*3+z*4<=pack:
                nums.append(x*4 + y*5 + z*6 + profit)
print(max(nums))
