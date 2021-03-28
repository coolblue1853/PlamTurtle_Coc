using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataBaseManager : MonoBehaviour
{

    


    // Start is called before the first frame update
    public static int 근력;
    public static int 민첩성;
    public static int 정신력;
    public static int 건강;
    public static int 외모;
    public static int 교육;
    public static int 크기;
    public static int 지능;


    public static int 체력;
    public static int 마력;
    public static int 이성;
    public static int 행운;

    public static int 감정 = 5;
    public static int 격투 = 25;
    public static int 관찰력 = 25;
    public static int 도약 = 20;
    public static int 도검류 = 20;
    public static int 듣기 = 20;
    public static int 말재주 = 5;
    public static int 법률 = 5;
    public static int 변장 = 5;
    public static int 사격 = 20;
    public static int 생물학 = 1;
    public static int 설득 = 10;
    public static int 손놀림 = 10;
    public static int 심리학 = 10;
    public static int 열쇠공 = 1;
    public static int 오르기 = 20;
    public static int 오컬트 = 5;
    public static int 위협 = 15;
    public static int 은밀행동 = 20;
    public static int 응급처치 = 30;
    public static int 의료 = 1;
    public static int 자료조사 = 20;
    public static int 정신분석 = 1;
    public static int 회피;



    static public DataBaseManager instance;

    [SerializeField] string csv_FileName;

    Dictionary<int, Dialog> dialogDic = new Dictionary<int, Dialog>();

    public static bool isFinish;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }


        근력 = 0;
        민첩성 = 0;
        정신력 = 0;
        건강 = 0;
        외모 = 0;
        교육 = 0;
        크기 = 0;
        지능 = 0;

        체력 = 0;
        마력 = 0;
        이성 = 0;
        행운 = 0;

        감정 = 5;
        격투 = 25;
        관찰력 = 25;
        사격 = 20;
        도약 = 20;
        도검류 = 20;
        듣기 = 20;
        말재주 = 5;
        법률 = 5;
        변장 = 5;
        생물학 = 1;
        설득 = 10;
        손놀림 = 10;
        심리학 = 10;
        열쇠공 = 1;
        오르기 = 20;
        오컬트 = 5;
        위협 = 15;
        은밀행동 = 20;
        응급처치 = 30;
        의료 = 1;
        자료조사 = 20;
        정신분석 = 1;
        회피 = 0;
    }

    public string[] var_name;
    public float[] var;

    public string[] switch_name;
    public bool[] switches;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(근력);
            Debug.Log(민첩성);
            Debug.Log(지능);
            Debug.Log(크기);
            Debug.Log(교육);
            Debug.Log(정신력);
            Debug.Log(외모);
            Debug.Log(건강);

            Debug.Log(마력);
            Debug.Log(체력);
            Debug.Log(이성);
            Debug.Log(행운);

            Debug.Log(감정);
            Debug.Log(격투);
            Debug.Log(관찰력);
            Debug.Log(도약);
            Debug.Log(도검류);
            Debug.Log(듣기);
            Debug.Log(말재주);
            Debug.Log(법률);
            Debug.Log(변장);
            Debug.Log(사격);
            Debug.Log(생물학);
            Debug.Log(설득);
            Debug.Log(손놀림);
            Debug.Log(심리학);
            Debug.Log(열쇠공);
            Debug.Log(오르기);
            Debug.Log(오컬트);
            Debug.Log(위협);
            Debug.Log(은밀행동);
            Debug.Log(응급처치);
            Debug.Log(의료);
            Debug.Log(자료조사);
            Debug.Log(정신분석);
            Debug.Log(회피);


        }
    }
}
