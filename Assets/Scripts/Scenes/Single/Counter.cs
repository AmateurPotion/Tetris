using System.Collections.Generic;
using UnityEngine;

namespace Tetris.Scenes.Single
{
    public class Counter : MonoBehaviour // ?? 뭐가이승 ㅁ?이거 쓰 안되나보네
    {
        // 지금 이건 유니티 스크립트라 Counter 클래스 내부에 선언 탁탁
        public void PlusCount()
        {
            // 저것ㄷ
            foreach (var (key, value) in UM)
            {
                Debug.Log($"Key: {key} / Value : {value}");
            } // 이런 식으로 내부에 있는 거 싹 다 출력가능
            // 아닌면 
            if(UM.ContainsKey("A")) // 여기 ConatainsKey 도 
            {
                // 이런 식으로 A 란 키가 있는지 확인할 수도 있고
                // 키보드에 alt 같은 거 있음? ㅇㅇ
                // alt 누르고 MonoBehaviour snㅏㅏ
            }
        }
        
        // 여기 앞 쪽이 key 자료형 , 뒤에가 값 자료형 
        // 위치를 지켜야됨
        public Dictionary<string, string> UM = new()// 이러면 string 키와 string 자료형
        { // 줄을 나눌 때는 쉼표로
            ["A"] = "A",
            ["B"] = "B",
            ["C"] = "C"
        };// 이렇게 쓰면됨 ? 문자는 못넣음 ? 아
        // 이걸 근데 어케 다외움
        // 클래스 내부에 선언해야됨
        // 쉽지않네
    }
}