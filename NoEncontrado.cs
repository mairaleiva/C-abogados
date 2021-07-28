/*
 * Created by SharpDevelop.
 * User: Familia
 * Date: 16/11/2020
 * Time: 05:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System;

 namespace proy
 {
	/// <summary>
	/// Description of NoEncontrado.
	/// </summary>
 	public class NoEncontrado:Exception
 	{
 		public NoEncontrado(string txt)
 		{
 			Console.WriteLine(txt+" no encontrado");
 			return;
 		}
 	}
 }
