
using System;
using System.Collections;

namespace proy
{
	class Program
    {
        static void Main(string[] args)
        {
            Estudio estudio = new Estudio("Estudio de abogados");
            Expediente expediente;
            string opcion = "";
            string nom = "";
            string nombreTitular = "";
            string abogadoacargo = "";
            
            int opcion2 = 1;
            int indexabogado = 0;
            
            bool encontrado = false;
            bool chequeado = false;
            
            
            
            Console.WriteLine("Para comenzar ingrese un abogado:");
            while (opcion != "no") {
               
               Console.Write("Nombre del abogado: ");
               nom = Console.ReadLine();
               
               
               Console.Write("Especialidad :");
               string especialidad = Console.ReadLine();
               
               Console.WriteLine("Dni: ");
               int dni = int.Parse(Console.ReadLine());
               
               Console.Write("nro :");
               int nro = int.Parse(Console.ReadLine());
               
               Abogado abogado = new Abogado(nom, dni, especialidad, nro);
               estudio.AgregarAbogado(abogado);

               Console.Write("Desea ingresar otro abogado? (si/no): ");
               opcion = Console.ReadLine();
           }
           
           
           
           
           
           while (opcion2 != 0)
           {
               Console.Clear();
               Console.Write("1. Agregar un expediente al estudio.\n2. Modificar estado de un expediente.\n3. Eliminar expediente\n4. Listado de expediente con el abogado a cargo\n5. Listado de expediente de un abogado\n6. agregar abogado\nOpción: ");
               opcion2 = int.Parse(Console.ReadLine());
               switch (opcion2)
               {

                case 1:
                chequeado = false;
                
                
                while(chequeado != true){
                   encontrado = false;
                   Console.Write("Nombre del abogado a cargo: ");
                   abogadoacargo = Console.ReadLine();	
                   try{
                    for(int i=0; i < estudio.TotalAbogados(); i++ ){
                       if(abogadoacargo == estudio.buscarAbogado(i).Pro_Nombre){
                          encontrado = true;
                          if(estudio.buscarAbogado(i).Pro_CantidadExpe >= 5){
                             throw new MaximoAbogados();
                         }
                         indexabogado = i;
                     }
                 }if(encontrado !=true){
                  throw new NoEncontrado("Abogado");
                  }chequeado = true;
              }catch(MaximoAbogados){
                Console.WriteLine("Abogado ya tiene 5 expedientes elija otro");
            }catch(NoEncontrado){
                
            }
        }
        
        Console.Write("Nombre Titular: ");
        nombreTitular = Console.ReadLine();

        Console.Write("Tipo de expediente: ");
        string tipo = Console.ReadLine();

        Console.Write("Estado: ");
        bool estado = bool.Parse(Console.ReadLine());

        Console.Write("Número de expediente: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Fecha -> año, mes, día: ");
        DateTime fecha = DateTime.Parse(Console.ReadLine());

        expediente = new Expediente(numero, tipo, estado, nombreTitular, fecha);
        estudio.AgregarExpediente(expediente);
        estudio.buscarAbogado(indexabogado).AgregarExpediente(expediente);
        
        
        
        



        break;
        case 2:
        Console.Write("Indique el nro de expediente a modificar: ");
        int nroActual = int.Parse(Console.ReadLine());


        

        break;

        case 3:
        Console.Write("Indique el nro de expediente a eliminr: ");
        int nroE = int.Parse(Console.ReadLine());

        ArrayList list = new ArrayList();
        list = estudio.TodosExpedientes();





        break;
        case 4:
        Console.Write("Ingrese el tipo de expediente: ");
        string tip = Console.ReadLine();

        ArrayList lista = new ArrayList();
        lista = estudio.TodosExpedientes();
        foreach (Expediente item in lista)
        {
            if (item.Pro_TipoExpediene == tip)
            {

            }
        }
        break;
        case 5:

        break;
        case 6:
        
        while (opcion != "no") {
           
           Console.Write("Nombre del abogado: ");
           nom = Console.ReadLine();
           
           
           Console.Write("Especialidad :");
           string especialidad = Console.ReadLine();
           
           Console.WriteLine("Dni: ");
           int dni = int.Parse(Console.ReadLine());
           
           Console.Write("nro :");
           int nro = int.Parse(Console.ReadLine());
           
           Abogado abogado = new Abogado(nom, dni, especialidad, nro);
           estudio.AgregarAbogado(abogado);

           Console.Write("Desea ingresar otro abogado? (si/no): ");
           opcion = Console.ReadLine();
           } break;
           
       } 

       Console.Clear();
   }

}       

}

}

