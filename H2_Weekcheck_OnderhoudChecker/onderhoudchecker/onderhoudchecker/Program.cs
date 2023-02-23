
var attracties = new List<Attractie>();

attracties.Add(new Attractie
{
    Naam = "Debug Hero",
    Soort = "Achtbaan",
    BezoekersPerJaar = 11000,
    LaatsteOnderhoud = 320,
    rating= "5 out of 10"
});

attracties.Add(new Attractie
{
    Naam = "Bugs of Horror",
    Soort = "Achtbaan",
    BezoekersPerJaar = 9900,
    LaatsteOnderhoud = 430,
    rating = "8 out of 10"
});

attracties.Add(new Attractie
{
    Naam = "Ffun Spalsh",
    Soort = "Water",
    BezoekersPerJaar = 20000,
    LaatsteOnderhoud = 100,
    rating = "4 out of 10"

});

attracties.Add(new Attractie
{
    Naam = "Turbo Turn 2000",
    Soort = "Water",
    BezoekersPerJaar = 8500,
    LaatsteOnderhoud = 260,
    rating = "9,5 out of 10"

});

attracties.Add(new Attractie
{
    Naam = "Magic Programmer",
    Soort = "Darkride",
    BezoekersPerJaar = 12500,
    LaatsteOnderhoud = 85,
    rating = "6 out of 10"

});

attracties.Add(new Attractie
{
    Naam = "Kids Park",
    Soort = "Anders",
    BezoekersPerJaar = 2100,
    LaatsteOnderhoud = 600,
    rating = "3 out of 10"

});

foreach (var attractie in attracties)
{
    bool check1 = attractie.LaatsteOnderhoud >= 500;
    bool check2 = attractie.BezoekersPerJaar >= 1000 && attractie.LaatsteOnderhoud >= 300;

    if (check1 || check2)
    {
        Console.WriteLine($"Naam attractie: {attractie.Naam} (heeft onderhoud nodig)" +
            $"");
        Console.WriteLine($"Soort: {attractie.Soort}");
        Console.WriteLine($"Bezoekers per jaar: {attractie.BezoekersPerJaar}");
        Console.WriteLine($"Laatste onderhoud: {attractie.LaatsteOnderhoud}");
        Console.WriteLine($"rating: {attractie.rating}");
        Console.ReadLine();
        Console.Clear();
    }
    else
    {

    }
        
    
    
}