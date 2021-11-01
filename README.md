# Título
*UTNFra Laboratorio de Computación II - Primer Parcial - Comisión 2do D - 2do cuatrimestre 2021*

### Mendoza.Maximiliano.ParcialLaboratorioII2D

[Enunciado del parcial](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/evaluaciones/parciales/2d-primer-parcial/)

# Sobre mí
> Mendoza Maximiliano , tercera vez recursando (la tercera es la vencida) cursando solo esta materia.

# Resumen

1°. Asigne los datos del cliente (nombre,apellido,edad,dni) dependiendo lo que quiera usar, marque computadora o cabina, se habilitara las opciones correspondiente a las necesidades del cliente.Una vez cargado todos los datos, oprima el boto 'OK'"        
2°. El boton 'Asignar' le asignara una maquina al cliente , dichos clientes se pueden observar en la 'lista de clientes'.         
3°. Se podran observar las maquinas en sus respectivas listas tanto disponibles como ocupadas, el boton 'FinalizarTarea' terminará con la tarea que esté realizando la maquina y proporcionará datos de tiempos y costos correspondientes.
4°. Al hacer doble clic en cualquiera de las listas se le brindará los datos correspondientes de dicha maquina y se vera reflejado en el formulario");

# Diagrama de clases
![Diagrama](https://user-images.githubusercontent.com/29763406/139609320-0ac5ff34-02ea-407e-b060-97f82fc12003.png)


# Justificación técnica

- **Metodos estaticos:** ubicados en la clase 'Local' usados para manejar, administrar, guardar datos en las listas
- **Datetime :** ubicados en las clases  'computadora' y 'cabina' para poder establecer el tiempo de uso de la maquina
- **Sobrecargas:** usadas en cada clase, la mayoria para poder comparar dos objeto.En la clase 'local' son usados para cargar, eliminar listas
- **Windows forms:** basicamente es la interfas de usuario
- **Colecciones:** list<> para administrar las computadoras y las cabinas  en la clase 'Local' Queue<> para administrar los clientes
- **Propiedades:** cada atributo de cada clase cuenta con propiedades con seus get y set correspondiente
- **Indexador:** usado para trabajar con la Queue de 'cliente'
- **Enumerados:** usado para ver la spetisiones del cliente
- **Herencia:** clase abstracta 'Maquina' la cual heredan 'computadora' y 'cabina' 
- **Sealed:** solo la clase 'Petisiones' ya que no le ví sentido que tenga herencia.
- **Polimorfismo:** La clase 'Maquina' cuenta con algunas funciones (por ej Mostrar())que van a ser sobreescritas en sus clases derivadas


# Propuesta de valor agregado
-La nueva funcionalidad implica cargarle una bebida al cliente ya sea que esté en una computadora o una cabina.Al finalizar la tarea de cualquier maquina , el valor total a pagar sera la tarifa de la computadora o cabina usada más las bebidas consumidas.
 Se agregan dos nuevas estadisticas que brindan una lista con las recaudaciones totales de cada maquina en el dia.

# Paquete Nugget agregado
>[TimePeriodLibrary.NET](https://www.codeproject.com/Articles/168662/Time-Period-Library-for-NET) , usado para calcular diferencias entre laapsos de tiempo, las usé para calcular el tiempo en que las maquinas estaban ocupadas
