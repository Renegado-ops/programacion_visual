#Generar las tablas de multiplicar del 1 hasta el limite que el usuario desee

print("tabla de multplicar del 5")
limite= int(input())

for n in range (1, limite+1):
    for i in range (13):
        result = i*n
        
        print(i,"*", n, "=", result, "\n")