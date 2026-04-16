Algoritmo Ejercicio2
	Definir num1, num2 Como Real
	Escribir Sin Saltar "Digite dos valores numericos: "
	leer num1
	leer num2
	//Menu de las operaciones
	Escribir "************************"
	Escribir "MENU PRINCIPAL"
	Escribir "1- suma"
	Escribir "2- Resta"
	Escribir "3- Multiplicación"
	Escribir "4- Division"
	Escribir "5- Salir"
	Escribir Sin Saltar "Digite el numero segun su Operación: "
	Leer opc
	
	//evaluar la Opcion 
			Segun opc Hacer
				1:
					msj="El resultado de la suma es:"
					result=num1+num2
				2:
					msj="El resultado de la Resta es:"
					result=num1-num2
				3:
					msj="El resultado de la Multiplicación es:"
					result=num1*num2
				4:
					msj="El resultado de la División es: "
					result=num1/num2
				5:
					msj="Saliendo del sistema..."
				De Otro Modo:
					msj="Selecciona una opción valida!!!"
			Fin Segun
			Escribir msj
			Escribir result
FinAlgoritmo
