f = open('D:/potions.txt')

translate = {
    'MIX': ['MX', 'XM'],
    'WATER': ['WT', 'TW'],
    'DUST': ['DT', 'TD'],
    'FIRE': ['FR', 'RF']
}

def pot(potion):
    potion = potion.split()
    potion_func = translate[potion[0]][0]

    for char in potion[1:]:
        if char.isnumeric():
            potion_func += potions[int(char) - 1]
        else:
            potion_func += char

    potion_func += translate[potion[0]][1]
    return potion_func


potions = []

for potion in f.readlines():
    now_potion = pot(potion.split('\n')[0])
    potions.append(now_potion)

print(potions[-1])
