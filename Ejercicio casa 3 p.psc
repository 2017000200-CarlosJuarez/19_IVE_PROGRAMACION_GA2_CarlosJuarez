Algoritmo mes
	Definir z, p Como real
	Definir s, c como entero
	
	Escribir "1 - calco Q300"
	Escribir "2 - tribuna Q100 o Q150"
	Escribir "3 - preferencia Q50 o Q75"
	Escribir "4 - generales Q30 o Q50"
	Escribir "Elija el numero segun su sector"
	leer s
	
	Segun s Hacer
		1: p = 200
		2: p = 100 
		3: p = 50
		4: p = 30
	FinSegun
	
	Escribir "Cantidad de entradas queridas"
	leer c
	
	z = p * c
	
	Escribir "El precio total es: ", z
FinAlgoritmo
