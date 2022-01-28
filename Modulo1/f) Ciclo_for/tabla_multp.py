#Generar la tabla de multiplicar pidiendo al usuario que digite el valor.

print("ingrese el valor con el que quiere la tabla de multiplicar")
tabla = int(input())

resultado =0
acumulador = 0

for i in range (12):
    acumulador +=1
    tabla = tabla*1
    resultado = tabla*acumulador
    print(tabla,"*", acumulador, "= ", resultado)