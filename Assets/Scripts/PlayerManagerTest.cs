using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManagerTest : MonoBehaviour
{    
    public PlayerManager playerManager;
    public TMP_InputField playerNameInput;
    
    // TODO: get the PlayersList here by making a public function that
    // returns it. Then use the List to check if a player with a certain
    // name has already been added, and if so add another name    
    public void AddTestPlayer() {
        
        string name = playerNameInput.text;
        playerManager.AddPlayer(name);
        playerNameInput.text = "";        
    }

    public void RemoveTestPlayer() {        
        playerManager.RemovePlayer();
    }
}
