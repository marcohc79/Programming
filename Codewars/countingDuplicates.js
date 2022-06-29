// Count the number of Duplicates

// Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
// Example

// "abcde" -> 0 # no characters repeats more than once
// "aabbcde" -> 2 # 'a' and 'b'
// "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
// "indivisibility" -> 1 # 'i' occurs six times
// "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
// "aA11" -> 2 # 'a' and '1'
// "ABBA" -> 2 # 'A' and 'B' each occur twice

function duplicateCount(text) {
  let diccionario = {}
  text.toLowerCase().split('').forEach(function (char) {
    if (diccionario[char] === undefined) {
      diccionario[char] = 1

    } else {
      diccionario[char] += 1
    }
  })

  return Object.values(diccionario).reduce(function (total, valor) {
    if (valor > 1) {
      total += 1;
    }
    return total;
  }, 0)
}

function duplicateCountV2(text) {
  return text.toLowerCase().split('').filter(function (val, i, arr) {
    return arr.indexOf(val) !== i && arr.lastIndexOf(val) === i;
  }).length;

}

// console.log(duplicateCountV2("abcde"))
console.log(duplicateCountV2("aabbcde"))
// console.log(duplicateCountV2("aabBcde"))
// console.log(duplicateCountV2("indivisibility"))
// console.log(duplicateCountV2("Indivisibilities"))
// console.log(duplicateCountV2("aA11"))
// console.log(duplicateCountV2("ABBA"))
