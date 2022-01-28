#Generar la tabla de multiplicar del 3.

print("tabla de multiplicar")

resultado =0
contador = 3
acumulador = 0

for i in range (12):
    acumulador +=1
    contador = contador*1
    resultado = contador*acumulador
    print(contador,"*", acumulador, "= ", resultado)