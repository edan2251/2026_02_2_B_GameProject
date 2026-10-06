using JetBrains.Annotations;
using System;

[Serializable]
public class DungeonPlayerData
{
    public int id;
    public string name;
    public int level;
    public int hp;
    public int maxHp;
    public int attack;
    public int gold;
}

[Serializable]
public class DungeonRoomData
{
    public int idex;
    public string type;
    public string state;
    public string monsterName;
    public int monsterHp;
    public int MonsterAttack;
    public int rewardGold;
}

[Serializable]
public class DungeonStateData
{
    public DungeonPlayerData player;
    public DungeonRoomData room;
}

[Serializable]
public class  DungeonResponse
{
    public bool success;
    public string code;
    public string message;
    public DungeonStateData data;
}

[Serializable]
public class  DungeonActionRequest
{
    public string action;
}
