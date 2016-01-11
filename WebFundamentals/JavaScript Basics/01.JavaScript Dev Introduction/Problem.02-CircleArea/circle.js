document.addEventListener('DOMContentLoaded', function(){
  var textArea = document.getElementById("text");
  var inputs = [7,1.5,20];

  for (var i = 0; i < inputs.length; i++) {
    textArea.innerHTML += "r = " + inputs[i] + "; area = " + calcArea(inputs[i]) + "<br>";
  }

},false);

function calcArea(radius){
  return Math.PI * radius * radius;
}
