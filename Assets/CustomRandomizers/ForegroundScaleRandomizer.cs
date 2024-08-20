using System;
using UnityEngine;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Randomizers;
using UnityEngine.Perception.Randomization.Samplers;

// Add this Component to any GameObject that you would like to be randomized. This class must have an identical name to
// the .cs file it is defined in.

[Serializable]
[AddRandomizerMenu("Foreground Scale Randomizer")]
public class ForegroundScaleRandomizer : Randomizer
{
    // Sample FloatParameter that can generate random floats in the [0,360) range. The range can be modified using the
    // Inspector UI of the Randomizer.
    public Vector3Parameter scale = new()
    {
        x = new UniformSampler(0, 360),
        y = new UniformSampler(0, 360),
        z = new UniformSampler(0, 360)
    };

    protected override void OnIterationStart()
    {
        var tags = tagManager.Query<ForegroundScaleRandomizerTag>();
        foreach (var tag in tags)
            tag.transform.localScale = scale.Sample();
    }
}
