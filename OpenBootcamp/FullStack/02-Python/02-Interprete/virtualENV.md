# Virtual ENV

Hay tres formas de trabajar con ellas. Iré enumerando cada una de ellas desde la peor a la mejor.

~~~
Virtualenvs
source Virtualenvs/scripy/bin/activate
desactivate

source Virtualenvs/mates/bin/activate
~~~
~~~
// se utliza mas 
pipenv shell (En la carpeta que vamos a generar el entorno)
which python (para saber donde estoy)
deactivate
~~~

Tambien puedo intalar desde git
~~~
pipenv install -e git+https://github.com/requests.git#egg=requests (como ejemplo)
~~~

Cuando se este trabajando proyectos por lo general vamos a querer que tambien se instale todas las dependencias. Lo que hacemos es pasar el archivos Pipfile.lock

~~~
pipenv lock (se crea dependencias y se bloquea para luego distribuirlo)
pipenv install --ignore-pipfile (se crea el proyecto installando las dependencias)
pipenv check (para verificar los paquetes)
pipenv graph (ver dependencias)
~~~
