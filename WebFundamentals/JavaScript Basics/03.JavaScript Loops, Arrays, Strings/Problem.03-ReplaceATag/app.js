var input = ['<ul>',
  ' <li>',
  '  <a href=http://softuni.bg>SoftUni</a>',
  ' </li>',
  '</ul>'
];
input = input.join('\n');
input = input.replace('<a', "[URL");
input = input.replace('</a>', "[/URL]");

console.log(input);
