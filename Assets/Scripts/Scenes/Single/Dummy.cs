using UnityEngine;

namespace Tetris.Scenes.Single
{
    
    public class ASD
    {
        public int A = 1;

        public void Test()
        {
            // void 부분이 Test 메소드가 돌려주는 값을 지정하는 거고
            // void는 아무 값도 안 준다는거임
            // 잠만 나 일때매 10분만 

            var value = new ASDD().GetInt(); // 이렇게 호출해서 value란 변수 안에는 1 이 들어가게 됨
        }

        public void ASDValue() // 메소드 명과 클래스의 이름은 같으면 안됨
        {

        }
    }
    //void 는 머임
    //
// 여기는 메소드 밖이라  ㅇㅇ 
//클래스 선언 안하고는 아무것도 못함 ?
    public class FF
    {
        // 메소드 밖에서는 var 변수 선언 불가능함 자료형을 결정해서 선언만 가능 변수 사이에 띄어쓰기 불가
        string asddadddadada = "이런것만 된다고 ?"; // 문자열은 "" 로 감싸줘야됨
        // 이것도 좀 어려운 기능 활용하면
        // 지금 이건 많이 꼬아놓은 거니 그냥 이런 게 있다~ 하고 보기만 하고
            //이해가안됨 뭐임이게 get set 이게 머임 쉽지안ㄴㅎ네
        public ASD asd;
        
        // class 는 다 이해됨? ㅇㅇ
        // 그럼 이제 변종에 대해 알려줄게
        
        
        
        
        /* 변수의 값을 설정할 때랑 가져올 때 어떻게 하라고 직접 설정하는거
        이거는 중요한 기능이기도 하니 나중에 제대로 알려줄게 일단은 넘기자
        지금 이거 다루면 순서가 꼬임 
        public string value 
        {
            get => "valuye";
            set
            {
                // 여기선 메소드처럼 작동함
                asddadddadada = value;
            }
        }

        public string this[string name]
        {
            get => name;
        }
        */
    }

    public abstract class AbstractClass
    {
        // 이게 추상 클래스
        // 얘들은 일반 클래스처럼 바로 선언해서 쓸 수 없고 반드시 상속해서 구현한뒤에 써야됨
        public abstract void Run(); // 여기 메소드 앞에 붙는 abstract 도 자식 클래스에서 반드시 이 메소드를 구현해야된다는 기능 명세 고
    }

// 이해 안되는 거 있어? 다 안됨 애초에 상속한다는 개념이 아 이해됨 뭐지 천잰가 근데 왜 상속해서 써야가가
// 부모로 총 이라는 클래스가 있다고 치면 이 총이라는 클래스가 있는데 샷건이라는 클래스를 처음부터 만들려면 구현해야되는 게 배로 늘어나니
// 총이라는 클래스를 상속해서 총의 기본적인 기능은 냅두고 샷건의 기능만을 추가로 구현하는거지
    public class ChildClass : AbstractClass
    {
        public override void Run()
        {
        }
    }

    public abstract class Gun
    {
        public abstract int Shot(); 
        public virtual void Reload()
        {
            // 이렇게 미리 어떻게 작동할지 선언가능
            // 이러면 자식에서 구현안하면 부모의 virtual 메소드를 호출함
            // abstract 나 virtual 로 선언한 걸 재정의한다는 말
            // virtual로 선언했으면 그냥 써도 되는데 abstract로 선언했으면 반드시 재정의해야됨
        }
        public void Run(){}
    }
    
    public class Shoutgun : Gun
    {
        public override int Shot() // 부모의 자료형을 그대로 가져와야됨 // 요로코롬 반환값을 int로 바꿈됨
        {
            int A = 1;// 얘는 void로 해놔서 다른 값을 반환하지 못함
            // 이거는됨 ? 이건 반환값이 없음 값을 반환하려면 return 뒤에 써야됨
            return A; // ㅇㅇ 편안
            //그럼 void쓰면 어떤 문자열이던 숫자던 반환 못하고 그냥 코드의 진행만 하는거임 ?
            // 이제이해함 ㅋㅋ
        }// 이렇게
        // abstract나 virtual 로 선언하지 않으면 override 로 재정의가 불가능
        // abstract 클래스에는 다 abstract 붙혀야됨 ?
        // override 는 머임
        //재정의 안하고 써도됨 ?
        //이럼 이제 Shoutgun 클래스 쓸수있는거임 ?
        //버츄얼로 선언했으면 재정의 안해도되는거아님 ?
        // 그럼 그냥 public이랑 다를게 없는거 아님 ?
        //abstract class 안에서 그냥 쓸려면 버츄얼 부팋는거 ?
        // 이해됐음 ㅁㄹ
    } // 진짜 이해 댕 잘하네 ㅋㅋㅋㅋㅋ 가르치는 맛이 있다
    
    public class Hand
    {// return 은 키워드 명칭이기 때문에 이름으로 쓸 수 없음. 대체로 class나 enum, interface, var 같은 키워드는 이름으로 불가
        public int ReturnValue() //이건됨 ? 대소문자 구분안함 ?
        {
            var obj = new Shoutgun();
            return obj.Shot();// ㅇㅇ
            //이러면 obj가 1 뱉어내는거 ? 아 obj 자체가 1을 뱉는 게 아니라 obj로 Shot 메소드를 호출했을때 Shot 메소드가 1을 뱉는거
            //여기서 Shot 불러올려면 어케함
            //그럼 obj가 1을 밷을려면 어케함 아
            //애초에 odj가 1을 뱉을 필요가 없네
            //그럼 Hand클래스의 ReturnValue를 호출하면 Shoutgun클래스의 Shot이 1을 뱉는거임 ?  ㅇㅇ
            // obj 엔 이미 Shotgun이란 클래스의 객체가 들어갔기 때문에 1을 뱉을 수 없고 굳이 하고자 한다면
            // 이제다알겠음 이해함 아까까지 반은 흘려들음 이해안돼서
        } // 조하   Counter 파일 쪽으로 와볼래?
    }
    
    public class ASDD
    {
        // void 라고 선언했기 떄문에 아무것도 반환하지 않음 그냥 ASD 란 기능만을 실행하기 위해서
        // 값을 반환하지 않는데 기능만을 구현하고 싶을때는 void를 씀
        //그럼 다른 클래스에서 클래스를 불러와서 특정 기능만을 쓸려고 void로 만들어두는거임 ?
        // 비슷하지만 특정 기능만을 쓴다 대신 이 ASD란 메소드에서 특정 기능만을 제공하는거지. 주체의 문제라 헷갈리기 쉬움
        // 그니까 A클래스에서 B클래스를 불러와놓고
        //B클래스에서 void로 선언한 기능을 쓸려고 따로 
        //아니 근데 애초에 기능을 만들려면 void없이 만들수가 있음 ?
        // 예를 들어 플레이어 A (클래스 A) 가 한 방향으로 달린다는 기능을 Run 이라는 이름으로 만들면 글케되지
        // 아니 이거 reference 떳다 사라졌다하는거때문에 줄 늘어났다 줄어들었다하는데 어케못하나
        // 데탑 환경에선 좀 살만해짐 근데 vscode는 어쩔 수 없음.. 얘가 첨부터 코드 편집용으로 나온 게 아니라 좀 기능이 딸림
        // public void RunTo(방향정보클래스 data) - data는 매개변수.... 인데 일단 넘어가자 간단히 말해서 플레이어 A 보고 일정방향으로 달리라는 건데 여기서 굳이 결과를 받을 필요는 없잖아
        // 지금 이게 객체지향을 첨 배우는 거라 어렵지 다른 언어에 비해  C#은 재밌는 게 진짜 많음
        public void ASDValue() // << 그럼 얘는 결국 뭘 반환함 void쓰면 아무것도 안주는데 그럼 왜씀
        {
            //new AbstractClass(); // 이렇게 추상 클래스 자체로는 클래스를 못 만들고
            new ChildClass(); // 이렇게 자식 클래스를 선언해서 써야됨


        ASD d = new ASD();
        d.ASDValue(); // 여기선 Run이라 선언하지 않고, Test라 선언했기 때문에 다르게 호출해줘야됨. 함 해보실?뭔소리지이게
        // 정답 
        // 아래 다른 클래스들에서는 Run이라고 메소드 이름을 선언했지만, ASD 에서는 Test라고 선언해서 
        // 정확히 메소드라는게 뭐임
        }

        // 이러면 아무것도 반환하지 않는 Runner란 메소드를 public으로 선언함
        public void Runner() // 이렇게 클래스안에 실행가능한 기능을 선언하는거
        {

        }

        // 이러면 1 을 리턴하는 GetInt란 메소드를 public으로 선언함. 이렇게 선언하면
        public int GetInt()
        {
            return 1;
        }
    }
    public class Dummy : MonoBehaviour // <- 얘가 클래스 
    {
        public int value; // <- 얘가 필드 (변수)
        // 값을 저장하는 용도
        // public - 어디서 접근할 수 있는지 지정함 public,

        public void Run() // <- 얘가 메소드
        {
            Test 객체 = new Test(); // 요로코롬 Test란 클래스(타입?)의 

            //Test.Run(); // 이렇게 Test 클래스의 Run 메소드를 바로 실행할 수는 없고
            // 여기처럼 클래스만 담을 수 있게 선언도 가능
            객체.Run(); // 이렇게 객체를 생성한 후에 내부의 메소드를 호출 가능

            var 변수1 = 객체.intValue;
            //var 변수1 = 객체.privateIntValue;// 이렇게 private 로 선언한 변수는 외부에서 접근 못함
            
            var DDObject = new DD();

            // 이렇게 name1 은 DDObject.name 을 넣기 전에 string 으로 결정했고
            string name1 = DDObject.name;
            // 이건 DDObject.name 의 자료형인 string 을 쓴다는거
            var name = DDObject.name;
            
            //그니까 class 그 자체로만은 실행못하고 객체에다가 클래스 넣어야지 쓸수있다는거임 ?
            Test 객체1; // 이렇게되면 어케됨 = new Test(); 의 의미를 모르겠음
            // 근데 Test는 클래스지 형식이 아니잖음
            //var int strong 이런거 다 클래스임 ?
                //int 객체3 = new Test(); // 이런것도 됨 그럼 ? 이거는 그럼 var이랑 Test 자료형 말고는 못쓰는거임 ? ㅇㅇ
                //만약 Test 결과가 숫자만 뱉어도 int 못씀 ?
                // 나중에 이렇게 할 수 있게 하는 게 있긴한데 지금 배우면 헷갈려서 스킵
            // int 랑 Test 의 자료형이 달라서 그럼
            // int란 깡통에 Test란 다른 내용물을 넣어서
            // var는 뒤에 자료형 할당을 미룬 거기 때문에 아무거나 넣어도 됨
            // 예외로 
            Test test = new DD();
            // 이렇게 부모 변수에 자식 클래스를 넣을 수 있음
            
            // 이러면 객체1 이란 변수를 생성하되, 변수안에 객체를 생성해서 넣지는 않는다는거 == 빈 깡통
            // 쏘리 클래스 랑 형식이 같은 말   정확힌 걍 다 클래스임 int 랑 string은 클래스가 맞는데 var는 뒤에 오는 객체의 클래스를 대신 사용한다는 키워드?
            // 이래서 
            var 객체2 = 1; // 이렇게 var 자체로만은 선언이 불가능함 뒤에 1을 넣었으니 이 객체2 는 1의 자료형인 int로 선언된거 ㅇㅇ
            //ㅇㅇ 클래스란 객체를 만드는거임 클래스 자체로는 코드에 불과하고 객체를 생성함으로써 해당 코드를 프로그램으로 실행한다고 볼 수 있음
            
            //var integer = DDObject.varName; // protected 라 private처럼 자식 클래스 외에는 밖에서 접근 못함
            // var 앞에 있는 이름들은 변수를 새로 선언하는거
            // 여기 integer는 Dummy 클래스의 Run이란 메소드 안에 integer 란 변수를 새로 선언한거
            // 편의상 var 를 썼지만
            int intVar; // 이렇게 형식을 직접 설정해서 선언도 가능 
            // 앞에 int 가 형식, 뒤에 intVar 가 변수명
            // 서로 담을 수 있는 데이터가 다 달라서
            /*
            int 는 숫자중 정수만 담을 수 있고
            string은 문자열만 담을 수 있음
            */
            // + 
            float var1 = 1;

            // ++
            float var0 = 1.1f; // 이렇게 소수점을 바로넣으면 오류가 나고 소수점을 넣을 때는 숫자 뒤에 꼭 f 를 붙여줘야됨
            //int var2 = var1; // 컴파일 언어에선 요로코롬 오류가 뜸
            if(int.TryParse(var1.ToString(), out var var2))
            {
                // 일케 체크..
                /*
                var1.ToString() <- 이게 바꿀 변수
                var2 가 바꿔지면 저 값에 바꾼값이 들어감
                근데 개발자들 중에서 아 어차피 여긴 int밖에 안 들어가겠다~ 싶고 귀찮으면
                */

                int var3 = (int)var1; // 이러기도 하는데 얘는 바꿀 수 있는지 체크하지 않고 강제로 변환하는 거라 변환도중 오류가 날 수 있음
                // var3 과 같이 float에서 int 형으로 바꾸는 경우 바꾸는 기능도 언어 개발자들이 만들어놔서 float -> int로 바꿀 땐 자동으로 int 범위로 바꿔줘서 오류 안남
                // 단, 이렇게 변환하는 기능을 만들어놓지 않은 자료형은 오류가 날 수 있음
                
                /* ㅇㅇ 근데 소수점 처리할려면 float 써야지
                var1.ToString() <- 이건 var1이란 변수를 문자열로 바꿔달라는거
                int.TryParse는 앞에 문자열로 바꾼 값을 int란 자료형으로 바꿀 수 있는지 체크하고 바꿀 수 있다면 var2에 넣어서 내보내주는거

                일단 간단하게 이렇게 말하긴 했는데
                */
            }
        }
    }
                    //Test 객체 = new Test(); 이건 뭐임 근데
                    
                    // Test 란 클래스의 객체를 생성한다는거
        //근데 걍 웬만해선 int안에서 숫자쓸꺼니까 신경안쓰고 in갈겨도 되겠네
    // https://hackersstudy.tistory.com/8
    // var 는 형식을 선언할 때 먼저 결정하지 않고 그 다음에 대입하는 변수의 자료형을 넣는다는거
            //근데 그냥 float만 쓰면 되는거아님 ? 왜 int씀
            //ㅇㅇ 그건 알겠는데 그냥 크기 큰거 쓰면
            //TryParse가 머하는거임 ToString 이건또 머고 
            // 근데 int 같은거 쓰다가 오버플로우 나는거아님 ? 쉽지않네
            // 서로 저장하는 데이터 크기가 달라서 그럼 -> 크기 큰 걸 많이 쓰는 만큼 렉을 먹음
            // 그래서 유효성 체크를 한다던가 int.TryParse 같은 걸로 자료형 변환이 되는지 체크를 하지
    //public 이 머임
    //아
    //근데 클래스 : (ㅇㅇ) << 이건 뭐임 / ㅇㅇ 에서 상속한다는 거 ㅇㅇ 이 하위 클래스라고 보면 됨 DD 가 Test의 자식이라는거
    public class DD : Test // 이렇게 하면 Test가 자식임 ? 그럼 DD가 자식임 ? ㅇ
    {
        protected int varName;// 이거 쓰면 그럼 integer은 어디서나온거임

        public string name;
    }

    public class Test
    {
        public int intValue; // 얘는 외부에서 제한없이 접근 가능
        private int privateIntValue; // 얘는 이 클래스 내부에서만 접근 가능
        protected int protectedIntValue; // 얘는 이 클래스와 이 클래스를 상속한 자식에서만 접근 가능
        int privateIntValue1; // 얘처럼 앞에 접근제한자(public, private, protected, internal) 등이 

        public Test() // 이건 생성자라는 건데 좀 이따 알려줌
        {

        }

        public void Run(){}
// 헷갈릴까봐 아래건 지움
    }
}



// class
/*
field, method 등을 묶어주는 용도.
객체로 생성하고 쓸 수 있는데 예시 보여줌
*/
// field
// method

// 클래스는 뭐하는애임
//엄 그니까 클래스에다가 뭐해줘 입력시켜놓고 클래스 불러오면 그거해주는거임 ? 일단 이렇게 봐도 됨
// 클래스에 기능을 적어놓고 클래스.기능() 또는 클래스.변수 같은 걸로 내부 데이터를 불러오거나 기능을 실행하는거
// 그니까 걍 f(x) 아님 ?ㅇㅇ
// 나 밥ㅘㅆ음
// 이따 먹고와서 핑 ㄱ ㄱㅇㅋ