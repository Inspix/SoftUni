function clone(obj){
  return Object.assign({},obj);
}

function compareObjects(obj, objCopy){
  return obj == objCopy;
}

var a = {name: 'Pesho', age: 21};
var b = clone(a); // a deep copy
console.log("a == b --> " + compareObjects(a, b));

a = {name: 'Pesho', age: 21};
b = a; // not a deep copy
console.log("a == b --> " + compareObjects(a, b));
