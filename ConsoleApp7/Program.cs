namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Overload Tasks :
            //1.Area deyə Method(lar) yaradılır.
            //1.Çevrənin sahəsi - S = p * r² (p = 3)
            //2.Düzbucaqlının sahəsi - S = a * b
            //3.Düzbucaqlı paralelpipedin tam səthinin sahəsi -
            //S=2(a*b+a*c+b*c)
            //4.Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p = (a + b + c) / 2
            int a = 3;
            int b = 5;
            int c = 11;
            int r = 3;
            char simvol= '/';
            string name = "Inara";
            string surname = "Ismailova";
            string fatherN = "Saleh";
            

            float circle = Area(r);
            Console.WriteLine($"Çevrənin sahəsi: {circle}");

            float triangle = Area(a, b);
            Console.WriteLine($"Düzbucaqlının sahəsi: {triangle}");

            float parPiped = Area(a, b, c);
            Console.WriteLine($"Düzbucaqlı paralelpipedin tam səthinin sahəsi: {parPiped}");

            float triCircle = Area(a, b, c, r);
            Console.WriteLine($"Üçbucaqlının daxilinə çəkilmiş çevrənin sahesi: {triCircle}");


            //Sinifdə yazdıqlarımızı yeniden özünüz yazın
            //a. Method yaradirsiz 2 eded ve 1 operator('+','-','*','/') qebul edir. Qebul etdiyi operatora uygun a v' b ədədləri üzərində hesablama aparib alinan deyeri qaytarır.

            float calcul = Calculator(simvol, a, b);
            Console.WriteLine($"Calculatorun neticesi: {calcul}");

            //b.Method yaradırsız əgər methoda bir eded gonderilirse hemin ededin kvadratını, iki eded gonderilirse 1ci ədədi ikinci ədəd qədər qüvvətinə yüksəldirsiz.(Misal: MyMethod(2, 3)-- > 8)

            float myMethod = MyMethod(a);//ustu menfi daxil etdikde cavab float oldugu ucun float verdim
            //float myMethod = MyMethod(a,b);// b daxil edildiyi hal
            Console.WriteLine("Ustu hesablama tapsiriginin cavabi: " + myMethod);

            //c.Methodlar yaradirsiz. Methoda ad gonderende adi ekrana cixardir(Sabir), ad ve soyad gonderende soyadi adi ekrana cixardir(Guliyev Sabir), ad, soyad ve ata adı göndərildikdə adin baş hərfi nöqtə soyad ata adi ekrana cixardirsiz(S.Guliyev Mehti). Methodlarin adi eyni olmalıdır.
            Names(name);
            Names(name, surname);
            Names(name, surname, fatherN);



        }
        static void Names(string name)
        {
            Console.WriteLine(name);
        }
        static void Names(string name,string surname)
        {
            Console.WriteLine(name+" "+surname);
        }
        static void Names(string name, string surname,string fatherName)
        {
            Console.WriteLine(name[0]+"."+surname+" "+fatherName);
        }
        static float MyMethod(int a, int b=2)
        {
            float answer = 1;
            if (b == 0)
            {
                return 1;
            }
            else if (b > 0)
            {
                for (int i = 0; i < b; i++)
                {
                    answer *= a;
                }
                return answer;
            }
            else
            {
                for (int i = 0; i < (-b); i++)
                {
                    answer *= a;
                }
                return 1/answer;

            }  
        }

        static float Calculator(char a,int numN, int numM)
        {
            switch (a) 
            {
                case '+': 
                    return Sum(numN,numM);
                case '-':
                    return Difference(numN, numM);
                case'/':
                    return Division(numN,numM);
                case '*':
                    return Multiplication(numN, numM);
                default: 
                    return 0;
     
            }   
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static float Division(int a, float b)//qaliq olduqda duzgun cavab olmasi ucun boleni float olaraq yazdim
        {   
            return a / b;
        }
        static int Difference(int a, int b)
        {
            return a - b;
        }
        
        static int Multiplication(int a, int b)
        {
            return a * b;
        }
        static int Area(int i)
        {
            int s = 3 * (i * i);
            return s;
        }
        static int Area(int a, int b)
        {
            int s = a * b;
            return s;
        }
        static int Area(int a, int b, int c)
        {
            int s = 2 * ((a * b) + (a * c) + (b * c));
            return s;
        }
        static float Area(int a, int b, float c, int r)// a b ve ya c den her hansi birini cavabda qaliq varsa duzgun qaytarmasi ucun float kimi yaziram
        {
            float s = ((a + b + c) / 2) * r;
            return s;
        }
    }
}







