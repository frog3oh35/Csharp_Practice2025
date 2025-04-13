using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*오늘은 인스턴스 메서드와 클래스 메서드의 마스터가 된날이다.
    public class FishBread
    {
        public string filling = "팥";

        public void Eat()
        {
            Console.WriteLine("냠냠! " + filling + " 붕어빵을 먹었습니다.");
        }
    }


### 1. 인스턴스 생성과 클래스 메서드
    FishBread myBread = new FishBread();
    붕어빵틀, 내 붕어빵 이름 = 붕어빵틀에맞춰서 new생성(함수호출);
    == 인스턴스 만들기다~

그리고 myBread.Eat(); 은
나의 복제품.먹다(=행동)


### 2. 오버라이딩과 업캐스팅
    *오버라이딩이란?
    상속받은 메서드를 내 방식대로 정의하는 것

    class 본사 - void filling (팥을 넣어라)
    class 분점 : 본사 - void filling (슈크림할래용)
    아래가 오버라이딩


    *업캐스팅 코드의 이해 (다형성의 개념)
    업캐스팅 : 자식 객체를 부모 타입으로 다루는 것

    BakeryHeadquarter bakery = new LocalBakery();
    부모타입 / 변수이름 / = / 인스턴스(자식 클래스)

    class 붕어빵본사 {}
    class 슈붕분점 : 붕어빵본사 {}
    class 팥붕분점 : 붕어빵본사 {}

    붕어빵본사 빵집 = new 슈붕분점();
    빵집.내용물();  // → 슈크림이 나옴

    ~내가 비유한 코드해석~
    BakeryHeadquarter bakery                    = new  LocalBakery ();
    본사의붕빵틀      본사의 이름을 딴 것(분점) = 생성 본사붕방틀로만든붕빵틀();
 
    LocalBakery = 본사의방침을따른(부모와 연결된 자식)의 붕빵틀
    BakeryHeadquarter = 본사붕빵틀
    bakery = 붕빵빵 대전점, 붕빵빵 청주점...

    업캐스팅 코드 : bakery.Filling()
    BakeryHeadquarter bakery = 본사의 이름을 딴 것 (QC)
    내 비유의 업캐스팅 : 본사붕방틀을 인지한 본사QC가,
    분사에 와서 내용물을 채우기 시키기.

    bakery가 분점 또는 QC 둘다 비유하는 이유
    = 결국 HeadQuarter라는 부모님 아래에서 생겨난 자식이기 때문.

 */