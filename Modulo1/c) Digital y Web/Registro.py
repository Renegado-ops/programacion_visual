#1)Realizar el registro de una cuenta en Facebook. El usuario debe ingresar su nombre, apellido, email
#contraseña, fecha de cumpleaños y sexo.

#2)Hacer un programa que confirme que las dos contraseñas ingresadas por un usuario son iguales. 
#Mostrar un mensaje de éxito cuando sean iguales. En caso contrario, pedir al usuario que intente nuevamente 
#hasta que sean iguales.

#3)Hacer el proceso de registro de usuario y login.



#1
print("Registro de usuario")
print("Ingrese cual es su nombre")
nombre = input()

print("Ingrese cual es su apellido")
apellido = input()

print("Ingrese cual será su nombre de usuario")
nombre_usuario = input()

print("Ingrese cual es su email")
email = input()

print("Ingrese cual es su contraseña")
contraseña = input()

print("Confirme su contraseña")
contraseña2 = input()

print("Ingrese cual es su fecha de cumpleaños")
fecha_de_cumpleaños = input()

print("Ingrese cual es su sexo")
sexo = input()


#2

while contraseña2 != contraseña:
    print("Su contraseña no es la misma intente la de nuevo")
    print("Ingrese cual es su contraseña")
    contraseña = input()

    print("Confirme su contraseña")
    contraseña2 = input()


#3

print ("Login \n")

print("Enter your username \n")
username = input()




while username =="":
        print("please enter your username again \n")
        username = input()
if nombre_usuario == username:
    print("es correcto")


print("Enter your password \n")
password = input()


while password =="":
        print("please enter your password again \n")
        password = input()

if password == contraseña:
    print("es correcto")


    
