print ("Digite un numero para saber que cuidad y de que pais: ")
cuidad = input()

print("Buscando registros que coincidan con...: ",cuidad)

print("conexion sakila")

#importar la libreria de mysql para poder conectarnos
import mysql.connector

#establecemos la conexion con  mysql
conexion = mysql.connector.connect(
    host = "localhost",
    user = "root",
    passwd = "",
    db = "sakila"
)

#el cursor representa la terminal de mysql
cursor = conexion.cursor()

#ejecutar un query (sentencia sql)
cursor.execute("SELECT country.country AS pais, city AS ciudad  FROM city INNER JOIN country ON city.city_id = country.country_id WHERE country.country_id = '"+cuidad+"'")

#guardar en una variable todos los resultados del query
resultado = cursor.fetchall()

for registros in resultado:
    print(registros)