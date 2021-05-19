import json
import random


id = 0
vendasData = []
notas = ["Marcas nos cantos.", "Dobrada um bocado devido a uso.", "Dobrada um bocado por ser foil."]

for i in range(0,50000):
    notasOdds = random.randint(0,15)
    produto = random.randint(0,9999)
    vendedor = random.randint(0,1999)
    ano = 2021
    mes = random.randint(1,6)
    dia = random.randint(1,27)
    data = f'{ano}/{mes}/{dia}'
    preçoP = random.uniform(0.50,15.0)
    preçoP = format(preçoP,'.2f')
    if (notasOdds == 13):
        dados =  {
                    "id": id,
                    "PrecoP": preçoP,
                    "Data": data,
                    "Notas": random.choice(notas),
                    "fk_Produto": produto,
                    "fk_Vendedor": vendedor,
                }
    
    else:
        dados =  {
                    "id": id,
                    "PrecoP": preçoP,
                    "Data": data,
                    "fk_Produto": produto,
                    "fk_Vendedor": vendedor,
                }

    vendasData.append(dados)
    id += 1


with open('./datasets/vendas.json', 'w') as outfile:
    json.dump(vendasData, outfile, indent=4, separators=(',',': '))

