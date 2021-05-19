import json

fileData = []
id = 0

cardNamesData = []

with open('../archive/AllCards.json') as json_file:
    fileData = json.load(json_file)

cardNames = list(fileData)

for e in cardNames:
    dados = {
            "id": id,
            "name": e
            }

    id += 1
    cardNamesData.append(dados)


cardNamesData_json = json.dumps(cardNamesData, indent = 4) 

with open('./datasets/cards.json', 'w') as outfile:
    json.dump(cardNamesData, outfile, sort_keys=True, indent=4, separators=(',',': '))
