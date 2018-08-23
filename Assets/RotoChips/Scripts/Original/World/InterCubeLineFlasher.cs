using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterCubeLineFlasher : MonoBehaviour {

	public Color maxColor;
	public int totalGlowTicks = 20;
	public float lowTransparency = 0.2f;
	float currentTransparency;
	float minTransparency;
	float deltaTransparency;
	LineRenderer lr;
	float prevTime;
	bool descending;
	int glowTicks;

	void setLineTransparency()
	{
		Color c = maxColor;
		c.a = currentTransparency;
		lr.startColor = c;
		lr.endColor = c;
	}

	// init loop values
	void setDeltaSteps()
	{
		currentTransparency = 1f;
		minTransparency = (1f - lowTransparency) * Random.value + lowTransparency;
		deltaTransparency = -(1f - minTransparency) / totalGlowTicks;
		descending = true;
		glowTicks = 0;
	}

	// Use this for initialization
	public void initLine (Color c) {
		maxColor = c;
		lr = GetComponent<LineRenderer>();
		setDeltaSteps();
		setLineTransparency();
	}

	// Update is called once per frame
	void Update () {
		setLineTransparency();
		glowTicks++;
		if (glowTicks < totalGlowTicks)
		{
			currentTransparency += deltaTransparency;
		}
		else
		{
			if (descending)
			{
				deltaTransparency = -deltaTransparency;
				currentTransparency = minTransparency;
				descending = false;
				glowTicks = 0;
			}
			else
			{
				setDeltaSteps();
			}
		}
	}
}
