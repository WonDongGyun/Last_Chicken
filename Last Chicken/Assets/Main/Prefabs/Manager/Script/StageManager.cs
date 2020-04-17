﻿using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static StageManager instance;

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public Sprite tutorial_BackGround;
    public string tutorial_Name;

    public Sprite stage0101_BackGround;
    public string stage0101_Name;
    public MonsterManager.SpawnMonster stage0101_Monsters = new MonsterManager.SpawnMonster();
    public int stage0101_ObjectValue;
    public int stage0101_WoodBoxValue;
    public int stage0101_TrapValue;

    public Sprite stage0102_BackGround;
    public string stage0102_Name;
    public MonsterManager.SpawnMonster stage0102_Monsters = new MonsterManager.SpawnMonster();
    public int stage0102_ObjectValue;
    public int stage0102_WoodBoxValue;
    public int stage0102_TrapValue;

    public Sprite stage0103_BackGround;
    public string stage0103_Name;
    public MonsterManager.SpawnMonster stage0103_Monsters = new MonsterManager.SpawnMonster();
    public int stage0103_ObjectValue;
    public int stage0103_WoodBoxValue;
    public int stage0103_TrapValue;

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    #region[Awake]
    public void Awake()
    {
        if (instance == null)
            instance = this;
    }
    #endregion
}