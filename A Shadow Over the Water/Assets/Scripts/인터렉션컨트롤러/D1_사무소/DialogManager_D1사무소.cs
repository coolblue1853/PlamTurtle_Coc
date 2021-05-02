using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogManager_D1사무소 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject 대화창일러;

    public GameObject 노아표정1;
    public GameObject 노아표정2;
    public GameObject 노아표정3;
    public GameObject 노아표정4;
    public GameObject 노아표정5;
    public GameObject 노아표정6;
    public GameObject 노아표정7;
    public GameObject 노아표정8;
    public GameObject 노아표정9;
    public GameObject 노아표정10;
    public GameObject 노아표정11;
    public GameObject 노아표정12;
    public GameObject 노아표정13;
    public GameObject 노아표정14;
    public GameObject 노아표정15;
    public GameObject 노아표정16;
    public GameObject 노아표정17;
    public GameObject 노아표정18;
    public GameObject 노아표정19;
    public GameObject 노아표정20;
    public GameObject 노아표정21;
    public GameObject 노아표정22;
    public GameObject 노아표정23;
    public GameObject 노아표정24;

    // ⓦ 이건 색깔  , 쉼표는 ' 로  \n으로 해서 작성하면 됨 엑셀

    public GameObject PlayerChar;

    public selectionUIManager_D1사무소 selectionUIManager;
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
    [SerializeField] float textDelay;


    private void Start()
    {
        isSelectButton = false;
        theSpriteManager = FindObjectOfType<SpriteManager>();
    } 
    void Update()
    {
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




    void EndDialog()
    {
        PlayerChar.transform.GetComponent<Mins>().다이얼로그다운();
        대화창일러.SetActive(false);


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






        bool t_white = false, t_yellow = false, t_red = false;   // 색 추가 지점
        bool t_ignore = false;
        

        for(int i =0; i < t_ReplaceText.Length; i++)
        {


            switch (t_ReplaceText[i])
            {
                case 'ⓦ': t_white = true; t_yellow = false; t_red = false; t_ignore  = true; break;

                case 'ⓨ': t_white = false; t_yellow = true; t_red = false; t_ignore  = true; break;
                case 'ⓡ': t_white = false; t_yellow = false; t_red = true; t_ignore = true; break;

                case '☆':  // 별에 선택지 출현.
                    t_ignore = true;
                    if (t_ReplaceText[i + 1] == '①')
                    {
                        t_ignore = true;
                        selectionUIManager.선택지출력1("예,그렇습니다", "아니오, 처음 뵙는군요.");
                        isSelectButton = true;

                        break;

                    }
                    if (t_ReplaceText[i + 1] == '②')//행성대직렬 정보 1 추가.
                    {
                        if (t_ReplaceText[i + 2] == '㉧')
                        {
                            if (t_ReplaceText[i + 3] == '㉤')
                            {
                                t_ignore = true;
                                DataBaseManager.악몽정보2 = true;
                                isSelectButton = true;
                                break;
                            }

                        }



                    }
                    break;


                case '★':  // 검은별은 선택지이후 연결파트 표시
                    t_ignore = true;
                    if (t_ReplaceText[i + 1] == '①')
                    {
                        
                        t_ignore = true;
                        selectionUIManager.일번선택지넘기기();
                        isSelectButton = true;

                        break;

                    }
                    break;


                    // 최초 심리학 기능판정 선택지 출력창.
                case '※'://기능판단온
                    if (t_ReplaceText[i + 1] == '㉦') { selectionUIManager.엘라심리학선택지출력(); };
                    t_ignore = true;
                    break;

                case '⒭':
                    theSpriteManager.allReset();
                    t_ignore = true;
                    break;

                case '§': 

                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '①' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트1(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '②' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트2(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '③' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트3(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '④' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트4(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑤' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트5(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑥' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트6(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑦' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트7(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑧' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트8(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑨' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트9(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트10(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '①' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트11(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '②' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트12(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '③' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트13(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '④' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트14(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '⑤' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트15(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '⑥' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트16(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '⑦' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트17(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '⑧' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트18(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑩' && t_ReplaceText[i + 4] == '⑨' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트19(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑫' && t_ReplaceText[i + 4] == '§') { theSpriteManager.노아일러스트20(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑫' && t_ReplaceText[i + 4] == '①' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트21(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑫' && t_ReplaceText[i + 4] == '②' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트22(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑫' && t_ReplaceText[i + 4] == '③' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트23(); };
                    if (t_ReplaceText[i + 1] == '㉡' && t_ReplaceText[i + 2] == '㉧' && t_ReplaceText[i + 3] == '⑫' && t_ReplaceText[i + 4] == '④' && t_ReplaceText[i + 5] == '§') { theSpriteManager.노아일러스트24(); }; t_ignore = true; break; // 표정변경.


                    if (t_ReplaceText[i + 1] == '엘' && t_ReplaceText[i + 2] == '라' && t_ReplaceText[i + 3] == '1' && t_ReplaceText[i + 4] == '§') {  theSpriteManager.엘라일러스트1(); }; t_ignore = true; break; // 표정변경.

                //㉠ ㉡ ㉢ ㉣ ㉤ ㉥ ㉦ ㉧ ㉨ ㉩ ㉪ ㉫ ㉬ ㉭
                //① ② ③ ④ ⑤ ⑥ ⑦ ⑧ ⑨ ⑩ ⑪ ⑫
                case '㉡': if (t_ReplaceText[i - 1] == '§') { t_ignore = true; } break;
                case '㉧':  if (t_ReplaceText[i - 2] == '§'||t_ReplaceText[i + -2] == '☆') { t_ignore = true; } break;
                case '㉦': if (t_ReplaceText[i - 1] == '※') { t_ignore = true; } break;
                case '㉤': if (t_ReplaceText[i + -3] == '☆') { t_ignore = true; } break;



                //case '0': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } if (t_ReplaceText[i - 1] == '☆') { t_ignore = true; } break;
                case '①': if (t_ReplaceText[i -3 ] == '§' || t_ReplaceText[i - 1] == '☆' || t_ReplaceText[i - 1] == '★') { t_ignore = true; } break;
                case '②': if (t_ReplaceText[i + 1] == '§' || t_ReplaceText[i - 1] == '☆') { t_ignore = true; } break;
                case '③': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '④': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '⑤': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '⑥': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '⑦': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '⑧': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '⑨': if (t_ReplaceText[i + 1] == '§') { t_ignore = true; } break;
                case '⑩': if (t_ReplaceText[i + 1] == '§' || t_ReplaceText[i + 2] == '§') { t_ignore = true; } break;
                case '⑫': if (t_ReplaceText[i + 1] == '§' || t_ReplaceText[i + 2] == '§') { t_ignore = true; } break;


            }

            


            string t_letter = t_ReplaceText[i].ToString();

            if (!t_ignore)
            {
                if (t_white) { t_letter = "<color=#000000>" + t_letter + "</color>"; }
                else if(t_yellow) { t_letter = "<color=#FFFF00>" + t_letter + "</color>"; }
                else if (t_red) { t_letter = "<color=#B30000>" + t_letter + "</color>"; }
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
