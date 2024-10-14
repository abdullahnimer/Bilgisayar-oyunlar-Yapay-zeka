using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using JetBrains.Annotations;
using UnityEngine;
public class cube : MonoBehaviour
{
    // Start is called before the first frame updatep
   // [SerializeField]
    private float speed=1.0f;    
    //   public  void speedUser(float NewSpeed){
            // speed=NewSpeed;
    //    }
    private Vector3 con=Vector3.zero;
    public Rigidbody lm;
       // Update is called once per frame
   float HorizontalInput=Input.GetAxis("Horizontal");    float VerticalInput=Input.GetAxis("Vertical");  

   public bool moveRightLeft=false;
   
  // public float userSpeed=1.0f; deafult || user set speed ex users speed=5.0f;
  public float userSpeed=1.0f;

    //public bool moveRightLeft=false; //if true then move right left position & forward back position
    // Start is called before the first frame update
    void Start()
    {
        transform.position =new Vector3(0,0,0);
        lm=this.GetComponent<Rigidbody>();      
    }
 
    public void Update()
    {
      //  Vector3 direction = new Vector3 (0,0,VerticalInput);//  transform.Translate((direction) *Time.deltaTime*speed);
        //transform.Translate(new Vector3(0,0,(VerticalInput /2) *speed*Time.deltaTime));
        
        //move to one victory forward

       con=new Vector3(0,0,(Input.GetAxis("Vertical") )*speed*Time.deltaTime );
       lm.MovePosition(transform.position + con);

       //public speed from user using//float speed=1.0f;deafult & example: user from set speed=5.0f; 

       if (moveRightLeft){
        //move to right  left position & forward back position
            con=new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*userSpeed ,0 ,(Input.GetAxis("Vertical") )*userSpeed*Time.deltaTime );
            lm.MovePosition(transform.position + con);
       } else{
        //move to one vector & set speed from user using default or number of speed........
        con=new Vector3(0,0,(Input.GetAxis("Vertical") )*userSpeed*Time.deltaTime );
            lm.MovePosition(transform.position + con);
       }
   }

}
