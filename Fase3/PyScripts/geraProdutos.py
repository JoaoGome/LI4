import json
import random

fileData = []
id = 0

produtosData = []

with open('./datasets/cartas.json') as json_file:
    fileData = json.load(json_file)

produtosName = list(fileData)

for i in range(0,10000):
    carta = random.randint(0,(len(produtosName) - 1))
    expansao = random.randint(0,460)
    condicao = random.randint(0,6)
    linguagem = random.randint(0,10)
    data =  {
                "id": id,
                "Nome": produtosName[carta]["name"],
                "fk_Condicao": condicao,
                "fk_expansao": expansao,
                "fk_linguagem": linguagem
            }

    produtosData.append(data)
    id += 1


with open('./datasets/produtos.json', 'w') as outfile:
    json.dump(produtosData, outfile, indent=4, separators=(',',': '))

