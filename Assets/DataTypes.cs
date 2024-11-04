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
            // Bool - 부울 자료형
            bool b = true;

            // Numeric - 숫자
            short sh = -32768;   // 16비트 signed integer
            int i = 2147483647;  // 32비트 signed integer
            long l = 1234L;      // L suffix - 64비트 signed integer
            float f = 123.45F;   // F suffix - 32비트 single precision 부동소수점 숫자
            double d1 = 123.45;  // 아무것도 없으므로 double 타입
            double d2 = 123.45D; // D suffix - 64비트 double precision 부동소수점 숫자
            decimal d = 123.45M; // M suffix - 128비트 Decimal

            // Char - 16비트 유니코드 문자('') / String - 유니코드 문자열("")
            char c = 'A';
            string s = "Hello";

            // DateTime  2024-10-30 21:30
            DateTime dt = new DateTime(2024, 10, 30, 21, 30, 0);

            // 최대 최소
            int imax = int.MaxValue;
            float fmin = float.MinValue;

            // Null - 메모리상 어떤 데이터도 가지고 있지 않다. / 데이타 타입은 NULL을 가질 수 있는 타입 (Reference 타입)과 가질 수 없는 타입 (Value 타입)으로 구분될 수 있다.
            string st;
            st = null;

            /* Nullable Type - 정수(int)나 날짜(DateTime)와 같은 Value Type은 일반적으로 NULL을 가질 수 없다. C# 2.0에서부터 이러한 타입들에 NULL을 가질 수 있게 하였는데, 이를 Nullable Type 이라 부른다.
             * 물음표(?)를 int나 DateTime 타입명 뒤에 붙이면 즉, int? 혹은 DateTime? 같이 하면 Nullable Type이 된다. 이는 컴파일하면 .NET의 Nullable<T> 타입으로 변환된다. Nullable Type (예: int?) 을 일반 Value Type (예: int)으로 변경하기 위해서는 Nullable의 .Value 속성을 사용한다.
             */
            // Nullable 타입
            int? inull = null;
            inull = 101;

            bool? bn = null;

            //int? 를 int로 할당
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
