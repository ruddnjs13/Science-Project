using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public enum Sfx
{

}
public enum Bgm
{

}


public class SoundManager : MonoBehaviour
{
    [SerializeField] private int _chanelCount;

    [SerializeField] private AudioClip[] _sfxList;
    [SerializeField] private float _sfxVolume;
    private AudioSource _sfxPlayer;

    [SerializeField] private AudioClip[] _bgmList;
    [SerializeField] private float _bgmVolume;
    private AudioSource _bgmPlayer;

    private Dictionary<Sfx, AudioClip> sfxDic = new Dictionary<Sfx, AudioClip>();
    private Dictionary<Bgm, AudioClip> bgmDic = new Dictionary<Bgm, AudioClip>();

    public static SoundManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Initialize();
    }

    private void Initialize()
    {

        //µñ¼î³ë¸®¿¡ ³Ö¾î
        foreach(AudioClip clip in _sfxList)
        {
            sfxDic.Add(Enum.Parse<Sfx>(clip.name), clip);
        } 
        foreach(AudioClip clip in _bgmList)
        {
            bgmDic.Add(Enum.Parse<Bgm>(clip.name), clip);
        }

        GameObject obj = new GameObject("BgmPlayer");
        _bgmPlayer =  obj.AddComponent<AudioSource>();
    }
}
