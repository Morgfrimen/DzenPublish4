using System;

namespace CSharpLib
{
	public sealed class MonitorTemperature
	{
		private Temperature.Temperature.Temperatyre Temperatures { get; set; }
		private TemperatyreStruct.Struct.ITemperatyre temperatyre1;

		public MonitorTemperature()
		{
			EventBroker.ChangeTemperatyreCelsia += EventBroker_ChangeTemperatyreCelsia;
			EventBroker.ChangeTemperatyreFaringete += EventBroker_ChangeTemperatyreFaringete;
			EventBroker.ChangeTemperatyreKelvin += EventBroker_ChangeTemperatyreKelvin;
		}

		private void EventBroker_ChangeTemperatyreKelvin(float obj)
		{
			temperatyre1 = new TemperatyreStruct.Struct.K(obj);
			CallPrintEvent();
		}

		private void EventBroker_ChangeTemperatyreFaringete(float obj)
		{
			temperatyre1 = new TemperatyreStruct.Struct.F(obj);
			CallPrintEvent();
		}

		private void EventBroker_ChangeTemperatyreCelsia(float obj)
		{
			temperatyre1 = new TemperatyreStruct.Struct.C(obj);
			CallPrintEvent();
		}

		private void CallPrintEvent()
		{
			Temperatures ??= new Temperature.Temperature.Temperatyre(temperatyre1);
			EventArgsMonitorTemperature eventInfo = new EventArgsMonitorTemperature(Temperatures);
			PrintTemperatyreCelsia?.Invoke(this, eventInfo);
		}

		public event Action<object, EventArgsMonitorTemperature> PrintTemperatyreCelsia;
	}
}
