using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public TMP_Text playerNameListText;  // UI Text component

    private List<Player> players = new List<Player>();  // To store the Player objects

    // Call this method to create a new player and add their name to the list
    public void AddPlayer(string name)
    {
        if (players.Count < 10)
        {
            Player newPlayer = new Player ( players.Count + 1, name );
            players.Add(newPlayer);
            UpdatePlayerNameList();
            Debug.Log("Player " + name + " added.");
        }
        else Debug.Log("Max players reached :)");
    }

    // Call this method to remove a player by name
    public void RemovePlayer()
    {
        if (players.Count > 0)            
        {
            players.Remove(players[players.Count - 1]);            
            UpdatePlayerNameList();
        }
    }

    private void AppendToPlayerNameList(int order, string playerName)
    {
        string orderText = order + ". ";
        playerNameListText.text += orderText + playerName + "\n";
    }

    private void UpdatePlayerNameList()
    {
        playerNameListText.text = "";

        foreach (Player player in players)
        {
            playerNameListText.text += $"{player.id}. {player.name}\n";
        }
        
    }

}
