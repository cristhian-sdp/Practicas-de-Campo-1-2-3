using System.Collections.Generic;

namespace PC2
{
    /// Pruebas de los casos límite
    public static class Pruebas
    {
        public static List<string> EjecutarPruebas()
        {
            var resultados = new List<string>();

            // CASO 1: lista vacía
            var lista1 = new ListaCircular();
            Verificar(resultados, "Caso 1 - Lista vacía: EstaVacia() debe ser true",
                lista1.EstaVacia());
            Verificar(resultados, "Caso 1 - Lista vacía: Siguiente() debe devolver null",
                lista1.Siguiente() == null);
            Verificar(resultados, "Caso 1 - Lista vacía: Anterior() debe devolver null",
                lista1.Anterior() == null);
            Verificar(resultados, "Caso 1 - Lista vacía: EliminarActual() debe devolver false",
                lista1.EliminarActual() == false);

            // CASO 2: un solo elemento
            var lista2 = new ListaCircular();
            lista2.Insertar("Canción A");
            Verificar(resultados, "Caso 2 - Un elemento: ObtenerActual() debe ser 'Canción A'",
                lista2.ObtenerActual() == "Canción A");
            Verificar(resultados, "Caso 2 - Un elemento: Siguiente() se queda en sí mismo",
                lista2.Siguiente() == "Canción A");
            Verificar(resultados, "Caso 2 - Un elemento: Anterior() se queda en sí mismo",
                lista2.Anterior() == "Canción A");

            // CASO 3: eliminar el primero
            var lista3 = new ListaCircular();
            lista3.Insertar("A");
            lista3.Insertar("B");
            lista3.Insertar("C");
            lista3.EliminarPrimero();
            var contenido3 = lista3.ObtenerTodas();
            Verificar(resultados, "Caso 3 - Eliminar primero: la lista queda [B, C]",
                contenido3.Count == 2 && contenido3[0] == "B" && contenido3[1] == "C");
            Verificar(resultados, "Caso 3 - Eliminar primero: la canción actual pasa a ser 'B'",
                lista3.ObtenerActual() == "B");

            // CASO 4: eliminar el último
            var lista4 = new ListaCircular();
            lista4.Insertar("A");
            lista4.Insertar("B");
            lista4.Insertar("C");
            lista4.EliminarUltimo();
            var contenido4 = lista4.ObtenerTodas();
            Verificar(resultados, "Caso 4 - Eliminar último: la lista queda [A, B]",
                contenido4.Count == 2 && contenido4[0] == "A" && contenido4[1] == "B");

            // El círculo debe seguir cerrado con solo 2 elementos: A -> B -> A
            string siguiente1 = lista4.Siguiente(); // de A pasa a B
            string siguiente2 = lista4.Siguiente(); // de B vuelve a A
            Verificar(resultados, "Caso 4 - Tras eliminar, el círculo sigue cerrado (A -> B -> A)",
                siguiente1 == "B" && siguiente2 == "A");

            return resultados;
        }

        private static void Verificar(List<string> resultados, string descripcion, bool condicion)
        {
            resultados.Add((condicion ? "OK    - " : "FALLÓ - ") + descripcion);
        }
    }
}
