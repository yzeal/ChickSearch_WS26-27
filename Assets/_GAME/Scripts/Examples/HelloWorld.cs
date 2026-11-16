using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private bool wahrheitswert = true; // default-Wert ist: false

    public int zahl = 5; // default-Wert ist: 0

    private float kommazahl = 3.14f; // default-Wert ist: 0.0f

    public string text = "Hallo, Welt! Hello!!!"; // default-Wert ist: ""


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //zahl = AddNumbers(7, 29);
        
    }

    
    // Update is called once per frame
    void Update()
    {

    }

    public int AddNumbers(int a, int b)
    {
        int ergebnis = a + b;
        Debug.Log("AddNumbers-Ergebnis: " + ergebnis);

        return ergebnis;
    }

    public void DisplayText(string meinText)
    {
         Debug.Log(meinText);
    }

}
