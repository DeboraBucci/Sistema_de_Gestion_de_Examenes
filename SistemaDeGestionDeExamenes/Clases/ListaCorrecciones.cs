namespace SistemaDeGestionDeExamenes.Clases
{
    public static class ListaCorrecciones
    {
        private static string archivoCorrecciones = "correcciones.json";

        public static List<Correccion> Correcciones { get; private set; } =
            JsonHelper.LeerDesdeArchivo<Correccion>(archivoCorrecciones);

        public static void GuardarCorreccion (Correccion correccion)
        {
            Correcciones.Add(correccion);
            GuardarEnArchivo();
        }

        public static void GuardarEnArchivo()
        {
            JsonHelper.GuardarEnArchivo(Correcciones, archivoCorrecciones);
        }

        public static void EliminarCorreccion(string id)
        {
            Correcciones =
                Correcciones
                .Where(corr => corr.CorreccionId != id)
                .ToList();

            GuardarEnArchivo();
        }
    }
}
