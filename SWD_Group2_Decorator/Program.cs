using SWD_Group2_Decorator;
using SWD_Group2_Decorator.Decorators;

MercedesCLA Mercedes = new MercedesCLA() { HorsePower = 20, Model = "Mercedes CLA", Cost = 2200000};
string test = Mercedes.getCarModel();
double cost = Mercedes.getCost();
double test3 = Mercedes.calculateTopSpeed();

SeatHeatingDecorator seatDecorator = new SeatHeatingDecorator(Mercedes, 5000);
string test2 = seatDecorator.getCarModel();
double cost2 = seatDecorator.getCost();

AddTireType tireTypeDecorator = new AddTireType(seatDecorator, "soft");
double test4 = tireTypeDecorator.calculateTopSpeed();
string test5 = tireTypeDecorator.getCarModel();

ImprovedStereoDecorator stereoDecorator = new ImprovedStereoDecorator(tireTypeDecorator, 12000);
double cost5 = stereoDecorator.getCost();
string cost6 = stereoDecorator.getCarModel();

PremiumArmrestDecorator premiumArmrestDecorator = new PremiumArmrestDecorator(stereoDecorator, 12345);
double cost7 = premiumArmrestDecorator.getCost();
string test6 = premiumArmrestDecorator.getCarModel();
Console.WriteLine("Done");
