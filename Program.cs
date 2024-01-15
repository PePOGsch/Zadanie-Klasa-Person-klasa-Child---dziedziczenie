using System;

//Test1();
//Test2();
//Test3();
//Test4();
//Test5();
//Test6();
//Test7();
Test8();


/////-----------
///

void Test1()
{
    /* Test: poprawne tworzenie obiektu Person, dane poprawne */
    try
    {
        Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test2()
{
    /* Test: poprawne tworzenie obiektu Person, 
   błędne imię lub nazwisko, pierwsza duża pozostałe małe */
    try
    {
        Person p = new Person(familyName: "MOlenda", firstName: "krzysztof", age: 18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test3()
{
    /* Test: poprawne tworzenie obiektu Person, 
   błędne imię lub nazwisko, niewłaściwy wiek */
    try
    {
        Person p = new Person(familyName: "MOlenda", firstName: "krzysztof", age: -18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test4()
{
    /* Test: poprawne tworzenie obiektu Person,
   błędne imię lub nazwisko, spacje przed i po */
    try
    {
        Person p = new Person(familyName: "  Molenda    ", firstName: " Krzysztof ", age: 18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test5()
{

    /* Test: modyfikacja obiektu */
    try
    {
        Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
        p.modifyFirstName(" Ja n");
        p.modifyFamilyName("kolenda ");
        p.modifyAge(35);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
void Test6()
{
    /* Test: poprawne tworzenie obiektu Person,
   błędne imię lub nazwisko, spacje w środku */
    try
    {
        Person p = new Person(familyName: "Molen  da", firstName: "Krzysztof.", age: 18);
        Console.WriteLine(p);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test7()
{
    /* Test: tworzenie obiektu Child */
    try
    {
        Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
        Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
        Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 10,
                            mother: m, father: o);
        Console.WriteLine(d);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void Test8()
{
    /* Test: tworzenie obiektu Child
   modyfikacja danych */
    try
    {
        Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
        Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
        Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14,
                            mother: m, father: o);
        d.modifyFirstName("Aneta");
        Console.WriteLine(d);
        d.modifyFirstName("Kolenda");
        Console.WriteLine(d);
        d.modifyAge(18);
        Console.WriteLine(d);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}