using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOp : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PanelFalse;
	public void OpenPanel()
    {
	if(Panel != null)
	{
	Panel.SetActive(true);
	PanelFalse.SetActive(false);
	}
    }
}
