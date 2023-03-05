'''reb = [[10,'1','2'], [100,'1','5'], [30,'1','4'], [50,'2','3'], [10,'3','5'],[20,'4','3'], [60,'4', '5']]
k = '12345'
maxx = 100'''

#Ввод дуг
reb = []
maxx = 0
versh = ''
inp = input()
k = ''
while inp != '':
    inp_str = [int(inp.split()[0]), inp.split()[1], inp.split()[2]]
    if inp_str[1] not in k:
        k += inp_str[1]
    if inp_str[2] not in k:
        k += inp_str[2]
    maxx = max(maxx, inp_str[0])
    reb.append(inp_str)
    inp = input()

#Точки
a = int(input('От куда:')) - 1
b = int(input('Куда:')) - 1

#Массив значений
d = [maxx]*len(k)

#Заполнение значений для первой точки
versh = str(a + 1)
for i in range(len(d)):
    for j in range(len(reb)):
        if reb[j][1] == str(a + 1) and reb[j][2] == str(i+1):
            d[i] = reb[j][0]
print(d)
minn = maxx
minn_ind = None
for i in range(len(d)):
    if d[i] < minn and str(i+1) not in versh:
        minn = d[i]
        minn_ind = i
a = minn_ind

#Изменение значений для остальных
while a != None:
    versh += str(a + 1)
    for i in range(len(d)):
        for j in range(len(reb)):
            if reb[j][1] == str(a + 1) and reb[j][2] == str(i+1):
                d[i] = min(reb[j][0] + d[a], d[i])
    minn = maxx
    minn_ind = None
    for i in range(len(d)):
        if d[i] < minn and str(i+1) not in versh:
            minn = d[i]
            minn_ind = i
    a = minn_ind

print(d[b])