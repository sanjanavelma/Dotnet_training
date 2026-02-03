public class Declaration
{
    string name = " ";
    int age;
    char gender;

    public string Person(string name, int age, char gender = 'm')
    {
        this.name = name;
        this.age = age;
        this.gender = gender;

        return ($"Name: {this.name}, Age: {this.age}, Gender: {this.gender}");
    }
}
