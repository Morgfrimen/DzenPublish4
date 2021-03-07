using System;

namespace CSharpLib
{
	public static class EventBroker
	{
		internal static event Action<float> ChangeTemperatyreCelsia;
		internal static event Action<float> ChangeTemperatyreFaringete;
		internal static event Action<float> ChangeTemperatyreKelvin;

		public static void SetCelsia(float value)
		{
			ChangeTemperatyreCelsia?.Invoke(value);
		}

		public static void SetFaringete(float value)
		{
			ChangeTemperatyreFaringete?.Invoke(value);
		}

		public static void SetKelvin(float value)
		{
			ChangeTemperatyreKelvin?.Invoke(value);
		}
	}
}
