# GIT

## Flujo de trabajo

Vamos a tener 4 etapas:

1. Computador
2. Stage
3. Commit
4. Server

<br>

1. Vamos a empezar agregar todos los archivos que nosotros queramos y para luego pasar a **stage** utilizaremos **git add**. 
2. Etapa intermedia donde veomos los posibles cambios que queramos subir posteriormente al repositorio, para el cual utilizaremos el comando **git commit**. 
3. Acá llevaramos dichos archivos al Server

Para no subir archivos y/o carpetas al repositorio utilizaremos `.gitignore`:
~~~
.gitignore
# Aca se colocaran todos los archivos
.env
css\
~~~

### Comandos.
`git status`
<br>
`git add nameFile.extension`
<br>
`git commit -m "message"`
<br>
`git rm nameFile.extension`
<br>
`git diff --staged` para unicamente los cambios
<br>
`git log`
<br>
`git log --oneline`
<br>
`git status -s` `?? significa que git no lo agrego para hacer seguimiento.`
<br>
`git log --oneline` muestra el historial con un hash referente al commit

### Generar ramas (branch)
`git branch` ver en que rama estoy.
<br>
`git checkout -b "nombre de la rama"` creo un branch nuevo
<br>
`git checkout "nombre de la rama"` cambio de rama
<br>
`git merge "nombre de donde traemos los cambios"`

### Subir a git online.
`git remote add origin https://github.com/usarioa/carpeta.git`
<br>
`git push -u origin main` git push es para subir los cambios respecto a la rama que estemos trabajando, -u para crear "main" es el nombre.
<br>

