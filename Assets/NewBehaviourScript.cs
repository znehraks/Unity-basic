using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;

        //2.그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevels = new int[3];
        monsterLevels[0] = 1;
        monsterLevels[1] = 6;
        monsterLevels[2] = 20;

        for (int i = 0; i < 3; i++)
        {
            Debug.Log(monsterLevels[i]);
        }

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        for (int i = 0; i < 2; i++)
        {
            Debug.Log(items[i]);
        }
        items.RemoveAt(0);
        for (int i = 0; i < 1; i++)
        {
            Debug.Log(items[i]);
        }

        //3.연산자
        int exp = 1500 + 320;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        int health = 20;
        Heal(health);
        //8. 클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.Hasweapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
        Debug.Log(player.move());
    }
    //7.함수(메소드)
    void Heal(int currenthealth)
    {
        currenthealth += 10;
        Debug.Log("힐을 받았습니다." + currenthealth);
    }
}
