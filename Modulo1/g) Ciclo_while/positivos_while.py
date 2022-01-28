#Realizar un programa que haga que el usuario sólo digite 2 números positivos.

print("Digite 2 numeros")
numeros = int(input())
numeros2 = int(input())


while numeros <0:
    print("ingrese numeros que sean positivos...")
    numeros = int(input())
    numeros2 = int(input())

while numeros2 <0:
    print("ingrese numeros que sean positivos...")
    numeros = int(input())
    numeros2 = int(input())
