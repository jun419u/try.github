int Num1 = 15;
int Num2 = 5;
Console.WriteLine("値を2つセットします");
Console.WriteLine("1つ目は" + Num1);
Console.WriteLine("2つ目は" + Num2);
Addition sum = new Addition(Num1, Num2);
Subtraction mainasu = new Subtraction(Num1, Num2);
Mutiplication kakeru = new Mutiplication(Num1, Num2);
Division waru = new Division(Num1, Num2);
Console.WriteLine(Num1 + " + " + Num2 + "=" + sum());

Console.WriteLine(Num1 + " - " + Num2 + " = "mainasu());

Console.WriteLine(Num1 + " × " + Num2 + " = "kakeru());

Console.WriteLine(Num1 + " ÷ " + Num2 + " = "waru());
