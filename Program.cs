using EspacioCalculadora;

Calculadora calculadora = new Calculadora();        // Se crea un nuevo objeto/instancia "calculadora" de la clase "Calculadora"

int flag = 0;

string? repeat = "Y";

Console.WriteLine("\n\t\t --- CALCULADORA ---");

do {

    Console.WriteLine("\n ¿Qué operación desea realizar?");
    Console.Write("\n [1] - Sumar \n [2] - Restar \n [3] - Multiplicar \n [4] - Dividir \n [5] - Salir del programa \n\n >> Su respuesta: " );

    string? input1 = Console.ReadLine();

    int option = 0;     // Se inicializa la variable para evitar errores

    while(!int.TryParse(input1, out option) || option < 0 || option > 5) {      // Controla que la cadena ingresada pueda convertirse efectivamente a un número entero comprendido entre 1 y 5

        Console.Write("\n\n (!) Ha ingresado una opción inválida.\n > Ingrese nuevamente: ");
        input1 = Console.ReadLine();

    }

    double numero = 0;

    if(option != 5) {

        Console.Write("\n > Ingrese un número (las operaciones se realizan de forma encadenada sobre un mismo resultado): ");
        input1 = Console.ReadLine();

        while(!double.TryParse(input1, out numero)) {      // Controla que la cadena ingresada pueda transformarse efectivamente a un número real
            
            Console.Write("\n\n (!) Ha ingresado un caracter inválido.\n > Ingrese un número: ");
            input1 = Console.ReadLine();

        }

    }

    if(flag == 0 && option != 5) {
        Console.WriteLine("\n (!) El valor inicial de la calculadora es 0, por lo que la primera operación se calculará de forma encadenada respecto a ese valor y al número que usted ingrese");
    }

    switch(option) {

        case 1:
            calculadora.Sumar(numero);
        break;

        case 2:
            calculadora.Restar(numero);
        break;

        case 3:
            calculadora.Multiplicar(numero);
        break;

        case 4:
            calculadora.Dividir(numero);
        break;

        case 5:
            calculadora.Limpiar();
        break;

    }

    if(option != 5) {
        Console.Write("\n\n >> Este es el resultado: " + calculadora.Resultado);
        Console.Write("\n\n > ¿Desea realizar otra operación consecutiva? \n >> Su respuesta [S] - [N]: ");
        repeat = Console.ReadLine();

        while(repeat != "Y" && repeat != "y" && repeat != "S" && repeat != "s" && repeat != "N" && repeat != "n") {

            Console.Write("\n\n (!) Ha ingresado un caracter inválido.\n > Ingrese nuevamente: ");
            repeat = Console.ReadLine();

        }

        if(repeat == "Y" || repeat == "y" || repeat == "S" || repeat == "s") {
            flag = 1;
        }
    }
    else {
        repeat = "N";
    }

    

} while(repeat == "Y" || repeat == "y" || repeat == "S" || repeat == "s");

Console.WriteLine("\n\n Fin del programa (!)");

Console.ReadLine();