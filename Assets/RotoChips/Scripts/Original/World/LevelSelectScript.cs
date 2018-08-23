using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour {
    public int LevelId;                     // a level id assigned to this spike
    public Color SpikeEmissionColor;        // normal texture emission color
    public Color ActiveEmissionColor;       // active (pressed) spike emission color changes from SpikeEmissionColor to ActiveEmissionColor
    public Color SelectedEmissionColor;     // selected spike emission color oscillates between SpikeEmissionColor and SelectedEmissionColor
    public Color DisabledColor;             // disabled spike color
	public Color DisabledIconColor;			// disabled icon color (above the spike)
    public int deltaSteps;                  // actually, a period of color oscillation in selected state

    Color deltaEmissionColor;
    Color currentSelectedEmissionColor;

    bool isButtonSelected;                  // internal flag of a selected/normal spike
    bool isButtonEnabled;                   // internal flag of an enabled/disabled spike
    int cStep;                              // current color change step
    int cDelta;                             // a step increment: +1 - moves from one color to another, -1 - moves back

    MeshRenderer mr;                        // a link to MeshRenderer component
    public GameObject listener;             // a listener object (it recieves messages when an active spike has flashed)

	// this method sets the MeshRenderer reference
    void initmr()
    {
        if (mr == null)
        {
            mr = gameObject.GetComponent<MeshRenderer>();
        }
    }

    public void setEmission(Color normal, Color selected, Color active)
    {
        SpikeEmissionColor = normal;
        SelectedEmissionColor = selected;
        ActiveEmissionColor = active;
    }

    public void setHeight(float size)
    {
        gameObject.GetComponent<Transform>().localScale = new Vector3(size, size, size);
        //gameObject.transform.position -= new Vector3(0, 0, zHeight > 0f ? zHeight : size);
    }

    void setNormalColor(Color color)
    {
        mr.materials[0].SetColor("_Color", color);
    }

    void setEmissionColor(Color color)
    {
        mr.materials[0].SetColor("_EmissionColor", color);
    }

	void setIconColor(Color color) {
		gameObject.GetComponentInChildren<SpriteRenderer> ().color = color;
	}

    public void setEnabled(bool to)
    {
        initmr();
        isButtonEnabled = to;
        if (to)
        {
            setSelected(isButtonSelected);
        } else
        {
            setNormalColor(DisabledColor);
            setEmissionColor(SpikeEmissionColor);
			setIconColor (DisabledIconColor);
        }
    }

    public void setSelected(bool to)
    {
        initmr();
        if (isButtonEnabled)
        {
            isButtonSelected = to;
            if (to)
            {
                currentSelectedEmissionColor = SpikeEmissionColor;                  // texture emission color start value
                deltaEmissionColor = (SelectedEmissionColor - SpikeEmissionColor) / deltaSteps; // this is a 'delta' emission color
                cDelta = 1;
                cStep = 0;
            }
            setEmissionColor(SpikeEmissionColor);
        }
    }

    IEnumerator flash()
    {
        bool oldSelected = isButtonSelected;
        setSelected(false);
        currentSelectedEmissionColor = SpikeEmissionColor;
        deltaEmissionColor = (ActiveEmissionColor - SpikeEmissionColor) / deltaSteps;
        for ( int i = 0; i <= deltaSteps; i++)
        {
            setEmissionColor(currentSelectedEmissionColor);
            yield return new WaitForFixedUpdate();
            currentSelectedEmissionColor = deltaEmissionColor;
        }
        setSelected(oldSelected);
		if (listener != null) {
			listener.SendMessage("selectorFlashed");
		}
    }

    public void flashActive()
    {
        StartCoroutine(flash());
    }

    // selected spike color oscillates from SpikeColor to SelectedColor and
    // selected spike emission color oscillates between SpikeEmissionColor and SelectedEmissionColor
    // we choose to do this in FixedUpdate method
    void FixedUpdate()
    {
        if (isButtonSelected)   // only selected button changes its color
        {
            if (cDelta > 0)
            {
                currentSelectedEmissionColor += deltaEmissionColor;
            }
            else
            {
                currentSelectedEmissionColor -= deltaEmissionColor;
            }
            cStep += cDelta;
            if (cDelta > 0 && cStep > deltaSteps)
            {
                cStep = deltaSteps;
                cDelta = -1;
                currentSelectedEmissionColor = SelectedEmissionColor;
            } else if (cDelta < 0 && cStep < 0)
            {
                cStep = 0;
                cDelta = 1;
                currentSelectedEmissionColor = SpikeEmissionColor;
            }
            setEmissionColor(currentSelectedEmissionColor);
        }
    }
}
