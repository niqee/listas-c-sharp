List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");



Console.WriteLine("Percorrendo a lista com For");
for (int contador = 0; contador < listaString.Count; contador++) //"Count" serve como um Length. faz a mesma coisa.
{                                                                       
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]} "); 
}
//Não é preciso redimensionar o lista.


//É mais recomendável percorrer a lista com o foreach
Console.WriteLine("Percorrendo a lista com Foreach");
int contadorForeach = 0;
foreach (string item in listaString)
{
    //Console.WriteLine($"Posição N° {contadorForeach} - {listaString[contadorForeach]} ");// código mais longo
    Console.WriteLine($"Posição N° {contadorForeach} - {item}");  //jeito mais simples
    contadorForeach++;
}


/*listaString.Remove("RJ");  //Método para remover item de lista. Logo que o item é removido.
//a lista é reordenada. OBS: Uma lista trabalha internamente com um array
OBS: Em qualquer momento há a possibilidade de utilizar o método "Add" que a lista
será redimensionada automaticamente, sem necessidade de fazer como o uso de "Copy" ou
"Resize" como foi feito em array.*/
