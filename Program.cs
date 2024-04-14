using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
поле :
---
---
---
*/


namespace XO
{

    class Program
    {
        static void Main(string[] args)
        {
            //создание объектов классов 
            Bourd someObject = new Bourd();
            Move moveObject = new Move();
            Logic logicObject = new Logic();

            //массив с данными игрового поля
            string[,] array = new string[,] {   {"-","-","-"},{"-","-","-"},{"-","-","-"}  };
            //спрайты asset1 - PC,asset2 - User
            string asset1 = "+",asset2 = "+";
            bool sprite = false;

            Console.WriteLine("--->|WELCOME|<---\nчтобы начать играть нажмите Enter");
            Console.ReadLine();
            while(sprite == false){
                Console.WriteLine("выберите и ввведите кем будете играть (X или O с большой буквы на английском) ->");
                asset1 = Console.ReadLine();
                if(asset1 == "X"){
                    asset2 = "O";
                    sprite = true;
                }
                else if(asset1 == "O"){
                    asset2 = "X";
                    sprite = true;
                }
                else {
                    Console.WriteLine("ERROR");
                }
            }
            

            Console.Write("карта игры :\n");

            //если пользователь выбрал O
            if(asset1 == "O"){
                //список ходов и проверка на возможный проигрыш  :
                Move.PCMove(array,asset1);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.UserMove(array,asset2);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.PCMove(array,asset1); 
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.UserMove(array,asset2);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.PCMove(array,asset1);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.UserMove(array,asset2);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.PCMove(array,asset1);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.UserMove(array,asset2);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.PCMove(array,asset1);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("ничья");
            }

            //если пользователь выбрал X
            else if(asset1 == "X"){
                //список ходов и проверка на возможный проигрыш  :
                Move.UserMove(array,asset2);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.PCMove(array,asset1); 
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");

                Move.UserMove(array,asset2);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");
                
                Move.PCMove(array,asset1); 
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");
                Move.UserMove(array,asset2);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");
                
                Move.PCMove(array,asset1); 
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");
                Move.UserMove(array,asset2);
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");
                
                Move.PCMove(array,asset1); 
                Bourd.Win(array[0,0],array[1,0],array[2,0]);
                Bourd.Win(array[0,1],array[1,1],array[2,1]);
                Bourd.Win(array[0,2],array[1,2],array[2,2]);
                Bourd.Win(array[0,0],array[0,1],array[0,2]);
                Bourd.Win(array[1,0],array[1,1],array[1,2]);
                Bourd.Win(array[2,0],array[2,1],array[2,2]);
                Bourd.Win(array[2,0],array[1,1],array[0,2]);
                Bourd.Win(array[0,0],array[1,1],array[2,2]);
                Console.Write("\n\n");
                Console.Write("ничья");
            }
        }

    }


//класс игрового поля
    class Bourd
    {
        //вывод поля
        public static void Print(string[,] array){
            int b = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(b % 3 == 0){
                        Console.Write("\n");
                    }
                    Console.Write(array[i, j]);
                    b++;
                }
            }
        }

        //проверка на победу
        public static string Win(string a,string b,string c){
            if(a == b && b == c && a != "-" && b != "-" && c != "-"){
                if(a == "X"){
                    Console.WriteLine("\nWinner - PC");
                    Environment.Exit(0);
                }
                else if(a == "O"){
                    Console.WriteLine("\nWinner - User");
                    Environment.Exit(0);
                }
            }
            return "следующий ход";
        }
    }

//класс логики ПК
    class Logic
    {
        //нахождение вероятности
        public static int choise(string a,string b,string c){
                
            int num = 0;
            if(a == "O" || b == "O" || c == "O"){
                return 404;
            }
            for(int i = 0;i<=2;i++){
                if(i == 0){
                    if(a == "-"){
                        num++;
                    }
                }
                if(i == 1){
                    if(b == "-"){
                        num++;
                    }
                }
                if(i == 2){
                    if(c == "-"){
                        num++;
                    }
                }
            }
            //Console.WriteLine(num);
            return num;
        }

        //проверка на порожение
        public static int choiseOver(string a,string b,string c){
                
            int num = 0;
            if(a == "X" || b == "X" || c == "X"){
                return 444;
            }
            for(int i = 0;i<=2;i++){
                if(i == 0){
                    if(a == "-"){
                        num++;
                    }
                }
                if(i == 1){
                    if(b == "-"){
                        num++;
                    }
                }
                if(i == 2){
                    if(c == "-"){
                        num++;
                    }
                }
            }
            //Console.WriteLine(num);
            return num;
        }
    }

//класс отвечающий за ход пользователя и ПК
    class Move 
    {
        //ход ПК
        public static void PCMove(string[,] array,string asset){
            //проверка вероятностей(1 - это 100%)
            if(Logic.choiseOver(array[0,0],array[1,0],array[2,0]) == 1){
                for(int i = 0;i<= 2;i++){
                    if(array[i,0] == "-"){
                        //присвоение ассета к точке игрового поля
                        array[i,0] = asset;
                        //вывод поля
                        Bourd.Print(array);
                        break;
                    }
                }
            }
            else if(Logic.choiseOver(array[0,1],array[1,1],array[2,1]) == 1){
                for(int i = 0;i<= 2;i++){
                    if(array[i,1] == "-"){
                        //присвоение ассета к точке игрового поля
                        array[i,1] = asset;
                        //вывод поля
                        Bourd.Print(array);
                        break;
                    }
                }
            }
            else if(Logic.choiseOver(array[0,2],array[1,2],array[2,2]) == 1){
                for(int i = 0;i<= 2;i++){
                    if(array[i,2] == "-"){
                        //присвоение ассета к точке игрового поля
                        array[i,2] = asset;
                        //вывод поля
                        Bourd.Print(array);
                        break;
                    }
                }
            }
            else if(Logic.choiseOver(array[0,0],array[0,1],array[0,2]) == 1){
                for(int i = 0;i<= 2;i++){
                    if(array[0,i] == "-"){
                        //присвоение ассета к точке игрового поля
                        array[0,i] = asset;
                        //вывод поля
                        Bourd.Print(array);
                        break;
                    }
                }
            }
            else if(Logic.choiseOver(array[1,0],array[1,1],array[1,2]) == 1){
                for(int i = 0;i<= 2;i++){
                    if(array[1,i] == "-"){
                        //присвоение ассета к точке игрового поля
                        array[1,i] = asset;
                        //вывод поля
                        Bourd.Print(array);
                        break;
                    }
                }
            }
            else if(Logic.choiseOver(array[2,0],array[2,1],array[2,2]) == 1){
                for(int i = 0;i<= 2;i++){
                    if(array[2,i] == "-"){
                        //присвоение ассета к точке игрового поля
                        array[2,i] = asset;
                        //вывод поля
                        Bourd.Print(array);
                        break;
                    }
                }
            }
            else if(Logic.choiseOver(array[2,0],array[1,1],array[0,2]) == 1){
                for(int i = 0;i<= 2;i++){
                    if(array[2-i,0+i] == "-"){
                        //присвоение ассета к точке игрового поля
                        array[2-i,0+i] = asset;
                        //вывод поля
                        Bourd.Print(array);
                        break;
                    }
                }
            }
            else if(Logic.choiseOver(array[0,0],array[1,1],array[2,2]) == 1){
                for(int i = 0;i<= 2;i++){
                    if(array[0+i,0+i] == "-"){
                        //присвоение ассета к точке игрового поля
                        array[0+i,0+i] = asset;
                        //вывод поля
                        Bourd.Print(array);
                        break;
                    }
                }
            }
            //Console.WriteLine("\n");
            else{
                //переменные вариантов линий
                int a,b,c,d,e,f,g,h;
                //обработка их вероятностей 
                a = Logic.choise(array[0,0],array[1,0],array[2,0]);
                //Console.WriteLine("\n UwU");
                if(a == 404)
                {
                    a = 0;
                }
                else{
                    a = 100/a;
                }
                b = Logic.choise(array[0,1],array[1,1],array[2,1]);
                if(b == 404)
                {
                    b = 0;
                }
                else
                {
                    b = 100/b;
                }
                c = Logic.choise(array[0,2],array[1,2],array[2,2]);
                if(c == 404)
                {
                    c = 0;
                }
                else{
                    c = 100/c;
                }
                d = Logic.choise(array[0,0],array[0,1],array[0,2]);
                if(d == 404)
                {
                    d = 0;
                }
                else
                {
                    d = 100/d;
                }
                e = Logic.choise(array[1,0],array[1,1],array[1,2]);
                if(e == 404)
                {
                    e = 0;
                }
                else
                {
                    e = 100/e;
                }
                f = Logic.choise(array[2,0],array[2,1],array[2,2]);
                if(f == 404)
                {
                    f = 0;
                }
                else
                {
                    f = 100/f;
                }
                g = Logic.choise(array[2,0],array[1,1],array[0,2]);
                if(g == 404)
                {
                    g = 0;
                }
                else
                {
                    g = 100/g;
                }
                h = Logic.choise(array[0,0],array[1,1],array[2,2]);
                if(h == 404)
                {
                    h = 0;
                }
                else
                {
                    h = 100/h;
                }

                //нахождение максимальной вероятности
                int m = Math.Max(a,b);
                int m1 = Math.Max(c,d);
                int mm = Math.Max(m,m1);
                int mm1 = Math.Max(g,h);
                int move = Math.Max(mm,mm1);
                //Console.WriteLine(mm);

                //нахождение варианта которму принадлежит эта вероятность
                if(a == move){
                    //зполнение пустой клетки поля в этой линии
                    for(int i = 0;i<= 2;i++){
                        if(array[i,0] == "-"){
                            array[i,0] = asset;
                            Bourd.Print(array);
                            break;
                        }
                    }
                }
                else if(b == move){
                    //зполнение пустой клетки поля в этой линии
                    for(int i = 0;i<= 2;i++){
                        if(array[i,1] == "-"){
                            array[i,1] = asset;
                            Bourd.Print(array);
                            break;
                        }
                    }
                }
                else if(c == move){
                    //зполнение пустой клетки поля в этой линии
                    for(int i = 0;i<= 2;i++){
                        if(array[i,2] == "-"){
                            array[i,2] = asset;
                            Bourd.Print(array);
                            break;
                        }
                    }
                }
                else if(d == move){
                    //зполнение пустой клетки поля в этой линии
                    for(int i = 0;i<= 2;i++){
                        if(array[0,i] == "-"){
                            array[0,i] = asset;
                            Bourd.Print(array);
                            break;
                        }
                    }
                }
                else if(e == move){
                    //зполнение пустой клетки поля в этой линии
                    for(int i = 0;i<= 2;i++){
                            if(array[1,i] == "-"){
                                array[1,i] = asset;
                                Bourd.Print(array);
                                break;
                            }
                        }
                }
                else if(f == move){
                    //зполнение пустой клетки поля в этой линии
                    for(int i = 0;i<= 2;i++){
                        if(array[2,i] == "-"){
                            array[2,i] = asset;
                            Bourd.Print(array);
                            break;
                        }
                    }
                }
                else if(g == move){
                    //зполнение пустой клетки поля в этой линии
                    for(int i = 0;i<= 2;i++){
                        if(array[2-i,0+i] == "-"){
                            array[2-i,0+i] = asset;
                            Bourd.Print(array);
                            break;
                        }
                    }
                }
                else if(h == move){
                    //зполнение пустой клетки поля в этой линии
                    for(int i = 0;i<= 2;i++){
                        if(array[0+i,0+i] == "-"){
                            array[0+i,0+i] = asset;
                            Bourd.Print(array);
                            break;
                        }
                    }
                }
            }
        }

        //ход пользователя
        public static void UserMove(string[,] array,string asset){
            //пременная доступа шага(true - можно false нельзя)
            bool move = false;
            while(move == false){
                Console.WriteLine("введите координату x куда поставить :");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите координату y куда поставить :");
                int y = Convert.ToInt32(Console.ReadLine());
                //проверка на правильность координат и свободны ли они
                if(x <= 2 && x >= 0){
                    if(y <= 2 && y >= 0){
                        if(array[y, x] == "-"){
                            array[y, x] = asset;
                            //разрешение шага
                            move = true;
                            //вывод поля
                            Bourd.Print(array);
                        }
                    }
                }
                else{
                    //ошибка
                    Console.WriteLine("ERROR");
                }
            }
            
        }
    }
    
}
