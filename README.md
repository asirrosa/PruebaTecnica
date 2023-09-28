# PruebaTecnica
## Pasos para ejecutar la aplicación:

1. Descargar el ```.zip``` del repositorio
2. Abrir preferiblemente Visual Studio y darle a ``Abrir un proyecto o solución``
3. Seleccionar el archivo ``WindowsFormsAplicacion.sln``
4. Dentro de este proyecto tendremos dos proyectos, ExpressApp que servira para dar el servicio y WindowsFormsAplicacion que será nuestra aplicación desarrollada con Windows Forms.
5. Para iniciar el servicio de Express.js, abriremos una terminal de powershell, entraremos dentro del directorio ``.\ExpressApp\`` y ejecutaremos el comando ``nodemon .\app.js``
6. Ahora solo nos faltara iniciar la aplicación creada con Windows Forms, para iniciarla solo tendremos que volver a entrar dentro del Visual Studio, click derecho en el proyecto raiz (que contiene ambos proyectos) -> propiedades -> Propiedades comunes -> Y seleccionaremos estas configuraciones:
![Captura](https://github.com/asirrosa/PruebaTecnica/assets/143890605/2d7388a5-6fb8-47ee-a3a1-18e699430da1)
7. Finalmente una vez hayamos realizado el anterior paso ejecutaremos el programa WindowsFormsAplicacion.

