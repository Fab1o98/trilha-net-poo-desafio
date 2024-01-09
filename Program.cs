using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia X4:"); 
Smartphone nokia = new Nokia(numero : "(17)989456512", imei : "111111111", modelo: "X4", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook"); 



Console.WriteLine("\n"); 


Console.WriteLine("Iphone 13 PRO:"); 
Smartphone iphone = new Iphone(numero : "(11)912213333", imei : "0110110001", modelo: "13 PRO", memoria: 512); 
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitch"); 
