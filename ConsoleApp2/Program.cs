using CSharpLib;

using System;

namespace ConsoleApp2
{
	internal class Program
	{
		private static readonly MonitorTemperature monitorTemperature = new();

		static Program()
		{
			monitorTemperature.PrintTemperatyreCelsia += MonitorTemperature_PrintTemperatyreCelsia;
		}

		private static void Main(string[] args)
		{
			Console.WriteLine("Тест температур");
			Console.WriteLine("Запись температуры кипения в цельсиях");
			EventBroker.SetCelsia(100);
			Console.WriteLine("Запись в Фарингейтах");
			EventBroker.SetFaringete(212);
			Console.WriteLine("Запись в Кельвинах");
			EventBroker.SetKelvin(373);
		}

		private static void MonitorTemperature_PrintTemperatyreCelsia(object arg1, EventArgsMonitorTemperature arg2)
		{
			Console.WriteLine($"Изменилось значение температур! ({arg1})");
			Console.WriteLine($"Цельсия: {arg2.Celsia:f2} , Фарингейн: {arg2.Faringete:f2}, Кельвин: {arg2.Kelvin:f2}");
		}
	}
}
