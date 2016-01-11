document.addEventListener("DOMContentLoaded",function(){
  var input = prompt("Enter a number:");
  var number = parseInt(input);
  if (!isNaN(number)) {
    alert(number.toString(16));
  }else {
    alert("Invalid Number");        
  }
});
