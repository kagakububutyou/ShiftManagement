
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

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
