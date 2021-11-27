
/// void Methode #2

void Methode2(string msg)
{
    Console.WriteLine(msg);
}
//Methode2("Данный пробный текст, привет Вацок!");
///Убрать слеш для вызова нижнего Метода!
//Methode2(msg: "Данный пробный текст, привет Вацок!");  //так делают если Аргументов НЕСКОЛЬКО!!!

// НАпример когда Аргументов НЕСКОЛЬКО!

void Method21(string msg , int count)
{int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        //count++; не верно, ножно увеличивать i !!!
        i++;
    }
}
//Method21("Привет, Вацок", 4); будет правильнне на ниж.строке!
Method21(msg: "Привет, Вацок", count: 10);
Method21(count: 10, msg: "Привет, Вацок");