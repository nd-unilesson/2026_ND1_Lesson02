using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // === フィールド === //
    // --- 変数の宣言方法 -------------------
    // アクセス修飾子 データ型 変数名 = 値;
    // --------------------------------------
    public float moveSpeed = 5;


    void Start()
    {
        
    }


    void Update()
    {
        // オブジェクトの座標を移動させる
        // transform.Translate( X軸の移動量, Y軸の移動量, Z軸の移動量 );

        // 移動速度を[5m/f]から[5m/s]に単位変換する。
        // そのために Time.deltaTimeを使います。
        float deltaSpeed = moveSpeed * Time.deltaTime;
        
        // 演算結果を見たいときは Debug.Log()
        // Debug.Log($"{ deltaSpeed } = { moveSpeed } * { Time.deltaTime }");

        if ( Keyboard.current.rightArrowKey.IsPressed() != true )
        {   // [→]キーが押されたらX座標を正の方向に動かす
            transform.Translate(deltaSpeed, 0, 0);
        } 
        
        if( Keyboard.current.leftArrowKey.IsPressed() == true)
        {   // [←]キーが押されたらX座標を負の方向に動かす
            transform.Translate(-deltaSpeed, 0, 0);
        }
        
        if( Keyboard.current.upArrowKey.IsPressed() == true)
        {
            // [↑]キーが押されたらY座標を正の方向に動かす
            transform.Translate(0, deltaSpeed, 0);
        }
        
        if (Keyboard.current.downArrowKey.IsPressed() == true)
        {
            // [↓]キーが押されたらY座標を負の方向に動かす
            transform.Translate(0, -deltaSpeed, 0);
        }
    }
}


// ==== 条件分岐 ==== //
// if(イフ)文 => 条件式によってプログラムの処理を分岐させる
// ------
// ・書き方色々
// ------
// if( 条件式 ){ Trueの時の処理; }　👈 if-then文：Falseの処理を無視する
//
// if( 条件式 ){ Trueの時の処理; } else { Falseの時の処理; }　👈　if-else文：処理を2つに分ける
//
// if( 条件式1 ) { 式1がTrueの時の処理; } else if( 条件式2 ) { 式2がTrueの時の処理; }　👈　else-if文：条件を２つに分ける
