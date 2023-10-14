
# Annie's Store - Punto de ventas básico

Este repositorio contiene una aplicación de gestión de tienda desarrollada en C# y XAML utilizando Windows Presentation Foundation (WPF). La aplicación proporciona una interfaz de usuario intuitiva para administrar productos, usuarios y las operaciones esenciales de una tienda.


## Tech Stack

- **C#**: El lenguaje de programación principal utilizado para desarrollar la lógica de la aplicación.

- **XAML**: Utilizado para diseñar la interfaz de usuario de la aplicación, permitiendo la creación de interfaces ricas y personalizables.

- **Windows Presentation Foundation (WPF)**: Framework de desarrollo de aplicaciones de escritorio en Windows que permite crear aplicaciones de alto rendimiento y con una interfaz de usuario atractiva.

- **BouncyCastle.Crypto**: Una biblioteca de criptografía utilizada para garantizar la seguridad de los datos en la aplicación.

- **iTextSharp**: Utilizado para generar y manipular documentos PDF, lo que podría ser útil para la generación de facturas y reportes.

- **LiveCharts**: Biblioteca de gráficos que facilita la visualización de datos y estadísticas en el panel de control de la aplicación.


## Screenshots

### LOGIN
![App Screenshot](https://i.imgur.com/CVbGNEv.png)

### VALIDACIONES
![App Screenshot](https://i.imgur.com/YDfyGLr.png)

![App Screenshot](https://i.imgur.com/QHwN342.png)

### DASHBOARD
![App Screenshot](https://i.imgur.com/ylIMBqj.png)

### ACERCA DE
![App Screenshot](https://i.imgur.com/jTg9WdV.png)

### MI CUENTA
![App Screenshot](https://i.imgur.com/JdIjwrI.png)

### MENU
![App Screenshot](https://i.imgur.com/NJlBK1Y.png)

### POS
![App Screenshot](https://i.imgur.com/cqlYUCz.png)

### MANTENIMIENTO PRODUCTOS
![App Screenshot](https://i.imgur.com/GbCH9ND.png)

![App Screenshot](https://i.imgur.com/YmA2qyf.png)

![App Screenshot](https://i.imgur.com/dc5QsO3.png)

![App Screenshot](https://i.imgur.com/wguqtCW.png)

![App Screenshot](https://i.imgur.com/sR0YYY6.png)

### TEMA OSCURO
![App Screenshot](https://i.imgur.com/lNGLXz8.png)

### MANTENIMIENTO USUARIOS
![App Screenshot](https://i.imgur.com/n7tGmBf.png)

![App Screenshot](https://i.imgur.com/dq8EIsm.png)

![App Screenshot](https://i.imgur.com/3PWRe7Z.png)

![App Screenshot](https://i.imgur.com/um8nKRx.png)

![App Screenshot](https://i.imgur.com/Mj3y7mm.png)

### VENTA
![App Screenshot](https://i.imgur.com/i5fZxWF.png)

![App Screenshot](https://i.imgur.com/7HV9tQk.png)

![App Screenshot](https://i.imgur.com/hsAkKJP.png)

![App Screenshot](https://i.imgur.com/siz6WxM.png)

![App Screenshot](https://i.imgur.com/pdl9cwn.png)

![App Screenshot](https://i.imgur.com/U3U8dhN.png)

![App Screenshot](https://i.imgur.com/WeBNjeV.png)
## Patrón de arquitectura en N Capas

El proyecto se estructura en cuatro capas principales:

- **Capa de Presentación**: Contiene la interfaz de usuario de la aplicación. Esto incluye las ventanas de gestión de productos y usuarios, el panel de control (dashboard), la ventana de inicio de sesión y otras páginas relacionadas con la presentación.

- **Capa de Lógica de Negocio**: En esta capa, se encuentra la lógica que gestiona la funcionalidad principal de la aplicación. Aquí se realizan operaciones como la creación, edición y eliminación de productos y usuarios, así como la lógica de punto de venta (POS) y las operaciones relacionadas con el panel de control.

- **Capa de Datos**: Esta capa se encarga de interactuar con una base de datos o sistema de almacenamiento de datos subyacente. Aquí se almacenan y recuperan datos como productos, usuarios, transacciones y más.

- **Capa de Entidad**: Esta capa representa las entidades y modelos de datos utilizados en la aplicación. Define la estructura de los objetos que se utilizan en la capa de lógica de negocio y la capa de datos.

## Archivos del Proyecto

- **AcercaDe**:
  - **Descripción**: Página de información sobre la aplicación y el equipo de desarrollo.
  - **Archivos**: AcercaDe.xaml, AcercaDe.xaml.cs

- **CRUDProductos**:
  - **Descripción**: Ventana de gestión de productos, que permite agregar, editar y eliminar productos en el sistema.
  - **Archivos**: CRUDProductos.xaml, CRUDProductos.xaml.cs

- **CRUDUsuarios**:
  - **Descripción**: Ventana de gestión de usuarios, utilizada para administrar cuentas de usuario.
  - **Archivos**: CRUDUsuarios.xaml, CRUDUsuarios.xaml.cs

- **Dashboard**:
  - **Descripción**: Panel de control que proporciona una visión general de las estadísticas y datos clave de la tienda.
  - **Archivos**: Dashboard.xaml, Dashboard.xaml.cs

- **Login**:
  - **Descripción**: Ventana de inicio de sesión para acceder a la aplicación.
  - **Archivos**: Login.xaml, Login.xaml.cs

- **MiCuenta**:
  - **Descripción**: Página de gestión de la cuenta del usuario, que puede incluir configuraciones y datos personales.
  - **Archivos**: MiCuenta.xaml, MiCuenta.xaml.cs

- **POS**:
  - **Descripción**: Ventana de Punto de Venta (POS) utilizada para procesar ventas y transacciones.
  - **Archivos**: POS.xaml, POS.xaml.cs

- **ProductosUsuarios**:
  - **Descripción**: Página que muestra información detallada sobre productos y usuarios.
  - **Archivos**: ProductosUsuarios.xaml, ProductosUsuarios.xaml.cs

- **MainWindow**:
  - **Descripción**: Ventana principal de la aplicación.
  - **Archivos**: MainWindow.xaml, MainWindow.xaml.cs

## Instrucciones de Ejecución

Asegúrate de seguir estos pasos para ejecutar la aplicación de manera correcta:

- **Requisitos del Sistema:**
   - Asegúrate de que tu sistema cumple con los requisitos necesarios para ejecutar la aplicación.

- **Descarga del Repositorio:**
   - Clona o descarga este repositorio en tu máquina local.

- **Configuración de la Base de Datos:**
   - Utiliza el archivo `AnniesStore.bak` proporcionado para restaurar un respaldo de la base de datos. Esto se puede hacer utilizando SQL Server Management Studio o una herramienta similar.

- **Compilación y Ejecución:**
   - Abre el proyecto en tu entorno de desarrollo (por ejemplo, Visual Studio).
   - Asegúrate de que el proyecto esté configurado para utilizar la base de datos restaurada.

- **Ejecución de la Aplicación:**
   - Compila el proyecto y ejecuta la aplicación.

- **Inicio de Sesión:**
   - Utiliza las credenciales de inicio de sesión proporcionadas o creadas en el proceso de restauración de la base de datos.

- **Explora la Aplicación:**
   - Navega por las distintas secciones de la aplicación, incluyendo POS, CRUD de Productos, CRUD de Usuarios y más.

- **¡Listo!**
   - Ahora puedes usar y explorar la aplicación.

Si experimentas algún problema o error durante la ejecución de la aplicación, asegúrate de verificar la configuración de la base de datos y los requisitos del sistema. Si estás utilizando credenciales específicas, asegúrate de tener acceso a la base de datos con esas credenciales.

¡Disfruta de tu experiencia con la aplicación!

## License

Este proyecto se distribuye bajo una **Licencia Educativa** que permite el uso exclusivamente con fines educativos. No está permitido vender el proyecto ni compartirlo con fines comerciales. La licencia no permite la redistribución o el uso del proyecto en aplicaciones comerciales o de producción.

## Agradecimientos Especiales

Quiero expresar mi profundo agradecimiento a los miembros del canal InfoToolsSV que han sido una parte fundamental de este proyecto. Su apoyo constante y entusiasta ha sido una fuente de inspiración y motivación para crear no solo este proyecto, sino también mis videos y contenido educativo. 

Agradezco su tiempo, sus valiosas sugerencias y comentarios, y su continua participación en este viaje de aprendizaje y crecimiento. Sin su apoyo, este proyecto no sería posible.

Gracias por ser una comunidad tan comprometida y apasionada. Espero que este proyecto y mi contenido continúen siendo de utilidad para todos ustedes. ¡Sigamos construyendo juntos!
