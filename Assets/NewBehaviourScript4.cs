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

    //    player02.ID = "��ڻ�";
    //    player02.currentHP = 1000000;
    //    player02.damage = 99999;

    //    Debug.Log($"{player01.ID}, ü�� : {player01.currentHP}, ���ݷ� : {player01.damage}");
    //    Debug.Log($"{player02.ID}, ü�� : {player02.currentHP}, ���ݷ� : {player02.damage}");
    //}

    //���� ���� ��
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

            Enemy.specise = "���";
            Debug.Log(Enemy.specise);
        }
    }
}
