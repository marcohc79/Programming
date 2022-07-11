def sumador(**kawargs):
    inicial = kawargs['inicial']
    final = kawargs['final']

    resultado = 0
    for x in range(inicial, final):
        resultado += x
    return resultado

print(sumador(inicial=1,final=3, algo=90))
