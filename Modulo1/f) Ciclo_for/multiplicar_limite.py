#Generar las tablas de multiplicar del 1 hasta el limite que el usuario desee.

print("ingrese hasta que numero será el limite")
limite = int(input())

sumador = 0



for i in range (limite):

    sumador+=1

    resultado = sumador*limite

    # for i in range (1, 12 +1):

    # sumador +=1
    # sumador2 +1
    # resultado = sumador*sumador2

    print(sumador, "*",limite, "=", resultado)




