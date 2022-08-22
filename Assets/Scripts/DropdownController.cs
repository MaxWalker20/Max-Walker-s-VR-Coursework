using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    Dropdown m_Dropdown;

    void Start()
    {
        Debug.Log("dropdown started");
        //Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate {
          Debug.Log("dropdown change detected");
          DropdownValueChanged(m_Dropdown);
        });
    }
    
    void DropdownValueChanged(Dropdown change)
    {
      Debug.Log("function called");
      ratioDecider(m_Dropdown);
      Graph graph = new Graph();
      graph.ratioNumerator = 3f;
      graph.ratioDenominator = 5f;
    }

    void ratioDecider(Dropdown change){
      Debug.Log(change.value);
    }
}
