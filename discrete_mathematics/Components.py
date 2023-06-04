matrix = [[1, 0, 1, 0, 0, 0],
          [0, 1, 0, 0, 1, 0],
          [1, 0, 1, 1, 0, 1],
          [0, 0, 1, 1, 0, 1],
          [0, 1, 0, 0, 1, 0],
          [0, 0, 1, 1, 0, 1]]

nodes = '123456'

components = list()

while nodes:
    node = nodes[0]
    currents_comp = str(node)
    nodes = nodes.replace(node, '')
    node = int(node) - 1
    for i in range(len(matrix)):
        if i != node and matrix[node][i] == 1:
            currents_comp += str(i + 1)
            nodes = nodes.replace(str(i + 1), '')
    for nod in currents_comp:
        for i in range(len(matrix)):
            if matrix[int(nod)-1][i] == 1:
                currents_comp += str(i + 1)
                nodes = nodes.replace(str(i + 1), '')
    components.append(set(currents_comp))

print(components)

