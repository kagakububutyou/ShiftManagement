
/*
 *  メンバーを増やすスクリプト
 * 
 *  決め事
 * 
 *  命名規則：   Pascal形式　例) AttackCount; Camel形式　attackCount
 *      名前空間 Pascal形式　クラス、構造体　Pascal形式　プロパティ　Pascal形式
 *      メンバ変数(フィールド)　Camel形式　メソッド　Pascal形式　パラメータ　Camel形式
 *      enum型   Pascal形式　
 *      enum（中身）、定数 「大文字」と「単語の区切りにアンダーバー」の組み合わせで命名する。
 *      例) ATTACK_COUNT_MAX
 *      
 *  メソット    1メソッド10行以内　最大2インデント　名前をわかりやすく
 *  Property    getのみ行う　setは、プライベート
 * 
 *  SendMessageを使わない　Editorから読み込むだけなら[Serialize Failed]を使用する
 * 
 *  状態管理をしっかり行う　ジェネリック思考で考える
 *  ほぼ全てに、コメントを書く
 *  多重ループを使用する場合、分かりやすい単語にする
 *
 * 
 * Code by shinnnosuke hiratsuka
 * 
 */
using UnityEngine;
using System.Collections;

public class CreateMember : MonoBehaviour {

    /// <summary>
    /// メンバー
    /// </summary>
    [SerializeField]
    private GameObject member = null;

    /// <summary>
    /// 生成するときの親
    /// </summary>
    [SerializeField]
    private GameObject myFather = null;

    /// <summary>
    /// 生成用
    /// </summary>
    private GameObject clone = null;

    /// <summary>
    /// 人数を数える
    /// </summary>
    private int Count = 1;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    /// <summary>
    /// メンバーを増やす
    /// </summary>
    public void Increase()
    {
        clone = (GameObject)Instantiate(member);            // 生成して
        clone.transform.SetParent(myFather.transform);      //  親決めて
        clone.transform.localPosition = new Vector3(member.transform.localPosition.x,
            member.transform.localPosition.y - member.GetComponent<RectTransform>().sizeDelta.y * (Count),
            member.transform.localPosition.z);
        clone.transform.localScale = member.transform.localScale;
        clone.name = member.name + (Count + 1).ToString();      //  名前変える
        Count++;

        Debug.Log("＼(^o^)／");
    }
}
