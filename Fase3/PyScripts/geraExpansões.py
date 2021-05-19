import json

fileData = []
id = 0

expansoesNamesData = []

with open('../archive/SetList.json') as json_file:
    fileData = json.load(json_file)

expansoesNames = list(fileData)

for e in expansoesNames:
    dados = { 
            "id": id,
            "name": e["name"]
            }
    id += 1
    expansoesNamesData.append(dados)

with open('./datasets/expansoes.json', 'w') as outfile:
    json.dump(expansoesNamesData, outfile, sort_keys=True, indent=4, separators=(',',': '))
