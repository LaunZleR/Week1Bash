using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        class DataType
    {
        static void Main(string[] args)
        {
            // Bool - �ο� �ڷ���
            bool b = true;

            // Numeric - ����
            short sh = -32768;   // 16��Ʈ signed integer
            int i = 2147483647;  // 32��Ʈ signed integer
            long l = 1234L;      // L suffix - 64��Ʈ signed integer
            float f = 123.45F;   // F suffix - 32��Ʈ single precision �ε��Ҽ��� ����
            double d1 = 123.45;  // �ƹ��͵� �����Ƿ� double Ÿ��
            double d2 = 123.45D; // D suffix - 64��Ʈ double precision �ε��Ҽ��� ����
            decimal d = 123.45M; // M suffix - 128��Ʈ Decimal

            // Char - 16��Ʈ �����ڵ� ����('') / String - �����ڵ� ���ڿ�("")
            char c = 'A';
            string s = "Hello";

            // DateTime  2024-10-30 21:30
            DateTime dt = new DateTime(2024, 10, 30, 21, 30, 0);

            // �ִ� �ּ�
            int imax = int.MaxValue;
            float fmin = float.MinValue;

            // Null - �޸𸮻� � �����͵� ������ ���� �ʴ�. / ����Ÿ Ÿ���� NULL�� ���� �� �ִ� Ÿ�� (Reference Ÿ��)�� ���� �� ���� Ÿ�� (Value Ÿ��)���� ���е� �� �ִ�.
            string st;
            st = null;

            /* Nullable Type - ����(int)�� ��¥(DateTime)�� ���� Value Type�� �Ϲ������� NULL�� ���� �� ����. C# 2.0�������� �̷��� Ÿ�Ե鿡 NULL�� ���� �� �ְ� �Ͽ��µ�, �̸� Nullable Type �̶� �θ���.
             * ����ǥ(?)�� int�� DateTime Ÿ�Ը� �ڿ� ���̸� ��, int? Ȥ�� DateTime? ���� �ϸ� Nullable Type�� �ȴ�. �̴� �������ϸ� .NET�� Nullable<T> Ÿ������ ��ȯ�ȴ�. Nullable Type (��: int?) �� �Ϲ� Value Type (��: int)���� �����ϱ� ���ؼ��� Nullable�� .Value �Ӽ��� ����Ѵ�.
             */
            // Nullable Ÿ��
            int? inull = null;
            inull = 101;

            bool? bn = null;

            //int? �� int�� �Ҵ�
            Nullable<int> jn = null;
            jn = 10;
            int k = jn.Value;
        }
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
