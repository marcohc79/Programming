def revisarNota (nota):
    if nota>=4:
        return 'Aprobado'
    return 'No Aprobado'

def convertirNota(nota):
    if 90<= nota <=100:
        return 'A'
    if 80<= nota <=89:
        return 'B'
    if 70<= nota <=79:
        return 'C'
    if 60<= nota <=69:
        return 'D'
    if 0<= nota <=59:
        return 'F'

def edades(edad):
    if edad >=18:
        return 'Mayor de edad'
    elif 0<= edad <18:
        return 'Menor de edad'
    else:
        return 'Edad no valida'
