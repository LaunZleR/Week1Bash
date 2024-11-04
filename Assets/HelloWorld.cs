using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        class HelloWorld
    {
        static void Main(string[] args)     // 모든 C# 프로그램은 Main()이라는 시작 함수(메서드)를 가져야 한다. Main() 메소드는 임의의 클래스 안에서 존재하며, 프로그램 상에 단 1개만 있어야 한다.
        {
            /* 
               Main()은 static으로 선언되며, 메소드 인자는 string[] 문자열이다.
               System.Console은 .NET Framework 클래스이며, WriteLine은 화면에 데이타를 Console클래스의 출력하는 메서드이다.
             */
            System.Console.WriteLine("Hello World...");
        }
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
