matrix = [[1, 0, 1, 0, 0, 0],
          [0, 1, 0, 0, 1, 0],
          [1, 0, 1, 1, 0, 1],
          [0, 0, 1, 1, 0, 1],
          [0, 1, 0, 0, 1, 0],
          [0, 0, 1, 1, 0, 1]]

nodes = list()
for i in range(len(matrix)):
    nodes.append(i)

components = list()

while nodes:
    node = nodes.pop(0)
    currents_comp = list()
    currents_comp.append(node + 1)
    for i in range(len(matrix)):
        if i != node and matrix[node][i] == 1:
            currents_comp.append(i + 1)
            nodes.remove(i)
    for nod in currents_comp:
        for i in range(len(matrix)):
            if matrix[nod-1][i] == 1 and (i + 1 not in currents_comp):
                currents_comp.append(i + 1)
                nodes.remove(i)
    components.append(currents_comp)

print(components)

