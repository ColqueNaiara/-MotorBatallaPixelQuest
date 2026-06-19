using PixelQuest;

List<Personaje> personajes = new List<Personaje>();

personajes.Add(new Guerrero {Nombre = "Hercúles", Resistencia = 90 });
personajes.Add(new Mago { Nombre = "Vandal", CantidadMana = 85 });
personajes.Add(new Arquero { Nombre = "Sam", CantidadFlechas = 110 });

Console.WriteLine("\t| Ronda de Ataque |");

foreach (var Personaje in personajes) {
    string mensaje = Personaje.Atacar();
    Console.WriteLine(mensaje);
}
Console.ReadKey();
