/** Задачи на ref и out 
    1. Написать метод который принимает два числа и меняет значения местами используя ref.

    2. Написать метод который принимает параметр и проверяет четное число или нет, если число 
    четное то вывести результат деления на 2 в параметр с out Возвращающий тип будет bool.

    3. Написать метод который из числа делает массив. Возвращает bool массив кладет в параметр 
    с модификатором out.  В случае если не удалость преобразовать возвращается false. Если удалось то true.

    4. Сделать метод (аналог TryParse) который принимает на вход строку и параметр с модификатором out
     и пытается преобразовать в число, если получилось то возвращается true, если нет то false
*/

namespace TaskRefOut;

public class TaskRefOut
{
    public void Main()
    {

        int number;

        Console.WriteLine("1. Написать метод который принимает два числа и меняет значения местами используя ref.\n\n" + 
        "2. Написать метод который принимает параметр и проверяет четное число или нет, если число четное то вывести\n" +
        "результат деления на 2 в параметр с out Возвращающий тип будет bool.\n\n" + 
        "3. Написать метод который из числа делает массив. Возвращает bool массив кладет в параметр с модификатором out.\n" + 
        "В случае если не удалость преобразовать возвращается false. Если удалось то true.\n\n" +
        "4. Сделать метод (аналог TryParse) который принимает на вход строку и параметр с модификатором out и пытается преобразовать\n" +
        "в число, если получилось то возвращается true, если нет то false.\n\n");

        while (true) {
            number = ReadNumber("Выберете номер задачи");
            switch (number)
            {
                case 1: 
                    TaskOne();
                    break;
                case 2: 
                    TaskTwo();
                    break;
                case 3: 
                    TaskThree();
                    break;
                case 4: 
                    TaskFour();
                    break;
            }
            if (number == 5) {
                break;
            }
        }

    }


    //Задача №1
    public void TaskOne () {
        int oneParametr = 1;
        int twoParametr = 2;
        Console.WriteLine("Значения до передачи в метод Changer: oneParametr=" + oneParametr + "; twoParametr=" + twoParametr);
        Changer(ref oneParametr, ref twoParametr);
        Console.WriteLine("Значения после передачи в метод Changer: oneParametr=" + oneParametr + "; twoParametr=" + twoParametr);
    }
    
    
    //Задача №2
    public void TaskTwo () {
        string result = "не делится";
        Console.WriteLine("2 четное число? " + ParityCheck(2, out result) + " Результат деления на 2 равен " + result);
        Console.WriteLine("5 четное число? " + ParityCheck(5, out result) + " Результат деления на 2 равен " + result);
    }


    
    //Задача №3
    public void TaskThree () {
        int[] res;
        Console.WriteLine(IntToArray(125634, out res) + " Результат: " + res[0]);
        Console.WriteLine(IntToArray(0, out res) + " Результат: " + res[0]);
        Console.WriteLine(IntToArray(-1, out res) + " Результат: " + res[0]);
        Console.WriteLine(IntToArray(-5826, out res) + " Результат: " + res[0]);
    }

    // Задача №4
    public void TaskFour () {
        int num;
        Console.WriteLine(MyTryParse("1234567890", out num) + " Результат: " + num);
        Console.WriteLine(MyTryParse("0", out num) + " Результат: " + num);
        Console.WriteLine(MyTryParse("-1", out num) + " Результат: " + num);
        Console.WriteLine(MyTryParse("-5826", out num) + " Результат: " + num);
        Console.WriteLine(MyTryParse("ouwrhvwre45375367", out num) + " Результат: " + num); 
    }
    public bool MyTryParse (string s, out int rslt) {
        try {
            rslt = int.Parse(s);
            return true;
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            rslt = 0;
            return false;
        }
    }
    public bool IntToArray (int i, out int[] res) {
        try {
            res = Math.Abs(i).ToString().Select(t=>int.Parse(t.ToString())).ToArray();
            return true;
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            res = new int[0];
            return false;
        }
    }


    public bool ParityCheck (int i, out string result) {
        if (i % 2 == 0){
            result = (i / 2).ToString();
            return true; 
        } else {
            result = "\"не делится\"";
            return false;
        }
    }

    public void Changer (ref int i, ref int j) {
        int temp = i;
        i = j;
        j = temp;
    }

    public int ReadNumber(string text) {
    Console.WriteLine(text);
    int number;
    string readNumber = Console.ReadLine() ?? "Nullable";
    if (int.TryParse(readNumber, out number)) {}
    else {
        Console.WriteLine("Ввод некорректный. Вводите только цифры");
        number = ReadNumber(text);
    }
    return number;
}
}






