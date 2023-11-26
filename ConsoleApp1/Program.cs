//Console.WriteLine("Ededi daxil edin");
//string input1 = Console.ReadLine();


////-----------------------------------------//

//int input1Num;
//int.TryParse(input1, out input1Num);

//while (!(int.TryParse(input1, out input1Num) && input1.Length != 4))
//{
//    Console.WriteLine("Sehvdi yeniden daxil edin !");
//    Console.WriteLine("1ci daxil et");
//    input1 = Console.ReadLine();
//}

//int result = input1Num % 10;
//Console.WriteLine(result);
//input1Num = (input1Num - result) / 10;

//result += input1Num % 10;
//input1Num = (input1Num - (input1Num % 10)) / 10;

//result += input1Num % 10;
//input1Num = (input1Num - (input1Num % 10)) / 10;

//result += input1Num % 10;
//input1Num = (input1Num - (input1Num % 10)) / 10;

//Console.WriteLine(result);

//int num = 0;
//int num1 = 1;



Student student = new Student();
student.Name = "Aqsin";
student.Surname = "Abbaszade";
student.GroupNo = 1;
student.Age = 27;

Student student2 = new Student();
student2.Name = "Konul";
student2.Surname = "Meherremzade";
student2.GroupNo = 1;
student2.Age = 20;

Student student3 = new Student();
student3.Name = "Eli";
student3.Surname = "Nezerov";
student3.GroupNo = 1;
student3.Age = 25;

Student student4 = new Student();
student4.Name = "Eli";
student4.Surname = "Hesenov";
student4.GroupNo = 1;
student4.Age = 21;

Student student5 = new Student();
student5.Name = "Sahin";
student5.Surname = "Aliyev";
student5.GroupNo = 1;
student5.Age = 28;

Student[] arrStudents = { student, student2, student3, student4, student5 };

for (int i = 0; i < arrStudents.Length; i++)
{
    Console.WriteLine($"Adi : {arrStudents[i].Name} \n" +
        $"Soyadi : {arrStudents[i].Surname} \n" +
        $" Yashi : {arrStudents[i].Age} \n " +
        $"Grup Nomresi : {arrStudents[i].GroupNo} \n");
}





class Student
{
    public string Name;
    public string Surname;
    public byte Age;
    public int GroupNo;

}









//int.TryParse(input1, out input1Num);  int.TryParse(input2, out input2Num);

//if (int.TryParse(input1, out input1Num) && (int.TryParse(input2, out input2Num)))
//{
//    Console.WriteLine($"Cevirdi {input1Num + input2Num}");
//}
//else
//{
//    Console.WriteLine("Fotmat sehvi");
//}

//Console.WriteLine(input2Num + input1Num);


