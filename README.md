
# Parcial #3 - Programación en C\#

Ejercicios desarrollados para la aplicación de **clases abstractas, herencia, polimorfismo, serialización JSON y seguridad de contraseñas mediante BCrypt**, utilizando **C#**, Windows Forms y conexión a una base de datos MySQL.

**Parcial  #3**\
**Universidad Tecnológica de Panamá - Facultad de Ingeniería en Sistemas**

**Programado por:** Kevin Esquivel

**Fecha:** 09/11/2026

---

## 📋 Descripción

Este parcial contiene tres ejercicios desarrollados en **C#**, enfocados en la aplicación de diferentes conceptos de programación.

El primer ejercicio implementa **clases abstractas y polimorfismo** para calcular el área y perímetro de figuras geométricas.

El segundo ejercicio utiliza la biblioteca **Newtonsoft.Json** para convertir los datos de un objeto a formato JSON.

El tercer ejercicio implementa un **sistema de registro e inicio de sesión** mediante Windows Forms, utilizando **BCrypt** para proteger las contraseñas y **MySQL** para almacenar los usuarios y registrar los intentos de acceso.

---

## 🔧 Funciones principales

### Ejercicio 1 - Clases abstractas y polimorfismo

Se implementó una clase abstracta llamada `Figura`, de la cual heredan las clases `Rectangulo`, `Cuadrado` y `Triangulo`.

El programa permite realizar las siguientes operaciones:

- **Área:** calcular el área de cada figura mediante `CalcularArea()`.
- **Perímetro:** calcular el perímetro mediante `CalcularPerimetro()`.
- **Herencia:** implementar los métodos definidos en la clase abstracta.
- **Polimorfismo:** almacenar diferentes figuras en un arreglo `Figura[]`.
- **Resultados:** recorrer las figuras mediante `foreach` y mostrar sus respectivos cálculos.

### Ejercicio 2 - Serialización JSON

Se desarrolló un programa que utiliza la biblioteca **Newtonsoft.Json** para convertir un objeto a formato JSON.

El objeto contiene los siguientes datos:

- Nombre
- Edad
- Carrera

La conversión se realiza mediante `JsonConvert.SerializeObject()`, mostrando el resultado en consola.

### Ejercicio 3 - Login con BCrypt y MySQL

Se implementó un sistema de registro e inicio de sesión utilizando **C# Windows Forms**, conexión a MySQL y protección de contraseñas mediante BCrypt.

El programa permite realizar las siguientes operaciones:

- **Crear usuario:** registrar nuevos usuarios en la base de datos.
- **Hash:** generar contraseñas protegidas mediante `BCrypt.HashPassword()`.
- **Inicio de sesión:** validar el usuario y la contraseña ingresados.
- **Verificación:** comprobar las contraseñas mediante `BCrypt.Verify()`.
- **Validaciones:** mostrar mensajes cuando existen campos vacíos, usuarios duplicados o credenciales incorrectas.
- **Usuario conectado:** mostrar un mensaje de bienvenida cuando las credenciales son correctas.
- **Registro de intentos:** almacenar los accesos logrados y no logrados con su fecha y hora.

La conexión con MySQL se realiza mediante una clase independiente llamada `Conexion`, encargada de establecer la comunicación entre la aplicación y la base de datos.

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET
- **IDE:** Visual Studio
- **Tipo de aplicación:** Consola y Windows Forms
- **Base de datos:** MySQL
- **Conexión:** MySql.Data
- **Serialización:** Newtonsoft.Json
- **Seguridad:** BCrypt.Net-Next
- **Paradigmas:** Programación Orientada a Objetos

---

## 🗄️ Base de datos

El tercer ejercicio utiliza la base de datos **`Parcial_3`**, que contiene dos tablas:

- **usuarios:** almacena el nombre de usuario y su contraseña protegida mediante BCrypt.
- **intentos:** registra el usuario, resultado y fecha de cada intento de inicio de sesión.

La tabla `usuarios` contiene los campos:

- `id`
- `usuario`
- `clave`

La tabla `intentos` contiene los campos:

- `id`
- `usuario`
- `resultado`
- `fecha`

Para consultar los registros almacenados se pueden ejecutar las siguientes instrucciones en MySQL Workbench:

```sql
USE Parcial_3;

SELECT * FROM usuarios;

SELECT * FROM intentos;
```

La aplicación utiliza consultas SQL parametrizadas para registrar usuarios, verificar credenciales y guardar los intentos de acceso.

El respaldo **`Parcial_3.sql`** permite importar la estructura de la base de datos.

---

## ⚙️ Instalación

**Requisitos:** Visual Studio, .NET, MySQL Server, MySQL Workbench y Git.

**Abrir los proyectos:**

1. Clonar o descargar el repositorio.
2. Abrir los proyectos correspondientes en Visual Studio.
3. Restaurar los paquetes NuGet necesarios.
4. Ejecutar los ejercicios desde Visual Studio.

**Importar la base de datos del ejercicio 3:**

1. Abrir MySQL Workbench.
2. Ir a **Server → Data Import**.
3. Seleccionar **Import from Self-Contained File**.
4. Buscar el archivo `Parcial_3.sql`.
5. Importar la base de datos.

**Configurar la conexión:**

En el archivo `Conexion.cs`, configurar los datos de conexión según el servidor MySQL utilizado:

- **Server:** dirección del servidor.
- **Database:** `Parcial_3`.
- **Uid:** usuario de MySQL con los permisos necesarios.
- **Pwd:** contraseña correspondiente a ese usuario.

Una vez configurada la conexión, ejecutar el tercer ejercicio desde Visual Studio para registrar usuarios e iniciar sesión.
