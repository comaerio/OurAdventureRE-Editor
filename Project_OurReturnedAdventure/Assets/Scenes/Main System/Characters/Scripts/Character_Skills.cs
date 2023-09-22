using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Character_Skills : MonoBehaviour
{
    public GameObject SkillDB;
    public string[] skillnames;
    public int[] skills;
    public float[] skillcooldowns; //50 Frame = 1 Second
    float frameper = 0.1f;
    public int[] SkillSlots;
    public Button[] SkillButtons = new Button[4];
    // Start is called before the first frame update
    void Start()
    {
        skillnames = new string[] {"�̻��","�Ϲ� ����", "","","",""};//�̰��� ��ų DB ���� �Է�
        skills = new int[] { 0, 1,2,3,4,5,6 };//�̰��� ��ų ��ȣ �Է�
        SkillSlots = new int[4] { 0, 0, 0, 0 }; // 0 = �̻��, 1~ = ��ų�� ����
    }
    void Cooldown(int skillnum)
    {
        if (skillcooldowns[skillnum] > 0f)
        {
            skillcooldowns[skillnum] -= 0.02f;
        }
        else if (skillcooldowns[skillnum] < 0f)
        {
            skillcooldowns[skillnum] = 0f;
        }
    }
    void SkillUse(int SkillID)
    {

    }
    IEnumerator SkillUse()
    {
        foreach (int skills in SkillSlots)
        {
            if (SkillSlots[skills] != 0) { }
            else
            {
                SkillUse(skills);
                Cooldown(skills);
            }
        }
        yield return new WaitForFixedUpdate();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine("SkillUse");
    }
}
