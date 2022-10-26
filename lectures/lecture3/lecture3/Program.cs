using lecture3;

/*TestClass test1 = new TestClass(2);
Console.WriteLine(test1);
test1.X = 5;
Console.WriteLine(test1);
TestClass test2 = new TestClass(7);
Console.WriteLine(test2);
test2.X = 8;
Console.WriteLine(test2);
Console.WriteLine(test1);

TestClass t = new TestClass(5);

int a, b;

t.Change(out a, out b);

Console.WriteLine($"a - {a} - b - {b}");*/

InheritenceTest child = new InheritenceTest(1, 2, "string");
/*Console.WriteLine(child);*/

TestClass testClass = new InheritenceTest(2, 3, "proog");

// бо залишається тестклас
/*testClass.ParentalMethod();*/

Console.WriteLine(testClass);

testClass.ParentMethodOrigin();

if (testClass is InheritenceTest) { (testClass as InheritenceTest).ChildMethod(); }
((InheritenceTest)testClass).ChildMethod();

// неможна
/*InheritenceTest childAnother = new TestClass(2);*/