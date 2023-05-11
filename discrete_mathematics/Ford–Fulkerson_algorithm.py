import math
from copy import deepcopy, copy


def dijkstra(matr, start, end):
    matrix = deepcopy(matr)
    versh = str(start)
    values = copy(matrix[start-1])

    minn = math.inf
    minn_ind = None
    for i in range(len(values)):
        if values[i] < minn and str(i + 1) not in versh:
            minn = values[i]
            minn_ind = i
    a = minn_ind
    while a != None:
        versh += str(a+1)
        for i in range(len(values)):
            values[i] = min(matrix[a][i] + values[a], values[i])
        minn = math.inf
        minn_ind = None
        for i in range(len(values)):
            if values[i] < minn and str(i + 1) not in versh:
                minn = values[i]
                minn_ind = i
        a = minn_ind

    way_dij = [end]
    values_recovery = copy(values)
    leng = values[end-1]
    b = end - 1
    for i in range(len(values)-1):
        for j in range(len(values_recovery)):
            if leng - matrix_Dijkstra[j][b] == values_recovery[j] or j == 0 and leng - matrix_Dijkstra[j][b] == 0:
                way_dij.append(j + 1)
                leng -= matrix_Dijkstra[j][b]
                b = j
                break
    way_dij.reverse()
    return values[end-1], way_dij


matrix_Dijkstra = [[math.inf, 1, math.inf, math.inf, 1, 1, 1, math.inf],
                   [math.inf, math.inf, 1, math.inf, 1, math.inf, math.inf, math.inf],
                   [math.inf, math.inf, math.inf, 1, math.inf, math.inf, 1, math.inf],
                   [math.inf, math.inf, math.inf, math.inf, math.inf, math.inf, math.inf, 1],
                   [math.inf, math.inf, 1, math.inf, math.inf, math.inf, 1, math.inf],
                   [math.inf, 1, math.inf, math.inf, math.inf, math.inf, 1, 1],
                   [math.inf, math.inf, math.inf, 1, math.inf, math.inf, math.inf, 1],
                   [math.inf, math.inf, math.inf, math.inf, math.inf, math.inf, math.inf, math.inf]]

I = 1  # исток
S = 8  # сток

weight_matrix = [[math.inf, 95, math.inf, math.inf, 75, 32, 57, math.inf],
                 [math.inf, math.inf, 6, math.inf, 18, math.inf, math.inf, math.inf],
                 [math.inf, math.inf, math.inf, 7, math.inf, math.inf, 11, math.inf],
                 [math.inf, math.inf, math.inf, math.inf, math.inf, math.inf, math.inf, 81],
                 [math.inf, math.inf, 9, math.inf, math.inf, math.inf, 24, math.inf],
                 [math.inf, 5, math.inf, math.inf, math.inf, math.inf, 20, 16],
                 [math.inf, math.inf, math.inf, 20, math.inf, math.inf, math.inf, 94],
                 [math.inf, math.inf, math.inf, math.inf, math.inf, math.inf, math.inf, math.inf]]

flow = 0
way = dijkstra(matrix_Dijkstra, I, S)
#while way[0] != math.inf:
for k in range(4):
    lenght = way[0]
    vertexes = way[1]
    min_bandwidth = weight_matrix[vertexes[0]-1][vertexes[1]-1]
    #  нахождение минимальной пропускной способности
    for i in range(len(vertexes)-1):
        min_bandwidth = min(min_bandwidth, weight_matrix[vertexes[i]-1][vertexes[i+1]-1])
    # вычитание
    for i in range(len(vertexes)-1):
        weight_matrix[vertexes[i] - 1][vertexes[i + 1] - 1] -= min_bandwidth
        # если дуга насыщенная убираем путь из точки i в i + 1 и меняем значени на inf
        if weight_matrix[vertexes[i] - 1][vertexes[i + 1] - 1] == 0:
            weight_matrix[vertexes[i] - 1][vertexes[i + 1] - 1] = math.inf
            matrix_Dijkstra[vertexes[i] - 1][vertexes[i + 1] - 1] = math.inf
    flow += min_bandwidth
    way = dijkstra(matrix_Dijkstra, I, S)

print(flow)
