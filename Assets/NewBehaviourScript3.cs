using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    public class Goblin
    {
        public void TakeDamage(int damage)
        {
            Debug.Log($"고블린: {damage}만큼 체력 감소");
        }
    }

    public class Slime
    {
        public void TakeDamage(int damage)
        {
            Debug.Log($"슬라임: {damage}만큼 체력 감소");
        }
    }

    public class Dragon
    {
        public void TakeDamage(int damage)
        {
            Debug.Log($"드래곤: {damage}만큼 체력 감소");
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