/*
 * Created by SharpDevelop.
 * User: Familia
 * Date: 16/11/2020
 * Time: 03:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System;
 using System.Collections;

 namespace proy
 {
	/// <summary>
	/// Description of Estudio.
	/// </summary>
  class Estudio
  {

    private string Nombre;
    private ArrayList ListaExpediente;
    private Abogado[] Listabogados;
    private int CantidadExpe, CantidadAbog;

    public Estudio(string nombre)
    {
        Nombre = nombre;
        ListaExpediente = new ArrayList();
        Listabogados = new Abogado[5];
        CantidadExpe = 0;
        CantidadAbog = 0;

    }

    public string Pro_Nombre { set { Nombre = value; } get { return Nombre; } }


    public void AgregarExpediente(Expediente unExp)
    {
        ListaExpediente.Add(unExp);
        CantidadExpe += 1;
    }
    public void EliminarExpediente(Expediente unExp)
    {
        ListaExpediente.Remove(unExp);
        CantidadExpe -= 1;
    }
    public int CantantidadExpediente()
    {
        return CantidadExpe;
    }
    public bool ExisteExpediente(int unExp)
    {
        foreach (Expediente elem in ListaExpediente)
        if (elem.Pro_NroExpediente == unExp)
        return true;
        return false;
    }
            /*public int VerExpediente(int i)
            {
                return ListaExpediente[i];
                }*/
                public ArrayList TodosExpedientes()
                {
                    return ListaExpediente;
                }


                public void AgregarAbogado(Abogado unAbog)
                {
                   Listabogados[CantidadAbog] = unAbog;
                   CantidadAbog++;
               }
               public void EliminarAbogado(Abogado unAbog)
               {
                int pos = Array.IndexOf(Listabogados, unAbog);
                foreach(Expediente e in Listabogados[pos].ExpedientesAsignados){
                	foreach(Expediente exp in ListaExpediente){
                		if(exp == e){
                			exp.Pro_AbogadoAcargo = "";
                		}
                	}
                }
                for (int i = pos-1; i < 4; i++) {
            Listabogados[i] = Listabogados[i + 1];
         }
                CantidadAbog -= 1;
            }
            /*public bool ExisteAbogado(Abogado unAbog)
            { }*/
            public int TotalAbogados()
            {
                return CantidadAbog;
            }
            public Abogado VerAbogado(int j)
            {
                return Listabogados[j];
            }
            public Abogado[] PlantelAbogado()
            {
                return Listabogados;
            }
            public Abogado buscarAbogado(int nroA)
            {
            	return Listabogados[nroA];
            }

        }
    }
