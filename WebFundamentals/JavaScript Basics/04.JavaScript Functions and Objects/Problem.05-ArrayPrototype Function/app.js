Array.prototype.removeItem = function(item){
  for (var i = 0; i < this.length; i++) {
    if (this[i] === item) {
      this.splice(i,1);
      i--;
    }
  }
};

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
var arr2 = ['hi', 'bye', 'hello' ];
arr.removeItem(1);
arr2.removeItem('bye');

console.log(arr);
console.log(arr2);
