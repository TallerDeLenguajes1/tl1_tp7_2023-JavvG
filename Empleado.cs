namespace EspacioEmpleados {

    public enum Cargos {        // Enumeración
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }

    public class Empleados {

        // Atributos

        private string? nombre;
        private string? apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        // Encapsulamiento - propiedades

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        // Métodos

        public int calcularAntigüedad() {
            return (DateTime.Now.Year - FechaIngreso.Year);
        }

        public int calcularEdad() {
            return(DateTime.Now.Year - FechaNacimiento.Year);
        }

        public int calcularAñosRestantesJubilacion(int edad) {

            if(Genero == 'M') {
                return 65 - edad;
            }
            else {
                return 60 - edad;
            }

        }

        public double calcularSalario(int antigüedad) {

            double adicional = 0;

            if(antigüedad < 20) {
                adicional = SueldoBasico * (antigüedad * 0.01);        // 1% del sueldo básico por cada año de antigüedad hasta los 20 años
            }
            else {
                adicional = SueldoBasico * (antigüedad * 1.25);       // 25% del sueldo básico por cada año de antigüedad desde los 25 años
            }

            if(Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista) {
                adicional += (adicional * 1.5);     //Si el cargo es Ingeniero o Especialista, el Adicional se incrementa en un 50%
            }

            if(EstadoCivil == 'C') {
                adicional += 15000;
            }

            return (SueldoBasico + adicional);

        }

    }
    
}