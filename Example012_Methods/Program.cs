﻿// Вид 1
void Method1()
{
  Console.WriteLine("Автор...");
}

//Method1();

//Вид 2

void Method2(string msg)
{
  Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
  int i=0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}

//Method21(" Текст", 4);
//Method21(count: 4, msg: " Новый текст");

//Вид 3

int Method3()
{
  return DataTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);