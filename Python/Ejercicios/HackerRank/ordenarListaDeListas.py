from operator import itemgetter

lista = [[1,'z'],[3,'r'],[2,'j'],[5,'a'],[9,'a'],[8,'c'],[4,'b']]
print(lista)
lista2 = sorted(lista,key=itemgetter(1))
print(lista2)
lista.sort()
print(lista)
