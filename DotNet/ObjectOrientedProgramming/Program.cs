// variable declaration: <type> <name> = <value>;
string name = "John Doe";

Car myCar = new();
myCar.Make = "Toyota";
myCar.Model = "Corolla";
myCar.StartEngine();
myCar.Accelerate();
myCar.Accelerate();
// myCar.CurrentSpeed = -555;
// myCar.EngineRunning = true;
Console.WriteLine("Current speed: " + myCar.CurrentSpeed);
Console.WriteLine("Engine running: " + myCar.EngineRunning);




Car myCousinsCar = new();
Car myFriendsCar = new();
