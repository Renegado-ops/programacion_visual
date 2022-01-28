#Generar las tablas de multiplicar del 1 al 5, excepto la del 2 y 3.

print("tabla de multiplicar del 1 al 5, exceptuando el tabla del 2 y 3")

sumador = 0
sumador2 = 1
resultado = 0

sumador1 = 0
sumador3 = 4
resultado1 = 0

sumador6 = 0
sumador4 = 5
resultado2 = 0

print("-"*15)

for i in range (1, 12 +1):

    sumador +=1
    sumador2 +1
    resultado = sumador*sumador2

    print(sumador, "*", sumador2, " = ", resultado)

print("-"*15)

for i in range (1, 12 +1):

    sumador1 +=1
    sumador3 +1
    resultado1 = sumador1*sumador3

    print(sumador1, "*", sumador3, " = ", resultado1)

print("-"*15)

for i in range (1, 12 +1):

    sumador6 +=1
    sumador4 +1
    resultado2 = sumador6*sumador4

    print(sumador6, "*", sumador4, " = ", resultado2)

print("-"*15)


