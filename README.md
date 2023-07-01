# Clínica veterinaria

## Introducción

Desarrollamos el caso de una hipotética clínica veterinaria. La misma, almacena datos de sus clientes (dueños de las mascotas) que, en este caso, son: nombre, apellido y correo electrónico. Estos datos son introducidos y gestionados por la persona encargada de la atención a clientes. Además, cada cliente cuenta con un identificador único.

Es posible, de esta manera, realizar un CRUD de nuestra entidad principal (cliente).


## Desarrollo

Para el desarrollo de la solución, se siguió e implementó una arquitectura de software bajo los conceptos de DDD, principios SOLID y buenas prácticas de la programación, contando así con:
- Capa de presentación
- Capa de aplicación
- Capa de *dominio*
- Capa de infraestructura de datos

Se realizaron una serie de pruebas unitarias de los *value objects* de nuestra capa de dominio.

Para la persistencia de datos, es posible intercambiar entre SQL Server y MongoDB. 

Adicionalmente, se implementó Entity Framework.

### Caso de uso 
![ClinicaVeterinaria](./documentacion/UML.png "Caso de Uso")