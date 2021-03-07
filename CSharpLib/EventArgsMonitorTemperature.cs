using System;

using temp = Temperature.Temperature;
using tempStruct = TemperatyreStruct.Struct;

namespace CSharpLib
{
	public sealed class EventArgsMonitorTemperature : EventArgs
	{
		internal EventArgsMonitorTemperature(temp.Temperatyre temperatyreSctruct)
		{
			tempStruct.ITemperatyre structTemp = temperatyreSctruct.value;
			switch (structTemp)
			{
				case tempStruct.C:
					temp.IConvertable<tempStruct.C> convertableC = temperatyreSctruct;
					SetValue(convertableC.ToCelsia().value, convertableC.ToFaringete().value, convertableC.ToKelvin().value);
					break;
				case tempStruct.F:
					temp.IConvertable<tempStruct.F> convertableF = temperatyreSctruct;
					SetValue(convertableF.ToCelsia().value, convertableF.ToFaringete().value, convertableF.ToKelvin().value);
					break;
				case tempStruct.K:
					temp.IConvertable<tempStruct.K> convertableK = temperatyreSctruct;
					SetValue(convertableK.ToCelsia().value, convertableK.ToFaringete().value, convertableK.ToKelvin().value);
					break;
				default:
					break;
			}
		}

		private void SetValue(float celsia, float faringete, float kelvin)
		{
			Celsia = celsia;
			Faringete = faringete;
			Kelvin = kelvin;
		}

		public float Celsia { get; private set; }
		public float Faringete { get; private set; }
		public float Kelvin { get; private set; }


	}
}
