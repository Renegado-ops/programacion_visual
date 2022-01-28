#Buscador

print("-"*27,)
buscador = input("Buscador nombre: ")
print("-"*27)

# while buscador =="":
#     buscador = input("Buscador nombre: \n")

# print("\n\nCantidad de resultados: ", "3 ")
# print("-"*27)

# print("{:<15} {:<5}".format("Nombres", "Apellidos"))
# print("-"*27)
# print("{:<15} {:<5}".format("Albert", ("Garcia")))
# print("{:<15} {:<5}".format("Marlin", "Vasquez"))
# print("{:<15} {:<5}".format("Aracelis", "Severino"))
# print("{:<15} {:<5}".format("Erick", "Díaz"))
# print("-"*27)

import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  password="",
  database="infotep"
)


mycursor = mydb.cursor()

sql = "SELECT name, last_name FROM usuarios WHERE name like %s"
adr = ("%"+buscador+"%", )

mycursor.execute(sql, adr)

myresult = mycursor.fetchall()

while buscador =="":
    buscador = input("Buscador nombre: \n")
    print("-"*27)

print("\n\nCantidad de resultados: ", mycursor.rowcount)

print("-"*27)
print("{:<18} {:<5}".format("Nombres", "Apellidos"))
print("-"*27)

for x in myresult:

    print("{:<18} {:<5}".format(x[0], x[1]))
#   print(x[0], x[1])


