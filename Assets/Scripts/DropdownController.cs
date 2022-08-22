using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    Dropdown m_Dropdown;

    void Start()
    {

        //Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate {

          DropdownValueChanged(m_Dropdown);
        });
    }

    //Ouput the new value of the Dropdown into Text
    void DropdownValueChanged(Dropdown change)
    {
      Graph graph = new Graph();
      graph.ratioNumerator = 3f;
      graph.ratioDenominator = 5f;
    }

    void ratioDecider(Dropdown change){

    }
}
