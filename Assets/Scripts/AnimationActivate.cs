using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator playerAnimator; // Référence à l'Animator du joueur
    public string boolParameterName = "Animation"; // Nom du paramètre booléen

    private bool isPlayerInZone = false; // Indique si le joueur est dans la zone

    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet entrant a le tag "Player"
        if (other.CompareTag("Player"))
        {
            isPlayerInZone = true;
            playerAnimator.SetBool(boolParameterName, true); // Active l'animation
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Désactive le booléen quand le joueur quitte la zone
        if (other.CompareTag("Player"))
        {
            isPlayerInZone = false;
            playerAnimator.SetBool(boolParameterName, false); // Désactive l'animation
        }
    }

    private void Update()
    {
        // Si le joueur n'est pas en zone, arrête l'animation
        if (!isPlayerInZone)
        {
            playerAnimator.SetBool(boolParameterName, false);
        }
    }
}