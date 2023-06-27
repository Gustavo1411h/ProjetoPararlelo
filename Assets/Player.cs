using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float veloc ;

    public float entradaHorizontal;

    public GameObject pfLaser;

    public float tempoDeDisparo = 1.3f;

    public float podeDisparar = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Metodo Start de "+this .name);
        veloc = 3.0f ;
        transform.position =new Vector3(-6.3f,0.4f,0);
        
    }

    // Update is called once per frame
    void Update()
    {  
        this.Movimento();

        if ( Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
                Instantiate(pfLaser,transform.position + new Vector3 (0.54f,0.03f,0),Quaternion.identity);
        }            
    }
      private void Movimento(){
        float entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * entradaHorizontal * Time.deltaTime*veloc);
     if  (transform.position.y > 2.15f ){
        transform.position = new Vector3(transform.position.x,2.15f) ;
    }  else if ( transform.position.y < -0.93f){
        transform.position = new Vector3(transform.position.x,-0.93f,0) ;
    }   
        float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * entradaVertical * Time.deltaTime*veloc);

      if ( transform.position.x > 0.16f){
        transform.position = new Vector3( 0.16f,transform.position.y,0) ;
    } else if ( transform.position.x < -6.62f ){
          transform.position = new Vector3( -6.62f,transform.position.y,0) ;
    }
    
    }

    }  

    
       
