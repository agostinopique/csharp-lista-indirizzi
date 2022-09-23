// See https://aka.ms/new-console-template for more information


#region instructions

//Oggi esercitazione veloce, ossia vi chiedo di prendere dimestichezza con quanto appena
//visto sui file in classe, in particolare nel live-coding di oggi.
//In questo esercizio dovrete leggere un file CSV, che cambia poco da
//quanto appena visto nel live-coding in classe, e salvare tutti gli
//indirizzi contenuti al suo interno all’interno di una lista di oggetti
//istanziati a partire dalla classe Indirizzo.

//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari”
//che possono accadere a questo genere di file: vi chiedo di pensarci e di
//gestire come meglio crediate queste casistiche.

#endregion instructions

public class Address
{
     
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public int ZIP { get; set; }


    public Address(string street, string city, string province, int zip, User)
    {
        this.Street = street;
        this.City = city;
        this.Province = province;
        this.ZIP = zip;
    }

    public void PrintAddress()
    {
        User user;
        Console.WriteLine("-----------");
        Console.WriteLine("Name: " + user.Name);
        Console.WriteLine("Surname: " + user.Surname);
        Console.WriteLine("Street: " + this.Street);
        Console.WriteLine("City: " + this.City);
        Console.WriteLine("Province " + this.Province);
        Console.WriteLine("ZIP: " + this.ZIP);
    }
}
