using System;
using System.Text.RegularExpressions;
using System.Linq;


public class Person
{
    private string firstName;
    public string FirstName
    { 
        get=>firstName;
        set
        {
            value = value.Replace(" ", "");
            Regex regex = new Regex("^[a-zA-Z ąćęłńóśźżĄĆĘŁŃÓŚŹŻ-]+$");

            if (value == null || value == "" || value.Length <2 || value.Split('-').Length > 2 || !(regex.IsMatch(value)))
                throw new ArgumentException("Wrong name!");

            firstName = char.ToUpper(value[0]) + value.ToLower().Substring(1);
        }
    }

    private string familyName;
    public string FamilyName 
    { 
        get=>familyName; 
        set
        {
            value = value.Replace(" ", "");

            Regex regex = new Regex("^[a-zA-Z ąćęłńóśźżĄĆĘŁŃÓŚŹŻ-]+$");

            if (value == null || value == "" || value.Length < 2 || value.Split('-').Length > 2 || !(regex.IsMatch(value)))
                throw new ArgumentException("Wrong name!");

            familyName = char.ToUpper(value[0]) + value.ToLower().Substring(1);
        }
    }
    private int age;
    public int Age 
    { 
        get=>age;
        set
        {
            if (value < 0)
                throw new ArgumentException("Age must be positive!");
            if (this is Child && (value > 15))
                throw new ArgumentException("Child’s age must be less than 15!");

            age = value;
        }

    }
    public Person(string firstName, string familyName, int age)
    {
        FirstName = firstName;
        FamilyName = familyName;
        Age = age;
    }

    public override string ToString()
    {
        return $"{FirstName} {FamilyName} ({Age})";
    }

    public void modifyFirstName(string newfirstName)
    {
        FirstName = newfirstName;
    }

    public void modifyFamilyName(string newfamilyName)
    {
        FamilyName = newfamilyName;
    }

    public void modifyAge(int newAge)
    {
        Age = newAge;
    }
}

public class Child : Person
{

    private Person mother;
    public Person Mother
    {
        get { return mother; }
    }

    private Person father;
    public Person Father
    {
        get { return father; }
    }


    public Child(string firstName, string familyName, int age, Person mother = null, Person father = null)
        :base(firstName, familyName, age)
    {
        if (age > 15)
        {
            throw new ArgumentException("Child’s age must be less than 15!");
        }

        this.mother = mother;
        this.father = father;
    }


    public override string ToString()
    {
        string motherInfo = (mother != null) ? $"mother: {mother.ToString()}" : "mother: No data";
        string fatherInfo = (father != null) ? $"father: {father.ToString()}" : "father: No data";
        return $"{base.ToString()}\n{motherInfo}\n{fatherInfo}";
       // return $"{FirstName} {FamilyName} ({Age})\nmother: {mother.ToString()}\nfather: {father.ToString()}";
    }
}
