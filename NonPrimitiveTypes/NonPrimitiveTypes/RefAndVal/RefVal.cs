var a = 10;
var b = a;

b++;

Console.WriteLine("a: {0},  b:{1}", a, b);
// Is the value of a 10 or 11?  Ans is 10 because it is value type

// Reference types

var numbers  = new int[5] {1,2,3,4,5};
var numbers2 = numbers;
numbers[0] = 0;

Console.WriteLine(numbers[0]);
Console.WriteLine(numbers2[0]);