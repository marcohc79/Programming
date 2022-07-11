// Complete the solution so that the function will break up camel casing, using a space between words.
// Example
// "camelCasing"  =>  "camel Casing"
// "identifier"   =>  "identifier"
// ""             =>  ""

function solution(string) {
  let newText = '';
  for (let str of string) {
    if (str == str.toUpperCase()) {
      newText += ' ' + str
      continue;
    }
    newText += str;
  };
  return newText
};

function solutionV2(string) {
  return (string.replace(/([A-Z])/g, ' $1'))
}

console.log(solutionV2('camelCase'));
