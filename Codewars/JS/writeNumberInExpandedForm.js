// You will be given a number and you will need to return it as a string in Expanded Form. For example:
// You will be given a number and you will need to return it as a string in Expanded Form. For example:

// expandedForm(12); // Should return '10 + 2'
// expandedForm(42); // Should return '40 + 2'
// expandedForm(70304); // Should return '70000 + 300 + 4'

// NOTE: All numbers will be whole numbers greater than 0.


function expandedForm(num) {
  num = num.toString().split('');
  let numStr = [];
  let aux = num.length - 1;

  for (let i = 0; i < num.length; i++) {
    if (num[i] === '0') {
      aux -= 1;
      continue
    }
    numStr.push(num[i] + '0'.repeat(aux))
    aux -= 1;
  }
  return numStr.join(' + ')
}

console.log(expandedForm(70304))
console.log(expandedForm(12))
console.log(expandedForm(42))
console.log(expandedForm(2))

const expandedFormV2 = n => n.toString()
  .split("")
  .reverse()
  .map((a, i) => a * Math.pow(10, i))
  .filter(a => a > 0)
  .reverse()
  .join(" + ");
console.log(expandedFormV2(70304))
