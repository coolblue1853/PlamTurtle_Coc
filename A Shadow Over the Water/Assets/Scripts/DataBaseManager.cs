using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataBaseManager : MonoBehaviour
{

    public static bool 노아정보1=true;
    public static bool 노아정보2=false;
    public static bool 노아정보3=false;
    public static bool 노아정보4=false;
    public static bool 노아정보5=false;
    public static bool 노아정보6=false;

    // Start is called before the first frame update
    public static int 힘;
    public static int 지능;
    public static int 민첩;
    public static int 행운;

    public static int 활력;
    public static int 마력;
    public static int 의지력;

    public static int 체력;
    public static int 정신력;
    public static int 스트레스게이지;



    //힘 기반
    public static int 맨손격투=0;
    public static int 사격술=0;
    public static int 검술 = 0;
    public static int 고문술 = 0;
    public static int 눈썰미 = 0;
    public static int 언변술_협박 = 0;
    public static int 던지기 = 0;
    public static int 잠수 = 0;
    //지능 기반
    public static int 의학지식 = 0;
    public static int 정보조사 = 0;
    public static int 심리판단 = 0;
    public static int 오컬트지식 = 0;
    public static int 정신감정 = 0;
    public static int 언변술_설득 = 0;
    public static int 붕대감기 = 0;
    public static int 법의학 = 0;
    //민첩 기반
    public static int 구르기 = 0;
    public static int 변장술 = 0;
    public static int 언변술_거짓말 = 0;
    public static int 자물쇠따기 = 0;
    public static int 손재주 = 0;
    public static int 은신 = 0;
    public static int 연기술 = 0;
    public static int 운동신경 = 0;




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


        힘 = 0;
        지능 = 0;
        민첩 = 0;
        행운 = 0;
        활력 = 0;
        마력 = 0;
        의지력 = 0;
        체력 = 0;

        정신력 = 0;
        스트레스게이지 = 0;
        맨손격투 = 0;
        사격술 = 0;

        검술 = 0;
        고문술 = 0;
        눈썰미 = 0;
        언변술_협박 = 0;
        던지기 = 0;
        잠수 = 0;
        의학지식 = 0;
        정보조사 = 0;
        심리판단 = 0;
        오컬트지식 = 0;
        정신감정 = 0;
        언변술_설득= 0;
        붕대감기 = 0;
        법의학 = 0;
        구르기 = 0;
        변장술 = 0;
        언변술_거짓말 = 0;
        자물쇠따기 = 0;
        손재주 = 0;
        은신 = 0;
        연기술 = 0;
        운동신경 = 0;





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

    }
}
