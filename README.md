# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

## Proyecto 2021 - Segundo Semestre -

Nuestro plan de acción para la siguiente entrega es el siguiente:

> :thinking: Tenemos que cumplir con varios casos se uso y la implementación del chatbot en un tiempo corto por lo cual pensamos un plan de accion diferente para aumentar el rendimiento del equipo.

## Nuestro plan

Identificamos requisitos claves en el desarollo del proyecto y estos son los siguientes:

**Kevin Alvarez** - Implementación del bot con telegram (ServerBot)

**Kevin Alvarez** - Chat bot funcionando con el patrón de diseño chain of responsability (BaseCommand, ICommand, Command iniciales)

## Casos de uso
**Lucas Martino** - Como administrador, quiero poder invitar empresas a la plataforma, para que de esa forma puedan realizar ofertas de materiales reciclables o residuos. (Invitation, token)

**Lucas Martino** - Como empresa, quiero aceptar una invitación a unirme en la plataforma y registrar mi nombre, ubicación y rubro, para que de esa forma pueda comenzar a publicar ofertas. (User, AdministratorUser)

**Lucas Martino** - Como empresa, quiero publicar una oferta de materiales reciclables o residuos, para que de esa forma los emprendedores que lo necesiten puedan reutilizarlos.(Publication, Recyclable (compartida), Residue (compartida) )

**Lucas Martino** - Como empresa, quiero clasificar los materiales o residuos, indicar su cantidad y unidad, el valor (en $ o U$S) de los mismos y el lugar donde se ubican, para que de esa forma los emprendedores tengan información de materiales o residuos disponibles. ( IMaterial (compartida), API Location, Location)

- Como empresa, quiero indicar las habilitaciones que requiere un emprendedor, para que de esa forma pueda recibir o retirar los materiales o residuos.

- Como empresa, quiero indicar un conjunto de palabras claves asociadas a la publicación de los materiales, para que de esa forma sea más fácil de encontrarlos en las búsquedas que hacen los emprendedores.

**Lucas Martino** - Como emprendedor, quiero registrarme en la platarforma indicando nombre, ubicación, rubro, habilitaciones y especializaciones, para que de esa forma pueda ver las ofertas de materiales o residuos. (Entrepreneur, Entrepreneur_Qual)

- Como emprendedor, quiero poder buscar materiales ofrecidos por empresas mediante palabras clave, categorías, o por zona, para de esa forma obtener insumos para mi emprendimiento.

**Juan Campos** - Como emprendedor, quiero saber qué materiales se generan constantemente, para de esa forma planificar que insumos tengo disponibles. (Pensar como implementarlo)

**Juan Campos** - Como emprendedor, quiero saber cuándo un material o residuo se genera puntualmente, para de esa forma determinar oportunidades de desarrollar nuevos productos. (Ideas para Juan: crear una clase Punctual_Generation que evalue estos casos cumpliendo los patrónes de diseño)

**Juan Campos** - Como empresa, quiero saber todos los materiales o residuos entregados en un período de tiempo, para de esa forma tener un seguimiento de su reutilización. (Agremment, ListAgreement)

**Juan Campos** - Como emprendedor, quiero saber cuántos materiales o residuos consumí en un período de tiempo, para de esa forma tener un control de mis insumos. (Agremment, ListAgreement)

 
**Kevin Alvarez -  Persistencia de la información**
Nuestro chatbot necesitará guardar la información de empresas, emprendedores, materiales, etc. Para esto utilizaremos una interface que permitirá realizar persistencia de datos (guardar y recuperar) y luego una implemnentación utilizando archivos. Al cambiar la implementación de la interface de la abse de datos, el chatbot debería seguir funcionando sin cambios.

## Hitos
Es de **obligatoriedad** el entregar los requisitos con el nombre del integrante del equipo para el **viernes 19 de noviembre 10:00pm** incluyendo los **test** de cada caso de uso / clase asignada. 

Cabe destacar que en el caso de ser necesario se deberán de crear nuevas clases para que el caso de uso funcione de manera satisfactoria. Se pueden modificar la clase de otro integrante del equipo siempre y cuando sea para implementar la nueva funcionalidad. Cosa que no deberia de pasar si se cumpliera con los patrones de diseño correctamente en ese caso se le debe de notificar al compañero de que modifique su clase para que la cohesion sea mayor y el agrupamiento menor.