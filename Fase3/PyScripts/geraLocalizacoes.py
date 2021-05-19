import csv
import json

fileData = []
id = 0

localizacoesData = []

with open('../archive/countries_europe.csv', newline='') as csvfile:
    data =list(csv.reader(csvfile))

for country in data:
    if ('EUROPE' in country[1]):
        dados = {
                "id": id,
                "designacao": country[0]
                }

        id += 1
        localizacoesData.append(dados)

with open('./datasets/localizacoes.json', 'w') as outfile:
    json.dump(localizacoesData, outfile, sort_keys=True, indent=4, separators=(',',': '))
