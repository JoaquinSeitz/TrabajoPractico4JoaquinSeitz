# Trabajo Práctico N° 4 - Cliente REST en Blazor Hybrid
**Alumno:** Joaquín Seitz
**Institución:** ITES
**Materia:** Programación III - Aplicaciones Móviles

## Descripción
Este proyecto es una aplicación frontend desarrollada en **.NET MAUI Blazor Hybrid** (.NET 10). Su objetivo es actuar como un cliente RESTful para consumir la API pública [FakeStore API](https://fakestoreapi.com/).

## Endpoints Consumidos y Páginas
La aplicación cuenta con una página principal `Productos.razor` (ruta: `/productos`), accesible desde el menú de navegación lateral. En esta vista se consumen los siguientes endpoints mediante `HttpClient`:

* **GET `/products?limit=5`**: Recupera y lista los productos en una tabla HTML.
* **POST `/products`**: Envía un objeto JSON para simular la creación de un nuevo producto ("Bikini de Carton Corrugado").
* **PUT `/products/21`**: Envía un objeto JSON para simular la actualización del producto con ID 21.
* **DELETE `/products/21`**: Envía una solicitud para simular la eliminación del producto con ID 21.