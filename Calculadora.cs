namespace EspacioCalculadora {

    class Calculadora {
        private double dato;        // Atributo (privado)
        public double Dato { get => dato; set => dato = value; }        // Encapsulamiento del atributo "dato"

        public double Resultado { get => dato; }      // Prpiedad que obtiene el valor de la variable "dato"
            
        // Métodos

        public Calculadora() {      // Constructor de la clase "Calculadora". Inicializa el atributo "dato".
            dato = 0;
        }

        public void Sumar(double numero) {
            Dato += numero;
        }

        public void Restar(double numero) {
            Dato -= numero;
        }

        public void Multiplicar(double numero) {
            Dato *= numero;
        }

        public void Dividir(double numero) {
            Dato /= numero;
        }

        public void Limpiar() {
            Dato = 0;
        }

    }

}