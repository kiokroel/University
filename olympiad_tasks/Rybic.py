f = open('D:/rybic.txt')
n, m = map(int, f.readline().split())

coordinates = f.readline().split()

coordinatesXYZ = {
            'X': int(coordinates[0]),
            'Y': int(coordinates[1]),
            'Z': int(coordinates[2])
}


def spin(sa, sc, sd, XYZ, n):
    if sc != XYZ[sa]:
        return XYZ

    XYZf = XYZ.copy()
    del XYZf[sa]

    if sd > 0:
        x = XYZf[list(XYZf.keys())[1]]
        XYZf[list(XYZf.keys())[1]] = n + 1 - XYZf[list(XYZf.keys())[0]]
        XYZf[list(XYZf.keys())[0]] = x
    else:
        y = XYZf[list(XYZf.keys())[0]]
        XYZf[list(XYZf.keys())[0]] = n + 1 - XYZf[list(XYZf.keys())[1]]
        XYZf[list(XYZf.keys())[1]] = y

    '''if sa == 'X':
        XYZ['Y'] = XYZf[list(XYZf.keys())[0]]
        XYZ['Z'] = XYZf[list(XYZf.keys())[1]]
    if sa == 'Y':
        XYZ['X'] = XYZf[list(XYZf.keys())[0]]
        XYZ['Z'] = XYZf[list(XYZf.keys())[1]]
    if sa == 'Z':
        XYZ['X'] = XYZf[list(XYZf.keys())[0]]
        XYZ['Y'] = XYZf[list(XYZf.keys())[1]] '''

    XYZ[list(XYZf.keys())[0]] = XYZf[list(XYZf.keys())[0]]
    XYZ[list(XYZf.keys())[1]] = XYZf[list(XYZf.keys())[1]]

    return XYZ


for i in range(m):
    step = f.readline().split()
    spin_axis = str(step[0])
    spin_coordinate = int(step[1])
    spin_direction = int(step[2])

    output_coordinate = spin(spin_axis, spin_coordinate, spin_direction, coordinatesXYZ, n)

print(output_coordinate)

out = open('D:/output.txt', 'w')
out.write(str(output_coordinate['X']) + ' ' + str(output_coordinate['Y']) + ' ' + str(output_coordinate['Z']))
