using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class NewBehaviourScript4 : MonoBehaviour
{
    //public struct Stats
    //{
    //    public string ID;
    //    public int currentHP;
    //    public int damage;
    //}
    //private void Awake()
    //{
    //    Stats player01 = new Stats();
    //    Stats player02 ;

    //    player02.ID = "고박사";
    //    player02.currentHP = 1000000;
    //    player02.damage = 99999;

    //    Debug.Log($"{player01.ID}, 체력 : {player01.currentHP}, 공격력 : {player01.damage}");
    //    Debug.Log($"{player02.ID}, 체력 : {player02.currentHP}, 공격력 : {player02.damage}");
    //}

    //정적 변수 예
    public class Enemy
    {
        public int numeric;
        public static string specise;
    }

    public class GameController
    {
        private void Awake()
        {
            Enemy enemy01 = new Enemy();
            enemy01.numeric = 0;
            Enemy enemy02 = new Enemy();
            enemy02.numeric = 1;

            Debug.Log(enemy01.numeric);
            Debug.Log(enemy02.numeric);

            Enemy.specise = "고블린";
            Debug.Log(Enemy.specise);
        }
    }
}
