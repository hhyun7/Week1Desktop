using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class NewBehaviourScript5 : MonoBehaviour
//{
//    //�ڵ� ���� ������Ƽ ��
//    public class GameController
//    {
//        private void Awake()
//        {
//            Player player = new Player();
//            player.ID = "rhqkerk";
//            player.CurrentHP = 100;
//            Debug.Log($"{player.ID} HP: {player.CurrentHP}");
//        }





//    }

//    public class Player
//    {
//        public int CurrentHP
//        {
//            get; set;
//        }
//        public string ID
//        {
//            get; set;
//        }

//        public string Shield
//        {
//            get; set;
//        }

//        public string Defense
//        {
//            get; set;
//        }
//    }
//    private void Awake1()
//    {
//        Player player = new Player()
//        {
//            player.ID = "rhqktk",
//            player.Shield = 50,
//            player.Defense = 10
//        };

//        Debug,Log($"ID : {player.ID}");
//        Debug.Log($"���� : {player.Defense}, �� : {player.Shield}");
//    }


//}

//�ΰ��� ���� �ϳ��� ����
public class NewBehaviourScript5 : MonoBehaviour
{
    
    public class Player
    {
        public int CurrentHP { get; set; }
        public string ID { get; set; }
        public int Shield { get; set; }
        public int Defense { get; set; }
    }

    private void Awake()
    {
        // Player �ν��Ͻ� ���� �� �ʱ�ȭ
        Player player = new Player()
        {
            ID = "rhqkert",
            CurrentHP = 100,
            Shield = 50, 
            Defense = 10 
        };

        Debug.Log($"{player.ID} HP: {player.CurrentHP}");
        Debug.Log($"���� : {player.Defense}, �� : {player.Shield}");
    }
}
