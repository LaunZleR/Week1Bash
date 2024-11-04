using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // C#�� Ű���� string�� .NET�� System.String Ŭ������ �����ϸ�, ���� System.String Ŭ������ ��� �޼���� �Ӽ�(Property)�� ����� �� �ִ�.
        // C# ���ڿ��� Immutable �� �ѹ� ���ڿ��� �����Ǹ�, �ٽ� ������ �� ����.
        static void Main(string[] args)
        {
            // ���ڿ�(string) ����
            string s1 = "C#";
            string s2 = "Programming";

            // ����(char) ���� 
            char c1 = 'A';
            char c2 = 'B';

            // ���ڿ� ����
            string s3 = s1 + " " + s2;
            Console.WriteLine("String: {0}", s3);

            // �κй��ڿ� ����
            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("Substring: {0}", s3substring);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
