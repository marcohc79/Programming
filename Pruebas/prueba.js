let calculadora;

let crearCalculadora = () => {
  let valores = 0;

  let valor = () => {
    return valores
  }
  let sumar = (num) => {
    valores += num
    console.log(valores)
  };
  return {
    valor: valor,
    sumar: sumar
  }
}

calculadora = crearCalculadora();
calculadora.sumar(2);
calculadora.sumar(3);
calculadora.sumar(2);
console.log(calculadora.valor());

