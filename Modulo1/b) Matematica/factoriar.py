#Realizar un programa para obtener el factorial de un número entero. 

fact = int(input("ingrese numero: "))

acumulador = 1


for i in range (fact, 0, -1):
    acumulador = acumulador * i
print(acumulador)

