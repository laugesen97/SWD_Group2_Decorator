using SWD_Group2_Decorator;

MercedesCLA Mercedes = new MercedesCLA() { HorsePower = 20, Model = "Mercedes CLA", Cost = 2200000};
string test = Mercedes.getCarModel();
double cost = Mercedes.getCost();

SeatHeatingDecorator seatDecorator = new SeatHeatingDecorator(Mercedes, 5000);
string test2 = seatDecorator.getCarModel();
double cost2 = seatDecorator.getCost();

double test3 = Mercedes.calculateTopSpeed();
AddTireType tireTypeDecorator = new AddTireType(Mercedes, "soft");
double test4 = tireTypeDecorator.calculateTopSpeed();
string test5 = tireTypeDecorator.getCarModel();
Console.WriteLine("Done");
