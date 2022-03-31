using SWD_Group2_Decorator;
using SWD_Group2_Decorator.Decorators;


// Der bliver udbygget på den første Mercedes her, hvor der kommer en wrapper mere på samme objekt, en ad gangen.
// Disse kunne også tilføjes samtidigt.

// Alm. mercedes
MercedesCLA Mercedes = new MercedesCLA() { HorsePower = 20, Model = "Mercedes CLA", Cost = 2200000};
string MercedesModel = Mercedes.getCarModel();
Console.WriteLine(MercedesModel);
double MercedesCost = Mercedes.getCost();
Console.WriteLine("Pris: " +MercedesCost);
double MercedesSpeed = Mercedes.calculateTopSpeed();
Console.WriteLine("Topfart: " + MercedesSpeed);
Console.WriteLine("----------------------------------------------------------------");

// Mercedes med sædevarme
SeatHeatingDecorator seatDecorator = new SeatHeatingDecorator(Mercedes, 5000);
string SeatDecoratorModel = seatDecorator.getCarModel();
Console.WriteLine(SeatDecoratorModel);
double SeatDecoratorCost = seatDecorator.getCost();
Console.WriteLine("Pris: " +SeatDecoratorCost);
Console.WriteLine("Topfart: " +seatDecorator.calculateTopSpeed());
Console.WriteLine("----------------------------------------------------------------");

// Mercedes med anderledes dæk
AddTireType tireTypeDecorator = new AddTireType(seatDecorator, "soft");
string TireTypeDecoratorModel = tireTypeDecorator.getCarModel();
Console.WriteLine(TireTypeDecoratorModel);
Console.WriteLine("Pris: " +tireTypeDecorator.getCost());
double TireTypeDecoratorSpeed = tireTypeDecorator.calculateTopSpeed();
Console.WriteLine("Topfart :" + TireTypeDecoratorSpeed);
Console.WriteLine("----------------------------------------------------------------");

//Mercedes med stereo
ImprovedStereoDecorator stereoDecorator = new ImprovedStereoDecorator(tireTypeDecorator, 12000);
string StereoDecoratorModel = stereoDecorator.getCarModel();
Console.WriteLine(StereoDecoratorModel);
double StereoDecoratorCost = stereoDecorator.getCost();
Console.WriteLine("Pris: " +StereoDecoratorCost);
Console.WriteLine("Topfart: " +stereoDecorator.calculateTopSpeed());
Console.WriteLine("----------------------------------------------------------------");

// Mercedes med premium armlæn
PremiumArmrestDecorator premiumArmrestDecorator = new PremiumArmrestDecorator(stereoDecorator, 12345);
string ArmrestDecoratorModel = premiumArmrestDecorator.getCarModel();
Console.WriteLine(ArmrestDecoratorModel);
double ArmrestDecoratorCost = premiumArmrestDecorator.getCost();
Console.WriteLine("Pris: " + ArmrestDecoratorCost);
Console.WriteLine("Topfart: " +premiumArmrestDecorator.calculateTopSpeed());
Console.WriteLine("----------------------------------------------------------------");

PremiumArmrestDecorator CombinedCar = new PremiumArmrestDecorator(new SeatHeatingDecorator(new AddTireType(new ImprovedStereoDecorator(new MercedesCLA
{
    HorsePower = 60,
    Cost = 1899999,
    Model = "Test2Model"
}, 12000), "soft"), 5999), 10000);
Console.WriteLine(CombinedCar.getCarModel());
Console.WriteLine("Pris: "+CombinedCar.getCost());
Console.WriteLine("Topfart: " + CombinedCar.calculateTopSpeed());

Console.ReadLine();