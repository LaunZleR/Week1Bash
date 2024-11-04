using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        // C#���� �迭�� Zero-based Array �� ù��° ��Ұ� �ε��� 0�� ���´�.
        class CSArray
        {
        /* 
         * C# �迭�� 1���迭, 2���迭, 3���迭,..., 32�� �迭 �� �ְ� 32�� �迭�� ���� �� �ִ�. 
         * 2�� �̻��� ������ �迭�� 
         * (1)�� ������ ��� ũ�Ⱑ ������ Rectangular �迭�� 
         * (2) �� ������ ũ�Ⱑ ���� �ٸ� �����迭�� ���� �� �ִ�.
         * ������ 1�� �迭�� 2��,3�� �迭(C-Style�� Rectangular �迭)�� �����ϴ� ���̴�. 
         * �Ʒ� �������� �迭 players�� 10���� string ��Ҹ� ������ ����Ǿ���, Regions/Depts�� ���� 1��,2�� �迭�̸� �ʱ�ȭ ������ �Ҵ��ϰ� �ִ�. 
         * �������� Cubes �� 3���迭�� ������ ���̴�.
         */
            // 1�� �迭
            string[] players = new string[10];
            string[] Regions = { "����", "���", "�λ�" };

            // 2�� �迭 ���� �� �ʱ�ȭ
            string[,] Depts = { { "�����", "�渮��" }, { "�̰���", "�ѹ���" } };

            // 3�� �迭 ����
            string[,,] Cubes = { "�ð�" , "����" , { "����" } };
        }

        // ��� C# �迭�� ���������� .NET Framework�� System.Array���� �Ļ��� ���̴�. ����, System.Array�� �޼���, ������Ƽ�� ����� �� �ִ�.
        // ���� ������ ���� �迭(scores)�� �ϳ� �ϳ� �������ϸ鼭 ������ ���ϴ� ���̴�.
        // �Ʒ� �������� �迭 scores�� ����� ���ϱ� ���Ͽ� scores.Length ó�� .Length �Ӽ��� ����Ͽ��µ�, �̴� System.Array Ŭ������ ���ǵ� �Ӽ��̴�.
        static void Main(string[] args)
        {
            int sum = 0;                                // ���� �� �ʱ�ȭ
            int[] scores = { 80, 78, 60, 90, 100 };     // ���� �迭
            for (int i = 0; i < scores.Length; i++)     // ���� �迭�� �ε��� 0~4���� 1�� �÷����� �ݺ�
            {
                sum += scores[i];                       // ���տ� ���� �迭�� i��° �ε����� �� ����
            }
            Console.WriteLine(sum);                     // ���� ���
        }

    // Update is called once per frame
    void Update()
    {
        /* 
         * ���� �迭 (Jagged Array) - �� ������ �迭 ��� ũ�Ⱑ �������� ���� �迭(Jagged Array)�� ��� [][] �� ���� �� �������� ��ȣ�� ������ ����Ѵ� (Java ��� ��Ÿ��).
         * ���� �迭�� �迭�� �迭(array of arrays)�̶� �Ҹ���µ�, ù��° ������ ũ��� ������ Ÿ�ӿ� Ȯ���Ǿ�� �ϰ�, �� �̻� ������ ��Ÿ�ӽ� �������� ���� �ٸ� ũ���� �迭�� ������ �� �ִ�. 
         * �̷��� ���� �迭�� �� ������ �迭 ��Ұ� �ұ�Ģ�Ͽ� Rectangular �迭ó�� ������ ũ�⸦ ����ϸ� �޸��� ���� ���� ��쿡 ����ϸ� �����ϴ�.
         */
        class CSJArray
        {
            //1�� �迭 ũ��(3)�� ����ؾ�
            int[][] A = new int[3][];

            //�� 1�� �迭 ��Ҵ� ���� �ٸ� ũ���� �迭 �Ҵ� ����
            A[0] = new int[2];
            A[1] = new int[3] {1, 2, 3;
            A[2] = new int[4] { 1, 2, 3, 4;

            A[0][0] = 1;
            A[0][1] = 2;
        }
        // C# �迭�� ����
        /*
        * C#���� �迭 ��ü�� �����ϱ� ���ؼ��� ������ �ʿ����� �迭���� ����ϰ�, �޴� �ʿ��� ������ �迭Ÿ���� �迭�� �޾Ƶ��̸� �ȴ�.
        * �迭�� ���۷���(Reference) Ÿ���̱� ������, 
        * �迭�� �ٸ� ��ü�� �޼��忡 ������ ��, ���� ��� �迭 ����Ÿ�� �������� �ʰ�, 
        * �迭 ��ü�� ����Ű�� ���� ��(Reference pointer)���� �����Ѵ�. 
        * ��, �����ϴ� �ʿ����� �ܼ��� ���۷����� �迭���� ����ϸ�, �޴� �ʿ����� �Ʒ� ������ ���� �迭 ����Ÿ Ÿ�� �� �迭 �Ķ���͸��� ����Ѵ�.
        */
        static void Main(string[] args)
        {            
            int[] scores = { 80, 78, 60, 90, 100 };
            int sum = CalculateSum(scores);         // �迭 ����: �迭�� ���
            Console.WriteLine(sum);        
        }

        static int CalculateSum(int[] scoresArray) // �迭 �޴� ��: �迭 ������ Ÿ��(static) �� �迭 �Ķ���͸�(int)
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }
            return sum;
        }
}
