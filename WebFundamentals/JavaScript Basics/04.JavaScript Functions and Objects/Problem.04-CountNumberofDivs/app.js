function countDivs(html){
  var index = html.indexOf('<div');
  var count = 0;
  while (index != -1) {
    count++;
    index = html.indexOf('<div',index + 1);
  }

  return count;

}

var htmlString = ['<!DOCTYPE html>',
'<html>',
'<head lang="en">',
'    <meta charset="UTF-8">',
'    <title>index</title>',
'    <script src="/yourScript.js" defer></script>',
'</head>',
'<body>',
'    <div id="outerDiv">',
"        <div",
'    class="first">',
  "          <div><div>hello</div></div>",
"        </div>",
"        <div>hi<div></div></div>",
"        <div>I am a div</div>",
"    </div>",
"</body>",
"</html>"];

var count = countDivs(htmlString.join('\n'));

console.log(count);
