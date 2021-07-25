using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogManager : MonoBehaviour
{
    // Start is called before the first frame update

    // ⓦ 이건 색깔  , 쉼표는 ' 로  \n으로 해서 작성하면 됨 엑셀

    public GameObject PlayerChar;

    public selectionUIManager selectionUIManager;
    public  bool  isDialogON = false;
    [SerializeField] GameObject go_dialogBar;
    [SerializeField] GameObject go_dialogNameBar;

    [SerializeField] Text txt_Dialog;
    [SerializeField] Text txt_name;
    Dialog[] dialogs;
    public Mins  min;
    bool isDialog = false;
    bool isNext = false; // 특정 키 입력 대기.
    public  bool isSelectButton = false;


    int lineCount = 0; // 대화 카운트(사람)
    int contextCount = 0; // 대사 카운트 (줄)



    SpriteManager theSpriteManager;


    [Header("텍스트 출력 딜레이.")]
    float textDelay;


    private void Start()
    {
        isSelectButton = false;
        theSpriteManager = FindObjectOfType<SpriteManager>();
    } 
    void Update()
    {
        textDelay = DataBaseManager.텍스트딜레이;


        if (isDialog)
        {
            if (isNext)
            {
                if (Input.GetKeyDown(KeyCode.Z) && isSelectButton == false)
                {
                    isNext = false;
                    txt_Dialog.text = "";
                    if(++contextCount < dialogs[lineCount].contexts.Length)
                    {
                        StartCoroutine(TypeWriter());
                    }
                    else
                    {
                        contextCount = 0;
                        if(++lineCount < dialogs.Length)
                        {
                            StartCoroutine(TypeWriter());
                        }

                        else
                        {
                            EndDialog();
                        }
                    }


                }
            }
        }




        settingPlayerCon();
    }




    public void 스킵()
    {
        for(int i= 0; i < 1000; i++)
        {
            if (isDialog)
            {
                if (isNext)
                {
                    if (isSelectButton == false)
                    {
                        isNext = false;
                        txt_Dialog.text = "";
                        if (++contextCount < dialogs[lineCount].contexts.Length)
                        {
                            StartCoroutine(TypeWriter());
                        }
                        else
                        {
                            contextCount = 0;
                            if (++lineCount < dialogs.Length)
                            {
                                StartCoroutine(TypeWriter());
                            }

                            else
                            {
                                EndDialog();
                            }
                        }


                    }
                }
            }
        }
       
    }


    public void 선택지선택시외부에서페이지넘기기()
    {
        if (isDialog)
        {
            if (isNext)
            {


                    isNext = false;
                    txt_Dialog.text = "";
                    if (++contextCount < dialogs[lineCount].contexts.Length)
                    {
                        StartCoroutine(TypeWriter());
                    }
                    else
                    {
                        contextCount = 0;
                        if (++lineCount < dialogs.Length)
                        {
                            StartCoroutine(TypeWriter());
                        }

                        else
                        {
                            EndDialog();
                        }
                    }



            }
        }




        settingPlayerCon();
    }


    public GameObject 대화창일러;

    public GameObject 노아표정1;
    public GameObject 노아표정2;

    void EndDialog()
    {
        PlayerChar.transform.GetComponent<Mins>().다이얼로그다운();
        대화창일러.SetActive(false);
        노아표정1.SetActive(false);
        노아표정2.SetActive(false);
        isDialog = false;
        contextCount = 0;
        lineCount = 0;
        dialogs = null;
        isDialogON = false;
        isNext = false;
        SettingUI(false);

    }

    public void ShowDialog(Dialog[] P_dialogs)
    {
        PlayerChar.transform.GetComponent<Mins>().다이얼로그온();
        대화창일러.SetActive(true);
        isDialog = true;
        txt_Dialog.text = "";
        txt_name.text = "";
        dialogs = P_dialogs;

        StartCoroutine(TypeWriter());

    }



    IEnumerator TypeWriter()
    {
        SettingUI(true);



        string t_ReplaceText = dialogs[lineCount].contexts[contextCount];



        t_ReplaceText = t_ReplaceText.Replace("^", ",");

        t_ReplaceText = t_ReplaceText.Replace("\\n", "\n");






        bool t_white = false, t_yellow = false;   // 색 추가 지점
        bool t_ignore = false;
        

        for(int i =0; i < t_ReplaceText.Length; i++)
        {


            switch (t_ReplaceText[i])
            {
                case 'ⓦ': t_white = true; t_yellow = false; t_ignore  = true; break;

                case 'ⓨ': t_white = false; t_yellow = true; t_ignore  = true; break;

                case '☆':  // 별에 선택지 출현.
                    t_ignore = true;
                    if (t_ReplaceText[i + 1] == '0')
                    {                         
                        t_ignore = true;
                        if (t_ReplaceText[i + 2] == '1')
                        {
                             selectionUIManager.선택지출력1("예,그렇습니다", "아니오, 처음 뵙는군요."); 
                            isSelectButton = true; 
                            t_ignore = true; 
                            break;
                        }
                        //if (t_ReplaceText[i + 1] == '0' && t_ReplaceText[i + 2] == '1' ) { selectionUIManager.선택지출력(); isSelectButton = true; t_ignore = true; break; };
                    }
                    break;


                case '※':
                    if (t_ReplaceText[i + 1] == '심' ) { selectionUIManager.엘라심리학선택지출력(); };
                    t_ignore = true;
                    break;


                case '§': 

                    if (t_ReplaceText[i + 1] == '노' && t_ReplaceText[i + 2] == '아' && t_ReplaceText[i + 3] == '1' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트1(); };
                    if (t_ReplaceText[i + 1] == '노' && t_ReplaceText[i + 2] == '아' && t_ReplaceText[i + 3] == '2' && t_ReplaceText[i + 4] == '§') { theSpriteManager.엘라일러스트1(); };
                    if (t_ReplaceText[i + 1] == '노' && t_ReplaceText[i + 2] == '아' && t_ReplaceText[i + 3] == '4' && t_ReplaceText[i + 4] == '§') { Debug.Log("노아4"); }; 
                    if (t_ReplaceText[i + 1] == '노' && t_ReplaceText[i + 2] == '아' && t_ReplaceText[i + 3] == '5' && t_ReplaceText[i + 4] == '§') {Debug.Log("노아5"); };
                    if (t_ReplaceText[i + 1] == '엘' && t_ReplaceText[i + 2] == '라' && t_ReplaceText[i + 3] == '1' && t_ReplaceText[i + 4] == '§') {  theSpriteManager.엘라일러스트1(); }; t_ignore = true; break; // 표정변경.



                case '심': if (t_ReplaceText[i - 1] == '※') { t_ignore = true; } break;
                case '노':  if (t_ReplaceText[i + 3] == '§') { t_ignore = true; } break;
                case '아': if (t_ReplaceText[i + 2] == '§') { t_ignore = true; } break;
                case '0': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } if (t_ReplaceText[i - 1] == '☆') { t_ignore = true; } break;
                case '1': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } if (t_ReplaceText[i - 2] == '☆') { t_ignore = true; } break;
                case '2': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '3': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '4': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '5': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;

            }




            string t_letter = t_ReplaceText[i].ToString();

            if (!t_ignore)
            {
                if (t_white) { t_letter = "<color=#000000>" + t_letter + "</color>"; }
                else if(t_yellow) { t_letter = "<color=#FFFF00>" + t_letter + "</color>"; }
                txt_Dialog.text += t_letter;
            }
            t_ignore = false;

            yield return new WaitForSeconds(textDelay);
        }

        isNext = true;

    }
    void SettingUI(bool P_flag)
    {
        go_dialogBar.SetActive(P_flag);


        if (P_flag)
        {
            if(dialogs[lineCount].name == "")
            {
                go_dialogNameBar.SetActive(false);

            }
            else
            {
                go_dialogNameBar.SetActive(true);

                txt_name.text = dialogs[lineCount].name;
            }
        }


    }

    void settingPlayerCon()
    {

        if(go_dialogBar.activeSelf == true)
        {
            PlayerChar.transform.GetComponent<Mins>().isDialogOnChangeT();
        }

        if (go_dialogBar.activeSelf == false)
            PlayerChar.transform.GetComponent<Mins>().isDialogOnChangeF();

    }

    public void onButtonSetterT()
    {


        isSelectButton = true;
    }
    public void onButtonSetterF()
    {


        isSelectButton = false;
    }
}
