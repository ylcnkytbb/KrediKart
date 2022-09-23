namespace Kredi
{
    internal class Program //normal değişkenlerde field kullanırken private değişkenlerde prop kullanıyoruz

    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer._kredikartno = "1234567891234567";
            Console.WriteLine("Girdiğiniz Değerler" + customer._kredikartno);
        }
    }
}