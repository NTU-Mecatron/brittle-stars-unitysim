using System;
using UnityEngine;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Randomizers;
using UnityEngine.Perception.Randomization.Samplers;

// Add this Component to any GameObject that you would like to be randomized. This class must have an identical name to
// the .cs file it is defined in.

[RequireComponent(typeof(Light))]
[Serializable]
[AddRandomizerMenu("My Light Randomizer")]
public class MyLightRandomzier : Randomizer
{
    // Sample FloatParameter that can generate random floats in the [0,360) range. The range can be modified using the
    // Inspector UI of the Randomizer.
    public FloatParameter lightIntensity = new()
    {
        value = new UniformSampler(0, 1)
    };

    public FloatParameter temperature = new()
    {
        value = new UniformSampler(3000, 16000)
    };

    protected override void OnIterationStart()
    {
        var tags = tagManager.Query<MyLightRandomizerTag>();
        foreach (var tag in tags)
        {
            var tagLight = tag.GetComponent<Light>();
            tagLight.intensity = lightIntensity.Sample();
            tagLight.colorTemperature = temperature.Sample();
        }
    }   
}
