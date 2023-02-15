// zadanie domowe dzień 4
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

string name = "ewa";
bool female = false;
var age = 33;

if (female && age < 30)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}

else if (age == 33 && name == "ewa")
{
    Console.WriteLine("ewa, lat 33");
}

else if (!female && age < 18)
{
    Console.WriteLine("niepełnoletni mężczyzna");

}
