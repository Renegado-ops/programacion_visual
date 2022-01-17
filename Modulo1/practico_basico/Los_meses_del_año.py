#Programa que introduciendo un numero del 1 al 12 me dia el mes en el que estamos.

mes = int(input("Introduzca un numero del 1 al 12 para saber los meses: "))
a, b, c, d, e, f, g, h, i, j, k, l = 1,2,3,4,5,6,7,8,9,10,11,12

if (mes == a):
    print("El mes introducido es enero")
elif (mes == b):
    print("Es febrero")
elif (mes == c):
    print("Es marzo")
elif (mes == d):
    print("Es abril")
elif (mes == e):
    print("Es mayo")
elif (mes == f):
    print("Es junio")
elif (mes == g):
    print("Es julio")
elif (mes == h):
    print("Es agosto")
elif (mes == i):
    print("Es septiembre")
elif (mes == j):
    print("Es octubre")
elif (mes == k):
    print("Es noviembre")
elif (mes == l):
    print("Es diciembre")
elif (mes > 12):
    print("error")