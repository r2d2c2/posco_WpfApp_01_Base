using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_04_Dessin
{
    public class CounterManager
    {
        // 전역 변수로
        private static CounterManager instance = null;
        //멀티 스레드 환경에서 안전하게 사용하기 위해
        private static object lockObject = new object();

        // 저장 속성
        public int Count { get; private set; }
        // 외부에서 직접 생성 못하도록 설정
        private CounterManager()
        {
            Count = 0;
        }
        // 공유인스턴스를 제고하는 속성
        public static CounterManager Instance
        {
            get
            {
                lock (lockObject)// 멀티 스레드 환경에서 안전하게 사용하기
                {
                    if (instance == null)
                    {
                        instance = new CounterManager();
                    }
                    return instance;
                }
            }
        }
        public void Increment()
        {
            Count++;
        }

    }
}
