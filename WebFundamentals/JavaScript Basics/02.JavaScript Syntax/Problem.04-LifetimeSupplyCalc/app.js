function calcSupply(age,maxAge,food,foodPerDay){
  var days = (maxAge - age) * 365;
  return days * foodPerDay;
}

function startTests(){
  var values = [
    {
      'age': 38,
      'maxAge': 118,
      'food': "chocolate",
      'foodAmount': 0.5
    },
    {
      'age': 20,
      'maxAge': 87,
      'food': "fruits",
      'foodAmount': 2
    },
    {
      'age': 16,
      'maxAge': 102,
      'food': "nuts",
      'foodAmount': 1.1
    }

  ];

  for (var i = 0; i < values.length; i++) {
    var test = values[i];
    var result = calcSupply(test.age,test.maxAge,test.food,test.foodAmount);

    console.log(result + "kg of " + test.food + ' would be enought until I am ' + test.maxAge + ' years old.');
  }
}

startTests();
