// See https://aka.ms/new-console-template for more information

int producto;
int cantidad;
int total=0;
int i=1;
do {
  Console.WriteLine("i = "+i);
    i++;

Console.WriteLine("BIENVENIDO A CANNABISHOP");
Console.WriteLine("Tenemos los mejores Krippys que estan actualmente mas movido en el mercado asi que aprovecha nuestras ventas ya que son limitadas ya que es una hierba exclusiva");
Console.WriteLine("Que Producto desea comprar?");
    Console.WriteLine("1:Krippy Kush $15.000");
        Console.WriteLine("2:Krippy $10.000 ");
            Console.WriteLine("3:Krippy Red $7.000");
                Console.WriteLine("4:Pangola Kush $5.000");   
                    Console.WriteLine("5: SALIR Y NO FUMAR NADA");
                producto = Convert.ToInt32 (Console.ReadLine());
               
            Console.WriteLine ("Ingrese la cantidad de producto");
		cantidad =Convert.ToInt32 (Console.ReadLine());
    if (producto==1) {
Console.WriteLine("Krippy Kush");
total=cantidad*15000;
}
if (producto==2){
                    Console.WriteLine("Krippy");
			        total=cantidad*10000;
                }
		else
			if  (producto==2){
				Console.WriteLine("Krippy Red");
				total=cantidad*7000;
            }
			else 
            if  (producto==3) {			
            Console.WriteLine("Pangola Kus");
					total=cantidad*5000;
            }
	Console.WriteLine("Producto comprado: "+producto);
	Console.WriteLine("Cantidad de producto: "+cantidad);
	Console.WriteLine("El total a pagar es: $ "+total);
 } while (i < 4);

