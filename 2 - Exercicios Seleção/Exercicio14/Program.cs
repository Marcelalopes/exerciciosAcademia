/* 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos).
*/

double tam_arq, velocidade, tempo;
Console.WriteLine("Tamanho de um arquivo para download (em MB): ");
tam_arq = double.Parse(Console.ReadLine());
Console.WriteLine("Velocidade de um link de internet (em Mbps): ");
velocidade = double.Parse(Console.ReadLine());
tempo = (tam_arq * velocidade)/60;

Console.WriteLine("Tempo aproximado de download do arquivo: "+tempo);
