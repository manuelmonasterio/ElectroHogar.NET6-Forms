using System;

public class AltaProveedor
{
	public void DarAltaProveedor()
	{
        string inputNombre;
        string inputApellido;
        string inputDireccion;
        string inputTelefono;
        string inputEmail;
        string inputCuit;

        do
        {
            Console.Write("Ingresar el nombre: ");
            inputNombre = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputNombre, "Nombre");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar el apellido: ");
            inputApellido = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputApellido, "Apellido");
        } while (flag == false);


        do
        {
            Console.Write("Ingresar un mail: ");
            inputEmail = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputEmail, "Email");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar su cuit: ");
            inputCuit = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarNumero(inputCuit, ref cuit, "CUIT");
        } while (flag == false);
    }
}
