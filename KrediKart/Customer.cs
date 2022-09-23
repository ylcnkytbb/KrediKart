namespace Kredi

{
    public class Customer    
    {
        public string kredikartno;
        public string _kredikartno
        {
            get
            {
                return "************" + kredikartno.Substring(12);
            }

            set
            {
                bool kontrol = false;
                if (value.Length == 16)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);//12345678
                        if (sayiMi)
                        {
                            //veri geçerlidir
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("Geçerli bir bilgi giriniz.");
                    }
                    else
                    {
                        kredikartno = value;
                    }
                }
                else
                {
                    Console.WriteLine("Hane sayısı yanlış.");
                }
            }
        }



    }
}
