// You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.
// Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:
// []                                -->  "no one likes this"
// ["Peter"]                         -->  "Peter likes this"
// ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
// ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
// ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
// Note: For 4 or more names, the number in "and 2 others" simply increases.

function likes(names) {
  let textConst = ' likes this';
  if (names === undefined) {
    return 'no one' + textConst
  }
  if (names.length === 1) {
    return names[0] + textConst
  }
  if (names.length === 2) {
    return names[0] + ' and ' + names[1] + textConst
  }
  if (names.length === 3) {
    return names[0] + ', ' + names[1] + ' and ' + names[2] + textConst
  }
  if (names.length > 3) {
    return names[0] + ', ' + names[1] + ' and ' + (names.length - 2) + textConst
  }
}

function likesV2(names) {
  return {
    0: 'no one likes this',
    1: `${names[0]} likes this`,
    2: `${names[0]} and ${names[1]} like this`,
    3: `${names[0]}, ${names[1]} and ${names[2]} like this`,
    4: `${names[0]}, ${names[1]} and ${names.length - 2} others like this`,
  }[Math.min(4, names.length)]
}

console.log(likes())
console.log(likes(["Peter"]))
console.log(likes(["Jacob", "Alex"]))
console.log(likes(["Max", "John", "Mark"]))
console.log(likes(["Alex", "Jacob", "Mark", "Max"]))
