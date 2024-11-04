using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // C#의 키워드 string은 .NET의 System.String 클래스와 동일하며, 따라서 System.String 클래스의 모든 메서드와 속성(Property)을 사용할 수 있다.
        // C# 문자열은 Immutable 즉 한번 문자열이 설정되면, 다시 변경할 수 없다.
        static void Main(string[] args)
        {
            // 문자열(string) 변수
            string s1 = "C#";
            string s2 = "Programming";

            // 문자(char) 변수 
            char c1 = 'A';
            char c2 = 'B';

            // 문자열 결합
            string s3 = s1 + " " + s2;
            Console.WriteLine("String: {0}", s3);

            // 부분문자열 발췌
            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("Substring: {0}", s3substring);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
