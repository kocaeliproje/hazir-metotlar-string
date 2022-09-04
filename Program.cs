namespace hazir_metotlar_string
{
    class program
    {
        static void Main(string[]args)
        {
            string degisken = "Dersimiz C# a Hoşgeldiniz";
            string degisken2 = "Dersimiz C#";
            //Lenght karakter sayısı
            Console.WriteLine(degisken.Length);

            //ToUpper ToLower küçük büyük harf
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat sonuna ekleme
             Console.WriteLine(string.Concat(degisken,"Merhaba"));

             //Compare  CompareTo   karşılaştırma
             Console.WriteLine(degisken.CompareTo(degisken2));  //-1-0-1
             Console.WriteLine(string.Compare(degisken,degisken2,true));
             Console.WriteLine(string.Compare(degisken,degisken2,false));

             //Contains Değişken1 in içinde değişken2 var mı
             Console.WriteLine(degisken.Contains(degisken2));  //true false
             Console.WriteLine(degisken.EndsWith("Hoşgeldiniz")); //bu kelimeyle bitiyor mu
             Console.WriteLine(degisken.StartsWith("Hoşgeldiniz")); //bu kelimeyle BAŞLIYOR mu
             
             //indexOf   girilen değerin index ini verir
                Console.WriteLine(degisken.IndexOf("er"));
                Console.WriteLine(degisken.IndexOf("xyz"));
                Console.WriteLine(degisken.LastIndexOf("i"));

            //insert   0. indeksten sonra girilen değeri ekler
                Console.WriteLine(degisken.Insert(0,"er"));
            
            //PadLeft  PadRight
                Console.WriteLine(degisken+degisken2.PadLeft(30));
                Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
                Console.WriteLine(degisken.PadRight(50,'-')+degisken2.PadLeft(30,'*'));

            //Remove  karakter silme
                Console.WriteLine(degisken.Remove(10));
                Console.WriteLine(degisken.Remove(5,3));
                Console.WriteLine(degisken.Remove(0,1));

            //Replace
                Console.WriteLine(degisken.Replace("C","D"));
                Console.WriteLine(degisken.Replace(" ","*"));
            
            //Split  Boşluklara göre parçala diziye ata
                Console.WriteLine(degisken.Split(" ")[1]);

            //Substring  4. indexten başlayarak sonuna kadar getir
                Console.WriteLine(degisken.Substring(4));
                Console.WriteLine(degisken.Substring(4,6));
        }
    }


}