/*
 * Created by SharpDevelop.
 * User: Familia
 * Date: 16/11/2020
 * Time: 03:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System;
 using System.Collections;

 namespace proy
 {
   class Abogado
   {
    private string NombreApellido, Especialidad;
    private int Dni, CantidadExpedienteAsiganados, nro;
    private ArrayList expedientesasignados ;

    public Abogado(string nombreape, int dni, string especialidad, int nro)
    {
        NombreApellido = nombreape;
        Dni = dni;
        Especialidad = especialidad;
        CantidadExpedienteAsiganados = 0;
        expedientesasignados = new ArrayList();
        
        this.nro = nro;
    }
    public string Pro_Nombre { set { NombreApellido = value; } get { return NombreApellido; } }
    public string Pro_Especialidad { set { Especialidad = value; } get { return Especialidad; } }
    public int Pro_Dni { set { Dni = value; } get { return Dni; } }
    public int Pro_CantidadExpe { set { CantidadExpedienteAsiganados = value; } get { return expedientesasignados.Count; } }
    public int Pro_nro {set {this.nro = value;} get {return this.nro;}}
    public ArrayList ExpedientesAsignados{get{return expedientesasignados;}}

    public void AgregarExpediente(Expediente exp)
    {
       expedientesasignados.Add(exp);
       CantidadExpedienteAsiganados++;
   }
            /*public void EliminarExpediente(int nroExp)
            {



            public bool ExisteExpediente(int Expe)
            {

                }*/
                public Expediente VerExpe(int k)
                {
                   return (Expediente)expedientesasignados[k];
               }
               public void TodosExpedientes()
               {
                   
                   Console.WriteLine("Expedientes Asignados:");
                   foreach(Expediente exp in expedientesasignados){
                      Console.WriteLine(exp.Pro_NroExpediente);
                      
                  }
              }


          }
          
      }
