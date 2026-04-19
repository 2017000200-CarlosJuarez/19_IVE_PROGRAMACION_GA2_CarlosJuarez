Algoritmo mes
	Definir v, b Como real
	Definir a como entero
	
	Escribir "Ingrese el valor que desee calcular"
	leer v
	
	Escribir "1 - metros"
	Escribir "2 - pies"
	Escribir "3 - centimetros"
	Escribir "4 - pilgadas"
	Escribir "Elija el numero segun su medida"
	leer a
	
	Segun a Hacer
		1:  b = v 
		2:  b = v * 3.28
		3:  b = v*100
		4:  b = v*39.37
	FinSegun
	
	Escribir "Su resultado es: ",b
FinAlgoritmo
