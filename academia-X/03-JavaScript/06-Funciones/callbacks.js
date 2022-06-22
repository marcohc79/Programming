// callbacks

function llamar(callback) {
  callback();
}

llamar(function () {console.log(3)})


function llamar(enExito, enError) {
  let exito = true;
  if (exito) {
    enExito()
  } else {
    enError()
  }
}
llamar(
  function () {console.log('Exito')},
  function () {console.log('Error')}
)
