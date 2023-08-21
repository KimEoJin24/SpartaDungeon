internal class Program
{
    private static Character player;
    static void Main(string[] args)
    {
        GameDataSetting();
        DisplayGameIntro();
    }

    static void GameDataSetting()
    {
        player = new Character("하늘연달", "마법사", 1, 100, 50, 10, 10, 25);
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
        Console.WriteLine($"공격력: {player.Attack}");
        Console.WriteLine($"방어력: {player.Defence}");
        Console.WriteLine($"Gold: {player.Gold}G");
    }

    static void DisplayInventory()
    {
        Console.Clear();
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
}

public class Character
{
    public string Name { get;  }
    public string Job { get; }
    public int Level { get; }
    public int Hp { get; }
    public int Mp { get; }
    public int Attack { get; }
    public int Defence { get; }
    public int Gold { get; }

    public Character (string name, string job, int level, int hp, int mp, int attack, int defence, int gold)
    {
        Name = name;
        Job = job;
        Level = level;
        Hp = hp;
        Mp = mp;
        Attack = attack;
        Defence = defence;
        Gold = gold;
    }
}
