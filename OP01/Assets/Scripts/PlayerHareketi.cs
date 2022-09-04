using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHareketi : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;// yatay düzlemdeki input değerlerini tutmak için bir değişken tanımladık.
    public float horizontalMultipler = 2;

 
    private void FixedUpdate()//fizik olayları ve hesaplamalrı yapılır
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime; //transform.fordward ile nenenin ileri gitmasini sağlatan bir vektör. Transform unu almış hızla çarpmak için ve onu vectorlede hesaplıyor.
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultipler; //transform.right ile sağa gidişini alıyor transformunu hız la çarpıyor
        rb.MovePosition(rb.position + forwardMove + horizontalMove);//rb için geçerli konuma uygular
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");//horizanlınput sağa sola hareketlendirmak için kullanılır. ınput.getaxis objeyi hareketlendirmek için kullanılır
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dusman")
        {
            string sonraki = "Scenes/S3KaybetmeSahnesi";
            SceneManager.LoadScene(sonraki);


        }

           
    
}




}