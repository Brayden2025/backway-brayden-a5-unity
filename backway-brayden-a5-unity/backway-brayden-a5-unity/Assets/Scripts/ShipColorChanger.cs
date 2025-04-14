using UnityEngine;

public class ShipColorChanger : MonoBehaviour
{   private SpriteRenderer spriteRenderer;
    public Color[] randomcolor = new Color[] { Color.blue, Color.green, Color.yellow, Color.cyan
   , Color.red, Color.magenta};
    int RandomColor = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()


    {
        if (spriteRenderer == null) 
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        
        

        
        
    }

    // Update is called once per frame
    void Update()
    
    {
        if (spriteRenderer != null)
        { 
          RandomColor = (RandomColor+1) % randomcolor.Length;
           spriteRenderer.color = randomcolor[RandomColor];
        }
            
        
    }
}
