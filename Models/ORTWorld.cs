class ORTWorld{

    public static List<string> ListaDestinos {get; set;} = new List<string> {"Buenos Aires", "Madrid", "Paris", "Nueva York", "Ottawa", "Amsterdam", "Damasco", "Canberra", "Kiev", "Barracas"};
    public static List<string> ListaHoteles {get; set;} = new List<string> {"Hilton", "Fourseasons", "Toujurs", "Manhattan", "HolidayInn", "Waldorff", "DamaRose", "Jamala", "Kyiv", "Aristobulo"};
    public static List<string> ListaAereos {get; set;} = new List<string> {"Aerolineas Argentinas", "Iberia", "Air France", "American Airlines", "Air Canada", "KLM", "Syrian Air", "Air Australia", "Ucraine International Airlines", "el 15"};
    public static List<string> ListaExcursiones {get; set;} = new List<string> {"Obelisco", "Palacio real", "Torre Eiffel", "Times Square", "Galeria Nacional", "Museo Van Gogh", "Mezquita Omeya", "Lago Burley", "Monasterio de las cuevas", "Estadio Chiqui Tapia"};
    public static Dictionary<string, Paquete> Paquetes {get; set;} = new Dictionary<string, Paquete>();


    public static bool IngresarPaquete(string destinoSeleccionado){
        
            if(Paquetes.ContainsKey(destinoSeleccionado)){
                return false;
            }

        return true;
    }


}