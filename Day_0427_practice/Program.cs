using System;

class Product
{
    // 필드 (privateㅋ 캡슐화)
    private string name;
    private double price;
    private static int productCount;

    // 정적 생성자 static constructor
    static Product()
    {
        productCount = 0;
    }
    
    //인스턴스 생성자
    public Product(string name, double price)
    {
        SetName(name);
        SetPrice(price);
        productCount++;
    }

    // Getter Setter 
    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        if (!string.IsNullOrEmpty(name))
            this.name = name;
        else
            this.name = "Unkown";
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice(double price)
    {
        if (price >= 0)
            this.price = price;
        else
            Console.WriteLine("가격은 음수일 수 없습니다!");
    }

    //클래스 메서드
    public static void ShowProductCount()
    {

        Console.WriteLine($"총 등록된 제품 수: {productCount}개");
    }

    //인스턴스 메서드
    public void ShowInfo()
    {
        Console.WriteLine($"상품명: {name}, 가격: {price}원");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("사과", 1200);
        Product p2 = new Product("바나나", -500);
        Product p3 = new Product("포도", 3500);

        p1.ShowInfo();
        p2.ShowInfo();
        p3.ShowInfo();

        Product.ShowProductCount();
;
    }
}