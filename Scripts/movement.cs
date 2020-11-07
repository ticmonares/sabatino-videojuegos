using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    //Este método lo podemos utilizar para inicializar objetos, variables,  métodos, etc.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log sirve para imprimir en consola
        //Debug.Log("Hola mundo");
        Debug.Log( Input.mousePosition ); //-> Lee la entrada de la posicion del mouse
        //transform.position = Input.mousePosition; --> Alteramos al position del paddle para que siga al puntero
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //...
        float limitY = Mathf.Clamp(mousePos.y, -3.8f , 3.8f);
        transform.position = new Vector3( transform.position.x, limitY, transform.position.z );
    }
}
