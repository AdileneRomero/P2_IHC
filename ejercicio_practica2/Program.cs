namespace practica2
{
   

    class main{  //clase que contiene la funcion principal

        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Numero: ");            //se imprime el mensaje 
            int x = Convert.ToInt32(Console.ReadLine());    //se guarda el valor

            solucion s1 = new solucion(x);    //se intancia el objeto de la clase solucion, recibe un numero entero 
            s1.dividirValores();     //se invocan los metodos de la clase solucion
            s1.buscarIndices();
        }
    }

    class solucion{  //clase solucion

        private   int [] num = new int [] {9,0,8,1,7,2,6,3,5,4,10,11,12};  //array de enteros para obtener los indices
        private int valor1 = 0;    
        private int valor2 = 0;  //declaracion de variables 
        private int x=0;

        public solucion(int x){  //el constructor de la clase recibe el numero entero
            this.x = x;
        }

      
        //getters y setters de las variables
        public int getValor1() {
        return valor1;
        }

        public void setValor1(int valor1) {
        this.valor1 = valor1;
        }

        public int getValor2() {
        return valor2;
        }

        public void setValor2(int valor2) {
        this.valor2 = valor2;
        }

        public int getX() {
        return x;
        }

        public void setX(int x) {
        this.x = x;
        }



        //funcion para dividir el valor de x en 2 partes
        public void dividirValores(){
            Random numRandon = new Random();  //se intancia la clase randon
            int aux = numRandon.Next(0,4);    //se genera un numero aleatorio entre 1-4  en aux

            if(getX() > 5){    //si x es mayor que se almacenan los siguentes valores en valor1 y valor2
                setValor1(getX()-aux); //valor x = x-aux
                setValor2(aux);  //default valor2 = aux
            }else{             //si es mayor que  5, se aplican estas instrucciones
                setValor1(getX());//default valor1 = x
                setValor2(0);  //valor 2 =0
            }

            
        }


        //funcion para buscar en array un numero igual al valor
        public void buscarIndices(){
            System.Console.WriteLine("Valores del array");
            for(int i = 0; i< num.Length; i++){
                System.Console.WriteLine("posicion["+i+"]: "+num[i]);   //se imprime el contenido del array num
            }

            System.Console.WriteLine("\n"); //imprime un salto de linea
            for(int i = 0; i< num.Length; i++){  //for para encontrar en array num el indice que contiene un valor = valor1
                if(num[i] == getValor1()){
                    System.Console.WriteLine("Valor 1 en posicion["+i+"]: ");  //se imprime mesaje + indice
                }
            }

           for(int i = 0; i< num.Length; i++){   //for para encontrar en array num el indice que contiene un valor = valor2
                if(num[i] == getValor2()){
                    System.Console.WriteLine("Valor 2 en posicion["+i+"]: "); //se imprime mesaje + indice
                }
            }
            System.Console.WriteLine("\n");//imprime un salto de linea
        }
    }
}
