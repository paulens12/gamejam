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
        string textToOutput = @"Key X{0}
Axe X{1}
Artefact X{2}
";
        Player player = m_player.GetComponent<Player>();
        string output = string.Format(textToOutput, player.getNumberObjectiveInstances(Player.Objectives.KeyItem), 
            player.getNumberObjectiveInstances(Player.Objectives.AxeItem), 
            player.getNumberObjectiveInstances(Player.Objectives.ArtefactItem));
        text.text = output;

    }



}
