using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryUI : MonoBehaviour {

    public Text text;
    public GameObject m_player;





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        string textToOutput = @"Key X%d
Axe X%d
Artefact X%d
";
        Player player = m_player.GetComponent<Player>();
        string output = string.Format(textToOutput, player.getNumberObjectiveInstances(Player.Objectives.KeyItem), 
            player.getNumberObjectiveInstances(Player.Objectives.AxeItem), 
            player.getNumberObjectiveInstances(Player.Objectives.ArtefactItem));
        text.text = output;

    }



}
