using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPeta : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PanelFalse;
    public GameObject PanelFalse1;
    public GameObject PanelFalse2;
    public GameObject PanelFalse3;
    public GameObject PanelFalse4;
    public GameObject PanelFalse5;
	public void OpenPanel()
    {
	if(Panel != null)
	{
	Panel.SetActive(true);
	PanelFalse.SetActive(false);
	PanelFalse1.SetActive(false);
	PanelFalse2.SetActive(false);
	PanelFalse3.SetActive(false);
	PanelFalse4.SetActive(false);
	PanelFalse5.SetActive(false);
	}
    }
}
