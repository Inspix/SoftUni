var inputString = "[{'name':'Пешо','score':91},{'name':'Лилия','score':290},{'name':'Алекс','score':343},{'name':'Габриела','score':400},{'name':'Жичка','score':70}]";

inputString = inputString.replace(/\'/g,'"');

var jsonObject = JSON.parse(inputString);
var passedStudents = [];

for (var i = 0; i < jsonObject.length; i++) {
  var current = jsonObject[i];
  current.score += current.score * 0.2;
  current.hasPassed = current.score >= 100;
  if (current.hasPassed) {
    passedStudents.push(current);
  }
}

passedStudents.sort(function(a,b){
  return a.name > b.name;
});

console.log(passedStudents);
