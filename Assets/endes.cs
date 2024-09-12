using UnityEngine;

public class endes : MonoBehaviour
{
    public GameObject[] objects;

    // Function to toggle the active state of all objects in the array
    public void ToggleObjects()
    {
        if (objects != null)
        {
            foreach (GameObject obj in objects)
            {
                if (obj != null)
                {
                    obj.SetActive(!obj.activeSelf);
                }
            }
        }
    }
}
