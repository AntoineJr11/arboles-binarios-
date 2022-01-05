using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacionIII
{
    class Program
    {
       
        static void Main(string[] args)
        {

            ArbolBinario arbol = new ArbolBinario();
            ArbolBinario arbol2 = new ArbolBinario();
            Int32 Opc = 0;
            String DecArbol = "";



            do
            {
                Console.WriteLine("      PROYECTO FINAL PROGRAMACIÓN III");
                Console.WriteLine("             ÁRBOLES BINARIOS");

                Console.WriteLine("1. INGRESO DE UN NODO");
                Console.WriteLine("2. PADRE DE UN NODO Y");
                Console.WriteLine("3. NODOS INTERIORES DEL ÁRBOL");
                Console.WriteLine("4. GRADO DE UN ARBOL");
                Console.WriteLine("5. ALTURA DE UN ARBOL");
                Console.WriteLine("6. LONGITUD DE CAMINO INTERNO");
                Console.WriteLine("7. LONGITUD DE CAMINO EXTERNO");
                Console.WriteLine("8. DETERMINAR SI LOS ARBOLES 'A' Y 'B' SON SIMILARES");
                Console.WriteLine("9. DETERMINAR SI LOS ARBOLES 'A' Y 'B' SON DISTINTOS");
                Console.WriteLine("10. ELIMINAR TODOS LOS NODOS HOJA DE UN ÁRBOL");
                Console.WriteLine("11. INTERCAMBIAR POSICIÓN DE DOS NODOS");
                Console.WriteLine("12. MOSTRAR EL ARBOL (RECORRIDO)");
                Console.WriteLine("13. SALIR");




                try
                {
                    Opc = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dato inválido");
                    Console.ReadKey();
                    Console.Clear();
                }
                switch (Opc)
                {




                    case 1:
                        Console.Clear();
                        Console.WriteLine("INGRESE EL ÁRBOL (A o B) AL QUE DESEA INGRESAR EL NUEVO NODO ");
                        try
                        {
                            DecArbol = Console.ReadLine();
                            Console.Clear();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (DecArbol == "A")
                        {
                            arbol.ABB();
                        }
                        else if (DecArbol == "B")
                        {
                            arbol2.ABB();
                        }
                        else
                        {
                            Console.WriteLine("ÁRBOL INVÁLIDO");
                        }
                        Console.ReadKey();
                        break;





                    case 2:
                        Console.Clear();
                        DecArbol = "";
                        Console.WriteLine("SELECCIONE EL ÁRBOL A RECORRER (A o B)");
                        try
                        {
                            DecArbol = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO, INGRESE UN NÚMERO ENTERO");
                        }
                        switch (DecArbol)
                        {
                            case "A":
                                if (arbol.EstaVacio() == false)
                                {
                                    Int32 Buscar = 0;
                                    Console.WriteLine("INGRESE EL NODO A BUSCAR: ");
                                    try
                                    {
                                        Buscar = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("DATO INVÁLIDO");
                                    }
                                    Console.WriteLine("EL NODO NO EXISTE");
                                    arbol.PadreNodoY(Buscar);
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            case "B":
                                if (arbol.EstaVacio() == false)
                                {
                                    Int32 Buscar = 0;
                                    Console.WriteLine("INGRESE EL NODO A BUSCAR: ");
                                    try
                                    {
                                        Buscar = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("DATO INVÁLIDO");
                                    }
                                    Console.WriteLine("EL NODO NO EXISTE");
                                    arbol.PadreNodoY(Buscar);
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            default:
                                Console.WriteLine("ÁRBOL INVÁLIDO");
                                break;
                        }

                        Console.ReadKey();
                        break;





                    case 3:
                        Console.Clear();
                        DecArbol = "";
                        Console.WriteLine("SELECCIONE EL ÁRBOL A RECORRER (A o B)");
                        try
                        {
                            DecArbol = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO");
                        }
                        switch (DecArbol)
                        {
                            case "A":
                                if (arbol.EstaVacio() == false)
                                {
                                    Console.WriteLine("LOS NODOS INTERIORES DEL ÁRBOL SON :");
                                    arbol.NodosInteriores();
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            case "B":
                                if (arbol.EstaVacio() == false)
                                {
                                    Console.WriteLine("LOS NODOS INTERIORES DEL ÁRBOL SON :");
                                    arbol2.NodosInteriores();
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            default:
                                Console.WriteLine("ÁRBOL INVÁLIDO");
                                break;
                        }
                        Console.ReadKey();
                        break;






                    case 4:
                        Console.Clear();
                        DecArbol = "";
                        Console.WriteLine("SELECCIONE EL ÁRBOL A RECORRER (A o B)");
                        try
                        {
                            DecArbol = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO");
                        }
                        switch (DecArbol)
                        {
                            case "A":
                                if (arbol.EstaVacio() == false)
                                {
                                    
                                    arbol.GradoDeUnArbol();
                                    
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            case "B":
                                if (arbol.EstaVacio() == false)
                                {
                                    
                                    Console.WriteLine("EL NODO NO EXISTE");
                                    arbol2.GradoDeUnArbol();
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            default:
                                Console.WriteLine("ÁRBOL INVÁLIDO");
                                break;
                        }
                        Console.ReadKey();
                        break;





                    case 5:
                        Console.Clear();
                        DecArbol = "";
                        Console.WriteLine("SELECCIONE EL ÁRBOL A RECORRER (A o B)");
                        try
                        {
                            DecArbol = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO");
                        }
                        switch (DecArbol)
                        {
                            case "A":
                                if (arbol.EstaVacio() == false)
                                {
                                    arbol.AlturaArbol();
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            case "B":
                                if (arbol.EstaVacio() == false)
                                {
                                    arbol2.AlturaArbol();
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            default:
                                Console.WriteLine("ÁRBOL INVÁLIDO");
                                break;
                        }
                        Console.ReadKey();
                        break;





                    case 6:
                        Console.Clear();
                        DecArbol = "";
                        Console.WriteLine("SELECCIONE EL ÁRBOL A RECORRER (A o B)");
                        try
                        {
                            DecArbol = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO");
                        }
                        switch (DecArbol)
                        {
                            case "A":
                                if (arbol.EstaVacio() == false)
                                {
                                    Console.WriteLine("La longitud de camino interna es: " + arbol.RecorrerCaminoInterno());
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            case "B":
                                if (arbol.EstaVacio() == false)
                                {
                                    Console.WriteLine("La longitud de camino interna es: " + arbol.RecorrerCaminoInterno());
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            default:
                                Console.WriteLine("ÁRBOL INVÁLIDO");
                                break;
                        }
                        Console.ReadKey();
                        break;




                    case 7:
                        Console.Clear();
                        DecArbol = "";
                        Console.WriteLine("SELECCIONE EL ÁRBOL A RECORRER (A o B)");
                        try
                        {
                            DecArbol = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO");
                        }
                        switch (DecArbol)
                        {
                            case "A":
                                if (arbol.EstaVacio() == false)
                                {
                                    Console.WriteLine("La longitud de camino externo es: " + arbol.CaminoExterior());
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            case "B":
                                if (arbol.EstaVacio() == false)
                                {
                                    Console.WriteLine("La longitud de camino externo es: " + arbol2.CaminoExterior());
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            default:
                                Console.WriteLine("ÁRBOL INVÁLIDO");
                                break;
                        }
                        Console.ReadKey();
                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("Dos arboles son similares:\n");
                        if (arbol.Similares(arbol.NodoRaiz, arbol2.NodoRaiz)==true)
                        {
                            Console.WriteLine("Arboles similares");
                        }
                        else
                        {
                            Console.WriteLine("Arboles no son similares");
                        }
                        Console.ReadKey();
                        break;





                    case 9:
                        Console.Clear();
                        Console.WriteLine("Dos arboles son Distintos:\n");
                        if (arbol.Distintos(arbol.NodoRaiz, arbol2.NodoRaiz))
                        {
                            Console.WriteLine("Arboles no son distintos");
                        }
                        else
                        {
                            Console.WriteLine("Arboles distintos");
                        }
                        Console.ReadKey();
                        break;




                    case 10:
                        Console.Clear();
                        DecArbol = "";
                        Console.WriteLine("SELECCIONE EL ÁRBOL A ELIMINAR NODOS HOJA (A o B)");
                        try
                        {
                            DecArbol = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO");
                        }
                        switch (DecArbol)
                        {
                            case "A":
                                arbol.EliminarHojas();
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Mostrando el nuevo arbol: ");
                                arbol.RecorridoInOrdenGrafico(arbol.NodoRaiz);
                                
                                break;
                            case "B":
                                arbol2.EliminarHojas();
                                Console.Clear();
                                Console.WriteLine("Mostrando el nuevo arbol: ");
                                arbol2.RecorridoInOrdenGrafico(arbol2.NodoRaiz);
                                break;
                            default:
                                Console.WriteLine("ÁRBOL INVÁLIDO");
                                break;
                        }
                        Console.ReadKey();
                        break;



                    



                    case 11:
                        Console.Clear();
                        DecArbol = "";
                        Console.WriteLine("SELECCIONE EL ÁRBOL A CAMBIAR NODOS (A o B)");
                        try
                        {
                            DecArbol = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO");
                        }
                        switch (DecArbol)
                        {
                            case "A":
                                Console.WriteLine("Arbol antes del cambio: ");
                                arbol.recorrido2();
                                arbol.Cambio();
                                Console.WriteLine("Intercambio exitoso.");
                                arbol.recorrido2();
                                    
                                break;
                            case "B":
                                Console.WriteLine("Arbol antes del cambio: ");
                                arbol2.recorrido2();
                                arbol2.Cambio();
                                Console.WriteLine("Intercambio exitoso.");
                                arbol2.recorrido2();

                                break;
                        }
                        Console.ReadKey();
                        break;


                    case 12:
                        Console.Clear();
                        DecArbol = "";
                        Console.WriteLine("SELECCIONE EL ÁRBOL A ELIMINAR NODOS HOJA (A o B)");
                        try
                        {
                            DecArbol = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("DATO INVÁLIDO");
                        }
                        switch (DecArbol)
                        {
                            case "A":
                                if (arbol.EstaVacio() == false)
                                {
                                    Console.Clear();
                                    arbol.RecorridoInOrdenGrafico(arbol.NodoRaiz);
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            case "B":
                                if (arbol2.EstaVacio() == false)
                                {
                                    Console.Clear();
                                    arbol2.RecorridoInOrdenGrafico(arbol2.NodoRaiz);
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("EL ÁRBOL ESTÁ VACÍO");
                                }
                                break;
                            default:
                                Console.WriteLine("ÁRBOL INVÁLIDO");
                                break;
                        }
                        Console.ReadKey();

                        break;


             
                }
                Console.Clear();
            } while (Opc != 13);
        }

    }
}
