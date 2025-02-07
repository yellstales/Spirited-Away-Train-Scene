using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovementControl : MonoBehaviour
{
    enum ButtonType {StopTrain, StartTrain};

    [SerializeField] ButtonType buttonType; 
    [SerializeField] Material stopMouseDownMaterial;
    [SerializeField] Material stopMouseUpMaterial;
    [SerializeField] Material startMouseDownMaterial;
    [SerializeField] Material startMouseUpMaterial;
    [SerializeField] Animator trainMovementAnimator;
    [SerializeField] AudioSource trainMovementAudioSource;
    

    private void OnMouseDown()
    {
        if (stopMouseDownMaterial != null & buttonType == ButtonType.StopTrain) {
            trainMovementAudioSource.Stop();
            trainMovementAnimator.SetBool("StopTrain", true);
            GetComponent<MeshRenderer>().material = stopMouseDownMaterial;
        }

        if (startMouseDownMaterial != null & buttonType == ButtonType.StartTrain)
        {
            Debug.Log("hiiii");
            trainMovementAudioSource.Play();
            trainMovementAnimator.SetBool("StopTrain", false);
            GetComponent<MeshRenderer>().material = startMouseDownMaterial;
        }
    }

    private void OnMouseUp()
    {
        if (stopMouseUpMaterial != null & buttonType == ButtonType.StopTrain) {
            GetComponent<MeshRenderer>().material = stopMouseUpMaterial;
        }

        if (startMouseUpMaterial != null & buttonType == ButtonType.StartTrain)
        {
            GetComponent<MeshRenderer>().material = startMouseUpMaterial;
        }
    }
}
