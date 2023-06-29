using EspacioEmpleados;

int cantidadEmpleados = 3;

Empleados[] arregloEmpleados = new Empleados[cantidadEmpleados];        // Declaración de un arreglo del tipo clase "Empleados"

for(int i=0; i<arregloEmpleados.Length; i++) {

    arregloEmpleados[i] = new Empleados();      // Importante (!)

    Console.Write($"\n > Ingrese el nombre del empleado nro. {i+1}: ");
    string? nombre = Console.ReadLine();

    arregloEmpleados[i].Nombre = nombre;

    Console.Write($"\n\n > Ingrese el apellido del empleado nro. {i+1}: ");
    string? apellido = Console.ReadLine();

    arregloEmpleados[i].Apellido = apellido;

    Console.Write($"\n\n > Ingrese la fecha de nacimiento del empleado nro. {i+1} (formato dd/mm/yyyy): ");
    string? fechaNacimientoStr = Console.ReadLine();

    DateTime fechaNacimiento;

    while(!DateTime.TryParse(fechaNacimientoStr, out fechaNacimiento)) {        // Convierte un string en una fecha (formato dd/mm/yyyy)

        Console.Write("\n (!) Ingresó un formato inválido. \n > Ingrese nuevamente (dd/mm/yyyy): ");
        fechaNacimientoStr = Console.ReadLine();

    }

    arregloEmpleados[i].FechaNacimiento = fechaNacimiento;

    Console.Write($"\n\n > Seleccione el estado civil del empleado nro. {i+1}: \n\n [1] - Soltero/a \n [2] - Casado/a \n [3] - Divorciado/a \n [4] - Viudo/a \n\n >> Su respuesta: ");
    string? input = Console.ReadLine();
    int option = 0;

    while(!int.TryParse(input, out option) || option < 1 || option > 4) {

        Console.Write("\n\n (!) Ha ingresado una opción inválida. \n > Ingrese nuevamente: ");
        input = Console.ReadLine();

    }

    char estadoCivil = 'X';

    switch(option) {

        case 1:
            estadoCivil = 'S';
        break;

        case 2:
            estadoCivil = 'C';
        break;

        case 3:
            estadoCivil = 'D';
        break;

        case 4:
            estadoCivil = 'V';
        break;

    }

    arregloEmpleados[i].EstadoCivil = estadoCivil;

    Console.Write($"\n\n > Seleccione el género del empleado nro. {i+1} (F o M): ");
    string? genero = Console.ReadLine();

    while(genero != "f" && genero != "F" && genero != "m" && genero != "M") {

        Console.Write("\n\n (!) Ha ingresado una opción inválida. \n > Ingrese nuevamente: ");
        genero = Console.ReadLine();

    }

    if(genero == "f" || genero == "F") {
        arregloEmpleados[i].Genero = 'F';
    }
    else {
        arregloEmpleados[i].Genero = 'M';
    }

    Console.Write($"\n\n > Ingrese la fecha de ingreso del empleado nro. {i+1} (formato dd/mm/yyyy): ");
    string? fechaIngresoStr = Console.ReadLine();

    DateTime fechaIngreso;

    while(!DateTime.TryParse(fechaIngresoStr, out fechaIngreso)) {        // Convierte un string en una fecha (formato dd/mm/yyyy)

        Console.Write("\n (!) Ingresó un formato inválido. \n > Ingrese nuevamente (dd/mm/yyyy): ");
        fechaIngresoStr = Console.ReadLine();

    }

    arregloEmpleados[i].FechaIngreso = fechaIngreso;

    Console.Write($"\n\n > Ingrese el sueldo básico del empleado nro. {i+1}: $");
    string? sueldoBasicoStr = Console.ReadLine();

    double sueldoBasico;

    while(!double.TryParse(sueldoBasicoStr, out sueldoBasico)) {

        Console.Write("\n\n (!) Ingresó algo inválido. \n Ingrese nuevamente: ");
        sueldoBasicoStr = Console.ReadLine();

    }

    arregloEmpleados[i].SueldoBasico = sueldoBasico;

    Console.Write($"\n\n > Seleccione el cargo que tiene el empleado {i+1}: \n\n");
    Console.WriteLine($"[1] - {Cargos.Auxiliar}");
    Console.WriteLine($"[2] - {Cargos.Administrativo}");
    Console.WriteLine($"[3] - {Cargos.Ingeniero}");
    Console.WriteLine($"[4] - {Cargos.Especialista}");
    Console.WriteLine($"[5] - {Cargos.Investigador}");

    Console.Write("\n\n >> Su respuesta: ");
    input = Console.ReadLine();

    int option1 = 0;

    while(!int.TryParse(input, out option1) || option1 < 1 || option1 > 5) {

        Console.Write("\n\n (!) Ingresó una opción inválida. \n > Ingrese nuevamente: ");
        input = Console.ReadLine();

    }

    switch(option) {

        case 1:
            arregloEmpleados[i].Cargo = Cargos.Auxiliar;
        break;

        case 2:
            arregloEmpleados[i].Cargo = Cargos.Administrativo;
        break;

        case 3:
            arregloEmpleados[i].Cargo = Cargos.Ingeniero;
        break;

        case 4:
            arregloEmpleados[i].Cargo = Cargos.Especialista;
        break;

        case 5:
            arregloEmpleados[i].Cargo = Cargos.Investigador;
        break;

    }

}

Console.ReadLine();

double montoTotalSalarios = 0;

for(int i=0; i<arregloEmpleados.Length; i++) {

    montoTotalSalarios += arregloEmpleados[i].calcularSalario(arregloEmpleados[i].calcularAntigüedad());

}

Console.Write("\n\n >> Monto total en concepto de salarios: $" + montoTotalSalarios);

Console.ReadLine();

int empleado = 0;

for(int i=0; i<arregloEmpleados.Length; i++) {

    if(arregloEmpleados[i].calcularAñosRestantesJubilacion(arregloEmpleados[i].calcularEdad()) < arregloEmpleados[empleado].calcularAñosRestantesJubilacion(arregloEmpleados[empleado].calcularEdad())) {
        empleado = i;
    }

}

Console.Write("\n\n (!) Estos son los datos del empleado más próximo a jubilarse: \n");

Console.Write($"\n\n >> Nombre del empleado:  {arregloEmpleados[empleado].Nombre} {arregloEmpleados[empleado].Apellido}");
Console.Write($"\n\n >> Fecha de nacimiento: {arregloEmpleados[empleado].FechaNacimiento}");
Console.Write($"\n\n >> Estado civil: {arregloEmpleados[empleado].EstadoCivil}");
Console.Write($"\n\n >> Género: {arregloEmpleados[empleado].Genero}");
Console.Write($"\n\n >> Fecha de ingreso: {arregloEmpleados[empleado].FechaIngreso}");
Console.Write($"\n\n >> Sueldo básico: ${arregloEmpleados[empleado].SueldoBasico}");
Console.Write($"\n\n >> Cargo: {arregloEmpleados[empleado].Cargo}");
Console.Write($"\n\n >> Antigüedad: {arregloEmpleados[empleado].calcularAntigüedad()} años");
Console.Write($"\n\n >> Edad: {arregloEmpleados[empleado].calcularEdad()} años");
Console.Write($"\n\n >> Años restantes hasta jubilación: {arregloEmpleados[empleado].calcularAñosRestantesJubilacion(arregloEmpleados[empleado].calcularEdad())} años");
Console.Write($"\n\n >> Salario: ${arregloEmpleados[empleado].calcularSalario(arregloEmpleados[empleado].calcularAntigüedad())}");

Console.ReadLine();