//---------------------------------------------------------------------
// Question 1: Player Class
// Create a class named "Player" to represent a character in a role-playing game.
// Include attributes for the player's name, level, health points (HP), and experience points (XP).
// Implement methods to level up the player, heal the player, and gain experience points.
// Hint: Declare a class with properties for name, level, HP, and XP. Implement methods to increase level, heal HP, and gain XP.
/* Think about how players progress in a typical RPG game. Consider what actions a player can take and how they affect the player's attributes. */

/*using System;

class Player
{
    // Thuộc tính
    public string Name { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }
    public int XP { get; set; }

    // Constructor
    public Player(string name)
    {
        Name = name;
        Level = 1;
        HP = 100;
        XP = 0;
    }

    // Tăng cấp
    public void LevelUp()
    {
        Level++;
        HP = 100; // hồi đầy máu khi lên level
        Console.WriteLine($"{Name} leveled up! Now level {Level}");
    }

    // Hồi máu
    public void Heal(int amount)
    {
        HP += amount;
        Console.WriteLine($"{Name} healed {amount} HP. Current HP: {HP}");
    }

    // Nhận kinh nghiệm
    public void GainXP(int amount)
    {
        XP += amount;
        Console.WriteLine($"{Name} gained {amount} XP. Total XP: {XP}");

        // Ví dụ: đủ 100 XP thì lên level
        if (XP >= 100)
        {
            XP -= 100;
            LevelUp();
        }
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player("Hero");

        player.GainXP(50);
        player.GainXP(60); // sẽ lên level
        player.Heal(20);
    }
}*/

//---------------------------------------------------------------------
// Question 2: Enemy Class
// Develop a class called "Enemy" to represent adversaries in a video game.
// Include properties for the enemy's name, health points (HP), attack power, and defense.
// Implement methods to calculate damage inflicted by the enemy and to update their HP.
// Hint: Define a class with attributes for name, HP, attack power, and defense. Create methods to calculate damage and update HP.
/* Consider the role enemies play in games. They typically attack players and can be defeated by reducing their HP to zero. */

/*using System;

class Enemy
{
    // Thuộc tính
    public string Name { get; set; }
    public int HP { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    // Constructor
    public Enemy(string name, int hp, int attack, int defense)
    {
        Name = name;
        HP = hp;
        AttackPower = attack;
        Defense = defense;
    }

    // Tính sát thương gây ra
    public int CalculateDamage()
    {
        Random rand = new Random();
        int damage = AttackPower + rand.Next(0, 6); // random thêm 0-5
        return damage;
    }

    // Nhận sát thương
    public void TakeDamage(int damage)
    {
        int actualDamage = damage - Defense;

        if (actualDamage < 0)
            actualDamage = 0;

        HP -= actualDamage;

        Console.WriteLine($"{Name} took {actualDamage} damage. Remaining HP: {HP}");

        if (HP <= 0)
        {
            Console.WriteLine($"{Name} has been defeated!");
        }
    }
}

class Program
{
    static void Main()
    {
        Enemy enemy = new Enemy("Goblin", 50, 10, 3);

        int damage = enemy.CalculateDamage();
        Console.WriteLine($"Enemy attacks with {damage} damage!");

        enemy.TakeDamage(20);
        enemy.TakeDamage(40);
    }
}
*/

//---------------------------------------------------------------------
// Question 3: Potion Class
// Design a class named "Potion" to model health-restoring items in an adventure game.
// Include properties for the potion's name, healing power, and quantity in inventory.
// Implement a method to apply the potion to a player character and restore their health.
// Hint: Define a class with attributes for name, healing power, and quantity. Create a method to apply the potion and heal the player.
/* Think about how healing items function in games. They typically restore a portion of a player's health when consumed. */

/*using System;

// Player đơn giản để test
class Player
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int MaxHP { get; set; }

    public Player(string name)
    {
        Name = name;
        MaxHP = 100;
        HP = 50;
    }

    public void Heal(int amount)
    {
        HP += amount;

        if (HP > MaxHP)
            HP = MaxHP;

        Console.WriteLine($"{Name} healed {amount} HP. Current HP: {HP}");
    }
}

// Potion class
class Potion
{
    public string Name { get; set; }
    public int HealingPower { get; set; }
    public int Quantity { get; set; }

    public Potion(string name, int healingPower, int quantity)
    {
        Name = name;
        HealingPower = healingPower;
        Quantity = quantity;
    }

    // Dùng potion
    public void Use(Player player)
    {
        if (Quantity <= 0)
        {
            Console.WriteLine("No potions left!");
            return;
        }

        Console.WriteLine($"{player.Name} uses {Name}!");

        player.Heal(HealingPower);
        Quantity--;

        Console.WriteLine($"Remaining {Name}: {Quantity}");
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player("Hero");
        Potion potion = new Potion("Health Potion", 30, 2);

        potion.Use(player);
        potion.Use(player);
        potion.Use(player); // hết potion
    }
}*/


//---------------------------------------------------------------------
// Question 4: Quest Class
// Create a class called "Quest" to represent tasks or missions in a quest-based game.
// Include properties for the quest's name, description, reward, and completion status.
// Implement methods to start the quest, complete the quest, and claim the reward.
// Hint: Define a class with attributes for name, description, reward, and completion status. Implement methods to manage quest progress.
/* Consider the structure of quests in games. They often involve objectives, rewards, and tracking completion status. */

/*using System;

// Player đơn giản để nhận thưởng
class Player
{
    public string Name { get; set; }
    public int XP { get; set; }

    public Player(string name)
    {
        Name = name;
        XP = 0;
    }

    public void AddXP(int amount)
    {
        XP += amount;
        Console.WriteLine($"{Name} gained {amount} XP. Total XP: {XP}");
    }
}

// Quest class
class Quest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Reward { get; set; } // XP reward
    public bool IsCompleted { get; set; }

    private bool isStarted = false;

    public Quest(string name, string description, int reward)
    {
        Name = name;
        Description = description;
        Reward = reward;
        IsCompleted = false;
    }

    // Bắt đầu nhiệm vụ
    public void StartQuest()
    {
        isStarted = true;
        Console.WriteLine($"Quest started: {Name}");
        Console.WriteLine($"Description: {Description}");
    }

    // Hoàn thành nhiệm vụ
    public void CompleteQuest()
    {
        if (!isStarted)
        {
            Console.WriteLine("You need to start the quest first!");
            return;
        }

        IsCompleted = true;
        Console.WriteLine($"Quest completed: {Name}");
    }

    // Nhận thưởng
    public void ClaimReward(Player player)
    {
        if (!IsCompleted)
        {
            Console.WriteLine("Quest not completed yet!");
            return;
        }

        Console.WriteLine($"{player.Name} claims reward: {Reward} XP");
        player.AddXP(Reward);
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player("Hero");

        Quest quest = new Quest(
            "Defeat Goblin",
            "Defeat 5 goblins in the forest",
            100
        );

        quest.StartQuest();
        quest.CompleteQuest();
        quest.ClaimReward(player);
    }
}*/

//---------------------------------------------------------------------
// Question 5: Inventory Class
// Develop a class named "Inventory" to manage a player's items in a role-playing game.
// Include properties for the inventory's capacity, list of items, and methods to add/remove items.
// Implement functionality to check if an item exists in the inventory and display its details.
// Hint: Define a class with attributes for capacity and a list of items. Create methods to add, remove, and search for items.
/* Think about how inventories work in games. Players can store and manage various items they collect during their adventures. */

/*using System;
using System.Collections.Generic;

// Class Item đơn giản
class Item
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public Item(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}

// Inventory class
class Inventory
{
    public int Capacity { get; set; }
    public List<Item> Items { get; set; }

    public Inventory(int capacity)
    {
        Capacity = capacity;
        Items = new List<Item>();
    }

    // Thêm item
    public void AddItem(string name, int quantity)
    {
        if (Items.Count >= Capacity)
        {
            Console.WriteLine("Inventory is full!");
            return;
        }

        // Nếu item đã tồn tại → cộng thêm
        Item existingItem = Items.Find(i => i.Name == name);

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            Items.Add(new Item(name, quantity));
        }

        Console.WriteLine($"Added {quantity} {name}(s)");
    }

    // Xóa item
    public void RemoveItem(string name, int quantity)
    {
        Item item = Items.Find(i => i.Name == name);

        if (item == null)
        {
            Console.WriteLine("Item not found!");
            return;
        }

        item.Quantity -= quantity;

        if (item.Quantity <= 0)
        {
            Items.Remove(item);
        }

        Console.WriteLine($"Removed {quantity} {name}(s)");
    }

    // Kiểm tra item
    public bool HasItem(string name)
    {
        return Items.Exists(i => i.Name == name);
    }

    // Hiển thị inventory
    public void ShowItems()
    {
        Console.WriteLine("=== Inventory ===");

        if (Items.Count == 0)
        {
            Console.WriteLine("Empty");
            return;
        }

        foreach (var item in Items)
        {
            Console.WriteLine($"{item.Name} x{item.Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory(5);

        inventory.AddItem("Potion", 2);
        inventory.AddItem("Sword", 1);
        inventory.AddItem("Potion", 3);

        inventory.ShowItems();

        inventory.RemoveItem("Potion", 4);

        Console.WriteLine("Has Sword? " + inventory.HasItem("Sword"));

        inventory.ShowItems();
    }
}*/

//---------------------------------------------------------------------
// Question 6: Spell Class
// Design a class called "Spell" to represent magical abilities or spells in a fantasy game.
// Include properties for the spell's name, damage, mana cost, and description.
// Implement methods to cast the spell, consume mana, and display spell details.
// Hint: Define a class with attributes for name, damage, mana cost, and description. Implement methods to cast and describe the spell.
/* Consider the mechanics of spellcasting in fantasy games. Spells often have different effects, costs, and descriptions. */

using System;

// Player đơn giản để test
class Player
{
    public string Name { get; set; }
    public int Mana { get; set; }

    public Player(string name)
    {
        Name = name;
        Mana = 100;
    }

    public bool UseMana(int amount)
    {
        if (Mana < amount)
        {
            Console.WriteLine("Not enough mana!");
            return false;
        }

        Mana -= amount;
        Console.WriteLine($"{Name} used {amount} mana. Remaining mana: {Mana}");
        return true;
    }
}

// Enemy đơn giản để nhận damage
class Enemy
{
    public string Name { get; set; }
    public int HP { get; set; }

    public Enemy(string name, int hp)
    {
        Name = name;
        HP = hp;
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        Console.WriteLine($"{Name} took {damage} damage. Remaining HP: {HP}");
    }
}

// Spell class
class Spell
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int ManaCost { get; set; }
    public string Description { get; set; }

    public Spell(string name, int damage, int manaCost, string description)
    {
        Name = name;
        Damage = damage;
        ManaCost = manaCost;
        Description = description;
    }

    // Hiển thị thông tin spell
    public void ShowInfo()
    {
        Console.WriteLine($"Spell: {Name}");
        Console.WriteLine($"Damage: {Damage}");
        Console.WriteLine($"Mana Cost: {ManaCost}");
        Console.WriteLine($"Description: {Description}");
    }

    // Cast spell
    public void Cast(Player player, Enemy enemy)
    {
        Console.WriteLine($"{player.Name} casts {Name}!");

        if (player.UseMana(ManaCost))
        {
            enemy.TakeDamage(Damage);
        }
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player("Mage");
        Enemy enemy = new Enemy("Orc", 80);

        Spell fireball = new Spell(
            "Fireball",
            25,
            20,
            "A powerful fire attack"
        );

        fireball.ShowInfo();
        fireball.Cast(player, enemy);
        fireball.Cast(player, enemy);
    }
}