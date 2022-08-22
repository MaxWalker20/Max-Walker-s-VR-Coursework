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
      float[] ratio = {0f, 0f};
      ratio = ratioDecider(change, ratio);
      Debug.Log(ratio[0] + " and " + ratio[1]);
      // Graph graph = new Graph();
      // graph.ratioNumerator = ratio[0];
      // graph.ratioDenominator = ratio[1];
    }

    float[] ratioDecider(Dropdown change, float[] ratio){
      Debug.Log(change.value);
      ratio[0] = 0f;
      ratio[1] = 1f;
      //https://en.wikipedia.org/wiki/Interval_(music)#Size_of_intervals_used_in_different_tuning_systems
      switch((int)change.value)
      {
        case 0:
          ratio[0] = 0f;
          ratio[1] = 1f;
          break;
        case 1:
          ratio[0] = 1f;
          ratio[1] = 1f;
          break;
        case 2:
          ratio[0] = 16f;
          ratio[1] = 15f;
          break;
        case 3:
          ratio[0] = 9f;
          ratio[1] = 8f;
          break;
        case 4:
          ratio[0] = 6f;
          ratio[1] = 5f;
          break;
        case 5:
          ratio[0] = 5f;
          ratio[1] = 4f;
          break;
        case 6:
          ratio[0] = 4f;
          ratio[1] = 3f;
          break;
        case 7:
          ratio[0] = 45f;
          ratio[1] = 32f;
          break;
        case 8:
          ratio[0] = 3f;
          ratio[1] = 2f;
          break;
        case 9:
          ratio[0] = 8f;
          ratio[1] = 5f;
          break;
        case 10:
          ratio[0] = 5f;
          ratio[1] = 3f;
          break;
        case 11:
          ratio[0] = 16f;
          ratio[1] = 9f;
          break;
        case 12:
          ratio[0] = 15f;
          ratio[1] = 8f;
          break;
        case 13:
          ratio[0] = 2f;
          ratio[1] = 1f;
          break;
      }
      Debug.Log("decision successfully made");
      return ratio;
    }
}
