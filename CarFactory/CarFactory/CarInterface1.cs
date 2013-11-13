using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
	public interface ICarInterface1
	{
		// Using a key, a button
		void StartEngine();

		void StopEngine();

		// Using a pedal or manual clutch (for handicaped drivers)
		void Accelerate();

		void Brake();

		void ChangeGear();

	}
}
