using System.ComponentModel;

internal class Program
{
    private static Character player;
    private static Item 낡은지팡이;
    private static Item 낡은로브; // 
    
    // item을 리스트화

    // 아이템을 더 간략하게 할 수 없을까?
    static void Main(string[] args)
    {
        GameDataSetting();
        DisplayGameIntro();
    }

    static void GameDataSetting()
    {
        player = new Character("하늘연달", "마법사", 1, 100, 50, 5, 20, 5, 10, 25);
        낡은지팡이 = new Item("낡은 지팡이", 0, 5, 1, 10, 0, 0, "하급마법사들이 사용하던 지팡이");
        낡은로브 = new Item("낡은 로브",20, 5, 0, 0, 0, 10, "하급마법사들이 입던 로브");

    }

    static void DisplayGameIntro()
    {
        Console.Clear();
        Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
        Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.\n");
        Console.WriteLine("1. 상태 보기");
        Console.WriteLine("2. 인벤토리\n");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">>");

        int input = CheckValidInput(1, 2);
        switch(input)
        {
            case 1:
                DisplayMyInfo();
                break;
            case 2:
                DisplayInventory();
                break;
        }
    }

    static void DisplayMyInfo()
    {
        Console.Clear();
        Console.WriteLine("상태 보기");
        Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");
        Console.WriteLine($"{player.Name}({player.Job}, Lv.{player.Level})\n");
        Console.WriteLine($"체력: {player.Hp}");
        Console.WriteLine($"마나: {player.Mp}");
        Console.WriteLine($"물리공격력: {player.PhysicalAttackPower}");
        Console.WriteLine($"마법공격력: {player.MagicAttackPower}");
        Console.WriteLine($"물리방어력: {player.PhysicalDefence}");
        Console.WriteLine($"마법방어력: {player.PhysicalDefence}");
        Console.WriteLine($"Gold: {player.Gold}G\n");
        Console.WriteLine("0. 나가기\n");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">>");
        


        int input = CheckValidInput(0, 0);
        switch (input)
        {
            case 0: 
                DisplayGameIntro();
                break;
        }
    }

    static void DisplayInventory()
    {
        Console.Clear();
        Console.WriteLine("인벤토리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
        Console.WriteLine("[아이템 목록]");
        Console.WriteLine($" -{낡은지팡이.Name}, | 마나 +{낡은지팡이.Mp}, 물리공격력 +{낡은지팡이.PhysicalAttackPower}, 마법공격력 +{낡은지팡이.MagicAttackPower} | {낡은지팡이.Info}");
        Console.WriteLine($" -{낡은로브.Name},   | 체력 +{낡은로브.Hp}, 마나 +{낡은로브.Mp}, 마법방어력 +{낡은로브.MagicDefence}      | {낡은로브.Info}\n");
        Console.WriteLine("1. 장착관리");
        Console.WriteLine("0. 나가기\n");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.WriteLine(">>");


        int input = CheckValidInput(0, 1);
        switch (input)
        {
            case 0:
                DisplayGameIntro();
                break;
            case 1:
                DisplayInventoryEquip();
                break;
        }
    }

    static int CheckValidInput(int min, int max)
    {
        while (true)
        {
            string input = Console.ReadLine();
            bool parseSuccess = int.TryParse(input, out var ret);
            if (parseSuccess)
            {
                if (ret >= min && ret <= max)
                {
                    return ret;
                }
            }
            Console.WriteLine("잘못된 입력입니다.");
        }
    }

    static void DisplayInventoryEquip()
    {
        Console.Clear();
        Console.WriteLine("인벤토리 - 장착 관리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
        Console.WriteLine("[아이템 목록]");
        Console.WriteLine($" - 1 {낡은지팡이.Name}, | 마나 +{낡은지팡이.Mp}, 물리공격력 +{낡은지팡이.PhysicalAttackPower}, 마법공격력 +{낡은지팡이.MagicAttackPower} | {낡은지팡이.Info}");
        Console.WriteLine($" - 2 {낡은로브.Name},   | 체력 +{낡은로브.Hp}, 마나 +{낡은로브.Mp}, 마법방어력 +{낡은로브.MagicDefence}      | {낡은로브.Info}\n");
        Console.WriteLine("0. 나가기\n");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.WriteLine(">>");

        int input = CheckValidInput(0, 2);
        switch (input)
        {
            case 0:
                DisplayInventory();
                break;
            case 1:
                
                break;
        }
    }
}

public class Character
{
    public string Name { get; }
    public string Job { get; }
    public int Level { get; }
    public int Hp { get; }
    public int Mp { get; }
    public int PhysicalAttackPower { get; }
    public int MagicAttackPower { get; }
    public int PhysicalDefence { get; }
    public int MagicDefence { get; }
    public int Gold { get; }
 

    public Character(string name, string job, int level, int hp, int mp, int physicalAttackPower, int magicAttackPower, int physicalDefence, int magicDefence, int gold)
    {
        Name = name;
        Job = job;
        Level = level;
        Hp = hp;
        Mp = mp;
        PhysicalAttackPower = physicalAttackPower;
        MagicAttackPower = magicAttackPower;
        PhysicalDefence = physicalDefence;
        MagicDefence = magicDefence;
        Gold = gold;
    }
}

public class Item
{
    public string Name { get; }
    public int Hp { get; }

    public int Mp { get; }
    public int PhysicalAttackPower { get; }
    public int MagicAttackPower { get; }
    public int PhysicalDefence { get; }
    public int MagicDefence { get; }
    public string Info { get; }

    public Item(string name, int hp, int mp, int physicalAttackPower, int magicAttackPower, int physicalDefence, int magicDefence, string info)
    {
        Name = name;
        Hp = hp;
        Mp = mp;
        PhysicalAttackPower = physicalAttackPower;      
        MagicAttackPower = magicAttackPower;
        PhysicalDefence = physicalDefence;
        MagicDefence = magicDefence;
        Info = info;
    }
}

