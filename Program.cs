
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
            string opcion1 = "";
            string nom = "";
            string nombreTitular = "";
            string abogadoacargo = "";
            string tipoexp = "";
            
            DateTime fecha1 = new DateTime(2000,10,10),fecha2=new DateTime(2000,10,10);
            DateTime mayor,menor;
            
            int opcion2 = 1;
            int indexabogado = 0;
                        
            bool encontrado = false;//variable que determina si se encontro abogado al agregar expediente
            bool chequeado = false;//variable que verifica si todos los datos son validos al agregar un expediente
            
        
            Abogado abogado;

            Console.Write("Ingrese un abogado: \n ");
            while (opcion1 != "no")
            {
                Console.Write("Nombre del abogado: ");
                string nombre = Console.ReadLine();

                Console.Write("Número de dni: ");
                int dni = int.Parse(Console.ReadLine());

                Console.Write("Especialidad: ");
                string especialidad = Console.ReadLine();
                
                Console.Write("Número : ");
                int nro = int.Parse(Console.ReadLine());

                
                abogado = new Abogado(nombre, dni, especialidad, nro);
                estudio.AgregarAbogado(abogado);

                Console.Write("Desea ingresar otro abogado? (si/no): ");
                opcion = Console.ReadLine();
                if (opcion == "no") {
                	break;
                }

            }
           
            
            while ( true)
            	try{
            	
            {
            		Console.Clear();
            	Console.Write("1. Agregar un expediente al estudio.\n2. Modificar estado de un expediente.\n3. Eliminar expediente\n4. Buscar Expediente por tipo\n5. Buscar expedientes entre dos fechas\n6. agregar abogado\nOpción: ");
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

                        expediente = new Expediente(numero, tipo, estado, nombreTitular, abogadoacargo, fecha);
                        estudio.AgregarExpediente(expediente);
                        estudio.buscarAbogado(indexabogado).AgregarExpediente(expediente);
     

                        break;
                    case 2:
                        
                        Console.Write("Ingrese el abogado a cargo: ");
                        string abogacargo = Console.ReadLine();
                        
                        
                        
                        Console.Write("Ingrese el número de expediente: ");
                        int nro = int.Parse(Console.ReadLine());
                        
                        ArrayList listaExpediente = new ArrayList();
                        listaExpediente = estudio.TodosExpedientes();
                        for (int i = 0; i <= estudio.TotalAbogados()-1; i++) {
                        	nom = estudio.buscarAbogado(i).Pro_Nombre;
                        	
                        	if (abogadoacargo == nom) {
                        		
                        		
                        		foreach (Expediente element in listaExpediente) {
                        			if (element.Pro_NroExpediente == nro) {
                        				element.Pro_Estado = !element.Pro_Estado;
                        				Console.WriteLine("expediente modificado");
                        				Console.ReadKey();
                        				
                        			} 
                        			else {Console.Write("El número de expediente no existe");
                        				Console.ReadKey();}
                        			
                        		}
                        	}
                        	
                        }

                        break;

                    case 3:
                        if (estudio.CantantidadExpediente() <= 0){
                        	Console.WriteLine("No existe ningun expediente");
                        	Console.ReadKey();
                        }else{
                        Console.Write("Indique el nro de expediente a eliminar: ");
                        int nroE = int.Parse(Console.ReadLine());
                        
                        ArrayList conjexpe = new ArrayList();
                        conjexpe = estudio.TodosExpedientes();
                        Console.WriteLine("aca llegue");
                        foreach (Expediente element in conjexpe) {
                            if (element.Pro_NroExpediente==nroE)
							{
					        	estudio.EliminarExpediente(element);
					        	Console.WriteLine("expediente eliminado");
					        	Console.ReadLine();
					        	break;
					       
                            }
                            Console.WriteLine("El expediente no existe. ");
                            Console.ReadKey();
                        }   

                }
                        break;
                    case 4:
                        Console.WriteLine("ingrese el tipo de expediente:");
                        tipoexp = Console.ReadLine();
                        Console.WriteLine("listado de expedientes por tipo: "+tipoexp);
                        
                        foreach(Expediente e in estudio.TodosExpedientes()){
                        	if (e.Pro_TipoExpediene == "audiencia"){
                        		Console.WriteLine("numero de expediente: "+ e.Pro_NroExpediente.ToString() +" Titular: "+e.Nomtitular +" Abogado a cargo: " + e.Pro_AbogadoAcargo +"\n");
                        	}
                        }
                        Console.ReadKey();
                        
                        
                        break;
                    case 5:
                        
                        Console.WriteLine("ingrese entre que fechas se debe buscar:\n");
                        Console.WriteLine("fecha 1:");
                        fecha1 = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("fecha 2:");
                        fecha2 = DateTime.Parse(Console.ReadLine());
                        
                        mayor = fecha1;
                        menor = fecha2;
                        
                        if(DateTime.Compare(fecha1,fecha2)<0){
                        	menor = fecha1;
                        	mayor= fecha2;
                        }
                        
                        Console.WriteLine("Casos entre las fechas solicitadas:");
                        
                        foreach(Expediente e in estudio.TodosExpedientes()){
                        	if(DateTime.Compare(e.Pro_FechaPresentacio,menor)>=0 && DateTime.Compare(e.Pro_FechaPresentacio,mayor)<=0){
                        	Console.WriteLine("numero de expediente: "+ e.Pro_NroExpediente.ToString() +" Titular: "+e.Nomtitular +" Abogado a cargo: " + e.Pro_AbogadoAcargo +"\n");
                        	}
                        
                        }
                        Console.ReadKey();
                        
                        
                        

                        break;
                    case 6:
                         
            			

                			
                         break;
                      
                }
                //Console.Write("1. Agregar un expediente al estudio.\n2. Modificar estado de un expediente.\n3. Eliminar expediente\n4. Listado de expediente con el abogado a cargo\n5. Listado de expediente de un abogado\n6. agregar abogado\nOpción: ");
            	//opcion2 = int.Parse(Console.ReadLine());               

                Console.Clear();
            }
            }catch(Exception){
            	Console.WriteLine("ha ocurrido un error");
            	Console.ReadKey();
            }

        }       
        
    }

	}

