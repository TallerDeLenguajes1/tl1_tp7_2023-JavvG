# Ejercicio 1

El parámetro _--output_ en la instrucción _dotnet new console --output ._ se utiliza para especificar el directorio donde se creará el proyecto de consola de .NET. En este caso, el punto (.) indica el directorio actual.
La principal consecuencia de invocar _--output ._ es que el proyecto se crea directamente en el directorio actual, lo que puede ser conveniente si se desea mantener todos los archivos de proyecto en una ubicación específica. Sin embargo, si ya existe un proyecto en ese directorio, se sobrescribirán los archivos existentes con los archivos del nuevo proyecto. 