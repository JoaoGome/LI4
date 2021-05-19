import json
import random

fileData = []
id = 0

vendedoresNamesData = []

with open('./datasets/vendedoresNames.json') as json_file:
    fileData = json.load(json_file)

vendedoresNames = list(fileData)

for v in vendedoresNames:
    vendedoresNamesData.append(v["Name"])

names = []
for i in range(0,2000):
    r1 = random.randint(0,(len(vendedoresNamesData) - 1))
    r2 = random.randint(0,(len(vendedoresNamesData) - 1))

    while(r2 == r1):
        r2 = random.randint(0,(len(vendedoresNamesData) - 1))
    
    name = f'{vendedoresNamesData[r1]} {vendedoresNamesData[r2]}'
    names.append(name)

namesNoDups = list(dict.fromkeys(names))

id = 0
vendedoresData = []

for name in namesNoDups:
    local = random.randint(0,42)
    nameReplaced = name.replace(' ','_')
    email = f'{nameReplaced}@gmail.com'
    data = {
            "id": id,
            "Nome": name,
            "Email": email,
            "fk_Localizacao": local
           }
    id += 1
    vendedoresData.append(data)

with open('./datasets/vendedores.json', 'w') as outfile:
    json.dump(vendedoresData, outfile, indent=4, separators=(',',': '))

