
using System.IO.Compression;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

class Items{
    public string Name;
    public float Weight;
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------
class Armor:Items{
    public float Protection;
}
class Weapon:Items{
    public int MinDmg;
    public int MaxDmg;

    public int Attack(){
        Random gen=new();
        int dmg=gen.Next(MinDmg,MaxDmg);
        return dmg;
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------
class Consumable:Items{
    public string Tag;
    public int UsesMax;
    public int UsesCurrent;
    public int MinMod;
    public int MaxMod;

    public void Use(Character character){
        Random gen=new();
        switch(Tag){
            case "Hp":
                character.Hp+=gen.Next(MinMod,MaxMod);
            break;


            case "Fp":
                character.Fp+=gen.Next(MinMod,MaxMod);

            break;
        }
        UsesCurrent-=1;
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------
class Inventory{
    public List<Items> ItemList=new();

    public void Display(){
        for (int i = 0; i < ItemList.Count; i++){
            Console.WriteLine((i+1)+") "+ItemList[i].Name);
        }
    }
    public void PickUp(Items item, Character character){
        character.Backpack.ItemList.Add(item);
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------
class Character{
    public int Hp;
    public int Fp;
    public string Name;
    public Inventory Backpack;
}