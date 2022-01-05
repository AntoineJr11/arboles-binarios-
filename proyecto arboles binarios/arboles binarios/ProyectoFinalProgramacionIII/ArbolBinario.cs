using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacionIII
{
    public class ArbolBinario
    {

        public Nodo NodoRaiz;
        public int Elementos { get; set; }
        public int LCI;
        public int LCE;
        public Int32 MayGrad;
        public Int32 Grad, CompSubArb;
        public Int32 Nivel;
        public Nodo padre, G1, G2;
        public bool grado1, grado2;
        public int cantidad = 0;
        public int Altura;
        public int longitud;
        public int Cantidad2 = 0;
        public Nodo nodoAuxiliar;




        public ArbolBinario()
        {
            NodoRaiz = null;
            Elementos = 0;
        }

        //OBTENER RAIZ

        public Nodo ObtenerRaiz()
        {
            return NodoRaiz;
        }

        //VERIFICAR SI EL ARBOL ESTÁ VACÍO

        public bool EstaVacio()
        {
            return NodoRaiz == null;
        }



        //COMPROBACION PARA QUE LA LLAVE DE CADA NODO SEA UNICA

        public bool BusquedaComprobacion(Int32 Busc)
        {
            if (Comprobacion(NodoRaiz, Busc) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Comprobacion(Nodo nodo, int Dato)
        {
            if (nodo != null)
            {
                if (nodo.Llave == Dato)
                {
                    return true;
                }
                if (Comprobacion(nodo.LigaIzquierda, Dato) == true)
                {
                    return true;
                }
                if (Comprobacion(nodo.LigaDerecha, Dato) == true)
                {
                    return true;
                }
            }
            return false;
        }

        //RECORRIDO INORDEN

        public void RecorridoInOrden()
        {
            if (NodoRaiz != null)
            {
                Console.Clear();
                InOrden(NodoRaiz);
            }
        }

        public void InOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                InOrden(nodo.LigaIzquierda);
                Console.Write("{0} -->>", nodo.Llave);
                InOrden(nodo.LigaDerecha);
            }
        }

        public void recorrido2()
        {
            InOrden2(NodoRaiz);
        }

        private void InOrden2(Nodo nodoActual)
        {
            if (nodoActual != null)
            {
                InOrden2(nodoActual.LigaIzquierda);
                Console.WriteLine(nodoActual.Llave);
                InOrden2(nodoActual.LigaDerecha);
            }
        }



        //Recorrido inorden que muestra graficamente los nodos

        public void RecorridoInOrdenGrafico(Nodo nodo)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                RecorridoInOrdenGrafico(nodo.LigaIzquierda);
                Console.SetCursorPosition(nodo.PosX, nodo.PosY);
                Console.Write($"{nodo}");
                RecorridoInOrdenGrafico(nodo.LigaDerecha);
            }
        }



        //PADRE DE UN NODO Y
        //Busca un nodo en especifico e imprime su nodo padre
        public Nodo PadreNodoY(Int32 Dato)
        {
            padre = null;
            //Valida que el nodo no sea el nodo raiz
            if (NodoRaiz.Llave == Dato)
            {
                Console.Clear();
                Console.WriteLine("EL NODO NO POSEE PADRE PORQUE ES EL NODO RAÍZ");
            }
            else
            {
                PadreNodoYMet(NodoRaiz, Dato);
            }
            return padre;
        }

        //Busca un nodo en especifico e imprime su nodo padre
        public string PadreNodoYMet(Nodo NodoActual, Int32 Dato)
        {
            if (NodoActual != null)
            {
                //Valida que la llave del nodo que se esta recorriendo sea igual al que se esta buscando
                if (NodoActual.Llave == Dato)
                {
                    Console.Clear();
                    return "";
                }
                //Se llama al metodo recursivamente
                //Si la liga derecha del nodo actual es igual al dato, el nodo actual es el padre
                //y se imprime su llave
                if (PadreNodoYMet(NodoActual.LigaIzquierda, Dato) == "")
                {
                    Console.WriteLine("EL PADRE DEL NODO {0} ES: {1}", Dato, NodoActual.Llave);
                    padre = NodoActual;
                }
                //Se llama al metodo recursivamente
                //Si la liga izquierda del nodo actual es igual al dato, el nodo actual es el padre
                //y se imprime su llave
                if (PadreNodoYMet(NodoActual.LigaDerecha, Dato) == "")
                {
                    Console.WriteLine("EL PADRE DEL NODO {0} ES: {1}", Dato, NodoActual.Llave);
                    padre = NodoActual;
                }

            }
            return " ";
        }

        //LOS NODOS INTERIORES DE UN ÁRBOL

        public void NodosInteriores()
        {
            //Valida que el arbol no este vacio
            if ((NodoRaiz.LigaDerecha == null && NodoRaiz.LigaIzquierda == null))
            {
                Console.Clear();
                Console.WriteLine("EL ÁRBOL NO POSEE NODOS INTERNOS");
            }
            //Si los nodos no apuntan a nulo en sus dos apuntadores (izquierdo o derecho)
            //quiere decir que no tiene nodos internos.
            else if (NodoRaiz.LigaIzquierda != null && NodoRaiz.LigaDerecha == null)
            {
                if ((NodoRaiz.LigaIzquierda.LigaIzquierda == null && NodoRaiz.LigaIzquierda.LigaDerecha == null && NodoRaiz.LigaDerecha == null))
                {
                    Console.Clear();
                    Console.WriteLine("EL ÁRBOL NO POSEE NODOS INTERNOS");
                }
                else
                {
                    NodosInterioresMet(NodoRaiz);
                }
            }
            //valida si el nodo derecho de la raiz NO es nulo y el izquierdo si
            else if (NodoRaiz.LigaDerecha != null && NodoRaiz.LigaIzquierda == null)
            {
                //si la liga derecha de la liga derecha del nodo raiz es igual a nulo y la liga izquierda de la 
                //liga derecha del nodo raiz es nulo y si la liga izquierda del nodo raiz es nulo entonces 
                //el arbol no posee nodos internos
                if ((NodoRaiz.LigaDerecha.LigaDerecha == null && NodoRaiz.LigaDerecha.LigaIzquierda == null && NodoRaiz.LigaIzquierda == null))
                {
                    Console.Clear();
                    Console.WriteLine("EL ÁRBOL NO POSEE NODOS INTERNOS");
                }
                else
                {
                    NodosInterioresMet(NodoRaiz);
                }
            }
            //valida si la liga derecha e izquierda del nodo raiz no es nulo
            else if (NodoRaiz.LigaDerecha != null && NodoRaiz.LigaIzquierda != null)
            {
                //si la liga izquierda de la liga izquierda del nodo raiz y la liga derecha de la liga izquierda del 
                //nodo raiz y la liga izquierda de la liga derecha y la liga derecha de la liga derecha
                //del nodo raiz es nulo el arbol no posee nodos internos
                if ((NodoRaiz.LigaIzquierda.LigaIzquierda == null && NodoRaiz.LigaIzquierda.LigaDerecha == null && NodoRaiz.LigaDerecha.LigaIzquierda == null && NodoRaiz.LigaDerecha.LigaDerecha == null))
                {
                    Console.Clear();
                    Console.WriteLine("EL ÁRBOL NO POSEE NODOS INTERNOS");
                }
                else
                {
                    //Se llama al metodo para que inicie a recorrer recursivamente desde la raiz
                    NodosInterioresMet(NodoRaiz);
                }
            }
            else
            {
                //Se llama al metodo para que inicie a recorrer recursivamente desde la raiz
                NodosInterioresMet(NodoRaiz);
            }
        }

        public void NodosInterioresMet(Nodo nodo)
        {
            //valida que el nodo no sea nulo
            if (nodo != null)
            {
                //valida si la liga derecha e izquierda del nodo no es nulo y el nodo es diferente 
                //al nodo raiz
                if ((nodo.LigaDerecha != null || nodo.LigaIzquierda != null) && nodo != NodoRaiz)
                {
                    //Si los apuntadores del nodo no son nulos quiere decir que es un nodo interno
                    //y lo imprime en pantalla
                    Console.WriteLine("{0} ", nodo.Llave);
                }
                //Se aplica recorrido recursivo
                NodosInterioresMet(nodo.LigaIzquierda);

                NodosInterioresMet(nodo.LigaDerecha);
            }
        }



        //EL NIVEL DE UN NODO X

        public Int32 NivelNodoX(Int32 Dato)
        {
            Nivel = 0;
            return NivelNodoXMet(NodoRaiz, Dato, 1);
        }

        public Int32 NivelNodoXMet(Nodo nodo, Int32 Dato, Int32 Cont)
        {
            if (nodo != null)
            {
                if (nodo.Llave == Dato)
                {
                    Console.Clear();
                    Console.WriteLine("EL NIVEL DE NODO {0} ES: {1}", Dato, Cont);
                    Nivel = Cont;
                }
                Cont++;
                NivelNodoXMet(nodo.LigaIzquierda, Dato, Cont);
                NivelNodoXMet(nodo.LigaDerecha, Dato, Cont);
            }
            return Nivel;
        }


        //Se llama al metodo para que inicie a recorrer recursivamente desde la raiz
        private void CaminoInterno(Nodo nodoactual, int Contador)
        {
            if (EstaVacio())
            {
                Console.WriteLine("Arbol vacio");
            }
            else if (nodoactual != null)
            {
                longitud = longitud + Contador;
                Contador++;  //contado0r
                //se agrega en las dos ramas
                CaminoInterno(nodoactual.LigaIzquierda, Contador);
                CaminoInterno(nodoactual.LigaDerecha, Contador);
            }
        }

        //Metodo Recursivo
        public int RecorrerCaminoInterno()
        {
            longitud = 0;
            CaminoInterno(NodoRaiz, 1); //Lamar al metodo camino interno y se inicializa con el nodo raiz y 1 que es contador

            //se retorna la variable longitud
            return longitud;

        }

        //Metodo cantidad de nodos para el contador 2
        private void CantidadNodos(Nodo Recorrido)
        {
            if (Recorrido != null)
            {
                Cantidad2++;

                //recorrido recursivo para las hojas 
                CantidadNodos(Recorrido.LigaIzquierda);
                CantidadNodos(Recorrido.LigaDerecha);
            }
        }
        public int MostrarCantidad()
        {
            Cantidad2 = 0;
            CantidadNodos(NodoRaiz);   //se inicializa el metodo cantidad de nodos con Nodo Raiz

            //se retorna la variable cantidad 2 
            return Cantidad2;

        }//Se agrega el metodo de camino externo
        public int CaminoExterior()
        {
            int CaminoExterno;
            //es la formula para determinar la longitud de camino externo
            CaminoExterno = 1 + (RecorrerCaminoInterno() + 2 * MostrarCantidad());

            //se retorna el mismo metodo
            return CaminoExterno;
        }



        public void EliminarHojas()
        {
            if (!EstaVacio())
            {
                EliminarNodosHojas(ref NodoRaiz);//CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA UE LA INFORMACION QUE TEIENE SEA DIFERENTE
            }
        }

        private void EliminarNodosHojas(ref Nodo Hoja)
        {
            if (Hoja != null)
            {
                //CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA UE LA INFORMACION QUE TEIENE SEA DIFERENTE
                if (Hoja.LigaDerecha == null && Hoja.LigaIzquierda == null && Hoja != NodoRaiz)
                {
                    Console.WriteLine("Nodo hoja: " + Hoja.Llave + "eliminado.");
                    Hoja = null;
                }
                else
                {
                    EliminarNodosHojas(ref Hoja.LigaIzquierda);//CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA UE LA INFORMACION QUE TEIENE SEA DIFERENTE
                    EliminarNodosHojas(ref Hoja.LigaDerecha);//CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA UE LA INFORMACION QUE TEIENE SEA DIFERENTE
                }
            }
        }


        public void Cambio()
        {

            Intercambio(NodoRaiz); //CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA UE LA INFORMACION QUE TEIENE SEA DIFERENTE


        }


        public void Intercambio(Nodo NodoActual)
        {

            if (NodoActual != null)
            {

                nodoAuxiliar = NodoActual.LigaIzquierda;//CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA UE LA INFORMACION QUE TEIENE SEA DIFERENTE
                NodoActual.LigaIzquierda = NodoActual.LigaDerecha;//CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA UE LA INFORMACION QUE TEIENE SEA DIFERENTE
                NodoActual.LigaDerecha = nodoAuxiliar;//CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA UE LA INFORMACION QUE TEIENE SEA DIFERENTE
                Intercambio(NodoActual.LigaDerecha);//CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA UE LA INFORMACION QUE TEIENE SEA DIFERENTE
                Intercambio(NodoActual.LigaIzquierda);



            }

        }

        //Generar arbol y asignar una posicion dentro de la consola
        public void poblar(Nodo NodoPadre, Nodo nodo)
        {
            if (EstaVacio())
            {
                nodo.PosX = 50;
                nodo.PosY = 1;
                NodoRaiz = nodo;

            }
            //Ordena automaticamente el nodo segun sea su valor, si es mayor al nodo padre
            //el nodo se ordenara en la parte derecha
            else if (nodo.Llave > NodoPadre.Llave)
            {

                //debemos seleccionar la rama derecha
                if (NodoPadre.LigaDerecha == null)
                {
                    //Asigna posiciones especificas para que se muestren los nodos
                    nodo.PosX = NodoPadre.PosX + 20;
                    nodo.PosY = NodoPadre.PosY + 3;
                    NodoPadre.LigaDerecha = nodo;
                    grado1 = true;
                }
                else
                {
                    //Poblado recursivo 
                    poblar(NodoPadre.LigaDerecha, nodo);
                }

            }
            //Ordena automaticamente el nodo segun sea su valor, si es menor al nodo padre
            //el nodo se ordenara en la parte izquierda
            else if (nodo.Llave < NodoPadre.Llave)
            {

                //debemos seleccionar la rama derecha
                if (NodoPadre.LigaIzquierda == null)
                {
                    //Asigna posiciones especificas para que se muestren los nodos
                    nodo.PosX = NodoPadre.PosX - 20;
                    nodo.PosY = NodoPadre.PosY + 3;
                    NodoPadre.LigaIzquierda = nodo;
                    grado2 = true;

                }
                else
                {
                    //Poblado recursivo 
                    poblar(NodoPadre.LigaIzquierda, nodo);
                }

            }

        }

        //Metodo que permite ingresar varios nodos en un solo arbol
        //Este metodo utiliza el de poblar para agregar los nodos
        public void ABB()
        {
            //Se crea el nodo que se va a ingresar
            Nodo nuevoNodo;

            string respuesta = "S";
            //Mientras la respuesta sea "S", se seguiran ingresando nodos al arbol
            while (respuesta.Equals("S"))
            {
                nuevoNodo = new Nodo();
                Console.Write("Ingrese la llave del nodo: ");
                nuevoNodo.Llave = int.Parse(Console.ReadLine());
                //Hace el llamado del nodo poblar para agregarlo al arbol
                poblar(NodoRaiz, nuevoNodo);

                Console.Write("Desea agregar otro nodo? <S/N>: ");
                respuesta = Console.ReadLine().ToUpper().Trim();
            }

            Console.Clear();
            RecorridoInOrdenGrafico(NodoRaiz);

        }

    //En esta seccion de codigo encontramos el metodo GradodeUnarbol para saber el grado del arbol ingresado, usamos una
    //concatenacion de ifs para contar u encontrar el grado del arbol.
        public void GradoDeUnArbol()
        {
            if (NodoRaiz == null)
            {
                Console.Write("El arbol esta vacio");
            }
            else
            {

                if (grado1 == true && grado2 == true)
                {
                    cantidad = 2;
                    Console.WriteLine("El grado es: " + cantidad);
                }
                else if (grado1 == true && grado2== false)
                {
                    cantidad = 1;
                    Console.WriteLine("El grado es: " + cantidad);
                }
                else if (grado1 == false && grado2 == false)
                {
                    cantidad = 1;
                    Console.WriteLine("El grado es: " + cantidad);
                }
                else
                {
                    cantidad = 0;
                    Console.WriteLine("El grado es: " + cantidad);
                }
            }
        
        }


        //Esta es la seccion de codigo que ejecuta el conteo de la altura del arbol, usamos la variable NodoRaiz mas 1 y
        //verificamos que su contenido no sea nullo, en ese caso la altura del arbol es iguala cero.
        public void AlturaArbol()
        {
            Altura = 0;
            AlturaArbol(NodoRaiz, 1);
            Console.WriteLine("La altura del arbol es: " + Altura);
        }

        private void AlturaArbol(Nodo altura, int nivel)
        {
            if (altura != null)
            {
                AlturaArbol(altura.LigaIzquierda, nivel + 1);
                if (nivel > Altura)
                {
                    Altura = nivel;
                }
                AlturaArbol(altura.LigaDerecha, nivel + 1);
            }
        }

        //SE VALIDA SI ES IGUAL O NO Y SE VALIDA QUE LA INFORMACION QUE TIENE SEA DISTINTA
        public bool Distintos(Nodo A, Nodo B)
        {
            if (A!=null && B!=null)
            {
                return Distintos(A.LigaIzquierda, B.LigaIzquierda) && Distintos(A.LigaDerecha, B.LigaDerecha);
            }
            else
            {
                return A == B;
            }
        }
        //CAMPO LLAVE SE VALIDA SI ES IGUAL O NO Y SE VALIDA QUE LA INFORMACION QUE TIENE SEA DIFERENTE
        public bool Similares(Nodo A, Nodo B)
        {
            if (A!=null && B!=null && A.Llave != B.Llave)
            {
                return Similares(A.LigaIzquierda, B.LigaIzquierda) && Similares(A.LigaDerecha, B.LigaDerecha);
            }
            else
            {
                return A == B;
            }
        }
        
    }
}
