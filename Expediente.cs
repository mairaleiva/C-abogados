/*
 * Created by SharpDevelop.
 * User: Familia
 * Date: 16/11/2020
 * Time: 03:26 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System;

 namespace proy
 {
	/// <summary>
	/// Description of Expediente.
	/// </summary>
  class Expediente
  {
    private int NroExpediente;
    private string TipoExpediente, AbogadoAcargo;
    private DateTime fechaPresentacion;
    private bool Estado;
    private string nomtitular;


    public Expediente(int nro, string tipo, bool estado, string nomti,string abog, DateTime fecha)
    {
        NroExpediente = nro;
        TipoExpediente = tipo;
        Estado = estado;
        AbogadoAcargo = abog;
        nomtitular = nomti;
        fechaPresentacion = fecha;
    }

    public int Pro_NroExpediente { set { NroExpediente = value; } get { return NroExpediente; } }
    public string Pro_TipoExpediene { set { TipoExpediente = value; } get { return TipoExpediente; } }
    public bool Pro_Estado { set { Estado = value; } get { return Estado; } }
    public string Pro_AbogadoAcargo { set { AbogadoAcargo = value; } get { return AbogadoAcargo; } }
    public DateTime Pro_FechaPresentacio { set { fechaPresentacion = value; } get { return fechaPresentacion; } }
	public string Nomtitular { set { nomtitular = value; } get { return nomtitular; } }

}

}
