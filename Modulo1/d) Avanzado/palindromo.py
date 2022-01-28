#Realizar un algoritmo que diga si una cadena de texto es un palíndromo.

palidrome = input('Enter una palabra palindrome o no: ')
reversa = ''.join(reversed(palidrome))


print(list(reversed(palidrome)))

if (palidrome == reversa):
  print(palidrome,'es palidromo')
else:
  print(palidrome,'no es palindrome')





