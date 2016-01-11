function findYoungestPerson(array){
  var youngest;
  for (var i = 0; i < array.length; i++) {
    var o = array[i];
    if ((youngest === undefined || o.age < youngest.age) && o.hasSmartphone) {
        youngest = o;
    }
  }
  return youngest;
}

var people = [
  { firstname : 'George', lastname: 'Kolev', age: 32, hasSmartphone: false },
  { firstname : 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true },
  { firstname : 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true },
  { firstname : 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false }];


var result = findYoungestPerson(people);

console.log("The youngest person is " + result.firstname + " " + result.lastname);
