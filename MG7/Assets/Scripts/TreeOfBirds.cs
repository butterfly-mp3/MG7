using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    public Bird[] _birds;
    public Transform _colobus;
    [SerializeField] private int _interactionDistance;

    private void Update()
    {
        for (int i = 0; i < _birds.Length; i++)
        {
            if (Vector3.Distance(_birds[i].transform.position, _colobus.position) < _interactionDistance)
            {
                _birds[i].gameObject.SetActive(true);
            }
        }

    }

}