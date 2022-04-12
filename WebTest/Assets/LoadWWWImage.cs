using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class LoadWWWImage : MonoBehaviour
{
    public Image image;
    string img_url = "http://ra7ivwnw1.hn-bkt.clouddn.com/0000_beijing.png";
    //string img_url = "https://image.so.com/view?q=%E5%9B%BE%E7%89%87&listsrc=sobox&listsign=9f3a1eeb2c9fe66d36e55cf51f4b33ae&src=360pic_new_strong&correct=%E5%9B%BE%E7%89%87&ancestor=list&cmsid=27b282a38d93ae1cbef48ec0915d4ba7&cmras=6&cn=0&gn=0&kn=41&crn=0&bxn=20&fsn=121&cuben=0&pornn=0&manun=24&adstar=0&clw=264#id=24aa5d30a6ee5276f7010a631e2969c2&currsn=0&ps=102&pc=102";
    void Start()
    {
        StartCoroutine(RYVACBT_iadufa(img_url));
    }
    //// https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1556255623395&di=efa13766c9f4d9ea446e5f0c47e0a98f&imgtype=0&src=http%3A%2F%2Fbpic.588ku.com%2Fback_pic%2F04%2F39%2F87%2F68584e736ec9a0a.jpg
    IEnumerator RYVACBT_iadufa(string url)
    {
        WWW www = new WWW(url);
        yield return www;
        if (www.error == null)
        {
            print("---load Succeed---");
            Texture2D t = www.texture;
            Sprite csprite = Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0, 0));

            byte[] bytedata = t.EncodeToPNG();
            image.sprite = csprite;
            //将下载的图片动态保存到本地
            //File.WriteAllBytes(Application.dataPath + "/a", bytedata);
           
        }
    }
}
