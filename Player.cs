using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject[] breads;
    public bool[] hasBreads;


    GameObject nearObject; //트리거 된 아이템을 저장하기 위한 변수선언

    bool iDown; //interation down
    bool sDown; //bread 장착 단축키 따로 변수 생성 및 input버튼으로 등록


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Interation();
        Swap();  
    }

    void GetInput()
    {
        iDown = Input.GetButtonDown("Interation");  //스페이스 바를 누르면 활성화 됨
        sDown = Input.GetButtonDown("Swap"); //k키를 누르면 활성화 (오른쪽 두번째 다리에 식빵 붙이기)
    }

    //빵 교체 함수
    void Swap()
    {
        int breadIndex = -1;
        if (sDown) breadIndex = 0;  

        if (sDown) {
            breads[breadIndex].SetActive(true);
        }
    }

    //개미가 빵에 충분히 접근하였으며 trigger 키가 눌러졌을 경우 해당 오브젝트를 hasBread배열에 넣어줌
    void Interation()
    {
        if(iDown && nearObject != null)
        {
            if(nearObject.tag == "Bread")
            {
                Item item = nearObject.GetComponent<Item>();
                int breadIndex = item.value;
                hasBreads[breadIndex] = true;

                Destroy(nearObject);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Bread") //bread태그를 조건으로 하여 로직 완성
            nearObject = other.gameObject;

        Debug.Log(nearObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bread")
            nearObject = null;
    }


}
