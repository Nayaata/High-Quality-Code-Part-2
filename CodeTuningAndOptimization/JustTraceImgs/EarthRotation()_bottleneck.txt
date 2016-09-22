The bottleneck was found in OrbitsCalculator class in EarthRotation() method.
The problem was solved correctly.
---------------------------------------

OLd method
---------------
private void EarthRotation()
        {
			for (decimal step = 0; step <= 360; step+=0.00005m)
			{
				EarthRotationAngle = ((double)step) * Days / EarthRotationPeriod;
			}
            Update("EarthRotationAngle");
        }


New method with corrections
---------------------------------
 private void EarthRotation()
        {

            EarthRotationAngle = EarthYear * Days / EarthRotationPeriod;
            Update("EarthRotationAngle");
        }