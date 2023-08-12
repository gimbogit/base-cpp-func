void log(string str) {
    System.Console.WriteLine(str);
}


void getAreaCircle (int rad ){
    double area = 2 * Math.PI * Math.Pow(rad, 5);
    if (isValidCircle(area)){
        log($"Площадь круга равна {area}");
    }

} 


bool isValidCircle ( double area){
    if (area > 100){
        return true ;
    }
    else{
        log("Не валидный круг )))");
        return false;

    }

}
log("Введите радиус первого круга: ");
int rad1 = int.Parse(Console.ReadLine());

log("Введите радиус второго круга: ");
int rad2 = int.Parse(Console.ReadLine());


getAreaCircle(rad1);
getAreaCircle(rad2);



// void getPerTriangle (int a , int b ,int c ){
//     int periMetr = a +b +c ;
//     if(isValidTriangle(a,b,c))  {
//         log($"Периметр равен {periMetr}");
//     } 
// }


// bool isValidTriangle (int a , int b , int c){
//     if (a + b > c && b + c > a && a + c > b)  {
//         return true;
//     }  else {
//         log("Не валидный треугольник");
//         return false;
//     }
// }


// int a1 = 23;
// int b1 = 17;
// int c1 =7;

// int a2 = 3;
// int b2 = 66;
// int c2 = 99;

// getPerTriangle(a1,b1,c1);
// getPerTriangle(a2,b2,c2);




// void getArea(int _1 ,int _2){
//     int area = _1 * _2;
//     System.Console.WriteLine(area);
// }


// int a123 = 5;
// int b1 = 12;

// int a2 = 123;
// int b2 = 1;



// getArea(a123, b1);
// getArea(a2, b2);



// void getPerimetr(string str) {
//     System.Console.WriteLine(str);
// }

// string str = Console.ReadLine();


// System.Console.Clear();
// System.Console.WriteLine("Hello");


// getPerimetr(str);
// getPerimetr(str);
// getPerimetr(str);
// getPerimetr(str);
// getPerimetr(str);
// getPerimetr(str);

