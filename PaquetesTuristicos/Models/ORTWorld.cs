class ORTWorld
{

    public static List<string> ListaDestinos { get; private set; } = new List<string>() { "Iguazu", "Bariloche", "Ushuaia", "Salta", "CABA", "El Calafate", "Puerto Madryn", "Mendoza", "Humahuaca", "San Martin de los Andes" };


    public static List<string> ListaImagenes { get; private set; } = new List<string>() { "imagen 1.png", "imagen 2.png", "imagen 3.png", "imagen 4.png", "imagen 5.png", "imagen 6.png", "imagen 7.png", "imagen 8.png", "imagen 9.png", "imagen 10.png" };
    //public static List<string> ListaAereos { get; private set; } = new List<string>() { "aereo 1.png", "aereo 2.png", "aereo 3.png", "aereo 4.png", "aereo 5.png", "aereo 6.png", "aereo 7.png", "aereo 8.png", "aereo 9.png", "aereo 10.png" };
    public static Dictionary<string, Paquete> Paquetes { get; private set; } = new Dictionary<string, Paquete>();



    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if (Paquetes.ContainsKey(destinoSeleccionado)) {return false;}
        else { Paquetes.Add(destinoSeleccionado, paquete); return true; }
    }

}