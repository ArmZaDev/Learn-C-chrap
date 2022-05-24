using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begining
{
    
    struct Empolyee   //พนักงาน
    {
        public string name; //ชื่อพนักงาน
        public int age;     //อายุ
        public double salary; // เงินเดือน
        public string department;  //แผนกม ตำแหน่ง

        public void setEmpolyee(string nameValue, int ageValue, double salaryValue, string dapartmentValue)
        {
            name = nameValue;
            age = ageValue;
            salary = salaryValue;
            department = dapartmentValue;
        }

        public void showEmpolyee()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);   
            Console.WriteLine("Salary: " + salary); 
            Console.WriteLine("Department: " + department); 
            Console.WriteLine("----------------");
        }
    }

    internal class Program        
    {
        enum Rating
        {
            Verybad,
            Bad,
            Good,
            Greate,
            Excellent
        }

        static void Main(string[] args)
        {
            int number = 120000;
            Console.WriteLine("Number = {0}", number);
            Console.WriteLine("Number = {0:E}", number); //Exponential
            Console.WriteLine("Number = {0:F4}", number); //Floating Point
            Console.WriteLine("Number = {0:G}", number); //เเสดงตัวเลขรูปเเบสั้นที่สุด
            Console.WriteLine("Number = {0:N}", number); //comma
            Console.WriteLine("Number = {0:P5}", number); //%
            Console.WriteLine("Number = {0:X}", number); //Hex
            Console.ReadKey();
            /*Console.WriteLine("Score Rating = " + Rating.Verybad +" "+ (int)Rating.Verybad);
            Console.ReadKey();*/

            /* Empolyee[] emp = new Empolyee[3];  //stuct Array
             emp[0].setEmpolyee("mumu", 24, 20000.00, "IT Support");
             emp[0].showEmpolyee(); */

            /*Empolyee em1 = new Empolyee();
            em1.setEmpolyee("KuKu", 20, 3200000, "GiGi");
            em1.showEmpolyee();
            em1.name = "isus";
            em1.age = 20;
            em1.salary = 20000.00;
            em1.department = "Programer";

            Console.WriteLine("Name: " + em1.name);
            Console.WriteLine("Age: " + em1.age);
            Console.WriteLine("Salary: " + em1.salary);
            Console.WriteLine("Department: " + em1.department);
            Console.ReadKey();*/


            /*
            //การแสดงผล(Wirte/WriteLine)
            Console.Write("KesukeTakoyaki");
            Console.WriteLine("SobaNoodle");
            Console.ReadKey();

            //กำหนดลำดับการแสดงผลด้วยปีกกา
            Console.WriteLine("FirstName: {0} LastName: {1}", "Nobpharat", "Pongdong");               
            Console.WriteLine("{0} + {2} = {1}, "50", "80", "30");
            Console.ReadKey(); 
                           
            //Variable 
            int myNum = 26;
            double myDoubleNum = 10.99D;
            char myChar = 'A';
            bool myBool = true;
            string myString = "Hello Wold";
            const int MyNum = 10;

            Console.WriteLine("int = " + myNum);
            Console.WriteLine("double = " + myDoubleNum);
            Console.WriteLine("char = " + myChar);
            Console.WriteLine("bool = " + myBool);
            Console.WriteLine("string = " + myString);
            Console.WriteLine("const = " + MyNum);
            Console.ReadKey();
            
            //format string
            int number = 120000;
            Console.WriteLine("Number = {0}", number);
            Console.WriteLine("Number = {0:E}", number); //Exponential
            Console.WriteLine("Number = {0:F4}", number); //Floating Point
            Console.WriteLine("Number = {0:G}", number); //เเสดงตัวเลขรูปเเบสั้นที่สุด
            Console.WriteLine("Number = {0:N}", number); //comma
            Console.WriteLine("Number = {0:P}", number); //%
            Console.WriteLine("Number = {0:X}", number); //Hex
            Console.ReadKey();
           
            //รับค่าผ่านทางคีย์บอร์ด
            Console.Write("UserName: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");            
            string password = Console.ReadLine();
            Console.WriteLine("UserName is: " + username + "\n" + "Password is: " + password);
            Console.Write("Aa-Zz to ASCII Code: ");
            int Ascii = Console.Read();
            Console.WriteLine("Ascii = " + Ascii);
       
            // (+ - * / %) OPerator
            int a = 15;
            int b = 10;
            int c = a + b;
            Console.WriteLine("Result = {0}",c);
            Console.WriteLine("Result = {0}", a - b);
            Console.WriteLine("Result = {0}", a * b);
            Console.WriteLine("Result = {0}", a / b);
            Console.WriteLine("Result = {0}", a % b);
            Console.WriteLine("Result = {0} {1} {2} {3} {4}", c, a - b, a * b, a / b, a % b);
            Console.ReadKey();

            //Funtion math
            double number = -15.59;            
            Console.WriteLine("Abs = {0}",Math.Abs(number));//ค่าสมบูรณ์
            Console.WriteLine("Ceiling = {0}", Math.Ceiling(number));//ปัดเศษขึ้นทุกกรณี
            Console.WriteLine("Floor = {0}", Math.Floor(number));//ปัดเศษลง
            Console.WriteLine("Round = {0}", Math.Round(number));//>.5ปัดลง <.5ปัดขึ้น
            Console.WriteLine("Power = {0}", Math.Pow(number,2));//ยกกำลัง หลัง Comma
            Console.WriteLine("Square Root = {0}", Math.Sqrt(25));//หารากมะม่วง
            Console.WriteLine("PI = {0:F4}", Math.PI);//ค่า PI
            Console.ReadKey();

            //ตัว Operator เปรียบเทียบ ชนิด boolean
            int num1 = 60, num2 = 100;

            Console.WriteLine(num1 == num2); //60 เท่ากับ 100?
            Console.WriteLine(num1 != num2); //60 ไม่เท่ากับ 100?
            Console.WriteLine(num1 > num2); //60 มากกว่า 100?
            Console.WriteLine(num1 < num2); //60 น้อยกว่า 100?
            Console.WriteLine(num1 >= num2); //60 มากกว่าเท่ากับ 100?
            Console.WriteLine(num1 <= num2); //60 น้อยกว่าเท่ากับ 100?
            Console.ReadKey();

            //Operator เพิ่มค่า 
            int a = 20, b = 10;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("Prefix = {0}", ++a); //Prefix เพิ่มค่าให้ n ก่อน 1 ค่า แล้วนำไปใช้
            Console.WriteLine("Last a = {0}", a + "\n");

            a = 20;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("Posfix = {0}", a++); //Posfix นำค่าปัจจุบันใน n ไปใช้ก่อน แล้วค่อยเพิ่มค่า
            Console.WriteLine("Last a = {0}", a);


            //Operator ลดค่า
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("Prefix = {0}", --b); //Prefix ลดค่าให้ n ก่อน 1 ค่า แล้วนำไปใช้
            Console.WriteLine("Last b = {0}", b + "\n");

            b = 10;
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("Posfix = {0}", b--); //Posfix นำค่าปัจจุบันใน n ไปใช้ก่อน แล้วค่อยลดค่า
            Console.WriteLine("Last b = {0}", b);
            Console.ReadKey();

            //Compound Assignment การลดรูปสมการ
            int x = 10, y = 15;
            x += y;             //x = x + y;
            Console.WriteLine(x);

            x = 10;
            y = 15; 
            Console.WriteLine(x -= y); //x = x - y;

            x = 10;
            y = 15;
            Console.WriteLine(x *= y); //x = x * y;

            x = 10;
            y = 15;
            Console.WriteLine(x /= y); //x = x / y;
            x = 10;
            y = 15;
            Console.WriteLine(x %= y); //x = x % y;
            Console.ReadKey();

            //ลำดับความสำคัญของตัว Operator
            1. ()
            2. ++, --           ซ้ายไปขวา
            3. * , / , %        ซ้ายไปขวา
            4. + , -            ซ้ายไปขวา
            5. < , <= , => , >  ซ้ายไปขวา
            6. == , !=          ซ้ายไปขวา
            7. &&(AND)          ซ้ายไปขวา
            8. ||(OR)           "    "
            9. = , += , -= , *= , /= , %= Compound Assignment ขวาไปซ้าย
             

            //การแปลงชนิดข้อมูลType Casting
            //Convert
            string MyString = "120";
            int MyInt = 100;
            

            byte myByte = Convert.ToByte(MyString); //SBtye - 
            short myShort = Convert.ToInt16(MyString);
            int myInt = Convert.ToInt32(MyString);
            long myLong = Convert.ToInt64(MyString);
            float myFloat = Convert.ToSingle(MyString); //ทศนิยม
            double myDouble = Convert.ToDouble(MyString); //ทศนิยม
            string result = Convert.ToString(myDouble);

            Console.WriteLine("Byte = {0}", myByte + MyInt);
            Console.WriteLine("Short = {0}", myShort + MyInt);
            Console.WriteLine("Int = {0}", myInt + MyInt);
            Console.WriteLine("long = {0}", myLong + MyInt);
            Console.WriteLine("Float = {0}", myFloat + MyInt);
            Console.WriteLine("Double = {0}", myDouble + MyInt);
            Console.WriteLine("Double to String = {0}", result);
            Console.ReadKey();


            //Parse
            string myString = "200";

            byte myByte = byte.Parse(myString);
            short myShort = short.Parse(myString);
            int myInt = int.Parse(myString);
            long myLong = long.Parse(myString);
            float myFloat = float.Parse(myString);
            double myDouble = double.Parse(myString);

            Console.WriteLine("Byte = {0}", myByte);
            Console.WriteLine("Short = {0}", myShort);
            Console.WriteLine("Int = {0}", myInt);
            Console.WriteLine("Long = {0}", myLong);
            Console.WriteLine("Float = {0}", myFloat);
            Console.WriteLine("Double = {0}", myDouble);
            Console.ReadLine();

            //Try Parse
            string myString = "200.00";
            int myInt;
            long myLong;
            bool success = int.TryParse(myString, out myInt);
            bool success2 = long.TryParse(myString,out myLong);
            float myFloat = float.Parse(myString);
            double myDouble = double.Parse(myString);

            Console.WriteLine("Long = {0}", myLong);
            Console.WriteLine("Float = {0}", myFloat);
            Console.WriteLine("Double = {0}", myDouble);
            Console.ReadLine(); 

            //การแปลงชนิดข้อมูลแบบ Narrowing Casting
            double x = 105.21;
            int y = (int)x;
            Console.WriteLine(y);
            Console.ReadLine(); 

            //การคำนวณดัชนีมวลกาย(BMI)
            double weight = 0, height = 0;
            //input
            Console.Write("Input Weight (kg): ");
            double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Input Height (cm): ");
            double.TryParse(Console.ReadLine(), out height);

            //Procees
            height /= 100; //แปลงเป็น (m)
            double bmi = weight / Math.Pow(height, 2);

            //output
            Console.WriteLine("BMI = {0:F2}", bmi);
            Console.ReadKey(); 

            //if, if else, if else if else
            //grade calculator
            int score = 0;
            string grade = "";
            
            Console.Write("Input your Grade: ");

            int.TryParse(Console.ReadLine(), out score);
            if(score >= 80 && score <= 100)
            {
                grade = "A";
            }
            else if(score >= 75 && score <= 79) // B+ = 75~79
            {
                grade = "B+";
            }
            else if(score >= 70 && score <= 74) // B = 70~74
            {
                grade = "B";
            }
            else if(score >= 65 && score <= 69) // C+ = 65~69
            {
                grade = "C+";
            }
            else if(score >= 60 && score <= 64) // C = 60~64  
            {
                grade = "C";
            }
            else if(score >= 55 && score <= 59) // D+ = 55~59
            {
                grade = "D+";
            }
            else if(score >= 50 && score <= 54) // D = 50~54
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine("score = {0}" + "\n"+ "grade = {1}", score , grade);
            Console.ReadKey();  


            //if else Ternary Operator
            int score = 0;
            string result = "";

            Console.Write("Input Score: ");
            int.TryParse(Console.ReadLine(), out score);

            result = (score >= 50) ? "Pass" : "NotPass";
            Console.WriteLine("Status = {0}",result);
            Console.ReadLine(); 

            //if ซ้อน if
            int money = 30000;

            if(money >= 15000)
            {
                if (money >= 15000 && money <= 19999)
                {
                    Console.WriteLine("Sale = 10%");
                }else if (money >= 20000 && money <= 29999)
                {
                    Console.WriteLine("Sale = 20%");
                }
                else if (money >= 30000)
                {
                    Console.WriteLine("Sale = 30%");
                }

            }
            Console.ReadLine(); 


            //Switch Case
            int day = 0;

            Console.Write("Input day number (1-7): ");
            int.TryParse(Console.ReadLine(), out day);

            switch (day)
            {
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2: Console.WriteLine("Monday");
                    break;
                case 3: Console.WriteLine("Tuesday");
                    break;
                case 4: Console.WriteLine("Wednesday");
                    break;
                case 5: Console.WriteLine("Thursday");
                    break;
                case 6: Console.WriteLine("Friday");
                    break;
                case 7: Console.WriteLine("Saturday");
                    break;
                default: Console.WriteLine("Plese enter only number 1-7");
                    break;
            }
            Console.ReadKey(); 


            //While loop
            int count = 1;
            while(count <= 10)
            {
                Console.WriteLine("{0} X {1} = {2}",2 , count, 2*count);
                count++;
                
            }
            Console.ReadKey();  


            //For loop
            int number = 0;
            Console.Write("input Product: ");
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 1;i <= number;i++)
            {
                Console.WriteLine("Product {0}", i);
            }
            Console.ReadKey(); 


            //Do While
            int count = 10;

            do
            {
                Console.WriteLine("Count {0}", count);
                count++;
            } while (count <= 0);
            Console.ReadKey(); 


            //Break, Continue
            int number = 0;
            Console.Write("Input NUmber: ");
            int.TryParse(Console.ReadLine(), out number);   
            for (int count = 1;count <= 12; count++)
            {
                if(count == 3)
                {
                    continue;     //ข้าม1ลูป
                }
                
                else if(count == 7)
                {
                    break;       //หยุดลูปตามเงื่อนไข
                }
                Console.WriteLine("{0} X {1} = {2}", number, count, 2*count);
            }
            Console.ReadKey();  


            //โจทย์หาผลรวมและค่าเฉลี่ย
            int sum = 0, avg = 0;
            for (int count = 1; count <= 5;count++)
            {
                int num = 0;
                Console.Write("Input Number: ");
                int.TryParse(Console.ReadLine(), out num);    
                sum += num;
            }
            avg = sum / 5;
            Console.WriteLine("Sum = {0}"+ "\n" +"Avg = {1}", sum, avg);
            Console.ReadKey(); 


            //หาค่าต่ำสุด สูงสุด
            int minnumber = int.MaxValue, maxnumber = 0;
            while (true)
            {
                int number;
                Console.Write("Input Number: ");
                int.TryParse(Console.ReadLine(), out number);
                if (number < 0) break;

                if (number > maxnumber)
                {
                    maxnumber = number;
                }

                if (number < minnumber)
                {
                    minnumber = number;
                }
            }
            Console.WriteLine("maxNumber {0}" + "\n" + "minNUmber {1}", maxnumber, minnumber);
            Console.ReadKey(); 


            //การจ่ายธนบัตรของ ตู้ ATM
            int amout = 0;
            do
            {
                Console.Write("Input Amout: ");
                int.TryParse(Console.ReadLine(), out amout);

            } while (amout % 100 != 0); //เช็คจำนวนเงินว่าเป็นหลักหน่วยหรือหลักสิบ
            Console.WriteLine("1000 Baht {0}", amout / 1000); //แบ็งค์1000
            amout %= 1000;
            Console.WriteLine("500 Baht {0}", amout / 500); //เเบ็งค์500
            amout %= 500;
            Console.WriteLine("100 Baht {0}", amout / 100);
            Console.ReadKey(); 


            //Array
            int[] vs = new int[6];
            int[] num = {10, 20, 30, 40, 100};
            double[] num2 = { 10.55, 20, 30};
            string[] names = { "gun", "dew", "sus" ,"pet"};
            num[2] = 100;

            
            Console.WriteLine("number index = {0}", num2[0]);
            Console.WriteLine("number index = {0}", num[1]);
            Console.WriteLine("number index = {0}", num[2]);
            Console.WriteLine("number index = {0}", names[3]);
            Console.WriteLine("Count Array = {0}", names.Length);
            Console.ReadKey();


            //เข้าถึงข้อมูลสมาชิกใน Array ด้วย for loop
            int[] numbers = { 10, 20, 30, 40, 50 };
            string[] students = { "pet", "ploy", "dew", "mei", "mai", "sus", "yut" };

            for (int index = 0; index<students.Length;  index++)
            {
                Console.WriteLine("Students Index{0} = {1}",index,students[index]); 
            }
            Console.ReadKey(); 


            //การเข้าถึงสมาชิกใน Array ค้วย Foreach
            string[] students = { "pet", "ploy", "dew", "mei", "mai", "sus", "yut" };
            foreach (string name in students)
            {
                Console.WriteLine("Students {0}", name);
            }
            Console.ReadKey(); 


            //Array 2 มิติ
            // [แถว,คอลัมน์]
            int[,] numbers = {
                {1, 2 , 4 , 1 },
                {2, 3 , 5 , 1 },
                {5, 1 , 7 , 1 }
            };

            string[,] students = {
                {"kong","kaw", "kig", "kam" },
                {"nik", "nok", "nook","nun" },
                {"sup","sop","same","som" }
            }; //3แถว 4คอลัมน์
            

            //เข้าถึงข้อมูลสมาชิกใน Array 2 มิติ ด้วย length, GetLength
            string[,] students = {
                {"kong","kaw", "kig", "kam" },
                {"nik", "nok", "nook","nun" },
                {"sup","sop","same","som" }
            }; //3แถว 4คอลัมน์
            Console.WriteLine("Students Array Row = {0}",students.GetLength(0)); //หาแแถว
            Console.WriteLine("Students Array Colum = {0}", students.GetLength(1)); //หาคอลัมน์
            Console.WriteLine("Students Array Size = {0}",students.Length);
            Console.ReadKey(); 


            //For Loop ใน Array 2 มิติ
            string[,] students = {
                {"kong","kaw", "kig", "kam" },
                {"nik", "nok", "nook","nun" },
                {"sup","sop","same","som" }
            };

            for (int row = 0;row<students.GetLength(0);row++)
            {
                for(int col = 0; col < students.GetLength(1); col++)
                {
                    Console.WriteLine("Students [{0}][{1}] = {2} ",row, col,students[row, col]);
                }
                Console.WriteLine("---------------------");
            }
            Console.ReadKey(); 


            //ForEach ใน Array 2 มิติ
            string[,] students = {
                {"kong","kaw", "kig", "kam" },
                {"nik", "nok", "nook","nun" },
                {"sup","sop","same","som" }
            };
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey(); 


            //Jagged Array
            string[][] JaggedArray = {            
                new string[] {"keaw","khig","nook" },
                new string[] {"nik","nun" },
                new string[] {"yut","yat" },
                new string[] {"pet"}
            }; 


            //เข้าถึงสมาชิกใน Jagged Array โดย For loop
            string[][] JaggedArray = {
                new string[] {"keaw","khig","nook" },
                new string[] {"nik","nun" },
                new string[] {"yut","yat" },
                new string[] {"pet"}
            };

            for(int row = 0;row < JaggedArray.Length; row++)
            {
                for(int col = 0;col < JaggedArray[row].Length; col++)
                {
                    Console.WriteLine("Students JaggedArray [{0}][{1}] = {2}",row,col,JaggedArray[row][col]);
                }
                Console.WriteLine("-----------");
            }
            Console.ReadKey(); */


            //การสร้างเมธอด (Method) 
            //aiSus();

            /*string name = "Tu";
            sayHi(name);
            Console.ReadKey();*/

            /*showData("Arm", "Za", "lampang");
            showData("naruto", "uzumaki", "konoha");
            Console.ReadKey();*/


            /*int number = 0;
            Console.Write("Enter NUmber: ");
            int.TryParse(Console.ReadLine(), out number);
     
            if (checkNumber(number))
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.ReadKey();*/

            /*int[] computerScore = { 50, 70, 60, 80 };
            int[] physicScore = { 40, 90, 60, 50 };
            int[] mathScore = { 30, 20, 80, 40 };

            Console.Write("Score Computer Exam : ");
            disPlayScore(computerScore);
            Console.WriteLine("Max Computer = " + findMaxValue(computerScore));

            Console.Write("Score Physic Exam : ");
            disPlayScore(physicScore);
            Console.WriteLine("Max Physic = " + findMaxValue(physicScore));

            Console.Write("Score Math Exam : ");
            disPlayScore(mathScore);
            Console.WriteLine("Max Math = " + findMaxValue(mathScore));
            Console.ReadKey();*/

            /*int[] scoreComputer = { 70, 50, 80,90, 100 };
            int[] cloneScore = copyArray(scoreComputer);
            for(int i = 0; i < cloneScore.Length; i++)
            {
                Console.WriteLine(cloneScore[i]);
            }
            Console.ReadKey();*/

            /*
            //method Default Parameter
            showData("Pet", 20000.00);
            showData("yut", 1000000.00, "Narog");
            Console.ReadKey(); */


            //Try catch
            try
            {
                
                Console.Write("input number1: ");
                int result = int.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("Involid format ,only number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("can't zero");
            }
            finally
            {

            }

        }
        /*static void aiSus()
        {
            Console.WriteLine("aisus");
            Console.ReadKey();
        }
    
        static void sayHi(string message)
        {
            Console.WriteLine("Hello " + message);
        }

        static void showData(string fname, string lname, string address)
        {
            Console.WriteLine("firstname = {0}",fname);
            Console.WriteLine("lastname = {0}", lname);
            Console.WriteLine("address = {0}", address);
        }

        //method ที่ส่งค่าไปทำงานด้านนอก
        static bool checkNumber(int num)
        {
            
            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        static void disPlayScore(int[] arr)
        {
            Console.Write("{");
            for(int i = 0; i< arr.Length; i++)
            {
                Console.Write(arr[i]);  
                if(i < arr.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("}");
            
        }

        static int findMaxValue(int[] arr)
        {
            int maxValue = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }

        static int findminValue(int[] arr)
        {
            int minValue = arr[0];
            for( int i = 1; i < arr.Length; i++)
            {
                if( arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }
            return minValue;
        }*/

        static int[] copyArray(int[] originalArr)
        {
            //สร้าง array เปล่าๆที่ไม่มีข้อมูล โดยระบุขนาดตาม Array ที่ต้องการ Copy
            int[] newArray = new int[originalArr.Length];
            for(int i = 0; i < originalArr.Length; i++)
            {
                newArray[i] = originalArr[i];
            }
            return newArray;
        }

        static void showData(string name, double salary, string addrss = "Bangkok")
        {
            Console.WriteLine("Name: {0}, Salary: {1}, Address: {2}", name, salary, addrss);    

        }
    }
}