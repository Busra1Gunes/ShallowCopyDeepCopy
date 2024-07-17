using ShallowCopyDeepCopy;

internal class Program
{
    private static void Main(string[] args)
    {
        // Shallow Copy
        // Var olan bir nesnenin, değerin, referansının kopyalanmasıdır,
        //Shallow copy neticesinde eldeki değer çoğaltılamaz, Sadece birden fazla referansla işaretlenmiş olur
        //Deep Copy
        //Var olan bir nesne ,deep copy ile kopyalanıyorsa eğer ilgili nesne miktarı çoğalır 
        //Aynı özelliklere ve değerlere sahip olan belekte farklı bir nesne daha oluşur
        // Referans turlu değişkenlerin değerlerin default davranışı shallow copydir
        //Değer türlü değişkenlerde default davranış deep copydir


        Class1 m1 = new Class1();
        m1.Ad = "Büşra";
        Class1 m2 = m1;
        m2.Ad = "Kübra";
        Class1 m3 = m1.Clone();

        Console.WriteLine(m1.Ad);
        Console.WriteLine(m2.Ad);
        Console.WriteLine(m3.Ad);
    }
}