// This is version 2 of my 'Write Number in Exanded Form' Kata.
// You will be given a number and you will need to return it as a string in expanded form:
// For example:

// expanded_from(807.304); // Should return "800 + 7 + 3/10 + 4/1000"
// expanded_from(1.24); // should return "1 + 2/10 + 4/100"
// expanded_from(7.304); // should return "7 + 3/10 + 4/1000"
// expanded_from(0.04); // should return "4/100"

let expandedFormInteger = n => n.split("")
  .reverse()
  .map((a, i) => a * Math.pow(10, i))
  .filter(a => a > 0)
  .reverse()
  .join(" + ");

let expandedFormDecimal = n => n.split('')
  .map((a, i) => a + '/' + (Math.pow(10, i)) * 10)
  .filter(a => a[0] > 0)
  .join(" + ")

function expandedForm(num) {
  let fullNum = num.toString().split('.');
  let part01 = expandedFormInteger(fullNum[0])
  let part02 = expandedFormDecimal(fullNum[1])
  if (part01 === '') {
    return part02
  }
  return part01 + ' + ' + part02

}

function expandedFormV2(num) {
  var [int, dec] = ('' + num).split('.')

  return int.split('').map((x, y, a) => x + '0'.repeat(a.length - y - 1))
    .concat(dec.split('').map((x, y, a) => `${x}/1${'0'.repeat(y + 1)}`))
    .filter(x => !x.startsWith('0'))
    .join(' + ')
}

console.log(expandedForm(0.304))
