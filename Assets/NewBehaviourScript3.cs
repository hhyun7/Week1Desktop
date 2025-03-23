using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    public class Goblin
    {
        public void TakeDamage(int damage)
        {
            Debug.Log($"���: {damage}��ŭ ü�� ����");
        }
    }

    public class Slime
    {
        public void TakeDamage(int damage)
        {
            Debug.Log($"������: {damage}��ŭ ü�� ����");
        }
    }

    public class Dragon
    {
        public void TakeDamage(int damage)
        {
            Debug.Log($"�巡��: {damage}��ŭ ü�� ����");
        }
    }

    public class Player
    {
        private int damage = 10;

        public void Hit(Goblin goblin)
        {
            goblin.TakeDamage(damage);
        }

        public void Hit(Slime slime)
        {
            slime.TakeDamage(damage);
        }

        public void Hit(Dragon dragon)
        {
            dragon.TakeDamage(damage);
        }
    }

    void Start()
    {
      
        Player player = new Player();

        
        Goblin goblin = new Goblin();
        Slime slime = new Slime();
        Dragon dragon = new Dragon();

        
        player.Hit(goblin);  
        player.Hit(slime);   
        player.Hit(dragon);  
    }
}