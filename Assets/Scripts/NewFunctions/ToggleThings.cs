using UnityEngine;

public class ToggleThings : MonoBehaviour
{
    [SerializeField] GameObject[] _thingsToToggle1;
    [SerializeField] GameObject[] _thingsToToggle2;

    public void Toggle()
    {
        if (_thingsToToggle1[0].activeSelf)
        {


            foreach (var x in _thingsToToggle1)
            {
                x.SetActive(false);
            }
            foreach (var x in _thingsToToggle2)
            {
                x.SetActive(true);
            }

        }
        else
        {
            foreach (var x in _thingsToToggle1)
            {
                x.SetActive(true);
            }
            foreach (var x in _thingsToToggle2)
            {
                x.SetActive(false);
            }
        }
    }
}
