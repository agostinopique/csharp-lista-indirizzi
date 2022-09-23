// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, System of a Down!");


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

StreamReader file = File.OpenText("./addresses.csv");

file.ReadLine();

List<Address> addresses = new List<Address>();

try
{

    while (!file.EndOfStream)
{

    string line = file.ReadLine();
    string[] stringParts = line.Split(",");
    
    string name = stringParts[0];
    string surname = stringParts[1];
    string street = stringParts[2];
    string city = stringParts[3];
    string province = stringParts[4];
    int zip = int.Parse(stringParts[5]);

    bool isNumeric = street.All(char.IsDigit);

    if (!isNumeric)
    {
        street = stringParts[3];
        city = stringParts[4];
        province = stringParts[5];
        zip = int.Parse(stringParts[6]);
    }

    Address address = new Address(street, city, province, zip, new User(name, surname));

    addresses.Add(address);

}

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


file.Close();

//          Name,Surname,Street,City,Province,ZIP
//          John, Doe,120 jefferson st., Riverside, NJ,08075
//          Jack, McGinnis,220 hobo Av., Phila, PA,09119
//          John Da Man, Repici,120 Jefferson St., Riverside, NJ,08075
//          Stephen, Tyler,7452 Terrace "At the Plaza" road, SomeTown, SD,91234
//          Joan, Anne, Jet,9th at Terrace plc, Desert City, CO,00123
//          , Blankman,, New York, NY, 100101
//          Joan, SomeTown, SD, 00298