using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator playerAnimator; // R�f�rence � l'Animator du joueur
    public string boolParameterName = "Animation"; // Nom du param�tre bool�en

    private bool isPlayerInZone = false; // Indique si le joueur est dans la zone

    private void OnTriggerEnter(Collider other)
    {
        // V�rifie si l'objet entrant a le tag "Player"
        if (other.CompareTag("Player"))
        {
            isPlayerInZone = true;
            playerAnimator.SetBool(boolParameterName, true); // Active l'animation
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // D�sactive le bool�en quand le joueur quitte la zone
        if (other.CompareTag("Player"))
        {
            isPlayerInZone = false;
            playerAnimator.SetBool(boolParameterName, false); // D�sactive l'animation
        }
    }

    private void Update()
    {
        // Si le joueur n'est pas en zone, arr�te l'animation
        if (!isPlayerInZone)
        {
            playerAnimator.SetBool(boolParameterName, false);
        }
    }
}