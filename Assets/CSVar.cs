using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        class CSVar
    {
        //�ʵ� (Ŭ���� ������ ���������� ���Ǵ� ���� ����) - ���� �Ҵ����� ������, �ش� Ÿ���� �⺻���� �ڵ����� �Ҵ�ȴ�. ex) int Ÿ���� �ʵ��� ��� �⺻�� 0�� �Ҵ�ȴ�.
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            // ���ú��� - �⺻���� �Ҵ���� ���ϱ� ������ �ݵ�� ��� ���� ���� �Ҵ��ؾ� �Ѵ�.
            int localVar;

            // �Ʒ� �Ҵ��� ������ ���� �߻�
            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }

        // ���- const�� ����Ͽ� �����Ѵ�. ����� ������ ��������, ������ ���α׷� �߰��� ���� ������ �� ������, ����� �ʱ⿡ ���� ���� �߰��� ������ �� ����. const�� �ʵ� ����ο��� ���ǰų� �޼��� ������ ���� �� ������, �����Ͻ� ������� �����ȴ�.
        const int MAX_VALUE = 1024;

        // readonly �ʵ� - C# const ��� readonly Ű���带 ����Ͽ� �б����� (���������� ����� �����) �ʵ带 ���� �� �ִ�. readonly�� �ʵ� ����γ� Ŭ���� �����ڿ��� �� ���� ������ �� �ְ�, ��Ÿ�ӽ� ���� �����ȴ�
        readonly int Max;
        public CSVar()
        {
            Max = 1;
        }

        //...
    }

    class Program
    {
        // ��� ���α׷����� Main()�� �־�� ��.
        static void Main(string[] args)
        {
            // �׽�Ʈ
            CSVar obj = new CSVar();
            obj.Method1();
        }
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
