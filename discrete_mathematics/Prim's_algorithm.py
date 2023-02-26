#reb = [[2,'A','B'],[2,'A','C'],[2,'B','C'],[2,'B','E'],[2,'D','G'],[5,'C','E'],[5,'D','F'],[7,'A','E'],[9,'E','G'],[9,'B','D'],[10,'E','D'],[16,'D','H'],[17,'F','H'],[17,'G','H']]
#reb = [[15, '1', '2'],[15, '2', '5'],[16, '2', '4'],[14, '3', '5'],[18, '5', '9'],[14, '1', '5'],[18, '8', '9'],[19, '2', '3'],[20, '4', '8'],[14, '7', '8'],[23, '1', '4'],[23, '4', '7'],[24, '5', '6'],[25, '4', '5'],[26, '3', '6'],[27, '5', '8'],]

reb = []
inp = input()
while inp != '':
    inp_str = [int(inp.split()[0]), inp.split()[1], inp.split()[2]]
    reb.append(inp_str)
    inp = input()

reb_isp = reb[0][1]
s = 0


def func(reb_isp, reb, s):
    for i in range(len(reb)):
        if reb[i][1] in reb_isp and reb[i][2] in reb_isp:
            reb.pop(i)
            return reb_isp, reb, s

    if len(reb) == 0:
        return reb_isp, reb, s

    min_reb = reb[0]
    for i in range(len(reb)):
        if min_reb[0] > reb[i][0] and (reb[i][1] in reb_isp or reb[i][2] in reb_isp):
            min_reb = reb[i]

    s += min_reb[0]
    if min_reb[1] not in reb_isp:
        reb_isp += min_reb[1]
    else:
        reb_isp += min_reb[2]
    reb.remove(min_reb)
    return reb_isp, reb, s


while reb:
    reb_isp, reb, s = func(reb_isp, reb, s)


print(s)
