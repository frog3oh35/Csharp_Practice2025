using System;

class Dog
{
    public string name;

    public void Bark()
    {
        Console.WriteLine($"{name}가 짖습니다. 멍멍!");
    }
}
// public void Bark() 인스턴스 메서드
// new Dog()로 객체 생성 후 사용 가능
// d.name = "초코"는 필드에 직접 접근한 예

class Calculator
{
    public static int Squre(int number)
    {
        return number * number;
    }
}
// static 붙으면 객체 없이 클래스명.메서드명()으로 직접 호출 가능
// 클래스 메서드는 인스턴스 필드나 메서드 접근 불가

class Greeter
{
    public void Greet()
    {
        Console.WriteLine("안녕하세요!");
    }
    public void Greet(string name)
    {
        Console.WriteLine($"안녕하세요, {name}님!");
    }
}
// 메서드 이름은 같고, 매개변수가 다르면 오버로딩
// 리턴값만 다르면 오버로딩 X 안 됨

class Counter
{
    private int count = 0;

    public void Increment()
    {
        count++;
    }

    public void ShowCount()
    {
        Console.WriteLine($"현재 카운트:  {count}");
    }
}
// count는 private이라 외부에서 직접 접근 X
// 대신 Increment()와 ShowCount()를 통해 간접 접근

class Student
{
    public string name;
    public int grade;

    public Student(string name, int grade)
    {
        this.name = name;
        this.grade = grade;
    }
     
    public void Introduce()
    { 
        Console.WriteLine($"{grade}학년 {name}입니다.");
    }
}
// 생성자: 클래스 이름과 같은 이름, void 안 붙임
// this.name = name; 에서 this는 멤버 변수와 매개변수 구분용

class Program
{
    static void Main(string[] args)
    {
        /*      1.instance Method
        Dog d = new Dog();
        d.name = "초코";
        d.Bark();
        */


        /*      2. class Method (static method)
        Console.WriteLine(Calculator.Squre(7));
        */

        /*      3. Overloading
        Greeter g = new Greeter();
        g.Greet();
        g.Greet("지민");
        */

        /*      4. Encapsulation
        Counter c = new Counter();
        c.Increment();
        c.Increment();
        c.ShowCount();
        */

        /*      5. Constructor
        Student s = new Student("태현", 3);
        s.Introduce();
        */

    }
}