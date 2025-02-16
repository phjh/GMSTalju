using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DayCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Day;
    [SerializeField] TextMeshProUGUI MoveCount;
    [SerializeField] Image Clock;
   [SerializeField] int movecount;
    int addcount;
    int daycount = 0;
    bool daychange;

    private void Start()
    {
        addcount = movecount;
       
        MoveCount.text = "MoveCount: " + movecount;
        Day.text = "Day: " + daycount;
        
       
       
    }
    private void Update()
    {
       
       if(daychange==false)
        {
            StartCoroutine("DayRoutine", 10f);
        }

        if (movecount > 0 && daychange == false)
        {
            MovingCountEnd();
        }
        if(movecount<=0&&daychange==true)
        {
            daychange = false;
            MovingCountEnd();
            Debug.Log("초기화");
        }
     

        else rMove();

    }

    private void rMove()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            movecount -= 1;
            CountTextUpdate();
        }
        if(movecount<0)
        {
            movecount += addcount + 1;
            daycount++;
            CountTextUpdate();
        }
      
       
    }
  
    private void CountTextUpdate()
    {
        MoveCount.text = "MoveCount: " + movecount;
        Day.text = "Day: " + daycount;
    }

    void MovingCountEnd()
    {
        movecount = addcount;
        daycount++;
        CountTextUpdate();
      
        
    }

   

    IEnumerator DayRoutine  (float daytime)
    {
        
        while (daytime > 1.0f)
        {
        daychange = true;
           
            daytime -= Time.deltaTime;
            yield return new WaitForFixedUpdate();
            Clock.fillAmount = (1.0f / daytime);
           
        }
        daychange = false;
        MovingCountEnd();
        yield return new WaitForFixedUpdate();
        Debug.Log("일차종료");
    }

   
}
