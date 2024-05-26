using System.IO.Pipes;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "24246969", modelo: "Tijolão", imei: "11112222", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");    




// Criando iPhone
Smartphone iPhone = new Iphone(numero: "24246969", modelo: "Tijolão", imei: "11112222", memoria: 256);
iPhone.Ligar();
iPhone.InstalarAplicativo("Nubank");