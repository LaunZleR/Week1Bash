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
        //필드 (클래스 내에서 공통적으로 사용되는 전역 변수) - 값을 할당하지 않으면, 해당 타입의 기본값이 자동으로 할당된다. ex) int 타입의 필드인 경우 기본값 0이 할당된다.
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            // 로컬변수 - 기본값을 할당받지 못하기 때문에 반드시 사용 전에 값을 할당해야 한다.
            int localVar;

            // 아래 할당이 없으면 에러 발생
            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }

        // 상수- const를 사용하여 정의한다. 상수와 변수의 차이점은, 변수는 프로그램 중간에 값을 변경할 수 있지만, 상수는 초기에 정한 값을 중간에 변경할 수 없다. const는 필드 선언부에서 사용되거나 메서드 내에서 사용될 수 있으며, 컴파일시 상수값이 결정된다.
        const int MAX_VALUE = 1024;

        // readonly 필드 - C# const 대신 readonly 키워드를 사용하여 읽기전용 (개념적으로 상수와 비슷한) 필드를 만들 수 있다. readonly는 필드 선언부나 클래스 생성자에서 그 값을 지정할 수 있고, 런타임시 값이 결정된다
        readonly int Max;
        public CSVar()
        {
            Max = 1;
        }

        //...
    }

    class Program
    {
        // 모든 프로그램에는 Main()이 있어야 함.
        static void Main(string[] args)
        {
            // 테스트
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
