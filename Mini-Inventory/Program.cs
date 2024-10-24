using System.Drawing;

Character Hero=new(){
    Name="Karl-Berta",
    Hp=10,
    Fp=10

};

Weapon Huvud=new(){
    Name="Ellies Huvud",
    Weight=7,
    MinDmg=3,
    MaxDmg=7
};

Armor Skellet=new(){
    Name="Skelletets Skellet",
    Weight=16.5f,
    Protection=7
};

Consumable Blod=new(){
    Name="Sams Blod",
    Tag="Fp",
    Weight=0.5f,
    MinMod=3,
    MaxMod=6

};

Consumable Fett1=new(){
    Name="Hugos Fett",
    Tag="Hp",
    Weight=1,
    MinMod=3,
    MaxMod=6,
    UsesMax=3
};

Consumable Fett2=new(){
    Name="Axels Fett",
    Tag="Hp",
    Weight=3,
    MinMod=6,
    MaxMod=12,
    UsesMax=3
};

Hero.Backpack.ItemList.Add(Huvud);
Hero.Backpack.ItemList.Add(Fett1);

Console.WriteLine("Welcome to this inventory simulator");
Hero.Backpack.Display();
Console.WriteLine();
Console.WriteLine("Would you like to add this Armor to your Inventory?");
Console.WriteLine("y/n");
string resp=Console.ReadLine().ToLower();

if(resp=="y"){
    Hero.Backpack.ItemList.Add(Fett1);
    Console.WriteLine("You added the Armor 'Skelletets Skellet' to your Inventory");
    Console.ReadLine();
}
else if(resp=="n"){
    Console.WriteLine("You didn't add the Armor, you boring fuck");
    Console.ReadLine();
}
else{
    Console.WriteLine("You didn't give an answer");
    Console.ReadLine();
}
Console.WriteLine("Thank you for testing this simulator");
Console.ReadLine();