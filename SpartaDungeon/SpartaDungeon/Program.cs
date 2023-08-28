using System.Net.Security;

internal class Program
{
    static Character player;
    static Item[] inventory;
    static void Main(string[] args)
    {
        GameStartDisplay();
        player = new Character(level: 01, name: "Chad", atk: 10, def: 5, hp: 100, gold : 1500);
        inventory[0] = new Item(name: "무쇠갑옷", atk: 0, def: 5, info: "무쇠로 만들어져 튼튼한 갑옷입니다.");
        inventory[1] = new Item(name: "낡은 검", atk: 2, def: 0, info: "쉽게 볼 수 있는 낡은 검입니다.");
    }

    static void GameStartDisplay()
    {
        Console.Clear();

        Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
        Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
        Console.WriteLine();
        Console.WriteLine("1. 상태 보기");
        Console.WriteLine("2. 인벤토리");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">>");

        int input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
            PlayerDisplay();
        }
        else if (input == 2)
        {
            InventoryDisplay();
        }
        else
        {
            Console.WriteLine("1 혹은 2를 입력해주세요.");
        }
    }

    static void PlayerDisplay()
    {
        Console.Clear();

        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
        Console.WriteLine();
        Console.WriteLine($"Lv. {player.Level}");
        Console.WriteLine("Chad ( 전사 )");
        Console.WriteLine("공격력 : 10");
        Console.WriteLine("방어력 : 5");
        Console.WriteLine("체력 : 100");
        Console.WriteLine("Gold : 1500 G");
        Console.WriteLine();
        Console.WriteLine("0. 나가기");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">>");

        int input = int.Parse(Console.ReadLine());
        if (input == 0)
        {
            GameStartDisplay();
        }
        else
        {
            Console.WriteLine("나가시기를 원하시면 0을 입력해주세요.");
        }
    }

    static void InventoryDisplay()
    {
        Console.Clear();

        Console.WriteLine("인벤토리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        Console.WriteLine();
        Console.WriteLine("[아이템 목록]");
        Console.WriteLine("- [E]무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
        Console.WriteLine("- 낡은 검         | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.");
        Console.WriteLine();
        Console.WriteLine("1. 장착 관리");
        Console.WriteLine("0. 나가기");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">>");

        int input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
            EquipInventoryDisplay();
        }
        else if (input == 0)
        {
            GameStartDisplay();
        }
        else
        {
            Console.WriteLine("1 혹은 0을 입력해주세요.");
        }
    }

    static void EquipInventoryDisplay()
    {
        Console.Clear();

        Console.WriteLine("인벤토리 - 장착관리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        Console.WriteLine();
        Console.WriteLine("[아이템 목록]");
        Console.WriteLine("- [E]무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
        Console.WriteLine("- 낡은 검         | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.");
        Console.WriteLine();
        Console.WriteLine("0. 나가기");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">>");

        int input = int.Parse(Console.ReadLine());
        if (input == 0)
        {
            InventoryDisplay();
        }
        else
        {
            Console.WriteLine("1 혹은 2를 입력해주세요.");
        }
    }
}

class Character
{
    public int Level;
    public string Name;
    public int Atk;
    public int Def;
    public int Hp;
    public int Gold;

    public Character(int level, string name, int atk, int def, int hp, int gold)
    {
        Level = level;
        Name = name;
        Atk = atk;
        Def = def;
        Hp = hp;    
        Gold = gold;
    }
}

class Item
{
    public string Name;
    public int Atk;
    public int Def;
    public string Info;

    public Item(string name, int atk, int def, string info)
    {
        Name = name;
        Atk = atk;
        Def = def;
        Info = info;
    }
}