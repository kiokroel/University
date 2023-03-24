import math

n = int(input("Введите кол-во вершин:"))

weight_matrix = [math.inf] * n
for i in range(n):
    weight_matrix[i] = [math.inf] * n

inp = input()
while inp != '':
    inp_split = list(map(int, inp.split()))
    weight_matrix[inp_split[1]-1][inp_split[2]-1] = inp_split[0]
    inp = input()


'''n = 6
weight_matrix = [[math.inf, 7, 9, math.inf, 11, math.inf],
                 [math.inf, math.inf, 6, 6, math.inf, 13],
                 [math.inf, math.inf, math.inf, 5, 6, math.inf],
                 [math.inf, math.inf, math.inf, math.inf, math.inf, math.inf],
                 [math.inf, 4, math.inf, 6, math.inf, math.inf],
                 [math.inf, math.inf, math.inf, 7, math.inf, math.inf]]'''

'''n = 5
weight_matrix = [[math.inf, 1, math.inf, math.inf, 3],
                 [math.inf, math.inf, 8, 7, 1],
                 [math.inf, math.inf, math.inf, 1, -5],
                 [math.inf, math.inf, 2, math.inf, math.inf],
                 [math.inf, math.inf, math.inf, 4, math.inf]]'''

point = int(input('От куда:')) - 1

table = [math.inf] * n
for i in range(n):
    table[i] = [math.inf] * n
table[point][0] = 0

for k in range(1, n):
    for i in range(n):
        if i == point:
            table[i][k] = 0
        else:
            minn = table[i][k]
            for j in range(0 ,n):
                minn = min(minn, table[j][k-1] + weight_matrix[j][i])
            table[i][k] = minn
        #print(table[i][k])
    #print('------')

for i in range(n):
    print(table[i])





